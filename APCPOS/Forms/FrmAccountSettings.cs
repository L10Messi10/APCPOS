using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.DateTime;
using static APCPOS.Includes.SqlConfig;

namespace APCPOS.Forms
{
    public partial class FrmAccountSettings : Form
    {
        private string _updatedinfo = @"" + username + " have updated his/her Personal info";
        private string _updatedsecurity = @"" + username + " have updated his/her security info";
        private bool xinfoupdated;
        public FrmAccountSettings()
        {
            InitializeComponent();
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btndashboard_Click(object sender, EventArgs e)
        {
            panelgeneral.Visible = true;
            panelsecurity.Visible = false;
            panellogs.Visible = false;
            indicator.Top = btndashboard.Top;
            indicator.Visible = false;
            bunifuTransition1.ShowSync(indicator);
        }

        private void btn_product_Click(object sender, EventArgs e)
        {
            panelgeneral.Visible = false;
            panelsecurity.Visible = true;
            panellogs.Visible = false;
            indicator.Top = btn_product.Top;
            indicator.Visible = false;
            bunifuTransition1.ShowSync(indicator);
        }

        private async void btn_stock_Click(object sender, EventArgs e)
        {
            await XLoadLogs();
            panelgeneral.Visible = false;
            panelsecurity.Visible = false;
            panellogs.Visible = true;
            indicator.Top = btn_stock.Top;
            indicator.Visible = false;
            bunifuTransition1.ShowSync(indicator);
        }

        private async void FrmAccountSettings_Load(object sender, EventArgs e)
        {
            await XLoadUser();
            await XLoadLogs();
        }

        private async Task XLoadLogs()
        {
            await Conopen();
            Strsql = "Select * from tbl_logs where u_name='" + username + "'";
            Sqlcmd.CommandText = Strsql;
            Sqlcmd.Connection = Cnn;
            Sqladapter.SelectCommand = Sqlcmd;
            Sqlreader = Sqlcmd.ExecuteReader();
            listView1.Items.Clear();
            while (Sqlreader.Read())
            {
                var lvi = listView1.Items.Add(Sqlreader.GetValue(0).ToString());
                lvi.SubItems.Add(Sqlreader.GetValue(2).ToString());
                lvi.SubItems.Add(Sqlreader.GetValue(3).ToString());
                lvi.SubItems.Add(Sqlreader.GetValue(4).ToString());
                lvi.SubItems.Add(Sqlreader.GetValue(5).ToString());
            }
            Sqlcmd.Dispose();
            Sqlreader.Close();
            Cnn.Close();
            Strsql = "";
            bunifuDatepicker1.Value = Today;
        }
        private async Task XLoadXfilterLogsLogs()
        {
            Sqlcmd.Parameters.Clear();
            await Conopen();
            Strsql = "Select * from tbl_logs where u_name='" + username + "' and log_date='" + bunifuDatepicker1.Value +"'";
            Sqlcmd.CommandText = Strsql;
            Sqlcmd.Connection = Cnn;
            Sqladapter.SelectCommand = Sqlcmd;
            Sqlreader = Sqlcmd.ExecuteReader();
            listView1.Items.Clear();
            while (Sqlreader.Read())
            {
                var lvi = listView1.Items.Add(Sqlreader.GetValue(0).ToString());
                lvi.SubItems.Add(Sqlreader.GetValue(2).ToString());
                lvi.SubItems.Add(Sqlreader.GetValue(3).ToString());
                var a = (DateTime)(Sqlreader.GetValue(4));
                lvi.SubItems.Add(a.ToShortDateString());
                lvi.SubItems.Add(Sqlreader.GetValue(5).ToString());
            }
            Sqlcmd.Dispose();
            Sqlreader.Close();
            Cnn.Close();
            Strsql = "";
        }
        private async Task XLoadUser()
        {
            UseWaitCursor = true;
            textBox4.Text = username;
            await Conopen();
            Sqlcmd.Parameters.Clear();
            Strsql = "Select * from tbl_Users where u_name='" + username + "'";
            Sqlcmd.CommandText = Strsql;
            Sqlcmd.Connection = Cnn;
            Sqladapter.SelectCommand = Sqlcmd;
            Sqlreader = Sqlcmd.ExecuteReader();
            if (Sqlreader.Read())
            {
                txtfname.Text = Sqlreader.GetValue(1).ToString();
                //userfullname = lblfullname.Text;
                textBox1.Text = Sqlreader.GetValue(2).ToString();
                textBox2.Text = Sqlreader.GetValue(3).ToString();
                label4.Text = Sqlreader.GetValue(6).ToString();
                label8.Text = Sqlreader.GetValue(8).ToString();
                label10.Text = Sqlreader.GetValue(10).ToString();
                textBox3.Text = Sqlreader.GetValue(11).ToString();
                linkLabel1.Text = Sqlreader.GetValue(12).ToString();
                label12.Text = Sqlreader.GetValue(13).ToString();
                var img = (byte[])(Sqlreader.GetValue(9));
                if (img.Length != 0)
                {
                    bunifuPictureBox1.Image = Image.FromStream(new MemoryStream(img));
                }
                var stat= Sqlreader.GetValue(7).ToString();
                label5.Text = stat == "1" ? @"Approved" : @"Pending";
            }
            Sqlcmd.Dispose();
            Sqlreader.Close();
            Cnn.Close();
            Strsql = "";
            UseWaitCursor = false;
        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            // open file dialog   
            OpenFileDialog open = new OpenFileDialog
            {
                // image filters  
                Title = @"Select your profile picture!",
                Filter = @"Image Files(*.jpg; *.jpeg; *.png; *.bmp)|*.jpg; *.jpeg; *.png; *.bmp"
            };
            if (open.ShowDialog() == DialogResult.OK)
            {
                // display image in picture box  
                var size = new FileInfo(open.FileName).Length;
                if (size > 3145728)
                {
                    popup.TitleText = @"Warning";
                    popup.ContentText = @"Please select an image less than or equal to 3MB. this is to ensure Database efficiency!";
                    popup.Popup();
                    Focus();
                }
                else
                {
                    bunifuPictureBox1.Image = new Bitmap(open.FileName);
                }
            }
        }

        private async void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            if (txtfname.Text == "")
            {
                popup.TitleText = @"Field required";
                popup.ContentText = @"Please Enter your full name!";
                popup.Popup();
                txtfname.Focus();
            }
            else if (textBox1.Text == "")
            {
                popup.TitleText = @"Field required";
                popup.ContentText = @"Please Enter your complete address!";
                popup.Popup();
                textBox1.Focus();
            }
            else if (textBox2.Text == "")
            {
                popup.TitleText = @"Field required";
                popup.ContentText = @"Please Enter your contact number!";
                popup.Popup();
                textBox2.Focus();
            }
            else await XupdateInfo();
        }
        private async Task XupdateInfo()
        {
            UseWaitCursor = true;

            Sqlcmd.Parameters.Clear();
            await Conopen();
            Image temp = new Bitmap(bunifuPictureBox1.Image);
            var strm = new MemoryStream();
            temp.Save(strm, System.Drawing.Imaging.ImageFormat.Jpeg);
            var _imagebytearray = strm.ToArray();
            Strsql =
                "Update tbl_Users set u_Fname=@u_Fname, u_address=@u_address, u_c_num=@u_c_num, u_img=@u_img Where u_name=@u_name";
            Sqlcmd.Parameters.AddWithValue("@u_Fname", txtfname.Text);
            Sqlcmd.Parameters.AddWithValue("@u_address", textBox1.Text);
            Sqlcmd.Parameters.AddWithValue("@u_c_num", textBox2.Text);
            Sqlcmd.Parameters.AddWithValue("@u_img", _imagebytearray);
            Sqlcmd.Parameters.AddWithValue("@u_name", username);
            Sqlcmd.Connection = Cnn;
            Sqlcmd.CommandText = Strsql;
            Sqlcmd.ExecuteNonQuery();
            Sqlcmd.Dispose();
            Strsql = "";
            Cnn.Close();
            xinfoupdated = true;
            await XSaveTransactionLog();
            popup.Delay = 5000;
            popup.TitleText = @"Info updated";
            popup.ContentText = @"Your personal information has been successfully updated! You might need to restart the application to see the modified changes";
            popup.Popup();
            UseWaitCursor = false;
        }
        private async Task XSaveTransactionLog()
        {
            Sqlcmd.Parameters.Clear();
            await Conopen();
            Strsql =
                "Insert into tbl_logs(u_name, action, log_date, log_time) " +
                "Values(@u_name, @action, @log_date, @log_time)";
            Sqlcmd.Parameters.AddWithValue("@u_name",
                username);
            Sqlcmd.Parameters.AddWithValue("@action",
                xinfoupdated ? _updatedinfo : _updatedsecurity);
            Sqlcmd.Parameters.AddWithValue("@log_date",
                Today);
            Sqlcmd.Parameters.AddWithValue("@log_time",
                Now.ToString("h:mm:ss tt"));
            Sqlcmd.Connection = Cnn;
            Sqlcmd.CommandText = Strsql;
            Sqlcmd.ExecuteNonQuery();
            Sqlcmd.Dispose();
            Cnn.Close();
            Strsql = string.Empty;
        }

