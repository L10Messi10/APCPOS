using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APCPOS.UserControl
{
    public partial class ListNotification : System.Windows.Forms.UserControl
    {
        public ListNotification()
        {
            InitializeComponent();
        }

        private void ListNotification_MouseEnter(object sender, EventArgs e)
        {
            BackColor = Color.FromArgb(29, 32, 38);
            lblnotdesc.BackColor = Color.FromArgb(29, 32, 38);
            panel1.BackColor = Color.FromArgb(29, 32, 38);
            lblnottitle.BackColor = Color.FromArgb(29, 32, 38);

        }

        private void ListNotification_MouseLeave(object sender, EventArgs e)
        {
            BackColor = Color.FromArgb(44, 48, 57);
            lblnotdesc.BackColor = Color.FromArgb(44, 48, 57);
            panel1.BackColor = Color.FromArgb(44, 48, 57);
            lblnottitle.BackColor = Color.FromArgb(44, 48, 57);
        }

        private void ListNotification_Load(object sender, EventArgs e)
        {

        }
    }
}
