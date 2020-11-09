using System;
using System.Globalization;
using System.Threading.Tasks;
using System.Windows.Forms;
using APCPOS.Form_Transparent;
using APCPOS.Includes;
using APCPOS.Messageboxes;
using Bunifu.UI.WinForms;
using static APCPOS.Includes.SqlConfig;
using static APCPOS.Includes.Log;

namespace APCPOS.Forms
{
    public partial class FrmAddStock : Form
    {
        private double prev_Stock;
        private double tot_stock;
        private string _stockFS;

        public FrmAddStock()
        {
            InitializeComponent();
        }
        

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            //numericUpDown1.UpButton();
            tot_stock = prev_Stock + Convert.ToDouble(numericUpDown1.Value);
            lblstock.Text = tot_stock.ToString(CultureInfo.InvariantCulture);

        }

        private async void FrmAddStock_Load(object sender, EventArgs e)
        {
           await XDisplayPrevStock();
           bunifuFormFadeTransition1.ShowAsyc(this);    
        }

        private async Task XDisplayPrevStock()
        {
            //byte[] img;
            //bunifuTextBox1.Text = Form1.XID;
            Sqlcmd.Parameters.Clear();
            await Conopen();
            Strsql = "Select * from tbl_Products where Prod_Number = '" + label1.Text + "'";
            Sqlcmd.CommandText = Strsql;
            Sqlcmd.Connection = Cnn;
            Sqladapter.SelectCommand = Sqlcmd;
            Sqlreader = Sqlcmd.ExecuteReader();
            //metroComboBox1.Items.Clear();
            if (Sqlreader.Read())
            {
                lblprodname.Text = (Sqlreader.GetValue(2).ToString());
                prev_Stock =Convert.ToDouble((Sqlreader.GetValue(3).ToString()));
                label6.Text = prev_Stock.ToString(CultureInfo.InvariantCulture);
                _stockFS= (Sqlreader.GetValue(11).ToString());
                bunifuCheckBox1.Checked = _stockFS == "1";
                cost.Value= Convert.ToDecimal(Sqlreader.GetValue(4));
                bunifuTextBox4.Value= Convert.ToDecimal(Sqlreader.GetValue(6));
            }
            Sqlcmd.Dispose();
            Sqlreader.Close();
            Cnn.Close();
            Strsql = "";
        }

        private void numericUpDown1_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private async void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            //Image temp = new Bitmap(bunifuPictureBox1.Image);
                var ok = new Frm_OK();
                var a = new T_Message();
            try
            {
                Sqlcmd.Parameters.Clear();
                await Conopen();
                Strsql =
                    "Update tbl_Products set Prod_Stock=@Prod_Stock, prod_FS=@prod_FS,cost_sale=@cost_sale,Prod_Price=@Prod_Price Where Prod_Number=@Prod_Number";
                if (lblstock.Text != "0")
                {
                    Sqlcmd.Parameters.AddWithValue("@Prod_Stock", Convert.ToDouble(lblstock.Text));
                }
                else
                {
                    Sqlcmd.Parameters.AddWithValue("@Prod_Stock", Convert.ToDouble(label6.Text));
                }

                Sqlcmd.Parameters.AddWithValue("@prod_FS", Convert.ToInt32(_stockFS));
                Sqlcmd.Parameters.AddWithValue("@cost_sale", Convert.ToDecimal(cost.Value));
                Sqlcmd.Parameters.AddWithValue("@Prod_Price", Convert.ToDecimal(bunifuTextBox4.Value));
                Sqlcmd.Parameters.AddWithValue("@Prod_Number", label1.Text);
                Sqlcmd.Connection = Cnn;
                //sqlcmd.CommandType = CommandType.Text;
                Sqlcmd.CommandText = Strsql;
                Sqlcmd.ExecuteNonQuery();
                ok.OkDescription = "Success";
                ok.titletxt.Text = "Success";
                ok.msgtxt.Text = "Stock for the product " + lblprodname.Text +
                                 " and other info. has been successfully updated. Please refresh the Stock data to see modified changes.";
                a.Show(this);
                ok.ShowDialog();
                a.Hide();
                Sqlcmd.Dispose();
                Strsql = "";
                Cnn.Close();
                Close();
            }
            catch (Exception ex)
            {
                a.Show(this);
                ok.titletxt.Text = "Error";
                ok.msgtxt.Text = "System has encountered an unexpected Error! Please contact the system developer relating to this problem.";
                ok.OkDescription = "Error";
                ok.ShowDialog(this);
                a.Hide();
                Focus();
                //call LogFile method and pass argument as Exception message, event name, control name, error line number, current form name
                LogFile(ex.Message, e.ToString(), ((Control)sender).Name, ex.LineNumber(), FindForm()?.Name);

            }
        }
        

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void bunifuCheckBox1_CheckedChanged(object sender, BunifuCheckBox.CheckedChangedEventArgs e)
        {
            if (bunifuCheckBox1.Checked)
            {
                _stockFS = "1";
            }
            else
            {
                _stockFS = "0";
            }
        }
    }
}
