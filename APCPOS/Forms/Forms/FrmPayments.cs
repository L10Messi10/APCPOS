using System;
using System.Data;
using System.Diagnostics;
using System.Globalization;
using System.Threading.Tasks;
using System.Windows.Forms;
using APCPOS.Form_Transparent;
using APCPOS.Messageboxes;
using Bunifu.Framework.UI;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using static APCPOS.Forms.FrmPOSTransaction;
using static APCPOS.Includes.SqlConfig;
using Tulpep.NotificationWindow;

namespace APCPOS.Forms
{
    public partial class FrmPayments : Form
    {
        public float AmountDue;
        public int Totitems;
        private float _change;
        private float _payments;
        private static string prdid;
        private static int prdqty;
        public FrmPayments()
        {
            InitializeComponent();
        }
        
        private void button_click(object sender, EventArgs e)
        {
            BunifuFlatButton button = (BunifuFlatButton)sender;
            if (button.Text == @".")
            {
                if (!numericUpDown1.Text.Contains("."))
                    numericUpDown1.Text = Convert.ToDecimal(numericUpDown1.Text + button.Text).ToString(CultureInfo.InvariantCulture);
            }
            else
                numericUpDown1.Text = Convert.ToDecimal(numericUpDown1.Text + button.Text).ToString(CultureInfo.InvariantCulture);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label3.Text = DateTime.Now.ToString("F");
        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            switch (keyData)
            {
                case Keys.Escape:
                    timer1.Stop();
                    Dispose();
                    break;
                case Keys.Control + (int) Keys.S:
                    printReceiptToolStripMenuItem_Click(null, null);
                    break;
            }

            // Call the base class
            return false;
        }

        private void bunifuImageButton9_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            Dispose();
        }

