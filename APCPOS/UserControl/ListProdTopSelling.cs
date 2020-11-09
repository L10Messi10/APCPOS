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
    public partial class ListProdTopSelling : System.Windows.Forms.UserControl
    {
        public ListProdTopSelling()
        {
            InitializeComponent();
        }

        private void ListProdTopSelling_MouseEnter(object sender, EventArgs e)
        {
            BackColor=Color.FromArgb(29, 32, 38);
        }

        private void ListProdTopSelling_MouseLeave(object sender, EventArgs e)
        {
            BackColor = Color.FromArgb(39, 48, 57);
        }
    }
}
