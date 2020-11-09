using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static APCPOS.Includes.SqlConfig;

namespace APCPOS.Forms
{
    public partial class FrmServerSettings : Form
    {
        public FrmServerSettings()
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
        private void FrmServerSettings_Load(object sender, EventArgs e)
        {
            txtipaddress.Text = Properties.Settings.Default.ip_add;
            txtusername.Text = Properties.Settings.Default.user_id;
            txtpassword.Text = Properties.Settings.Default.user_pass;
            try
            {
                if (txtipaddress.Text != "")
                {
                    var p = new Ping();
                    var s = txtipaddress.Text;
                    var r = p.Send(s);
                    if (r != null && r.Status == IPStatus.Success)
                    {
                        metroTabControl1.Enabled = true;
                        txtusername.Focus();
                    }
                }
                else
                {
                    metroTabControl1.Enabled = false;
                    txtusername.Text = "";
                    txtpassword.Text = "";
                    txtipaddress.Focus();
                }
            }
            catch
            {
                metroTabControl1.Enabled = false;
                txtusername.Text = "";
                txtpassword.Text = "";
                txtipaddress.Focus();
            }
        }

        private async void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            IP_Add= txtipaddress.Text;
            user_id = txtusername.Text;
            user_pass = txtpassword.Text;
            await TestConnection();
            if (!Connected) return;
            Properties.Settings.Default.ip_add = txtipaddress.Text;
            Properties.Settings.Default.user_id = txtusername.Text;
            Properties.Settings.Default.user_pass = txtpassword.Text;
            Properties.Settings.Default.Save();
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtipaddress.Text != "")
                {
                    var p = new Ping();
                    var s = txtipaddress.Text;
                    var r = p.Send(s);
                    if (r == null || r.Status != IPStatus.Success) return;
                    MessageBox.Show(@"Ip address found!", @"Ping", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    metroTabControl1.Enabled = true;
                    txtusername.Focus();
                }
                else
                {
                    MessageBox.Show(@"Please enter a valid IP address!", @"Ping", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtipaddress.Focus();
                }
            }
            catch
            {
                MessageBox.Show(@"IP address was not found! Please try again.", @"Ping", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtipaddress.Focus();
            }
        }
    }
}
