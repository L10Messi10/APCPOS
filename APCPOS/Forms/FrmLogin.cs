using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Net.NetworkInformation;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Forms;
using APCPOS.Form_Transparent;
using APCPOS.Messageboxes;
using static System.DateTime;
using static APCPOS.Includes.SqlConfig;
using static APCPOS.Forms.FrmScanner;

namespace APCPOS.Forms
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
            typeof(Panel).InvokeMember("DoubleBuffered", BindingFlags.SetProperty
                                                         | BindingFlags.Instance | BindingFlags.NonPublic, null,
                panel1, new object[] { true });
            typeof(Panel).InvokeMember("DoubleBuffered", BindingFlags.SetProperty
                                                         | BindingFlags.Instance | BindingFlags.NonPublic, null,
                panel2, new object[] { true });
            typeof(Panel).InvokeMember("DoubleBuffered", BindingFlags.SetProperty
                                                         | BindingFlags.Instance | BindingFlags.NonPublic, null,
                panel3, new object[] { true });
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

        private async void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            if (txtusername.Text != "" && txtpassword.Text != "")
            {
                await Conopen();
                Sqlcmd.Parameters.Clear();
                Strsql = "Select * from tbl_Users where u_name='" + txtusername.Text + "' and u_pass ='" + txtpassword.Text + "' and approval_stat = 1";
                Sqlcmd.CommandText = Strsql;
                Sqlcmd.Connection = Cnn;
                Sqladapter.SelectCommand = Sqlcmd;
                Sqlreader = Sqlcmd.ExecuteReader();
                if (Sqlreader.Read())
                {
                    userpassword = txtpassword.Text;
                    username = txtusername.Text;
                    await XUpdatelogindate();
                    await XSaveLog();
                    popup.TitleText = @"Access granted";
                    popup.Image = Properties.Resources.check;
                    popup.ContentText = @"Welcome " + txtusername.Text +"!";
                    popup.Popup();
                    Sqlcmd.Dispose();
                    Sqlreader.Close();
                    Cnn.Close();
                    Strsql = "";

                    Hide();
                    Form1 a = new Form1();
                    a.Show();
                }
                else
                {
                    
                    popup.TitleText = @"Access denied";
                    popup.Image = Properties.Resources.error;
                    popup.ContentText = @"Account not found or the account you are trying to access is pending for approval by the admin. Please try again later or contact your admin!";
                    popup.Popup();
                    Focus();
                }
                Sqlcmd.Dispose();
                Sqlreader.Close();
                Cnn.Close();
                Strsql = "";
            }
            else
            {
                popup.TitleText = @"Access denied";
                popup.Image = Properties.Resources.error;
                popup.ContentText = @"Please enter your credentials to gain access to the system!";
                popup.Popup();
                Focus();
            }
        }
        public static async Task XSaveLog()
        {
            logaction = @"" + username + " has logged in the system.";
            Sqlcmd.Parameters.Clear();
            await Conopen();
            Strsql =
                "Insert into tbl_logs(u_name, action, log_date, log_time) " +
                "Values(@u_name, @action, @log_date, @log_time)";
            Sqlcmd.Parameters.AddWithValue("@u_name",
                username);
            Sqlcmd.Parameters.AddWithValue("@action",
                logaction);
            Sqlcmd.Parameters.AddWithValue("@log_date",
                Now.ToString("G"));
            Sqlcmd.Parameters.AddWithValue("@log_time",
                Now.ToString("h:mm:ss tt"));
            Sqlcmd.Connection = Cnn;
            Sqlcmd.CommandText = Strsql;
            Sqlcmd.ExecuteNonQuery();
            Sqlcmd.Dispose();
            Cnn.Close();
            Strsql = string.Empty;
        }

        public static async Task XUpdatelogindate()
        {
            Sqlcmd.Parameters.Clear();
            await Conopen();
            Strsql =
                "Update tbl_Users set last_login=@last_login Where u_name=@u_name";
            Sqlcmd.Parameters.AddWithValue("@last_login", Now);
            Sqlcmd.Parameters.AddWithValue("@u_name", username);
            Sqlcmd.Connection = Cnn;
            Sqlcmd.CommandText = Strsql;
            Sqlcmd.ExecuteNonQuery();
            Sqlcmd.Dispose();
            Strsql = "";
            Cnn.Close();
        }

        private async void bunifuFlatButton4_Click(object sender, EventArgs e)
        {
            if (bunifuFlatButton4.Text == @"Sign Up")
            {
                await XFilldesignation();
                label6.Text = @"Already have an account?";
                bunifuFlatButton4.Text = @"Sign In";
                panel1.Visible = false;
                bunifuTransition1.ShowSync(panel3);
            }
            else
            {
                label6.Text = @"Not registered yet?";
                bunifuFlatButton4.Text = @"Sign Up";
                panel3.Visible = false;
                bunifuTransition1.ShowSync(panel1);
            }
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
                    popup.Image = Properties.Resources.warning;
                    popup.ContentText = @"Please select an image less than or equal to 3MB. this is to ensure Database efficiency!";
                    popup.Popup();
                    Focus();
                }
                else
                {
                    bunifuPictureBox2.Image = new Bitmap(open.FileName);
                }
            }

        }

        private async void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            var a = new T_Message();
            if (bunifuTextBox5.Text == "")
            {
                var frmok = new Frm_OK
                {
                    titletxt = { Text = "Warning" },
                    OkDescription = "Warn",
                    msgtxt = { Text = "Please Enter your full name!" }
                };
                a.Show(this);
                frmok.ShowDialog();
                a.Hide();
                Focus();
                bunifuTextBox5.Focus();
            }
            else if (bunifuTextBox6.Text == "")
            {
                var frmok = new Frm_OK
                {
                    titletxt = { Text = "Warning" },
                    OkDescription = "Warn",
                    msgtxt = { Text = "Please Enter your address!" }
                };
                a.Show(this);
                frmok.ShowDialog();
                a.Hide();
                Focus();
                bunifuTextBox6.Focus();
            }
            else if (bunifuTextBox7.Text == "")
            {
                var frmok = new Frm_OK
                {
                    titletxt = { Text = "Warning" },
                    OkDescription = "Warn",
                    msgtxt = { Text = "Please Enter your contact number!" }
                };
                a.Show(this);
                frmok.ShowDialog();
                a.Hide();
                Focus();
                bunifuTextBox7.Focus();
            }
            else if (cmbodesig.Text == "")
            {
                var frmok = new Frm_OK
                {
                    titletxt = { Text = "Warning" },
                    OkDescription = "Warn",
                    msgtxt = { Text = "Please your designation!" }
                };
                a.Show(this);
                frmok.ShowDialog();
                a.Hide();
                Focus();
                cmbodesig.Focus();
            }
            else if (bunifuTextBox4.Text == "")
            {
                var frmok = new Frm_OK
                {
                    titletxt = { Text = "Warning" },
                    OkDescription = "Warn",
                    msgtxt = { Text = "Please Enter your unique user name!" }
                };
                a.Show(this);
                frmok.ShowDialog();
                a.Hide();
                Focus();
                bunifuTextBox4.Focus();
            }
            else if (bunifuTextBox3.Text == "")
            {
                var frmok = new Frm_OK
                {
                    titletxt = { Text = "Warning" },
                    OkDescription = "Warn",
                    msgtxt = { Text = "Please Enter your password!" }
                };
                a.Show(this);
                frmok.ShowDialog();
                a.Hide();
                Focus();
                bunifuTextBox3.Focus();
            }
            else
            {
               await XSignUp();
            }
        }

        private async Task XSignUp()
        {
            try
            {
                Sqlcmd.Parameters.Clear();
                Image temp = new Bitmap(bunifuPictureBox2.Image);
                MemoryStream strm = new MemoryStream();
                temp.Save(strm, ImageFormat.Jpeg);
                byte[] imagebytearray = strm.ToArray();
                await Conopen();
                Strsql =
                    "Insert into tbl_Users(u_Fname, u_address, u_c_num, u_name, u_pass, Desig_Desc, u_img) " +
                                   "Values(@u_Fname, @u_address, @u_c_num, @u_name, @u_pass,@Desig_Desc, @u_img)";
                Sqlcmd.Parameters.AddWithValue("@u_Fname", bunifuTextBox5.Text);
                Sqlcmd.Parameters.AddWithValue("@u_address", bunifuTextBox6.Text);
                Sqlcmd.Parameters.AddWithValue("@u_c_num", bunifuTextBox7.Text);
                Sqlcmd.Parameters.AddWithValue("@u_name", bunifuTextBox4.Text);
                Sqlcmd.Parameters.AddWithValue("@u_pass", bunifuTextBox3.Text);
                Sqlcmd.Parameters.AddWithValue("@Desig_Desc", cmbodesig.Text);
                Sqlcmd.Parameters.AddWithValue("@u_img", imagebytearray);
                Sqlcmd.Connection = Cnn;
                //sqlcmd.CommandType = CommandType.Text;
                Sqlcmd.CommandText = Strsql;
                Sqlcmd.ExecuteNonQuery();
                popup.TitleText = @"Success";
                popup.Image = Properties.Resources.check;
                popup.ContentText = @"You've successfully signed up, Your system application is pending for approval by the administrator.";
                popup.Popup();
                Sqlcmd.Dispose();
                Strsql = "";
                Cnn.Close();
                //Close();
                bunifuTextBox5.Text = "";
                bunifuTextBox6.Text = "";
                bunifuTextBox7.Text = "";
                bunifuTextBox4.Text = "";
                bunifuTextBox3.Text = "";
                cmbodesig.Items.Clear();
                bunifuPictureBox2.Image = null;
                label6.Text = @"Not registered yet?";
                bunifuFlatButton4.Text = @"Sign Up";
                panel3.Visible = false;
                bunifuTransition1.ShowSync(panel1);
                Focus();

            }
            catch
            {
                popup.TitleText = @"Warning";
                popup.Image = Properties.Resources.warning;
                popup.ContentText = @"The user name is already taken, please enter another one and try signing up again!";
                popup.Popup();
                Focus();
                bunifuTextBox5.Focus();
            }
        }

        private async void FrmLogin_Load(object sender, EventArgs e)
        {
            try
            {
                if (Properties.Settings.Default.ip_add != "")
                {
                    IP_Add = Properties.Settings.Default.ip_add;
                    user_id = Properties.Settings.Default.user_id;
                    user_pass = Properties.Settings.Default.user_pass;
                    var p = new Ping();
                    var s = IP_Add;
                    var r = p.Send(s);
                    if (r != null && r.Status == IPStatus.Success)
                    {
                        await TestConnection();
                        if (Connected)
                        {
                            await XFilldesignation();
                            GetSettings();
                        }
                        else
                        {
                            var tr = new T_Dashboard();
                            var svr = new FrmServerSettings();
                            tr.Show(this);
                            svr.ShowDialog();
                            tr.Dispose();
                            Focus();
                        }
                    }
                    else
                    {
                        MessageBox.Show(@"Server has not been set-up. Please set-up server first!", @"Server setting", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        var tr = new T_Dashboard();
                        var svr = new FrmServerSettings();
                        tr.Show(this);
                        svr.ShowDialog();
                        tr.Dispose();
                        Focus();
                    }

                }
                else
                {
                    MessageBox.Show(@"Server has not been set-up. Please set-up server first!", @"Server setting", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    var tr = new T_Dashboard();
                    var svr = new FrmServerSettings();
                    tr.Show(this);
                    svr.ShowDialog();
                    tr.Dispose();
                    Focus();
                }
            }
            catch
            {
                MessageBox.Show(@"Server has not been set-up. Please set-up server first!", @"Server setting", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                var tr = new T_Dashboard();
                var svr = new FrmServerSettings();
                tr.Show(this);
                svr.ShowDialog();
                tr.Dispose();
                Focus();
            }
            
        }
        private void GetSettings()
        {
            en_vat = Properties.Settings.Default.en_vat;
            en_debt = Properties.Settings.Default.en_debt;
            direct_print = Properties.Settings.Default.direct_print;
        }

        private async Task XFilldesignation()
        {
            await Conopen();
            Sqlcmd.Parameters.Clear();
            Strsql = "Select * from tbl_Designation";
            Sqlcmd.CommandText = Strsql;
            Sqlcmd.Connection = Cnn;
            Sqladapter.SelectCommand = Sqlcmd;
            Sqlreader = Sqlcmd.ExecuteReader();
            cmbodesig.Items.Clear();
            while (Sqlreader.Read())
            {
                cmbodesig.Items.Add(Sqlreader.GetValue(1));
            }
            Sqlcmd.Dispose();
            Sqlreader.Close();
            Cnn.Close();
            Strsql = "";
        }

        private void txtpassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                bunifuFlatButton1_Click(null, null);
            }
        }

        private void bunifuImageButton9_Click(object sender, EventArgs e)
        {
            XTask = "Login";
            Hide();
            var scan=new FrmScanner();
            scan.ShowDialog();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            var tr = new T_Dashboard();
            var svr = new FrmServerSettings();
            tr.Show(this);
            svr.ShowDialog();
            tr.Dispose();
            Focus();
        }
    }
}
