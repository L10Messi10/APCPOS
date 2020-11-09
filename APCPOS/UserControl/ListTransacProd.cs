using System;
using System.Drawing;
using APCPOS.Form_Transparent;
using APCPOS.Forms;
using APCPOS.Messageboxes;
using static APCPOS.Forms.FrmPOSTransaction;
using static APCPOS.Includes.SqlConfig;

namespace APCPOS.UserControl
{
    public partial class ListTransacProd : System.Windows.Forms.UserControl
    {
        public ListTransacProd()
        {
            InitializeComponent();
        }
        private void ListTransacProd_Load(object sender, EventArgs e)
        {
           //bunifuFormFadeTransition1.ShowAsyc(this);
        }

        private async void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            if (TranNum != null)
            {
                
                Sqlcmd.Parameters.Clear();
                await Conopen();
                Strsql = "Select * from tbl_Transaction_Detail where Inv_Num='" + TranNum + "' AND Prod_Number = '" + label2.Text + "'";
                Sqlcmd.CommandText = Strsql;
                Sqlcmd.Connection = Cnn;
                Sqladapter.SelectCommand = Sqlcmd;
                Sqlreader = Sqlcmd.ExecuteReader();
                //metroComboBox1.Items.Clear();
                if (Sqlreader.Read())
                {
                    Sqlcmd.Dispose();
                    Sqlreader.Close();
                    Cnn.Close();
                    Strsql = "";
                    var ms = new T_Message();
                    var ok = new Frm_OK();
                    ms.Show(this);
                    ok.OkDescription = "Warn";
                    ok.titletxt.Text = @"Warning";
                    ok.msgtxt.Text = @"This product is already in the cart. Are you trying to modify it's quantity? If so, please select set quantity option in the cart panel.";
                    ok.ShowDialog();
                    ms.Close();
                    Focus();
                }
                else
                {
                    Sqlcmd.Dispose();
                    Sqlreader.Close();
                    Cnn.Close();
                    Strsql = "";
                    var b = new T_Transaction();
                    var a = new FrmAddToCart();
                    a.lblprodID.Text = label2.Text;
                    b.Show(this);
                    a.ShowDialog();
                    b.Dispose();
                    a.Dispose();
                    Focus();
                }
            }
            else
            {
                var b = new T_Transaction();
                var a = new FrmAddToCart();
                a.lblprodID.Text = label2.Text;
                b.Show(this);
                a.ShowDialog();
                //c.lblinvoice.Text = a.inv_num;
                b.Dispose();
                a.Dispose();
                Focus();
            }

            
        }

        private void ListTransacProd_MouseEnter(object sender, EventArgs e)
        {
            BackColor = Color.FromArgb(69, 70, 73);
        }

        private void ListTransacProd_MouseLeave(object sender, EventArgs e)
        {
            BackColor = Color.FromArgb(30, 30, 32);
        }
    }
}
