using System;
using System.Drawing;
using APCPOS.Form_Transparent;
using APCPOS.Forms;

namespace APCPOS.UserControl
{
    public partial class ListStock : System.Windows.Forms.UserControl
    {
        public ListStock()
        {
            InitializeComponent();
        }

        private void ListStock_MouseEnter(object sender, EventArgs e)
        {
            BackColor = Color.FromArgb(69, 70, 73);
        }

        private void ListStock_MouseLeave(object sender, EventArgs e)
        {
            BackColor = Color.FromArgb(29, 32, 38);
        }

        private void ListStock_Load(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton9_Click(object sender, EventArgs e)
        {
            var a=new T_Dashboard();
            var b=new FrmAddStock();
            b.label1.Text = lblID.Text;
            a.Show(this);
            b.ShowDialog();
            a.Hide();
            Focus();
        }
    }
}