        private async void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            if (textBox4.Text == "")
            {
                popup.TitleText = @"Field required";
                popup.ContentText = @"Please Enter your username!";
                popup.Popup();
                textBox4.Focus();
            }
            else if (textBox5.Text == "")
            {
                popup.TitleText = @"Field required";
                popup.ContentText = @"Please Enter your old password!";
                popup.Popup();
                textBox5.Focus();
            }
            else if (textBox5.Text != userpassword)
            {
                popup.TitleText = @"Password";
                popup.ContentText = @"The old password you entered doesn't match the old password. Please try again!";
                popup.Popup();
                textBox5.Text = "";
                textBox5.Focus();
            }
            else if (textBox6.Text == "")
            {
                popup.TitleText = @"Field required";
                popup.ContentText = @"Please Enter your new password!";
                popup.Popup();
                textBox6.Focus();
            }
            else if (textBox7.Text == "")
            {
                popup.TitleText = @"Field required";
                popup.ContentText = @"Please confirm your new password!";
                popup.Popup();
                textBox7.Focus();
            }
            else if (textBox6.Text != textBox7.Text)
            {
                popup.TitleText = @"New password";
                popup.ContentText = @"New password mismatched! Please try confirming your password again!";
                popup.Popup();
                textBox7.Text = "";
                textBox7.Focus();
            }
            else await XupdateSecurity();
        }

