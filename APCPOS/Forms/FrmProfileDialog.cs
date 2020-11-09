using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APCPOS.Forms
{
    public partial class FrmProfileDialog : Form
    {
        public FrmProfileDialog()
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

        private void FrmProfileDialog_Deactivate(object sender, EventArgs e)
        {
            Dispose();
        }

        private void btnnetworkstatus_Click(object sender, EventArgs e)
        {
           
        }
    }
}
