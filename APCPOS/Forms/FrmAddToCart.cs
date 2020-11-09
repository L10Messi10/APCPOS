using System;
using System.Data;
using System.Globalization;
using System.Threading.Tasks;
using System.Windows.Forms;
using APCPOS.Form_Transparent;
using APCPOS.Messageboxes;
using static System.DateTime;
using static APCPOS.Forms.FrmPOSTransaction;
using static APCPOS.Includes.SqlConfig;


namespace APCPOS.Forms
{
    public partial class FrmAddToCart : Form
    {
        private Single _sellprice;
        private Int32 _currStock;
        private double stock;
        private static string inv_num;
        public FrmAddToCart()
        {
            InitializeComponent();
        }
        protected override CreateParams CreateParams
        {
            get
            {
                const int CS_DROPSHADOW = 0x20000;
                CreateParams cp = base.CreateParams;
                cp.ClassStyle |= CS_DROPSHADOW;
                return cp;
            }
        }
        protected override bool ProcessCmdKey(ref Message _message, Keys keyData)
        {
            // ReSharper disable once SwitchStatementMissingSomeEnumCasesNoDefault
            switch (keyData)
            {
                case Keys.Escape:
                    Dispose();
                    break;
            }
            return false;
        }
        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private async void FrmAddToCart_Load(object sender, EventArgs e)
        {
            Sqlcmd.Parameters.Clear();
            await Conopen();
            Strsql = "Select * from tbl_Products where Prod_Number = '" + lblprodID.Text + "'";
            Sqlcmd.CommandText = Strsql;
            Sqlcmd.Connection = Cnn;
            Sqladapter.SelectCommand = Sqlcmd;
            Sqlreader = Sqlcmd.ExecuteReader();
            //metroComboBox1.Items.Clear();
            if (Sqlreader.Read())
            {
                lblprodname.Text = (Sqlreader.GetValue(2).ToString());
                stock = Convert.ToDouble((Sqlreader.GetValue(3).ToString()));
                label4.Text = stock.ToString(CultureInfo.InvariantCulture);
                _sellprice =Convert.ToSingle(Sqlreader.GetValue(6).ToString());
                label9.Text = _sellprice.ToString(CultureInfo.InvariantCulture);
            }
            numericUpDown1.Maximum = Convert.ToInt16(label4.Text);
            Sqlcmd.Dispose();
            Sqlreader.Close();
            Cnn.Close();
            Strsql = "";
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
           
            var subtotal = (numericUpDown1.Value) * (decimal)(_sellprice);
            label6.Text = subtotal.ToString(CultureInfo.InvariantCulture);
            _currStock = (int)((stock) - (double)numericUpDown1.Value);
            label4.Text = _currStock.ToString();

        }