        private void lbltitle_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            Dispose();
        }

        private void FrmPayments_Resize(object sender, EventArgs e)
        {
            if (Width == 1920 && Height == 1080)
            {
                panel11.Width = 482;
            }
            else if (Width == 1366 && Height == 768)
            {
                panel11.Width = 273;
            }
        }

        private void FrmPayments_Load(object sender, EventArgs e)
        {
            label5.Text = userfullname;
            numericUpDown1.Focus();
        }
        
        private void bunifuFlatButton13_Click(object sender, EventArgs e)
        {
            numericUpDown1.Text = @"0";
        }

        private void numericUpDown1_TextChanged(object sender, EventArgs e)
        {
            if (numericUpDown1.Text != "")
            {
                lblpayment.Text = numericUpDown1.Text;
                _payments = Convert.ToSingle(numericUpDown1.Text);
                _change = _payments - AmountDue;
                lblchange.Text = _change.ToString("N");
                label6.Visible = _payments < AmountDue;
            }
        }

        private async void printReceiptToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_payments < AmountDue)
            {
                //    var msg = new T_Message();
                //    var ok = new Frm_OK();
                //    ok.OkDescription = "Error";
                //    ok.msgtxt.Text = @"Insufficient amount! Please check and try again!";
                //    ok.titletxt.Text = @"Error";
                //    msg.Show(this);
                //    ok.ShowDialog();
                //    msg.Close();
                //    Focus();
                //PopupNotifier popup=new PopupNotifier();
                popup.TitleText = "Error";
                popup.ContentText = "Insufficient amount! Please check and try again!";
                popup.Popup();

            }
            else
            {
                var tQuestion=new T_Question();
                var question=new Frm_Question();
                question.titletxt.Text = @"Confirmation";
                question.msgtxt.Text = @"This action will save this transaction. Do you want to continue this transaction?";
                tQuestion.Show(this);
                question.ShowDialog();
                tQuestion.Close();
                Focus();
                if (question.DialogResult != DialogResult.Yes) return;
                //*******Print receipt********************
                UseWaitCursor = true;
                if (!Hascustomer)
                {
                    Sqlcmd.Parameters.Clear();
                    await Conopen();
                    Strsql =
                        "Update tbl_Transaction set inv_amnt_due=@inv_amnt_due, inv_tax=@inv_tax,inv_tax_tot=@inv_tax_tot,Inv_Money_Render=@Inv_Money_Render, Inv_Change=@Inv_Change, Inv_total=@Inv_total, Inv_Num_of_items=@Inv_Num_of_items, tran_stat=@tran_stat Where Inv_Num=@Inv_Num";
                    Sqlcmd.Parameters.AddWithValue("@inv_amnt_due",
                        Convert.ToSingle(lblsubtotal.Text));
                    Sqlcmd.Parameters.AddWithValue("@inv_tax",
                        Convert.ToSingle(lbltax.Text));
                    Sqlcmd.Parameters.AddWithValue("@inv_tax_tot",
                        Convert.ToSingle(lbltotaltax.Text));
                    Sqlcmd.Parameters.AddWithValue("@Inv_Money_Render",
                        Convert.ToSingle(numericUpDown1.Text));
                    Sqlcmd.Parameters.AddWithValue("@Inv_Change",
                        Convert.ToSingle(lblchange.Text));
                    Sqlcmd.Parameters.AddWithValue("@Inv_total",
                        Convert.ToSingle(AmountDue));
                    Sqlcmd.Parameters.AddWithValue("@Inv_Num_of_items",
                        Convert.ToInt32(Totitems));
                    Sqlcmd.Parameters.AddWithValue("@Inv_Num",
                        lblinvoice.Text);
                    Sqlcmd.Parameters.AddWithValue("@tran_stat",
                        "Cash");
                    Sqlcmd.Connection = Cnn;
                    Sqlcmd.CommandText = Strsql;
                    Sqlcmd.ExecuteNonQuery();
                    Sqlcmd.Dispose();
                    Strsql = "";
                    Cnn.Close();
                    //*********retrieve product sold to deduct to products table
                    await XretriveProduct();
                    popup.TitleText = @"Success";
                    popup.ContentText = @"Transaction successful!";
                    popup.Popup();
                    var frmReports = new FrmReports { StrReport = "Receipt", PrintWhere = ("{V_Receipt.Inv_Num} ='" + lblinvoice.Text + "'") };
                    frmReports.ShowDialog();
                    frmReports.Close();
                    timer1.Stop();
                    NewTrans = true;
                    FillCart = true;
                    CustomerRetrieve = false;
                    CustomerId = null;
                    Hascustomer = false;
                    UseWaitCursor = false;
                    Dispose();
                }
                else
                {
                    Sqlcmd.Parameters.Clear();
                    await Conopen();
                    Strsql =
                        "Update tbl_Transaction set inv_amnt_due=@inv_amnt_due, inv_tax=@inv_tax,inv_tax_tot=@inv_tax_tot,Inv_Money_Render=@Inv_Money_Render, Inv_Change=@Inv_Change, Inv_total=@Inv_total, Inv_Num_of_items=@Inv_Num_of_items, tran_stat=@tran_stat, cus_ID=@cus_ID Where Inv_Num=@Inv_Num";
                    Sqlcmd.Parameters.AddWithValue("@inv_amnt_due",
                        Convert.ToSingle(lblsubtotal.Text));
                    Sqlcmd.Parameters.AddWithValue("@inv_tax",
                        Convert.ToSingle(lbltax.Text));
                    Sqlcmd.Parameters.AddWithValue("@inv_tax_tot",
                        Convert.ToSingle(lbltotaltax.Text));
                    Sqlcmd.Parameters.AddWithValue("@Inv_Money_Render",
                        Convert.ToSingle(numericUpDown1.Text));
                    Sqlcmd.Parameters.AddWithValue("@Inv_Change",
                        Convert.ToSingle(lblchange.Text));
                    Sqlcmd.Parameters.AddWithValue("@Inv_total",
                        Convert.ToSingle(AmountDue));
                    Sqlcmd.Parameters.AddWithValue("@Inv_Num_of_items",
                        Convert.ToInt32(Totitems));
                    Sqlcmd.Parameters.AddWithValue("@Inv_Num",
                        lblinvoice.Text);
                    Sqlcmd.Parameters.AddWithValue("@tran_stat",
                        "Cash");
                    Sqlcmd.Parameters.AddWithValue("@cus_ID",
                        CustomerId);
                    Sqlcmd.Connection = Cnn;
                    Sqlcmd.CommandText = Strsql;
                    Sqlcmd.ExecuteNonQuery();
                    Sqlcmd.Dispose();
                    Strsql = "";
                    Cnn.Close();
                    //*********retrieve product sold to deduct to products table
                    await XretriveProduct();
                    popup.TitleText = @"Success";
                    popup.ContentText = @"Transaction successful!";
                    popup.Popup();
                    var frmReports = new FrmReports { StrReport = "Receipt_Customer", PrintWhere = ("{V_Receipt_Customer.Inv_Num} ='" + lblinvoice.Text + "'") };
                    frmReports.ShowDialog();
                    frmReports.Close();
                    timer1.Stop();
                    NewTrans = true;
                    FillCart = true;
                    CustomerRetrieve = false;
                    CustomerId = null;
                    Hascustomer = false;
                    UseWaitCursor = false;
                    Dispose();
                }
            }
        }

        private static async Task XretriveProduct()
        {
            await Conopen();
            Strsql = "Select * from tbl_Transaction_Detail where Inv_Num='" + TranNum + "'";
            Sqlcmd.CommandText = Strsql;
            Sqlcmd.Connection = Cnn;
            Sqladapter.SelectCommand = Sqlcmd;
            Sqlreader = Sqlcmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(Sqlreader);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                prdid = dt.Rows[i]["Prod_Number"].ToString();
                prdqty = Convert.ToInt32(dt.Rows[i]["qty"].ToString());
                await Xupdateproduct();
            }
            Sqlcmd.Dispose();
            Sqlreader.Close();
            Cnn.Close();
            Strsql = "";
        }
        private static async Task Xupdateproduct()
        {
            int curstock=0;
            int totqty;
            await Conopen();
            Strsql = "Select * from tbl_Products where prod_number='" + prdid + "'";
            Sqlcmd.CommandText = Strsql;
            Sqlcmd.Connection = Cnn;
            Sqladapter.SelectCommand = Sqlcmd;
            Sqlreader = Sqlcmd.ExecuteReader();
            if (Sqlreader.Read())
            {
                curstock = Convert.ToInt32(Sqlreader.GetValue(3).ToString());
            }
            Strsql = "";
            totqty = curstock - prdqty;
            Sqlcmd.Parameters.Clear();
            await Conopen();
            Strsql =
                "Update tbl_Products set Prod_Stock=@Prod_Stock Where Prod_Number=@Prod_Number";
            Sqlcmd.Parameters.AddWithValue("@Prod_Stock", Convert.ToInt32(totqty));
            Sqlcmd.Parameters.AddWithValue("@Prod_Number", prdid);
            Sqlcmd.Connection = Cnn;
            Sqlcmd.CommandText = Strsql;
            Sqlcmd.ExecuteNonQuery();
            Sqlcmd.Dispose();
            Strsql = "";
            //prdqty = 0;
            //prdid = "";

        }
        private void Onlynumwithsinglepoint(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == '.'))
            { e.Handled = true; }
            var txtDecimal = sender as TextBox;
            Debug.Assert(txtDecimal != null, nameof(txtDecimal) + " != null");
            if (e.KeyChar == '.' && txtDecimal.Text.Contains("."))
            {
                e.Handled = true;
            }
        }

        private void numericUpDown1_KeyPress(object sender, KeyPressEventArgs e)
        {
            Onlynumwithsinglepoint(sender, e);
        }
    }
}
