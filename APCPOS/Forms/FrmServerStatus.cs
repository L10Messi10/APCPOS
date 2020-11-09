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
using APCPOS.Form_Transparent;
using APCPOS.Properties;
using static APCPOS.Includes.SqlConfig;

namespace APCPOS.Forms
{
    public partial class FrmServerStatus : Form
    {
        public FrmServerStatus()
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
        protected override bool ProcessCmdKey(ref Message message, Keys keyData)
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
        private void FrmServerStatus_Deactivate(object sender, EventArgs e)
        {
            Dispose();
        }

        private void FrmServerStatus_Load(object sender, EventArgs e)
        {
            try
            {
                btnipaddress.Text = IP_Add;
                var p = new Ping();
                var s = IP_Add;
                var r = p.Send(s);
                if (r == null || r.Status != IPStatus.Success) return;
                btnnetworkstatus.Text = @"Response delay = " + r.RoundtripTime + @" ms";
                btnstatus.Text = @"Connected";
            }
            catch
            {
                //ignored
            }
        }
    }
}
