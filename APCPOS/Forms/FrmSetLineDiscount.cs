using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using APCPOS.Form_Transparent;
using APCPOS.Includes;
using APCPOS.Messageboxes;
using static APCPOS.Includes.SqlConfig;
using static APCPOS.Forms.FrmPOSTransaction;

namespace APCPOS.Forms
{
    public partial class FrmSetLineDiscount : Form
    {
        public string proid;
        public string inv_num;
        public string prodname;
        private int qty;
        public FrmSetLineDiscount()
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
                    //
                    break;
            }
            return false;
        }

        private async void FrmSetLineDiscount_Load(object sender, EventArgs e)
        {
            Sqlcmd.Parameters.Clear();
            await Conopen();
            Strsql = "Select * from tbl_Transaction_Detail where Inv_Num='" + inv_num +"' AND Prod_Number = '" + proid + "'";
            Sqlcmd.CommandText = Strsql;
            Sqlcmd.Connection = Cnn;
            Sqladapter.SelectCommand = Sqlcmd;
            Sqlreader = Sqlcmd.ExecuteReader();
            //metroComboBox1.Items.Clear();
            if (Sqlreader.Read())
            {
                var a = (decimal)Sqlreader.GetValue(4);
                qty= (int) Sqlreader.GetValue(2);
                lblprice.Text =a.ToString("F") ;
            }
            Sqlcmd.Dispose();
            Sqlreader.Close();
            Cnn.Close();
            Strsql = "";
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            lbldiscount.Text =Convert.ToSingle((numericUpDown1.Value) *  Convert.ToDecimal(lblprice.Text)).ToString(CultureInfo.InvariantCulture);
            var namnt = (Convert.ToDecimal(lblprice.Text) - Convert.ToDecimal(lbldiscount.Text));
            lblnewamount.Text = (namnt * qty).ToString(CultureInfo.InvariantCulture);
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private async void numericUpDown1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                var ok = new Frm_OK();
                var a = new T_Message();
                //try
                //{
                    Sqlcmd.Parameters.Clear();
                    await Conopen();
                    Strsql =
                        "Update tbl_Transaction_Detail set Tran_D_Subtotal=@Tran_D_Subtotal, Disc=@Disc Where Prod_Number=@Prod_Number And Inv_Num=@Inv_Num";
                    Sqlcmd.Parameters.AddWithValue("@Tran_D_Subtotal", Convert.ToSingle(lblnewamount.Text));
                    Sqlcmd.Parameters.AddWithValue("@Disc", Convert.ToDecimal(lbldiscount.Text));
                    Sqlcmd.Parameters.AddWithValue("@Inv_Num", inv_num);
                    Sqlcmd.Parameters.AddWithValue("@Prod_Number", proid);
                    Sqlcmd.Connection = Cnn;
                    //sqlcmd.CommandType = CommandType.Text;
                    Sqlcmd.CommandText = Strsql;
                    Sqlcmd.ExecuteNonQuery();
                    ok.OkDescription = "Success";
                    ok.titletxt.Text = @"Success";
                    ok.msgtxt.Text = @"Discount has been successfully added!";
                    a.Show(this);
                    ok.ShowDialog();
                    a.Hide();
                    Sqlcmd.Dispose();
                    Strsql = "";
                    Cnn.Close();
                    FillCart = true;
                    Hide();
                //}
                //catch (Exception ex)
                //{
                //    a.Show(this);
                //    ok.titletxt.Text = @"Error";
                //    ok.msgtxt.Text = @"System has encountered an unexpected Error! Please contact the system developer relating to this problem.";
                //    ok.OkDescription = "Error";
                //    ok.ShowDialog(this);
                //    a.Hide();
                //    Focus();
                //    //call LogFile method and pass argument as Exception message, event name, control name, error line number, current form name
                //    LogFile(ex.Message, e.ToString(), ((Control)sender).Name, ex.LineNumber(), FindForm()?.Name);

                //}
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
