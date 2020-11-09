using System;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Net;
using System.Net.Mail;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using APCPOS.Form_Transparent;
using APCPOS.Messageboxes;
using static System.DateTime;
using static APCPOS.Forms.FrmPOSTransaction;
using static APCPOS.Includes.SqlConfig;


namespace APCPOS.Forms
{
    public partial class FrmCustomerAE : Form
    {
        private static FrmCustomerAE f;
        private string _mailmsg;
        private string _subject;
        private string _mymail;
        private string _mypassword;
        private Byte[] _imagebytearray;
        private string _idNum;
        public FrmCustomerAE()
        {
            InitializeComponent();
            f = this;
        }

        private async void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            var a = new T_Message();
            if (txtfname.Text == "")
            {
                var frmok = new Frm_OK
                {
                    titletxt = { Text = @"Warning" },
                    OkDescription = "Warn",
                    msgtxt = { Text = @"Please enter customer's first name!" }
                };
                a.Show(this);
                frmok.ShowDialog();
                a.Dispose();
                Focus();
                txtfname.Focus();
            }
            else if (txtlname.Text == "")
            {
                var frmok = new Frm_OK
                {
                    titletxt = { Text = @"Warning" },
                    OkDescription = "Warn",
                    msgtxt = { Text = @"Please enter customer's last name!" }
                };
                a.Show(this);
                frmok.ShowDialog();
                a.Dispose();
                Focus();
                txtlname.Focus();
            }
            else if (cmbprefix.Text == "")
            {
                var frmok = new Frm_OK
                {
                    titletxt = { Text = @"Warning" },
                    OkDescription = "Warn",
                    msgtxt = { Text = @"Please select customer's preferred prefix!" }
                };
                a.Show(this);
                frmok.ShowDialog();
                a.Dispose();
                Focus();
                cmbprefix.Focus();
            }
            else if (txtaddress.Text == "")
            {
                var frmok = new Frm_OK
                {
                    titletxt = { Text = @"Warning" },
                    OkDescription = "Warn",
                    msgtxt = { Text = @"Please enter customer's address!" }
                };
                a.Show(this);
                frmok.ShowDialog();
                a.Dispose();
                Focus();
                txtaddress.Focus();
            }
            else if (txtmobilephone.Text == "")
            {
                var frmok = new Frm_OK
                {
                    titletxt = { Text = @"Warning" },
                    OkDescription = "Warn",
                    msgtxt = { Text = @"Please enter customer's mobile number!" }
                };
                a.Show(this);
                frmok.ShowDialog();
                a.Dispose();
                Focus();
                txtmobilephone.Focus();
            }
            else if (txtemail.Text == "")
            {
                var frmok = new Frm_OK
                {
                    titletxt = { Text = @"Warning" },
                    OkDescription = "Warn",
                    msgtxt = { Text = @"Please enter customer's valid e-mail address!" }
                };
                a.Show(this);
                frmok.ShowDialog();
                a.Dispose();
                Focus();
                txtemail.Focus();
            }
            else
            {
                await XGen_ID();
                await XAddCustomer();
                XSendEmail();
            }
        }
        private async Task XGen_ID()
        {
            Sqlcmd.Parameters.Clear();
            await Conopen();
            Strsql = "Select * from tbl_customer";
            Sqlcmd.CommandText = Strsql;
            Sqlcmd.Connection = Cnn;
            Sqladapter.SelectCommand = Sqlcmd;
            DataTable sqlDt = new DataTable();
            sqlDt.Reset();
            Sqladapter.Fill(sqlDt);
            Sqlreader = Sqlcmd.ExecuteReader();
            if (Sqlreader.Read())
            {
                var count = Convert.ToDouble(sqlDt.Rows.Count.ToString());
                var xRi = Convert.ToDouble(1 + count);
                _idNum = $"{Now.Year}{xRi}";
            }
            else
            {
                _idNum = $"{Now.Year}{1}";
            }
            Sqlcmd.Dispose();
            Strsql = "";
            Cnn.Close();
        }
        private async Task XAddCustomer()
        {
            Sqlcmd.Parameters.Clear();
            Image temp = new Bitmap(bunifuPictureBox1.Image);
            var strm = new MemoryStream();
            temp.Save(strm,
                ImageFormat.Jpeg);
            _imagebytearray = strm.ToArray();
            await Conopen();
            Strsql =
                "Insert into tbl_customer(cus_ID, cus_fname, cus_lname, cus_prefix, cus_address, cus_home_phone, cus_mobile,cus_email,cus_dob,cus_notes,cus_img) " +
                "Values(@cus_ID, @cus_fname, @cus_lname, @cus_prefix, @cus_address, @cus_home_phone, @cus_mobile, @cus_email,@cus_dob,@cus_notes,@cus_img)";
            Sqlcmd.Parameters.AddWithValue("@cus_ID",
                _idNum);
            Sqlcmd.Parameters.AddWithValue("@cus_fname",
                txtfname.Text);
            Sqlcmd.Parameters.AddWithValue("@cus_lname",
                txtlname.Text);
            Sqlcmd.Parameters.AddWithValue("@cus_prefix",
                cmbprefix.Text);
            Sqlcmd.Parameters.AddWithValue("@cus_address",
                txtaddress.Text);
            Sqlcmd.Parameters.AddWithValue("@cus_home_phone",
                txthomephone.Text);
            Sqlcmd.Parameters.AddWithValue("@cus_mobile",
                txtmobilephone.Text);
            Sqlcmd.Parameters.AddWithValue("@cus_email",
                txtemail.Text);
            Sqlcmd.Parameters.AddWithValue("@cus_dob",
                dateTimePicker1.Value);
            Sqlcmd.Parameters.AddWithValue("@cus_notes",
                txtnotes.Text);
            Sqlcmd.Parameters.AddWithValue("@cus_img",
                _imagebytearray);
            Sqlcmd.Connection = Cnn;
            Sqlcmd.CommandText = Strsql;
            Sqlcmd.ExecuteNonQuery();
            var a = new T_Message();
            var frmok = new Frm_OK();
            a.Show(this);
            frmok.titletxt.Text = @"Success";
            frmok.msgtxt.Text =
                @"Record has been successfully Added! Please refresh the customer data to see modified changes.";
            frmok.OkDescription = "Success";
            frmok.ShowDialog(this);
            a.Hide();
            Sqlcmd.Dispose();
            Strsql = "";
            Cnn.Close();
            XCustomerLoaded = false;
            Close();
        }