        private async void numericUpDown1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData != Keys.Enter) return;
            if (numericUpDown1.Value != 0)
            {
                if (TranNum == null)
                {
                    await XGenInvoice();
                    await XTransaction();
                }
                else
                {
                    await XTransaction();
                }
            }
        }

        private async Task XGenInvoice()
        {
            Sqlcmd.Parameters.Clear();
            await Conopen();
            Strsql = "Select * from tbl_Transaction";
            Sqlcmd.CommandText = Strsql;
            Sqlcmd.Connection = Cnn;
            Sqladapter.SelectCommand = Sqlcmd;
            DataTable sqlDt=new DataTable();
            sqlDt.Reset();
            Sqladapter.Fill(sqlDt);
            Sqlreader = Sqlcmd.ExecuteReader();
            if (Sqlreader.Read())
            {
                var count = Convert.ToDouble(sqlDt.Rows.Count.ToString());
                var xRi = Convert.ToDouble(1+count);
                inv_num =$"{Now.Year}{xRi}";
            }
            else
            {
                inv_num = $"{Now.Year}{1}";
            }
            Sqlcmd.Dispose();
            Strsql = "";
            Cnn.Close();
        }

        private async Task XTransaction()
        {
                Sqlcmd.Parameters.Clear();
                await Conopen();
                Strsql = "Select * from tbl_Transaction where Inv_Num like '" + inv_num +"'";
                Sqlcmd.CommandText = Strsql;
                Sqlcmd.Connection = Cnn;
                Sqladapter.SelectCommand = Sqlcmd;
                DataTable sqlDt = new DataTable();
                sqlDt.Reset();
                Sqladapter.Fill(sqlDt);
                Sqlreader = Sqlcmd.ExecuteReader();
                //**************************************************
                if (!Sqlreader.Read())
                {
                   await XSaveTransaction();
                   await XSaveTransactionDetails();
                }
                else
                {
                    await XSaveTransactionDetails();
                }

                var a = new T_Message();
                var frmok = new Frm_OK();
                a.Show(this);
                frmok.titletxt.Text = @"Success";
                frmok.msgtxt.Text =
                    @"Item successfully added to cart!";
                frmok.OkDescription = "Success";
                frmok.ShowDialog(this);
                a.Hide();
                //popup.TitleText = @"Success";
                //popup.Image = Properties.Resources.check;
                //popup.ContentText = @"The product "+ lblprodname.Text + " has been successfully added to cart!";
                //popup.Popup();
                Sqlcmd.Dispose();
                Strsql = "";
                Cnn.Close();
                TranNum = inv_num;
                FillCart = true;
                Hide();
        }

        private async Task XSaveTransaction()
        {
            Sqlcmd.Parameters.Clear();
            await Conopen();
            Strsql =
                "Insert into tbl_Transaction(Inv_Num, Inv_date, Inv_time, u_name) " +
                "Values(@Inv_Num, @Inv_date, @Inv_time, @u_name)";
            Sqlcmd.Parameters.AddWithValue("@Inv_Num",
                inv_num);
            Sqlcmd.Parameters.AddWithValue("@Inv_date",
                Today);
            Sqlcmd.Parameters.AddWithValue("@Inv_time",
                Now.ToString("h:mm:ss tt"));
            Sqlcmd.Parameters.AddWithValue("@u_name",
                username);
            Sqlcmd.Connection = Cnn;
            Sqlcmd.CommandText = Strsql;
            Sqlcmd.ExecuteNonQuery();
            Sqlcmd.Dispose();
            Cnn.Close();
            Strsql = string.Empty;
        }


        private async Task XSaveTransactionDetails()
        {
            Sqlcmd.Parameters.Clear();
            await Conopen();
            Strsql =
                "Insert into tbl_Transaction_Detail(Inv_Num, Prod_Number, Qty, Sell_price, Tran_D_Subtotal) " +
                "Values(@Inv_Num, @Prod_Number, @Qty, @Sell_price, @Tran_D_Subtotal)";
            Sqlcmd.Parameters.AddWithValue("@Inv_Num",
                inv_num);
            Sqlcmd.Parameters.AddWithValue("@Prod_Number",
                lblprodID.Text);
            Sqlcmd.Parameters.AddWithValue("@Qty",
                numericUpDown1.Value);
            Sqlcmd.Parameters.AddWithValue("@Sell_price",
                label9.Text);
            Sqlcmd.Parameters.AddWithValue("@Tran_D_Subtotal",
                label6.Text);
            Sqlcmd.Connection = Cnn;
            Sqlcmd.CommandText = Strsql;
            Sqlcmd.ExecuteNonQuery();
            Sqlcmd.Dispose();
            Cnn.Close();
            Strsql = string.Empty;
            //*****************update products table for stock************************
            //*****************There might be an error here in case the clients selects and save the same product at the same time**********
            //Sqlcmd.Parameters.Clear();
            //await Conopen();
            //Strsql = 
            //    "Update tbl_Products set Prod_Stock=@Prod_Stock Where Prod_Number=@Prod_Number";
            //Sqlcmd.Parameters.AddWithValue("@Prod_Stock", Convert.ToDouble(label4.Text));
            //Sqlcmd.Parameters.AddWithValue("@Prod_Number", lblprodID.Text);
            //Sqlcmd.Connection = Cnn;
            //Sqlcmd.CommandText = Strsql;
            //Sqlcmd.ExecuteNonQuery();
            //Sqlcmd.Dispose();
            //Strsql = "";
            //Cnn.Close();
        }

        private async void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            if (numericUpDown1.Value != 0)
            {
                if (TranNum == null)
                {
                    await XGenInvoice();
                    await XTransaction();
                }
                else
                {
                    await XTransaction();
                }
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
