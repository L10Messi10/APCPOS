using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using APCPOS.Form_Transparent;
using APCPOS.Includes;
using APCPOS.Messageboxes;
using Bunifu.UI.WinForms;
using static APCPOS.Includes.Log;
using static APCPOS.Includes.SqlConfig;

namespace APCPOS.Forms
{
    public partial class FrmProductAe : Form
    {
        public bool _PAdd;
        private Byte[] _imagebytearray;
        private string prodFS="1";
        public FrmProductAe()
        {
            InitializeComponent();
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private async void FrmProductAe_Load(object sender, EventArgs e)
        {
            await XFillUnit();
            bunifuFormFadeTransition1.ShowAsyc(this);

        }

        private async Task XFillUnit()
        {
            Sqlcmd.Parameters.Clear();
            await Conopen();
            Strsql = "Select * from tbl_prod_category";
            Sqlcmd.CommandText = Strsql;
            Sqlcmd.Connection = Cnn;
            Sqladapter.SelectCommand = Sqlcmd;
            Sqlreader = Sqlcmd.ExecuteReader();
            category.Items.Clear();
            while (Sqlreader.Read())
            {
                category.Items.Add(Sqlreader.GetValue(1));
            }
            Sqlcmd.Dispose();
            Sqlreader.Close();
            Cnn.Close();
            Strsql = "";
            //*****************************************************
            Sqlcmd.Parameters.Clear();
            await Conopen();
            Strsql = "Select * from tbl_Unit";
            Sqlcmd.CommandText = Strsql;
            Sqlcmd.Connection = Cnn;
            Sqladapter.SelectCommand = Sqlcmd;
            Sqlreader = Sqlcmd.ExecuteReader();
            cmbounit.Items.Clear();
            while (Sqlreader.Read())
            {
                cmbounit.Items.Add(Sqlreader.GetValue(1));
            }
            Sqlcmd.Dispose();
            Sqlreader.Close();
            Cnn.Close();
            Strsql = "";
        }

        private async void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            var ok = new Frm_OK();
            var a = new T_Message();
            if (bunifuTextBox1.Text == "")
            {
                var frmok = new Frm_OK
                {
                    titletxt = { Text = "Warning" },
                    OkDescription = "Warn",
                    msgtxt = { Text = "Please Enter Product name!" }
                };
                a.Show(this);
                frmok.ShowDialog();
                a.Hide();
                Focus();
                bunifuTextBox1.Focus();
            }
            else if (bunifuTextBox3.Text == "")
            {
                var frmok = new Frm_OK
                {
                    titletxt = { Text = "Warning" },
                    OkDescription = "Warn",
                    msgtxt = { Text = "Please Enter Product Stock!" }
                };
                a.Show(this);
                frmok.ShowDialog();
                a.Hide();
                Focus();
                bunifuTextBox3.Focus();
            }
            else if (cmbounit.Text == "")
            {
                var frmok = new Frm_OK
                {
                    titletxt = { Text = "Warning" },
                    OkDescription = "Warn",
                    msgtxt = { Text = "Please Select Product's Unit description!" }
                };
                a.Show(this);
                frmok.ShowDialog();
                a.Hide();
                Focus();
                cmbounit.Focus();
            }
            else if (bunifuTextBox4.Text == "")
            {
                var frmok = new Frm_OK
                {
                    titletxt = { Text = "Warning" },
                    OkDescription = "Warn",
                    msgtxt = { Text = "Please Select Product's Unit price!" }
                };
                a.Show(this);
                frmok.ShowDialog();
                a.Hide();
                Focus();
                bunifuTextBox4.Focus();
            }
            else
            {
                if (_PAdd)
                {
                    try
                    {
                        await Xaddmode();
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
                        LogFile(ex.Message, e.ToString(), ((Control)sender).Name, ex.LineNumber(), FindForm()?.Name);
                    }
                }
            }
        }

        private async Task Xaddmode()
        {
            Sqlcmd.Parameters.Clear();
            Image temp = new Bitmap(bunifuPictureBox1.Image);
            var strm = new MemoryStream();
            temp.Save(strm,
                ImageFormat.Jpeg);
            _imagebytearray = strm.ToArray();
            await Conopen();
            Strsql =
                "Insert into tbl_Products(Prod_Barcode, Prod_Name, Prod_Stock, Unit_Desc, Prod_Price,Prod_Img,production_Strt_date,cost_sale,cat_desc,prod_description,prod_FS) " +
                "Values(@Prod_Barcode, @Prod_Name, @Prod_Stock, @Unit_Desc, @Prod_Price, @Prod_Img,@production_Strt_date,@cost_sale,@cat_desc,@prod_description,@prod_FS)";
            Sqlcmd.Parameters.AddWithValue("@Prod_Barcode",
                bunifuTextBox2.Text);
            Sqlcmd.Parameters.AddWithValue("@Prod_Name",
                bunifuTextBox1.Text);
            Sqlcmd.Parameters.AddWithValue("@Prod_Stock",
                bunifuTextBox3.Text);
            Sqlcmd.Parameters.AddWithValue("@Unit_Desc",
                cmbounit.Text);
            Sqlcmd.Parameters.AddWithValue("@Prod_Price",
                bunifuTextBox4.Value);
            Sqlcmd.Parameters.AddWithValue("@Prod_Img",
                _imagebytearray);
            Sqlcmd.Parameters.AddWithValue("@production_Strt_date",
                psdstartdate.Value);
            Sqlcmd.Parameters.AddWithValue("@cost_sale",
                cost.Value);
            Sqlcmd.Parameters.AddWithValue("@cat_desc",
                category.Text);
            Sqlcmd.Parameters.AddWithValue("@prod_description",
                txtdesciption.Text);
            Sqlcmd.Parameters.AddWithValue("@prod_FS",
                prodFS);
            Sqlcmd.Connection = Cnn;
            //sqlcmd.CommandType = CommandType.Text;
            Sqlcmd.CommandText = Strsql;
            Sqlcmd.ExecuteNonQuery();
            var a = new T_Message();
            var frmok = new Frm_OK();
            a.Show(this);
            frmok.titletxt.Text = "Success";
            frmok.msgtxt.Text =
                "Record has been successfully Added! Please refresh the products data to see modified changes.";
            frmok.OkDescription = "Success";
            frmok.ShowDialog(this);
            a.Hide();
            Sqlcmd.Dispose();
            Strsql = "";
            Cnn.Close();
            Close();
        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            // open file dialog   
            OpenFileDialog open = new OpenFileDialog
            {
                // image filters  
                Filter = "Image Files(*.jpg; *.jpeg; *.png; *.bmp)|*.jpg; *.jpeg; *.png; *.bmp"
            };
            if (open.ShowDialog() == DialogResult.OK)
            {
                // display image in picture box  
                var size = new FileInfo(open.FileName).Length;
                if (size > 3145728)
                {
                    var a = new Frm_OK();
                    a.OkDescription = "Error";
                    a.titletxt.Text = "Error";
                    a.msgtxt.Text =
                        "Please select an image less than or equal to 3MB. this is to ensure Database effeciency!";
                    a.ShowDialog();
                    Focus();
                }
                else
                {
                    bunifuPictureBox1.Image = new Bitmap(open.FileName);
                }

            }
        }

        private void bunifuCheckBox1_CheckedChanged(object sender, BunifuCheckBox.CheckedChangedEventArgs e)
        {
            if (bunifuCheckBox1.Checked)
            {
                prodFS = "1";
            }
            else
            {
                prodFS = "0";
            }
        }
    }
}