        private void XSendEmail()
        {
            try
            {
                var message = new MailMessage(_mymail, txtemail.Text) { Subject = _subject, Body = _mailmsg };

                using (var mailer = new SmtpClient("smtp.gmail.com", 587))
                {
                    mailer.Credentials = new NetworkCredential(_mymail, _mypassword);
                    mailer.EnableSsl = true;
                    mailer.Send(message);
                }
            }
            catch
            {
                var t = new T_Message();
                t.Show(this);
                var ok = new Frm_OK
                {
                    msgtxt = { Text = @"There is an error sending and email, ensure that the root mail is set up properly! and ensure that the application is not blocked by the firewall! And ensure that this PC has an internet connection!" },
                    OkDescription = "Warn",
                    titletxt = { Text = @"E-mail error" }
                };
                ok.ShowDialog();
                t.Dispose();
                // ignored
            }
        }

        private async Task XLoadMailinfo()
        {
            Sqlcmd.Parameters.Clear();
            await Conopen();
            Strsql = "Select * from tbl_email_settings";
            Sqlcmd.CommandText = Strsql;
            Sqlcmd.Connection = Cnn;
            Sqladapter.SelectCommand = Sqlcmd;
            Sqlreader = Sqlcmd.ExecuteReader();
            //metroComboBox1.Items.Clear();
            if (Sqlreader.Read())
            {
                _mymail = Sqlreader.GetValue(0).ToString();
                _mypassword = Sqlreader.GetValue(1).ToString();
                _subject = Sqlreader.GetValue(2).ToString();
                _mailmsg= Sqlreader.GetValue(3).ToString();
            }
            Sqlcmd.Dispose();
            Sqlreader.Close();
            Cnn.Close();
            Strsql = "";
        }

        private void txtemail_Leave(object sender, EventArgs e)
        {
            string pattern = "^([0-9a-zA-Z]([-\\.\\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\\w]*[0-9a-zA-Z]\\.)+[a-zA-Z]{2,9})$";
            if (Regex.IsMatch(txtemail.Text, pattern))
            {
                errorProvider1.Clear();
            }
            else
            {
                errorProvider1.SetError(txtemail, "Please enter a valid email address");
            }
        }

        private async void FrmCustomerAE_Load(object sender, EventArgs e)
        {
            await XLoadMailinfo();
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
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
    }
}