        private async Task XupdateSecurity()
        {
            try
            {
                UseWaitCursor = true;
                Sqlcmd.Parameters.Clear();
                await Conopen();
                Strsql =
                    "Update tbl_Users set u_name=@u_name, u_pass=@u_pass Where u_name=@u_nam";
                Sqlcmd.Parameters.AddWithValue("@u_name", textBox4.Text);
                Sqlcmd.Parameters.AddWithValue("@u_pass", textBox7.Text);
                Sqlcmd.Parameters.AddWithValue("@u_nam", username);
                Sqlcmd.Connection = Cnn;
                Sqlcmd.CommandText = Strsql;
                Sqlcmd.ExecuteNonQuery();
                Sqlcmd.Dispose();
                Strsql = "";
                username = textBox4.Text;
                userpassword = textBox7.Text;
                Cnn.Close();
                xinfoupdated = false;
                await XSaveTransactionLog();
                popup.TitleText = @"Security updated";
                popup.ContentText = @"Your security information has been successfully updated!";
                popup.Popup();
                UseWaitCursor = false;
                Close();
            }
            catch
            {
                UseWaitCursor = false;
                textBox5.Text = "";
                textBox6.Text = "";
                textBox7.Text = "";
                popup.TitleText = @"User name";
                popup.ContentText = @"The user name you entered is already taken, please enter another user name and try saving the data again!";
                popup.Popup();
                textBox4.Focus();
            }
}

        private async void bunifuDatepicker1_onValueChanged(object sender, EventArgs e)
        {
            await XLoadXfilterLogsLogs();
        }

        private async void bunifuImageButton6_Click(object sender, EventArgs e)
        {
            await XLoadLogs();
        }

        private void bunifuFlatButton4_Click(object sender, EventArgs e)
        {
            var frmReports = new FrmReports { StrReport = "MyLogs", PrintWhere = ("{V_Logs.u_name} ='" + username + "'") };
            frmReports.ShowDialog();
            frmReports.Close();
        }
    }
}
