using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using APCPOS.Form_Transparent;
using APCPOS.Messageboxes;
using ZXing;
using AForge.Video;
using AForge.Video.DirectShow;
using static APCPOS.Includes.SqlConfig;
using static APCPOS.Forms.FrmLogin;

// ReSharper disable once CheckNamespace
namespace APCPOS.Forms
{
    public partial class FrmScanner : Form
    {
        public static string XTask;
        private bool loggedin;
        public static string ScannedNumber;
        public FrmScanner()
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
                    try
                    {
                        if (captureDevice.IsRunning)
                        {
                            captureDevice.Stop();
                            timer1.Stop();
                            Dispose();
                        }

                        if (loggedin == false)
                        {
                            var a = new FrmLogin();
                            a.Show();
                            Dispose();
                        }
                        Dispose();
                    }
                    catch
                    {
                        timer1.Stop();
                        Dispose();
                    }
                    
                    //
                    break;
            }
            return false;
        }
        private FilterInfoCollection filterInfoCollection;
        private VideoCaptureDevice captureDevice;

        private void FrmScanner_Load(object sender, EventArgs e)
        {
            try
            {
                filterInfoCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);
                foreach (FilterInfo filter in filterInfoCollection)
                {
                    metroComboBox1.Items.Add(filter.Name);
                    metroComboBox1.SelectedIndex = 0;
                }
                captureDevice = new VideoCaptureDevice(filterInfoCollection[metroComboBox1.SelectedIndex].MonikerString);
                captureDevice.NewFrame += CaptureDevice_NewFrame;
                captureDevice.Start();
                timer1.Start();
            }
            catch
            {
                MessageBox.Show(@"No camera detected!", @"Camera", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            

        }

        private void CaptureDevice_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            pictureBox1.Image = (Bitmap)eventArgs.Frame.Clone();
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            try
            {
                if (captureDevice.IsRunning)
                {
                    captureDevice.Stop();
                    timer1.Stop();
                    Dispose();
                }

                if (loggedin == false)
                {
                    var a = new FrmLogin();
                    a.Show();
                    Dispose();
                }
                Dispose();
            }
            catch
            {
                timer1.Stop();
                Dispose();
            }
        }

        private void FrmScanner_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (captureDevice.IsRunning)
                captureDevice.Stop();

        }

        private async void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                if (pictureBox1.Image != null)
                {
                    var barcodeReader = new BarcodeReader();
                    var result = barcodeReader.Decode((Bitmap)pictureBox1.Image);
                    if (result != null)
                    {
                        ScannedNumber = result.ToString();
                        await xFindTask();
                        //MessageBox.Show(result.ToString());

                    }
                }
            }
            catch
            {
                //ignored
            }
            
        }

        private async Task xFindTask()
        {
            switch (XTask)
            {
                case "Login":
                    UseWaitCursor = true;
                    await Conopen();
                    Sqlcmd.Parameters.Clear();
                    Strsql = "Select * from tbl_Users where u_name='" + ScannedNumber+ "' and approval_stat = 1";
                    Sqlcmd.CommandText = Strsql;
                    Sqlcmd.Connection = Cnn;
                    Sqladapter.SelectCommand = Sqlcmd;
                    Sqlreader = Sqlcmd.ExecuteReader();
                    if (Sqlreader.Read())
                    {
                        userpassword = Sqlreader.GetValue(5).ToString();
                        username = Sqlreader.GetValue(4).ToString();
                        await XUpdatelogindate();
                        await XSaveLog();
                        popup.TitleText = @"Access granted";
                        popup.Image = Properties.Resources.check;
                        popup.ContentText = @"Welcome " + username + "!";
                        popup.Popup();
                        Sqlcmd.Dispose();
                        Sqlreader.Close();
                        Cnn.Close();
                        Strsql = "";
                        loggedin = true;
                        UseWaitCursor = false;
                        timer1.Stop();
                        if (captureDevice.IsRunning)
                            captureDevice.Stop();
                        Close();
                        Form1 a = new Form1();
                        a.Show();
                    }
                    else
                    {
                        UseWaitCursor = false;
                        popup.TitleText = @"Access denied";
                        popup.Image = Properties.Resources.error;
                        popup.ContentText = @"Account not found or the account you are trying to access is pending for approval by the admin. Please try again later or contact your admin!";
                        popup.Popup();
                        captureDevice.Start();
                        timer1.Start();
                        Focus();
                    }
                    UseWaitCursor = false;
                    Sqlcmd.Dispose();
                    Sqlreader.Close();
                    Cnn.Close();
                    Strsql = "";
                    break;
            }
        }

    }
}
