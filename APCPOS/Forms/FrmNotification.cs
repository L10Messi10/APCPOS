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
    public partial class FrmNotification : Form
    {
        public FrmNotification()
        {
            InitializeComponent();
        }

        private void FrmNotification_Leave(object sender, EventArgs e)
        {
            Dispose();
        }

        private void FrmNotification_MouseLeave(object sender, EventArgs e)
        {
        }

        private void FrmNotification_Load(object sender, EventArgs e)
        {
        }

        private void flowLayoutPanel1_MouseLeave(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
