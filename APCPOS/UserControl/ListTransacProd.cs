using System;
using System.Drawing;
using APCPOS.Form_Transparent;
using APCPOS.Forms;

namespace APCPOS.UserControl
{
    public partial class ListTransacProd : System.Windows.Forms.UserControl
    {
        public ListTransacProd()
        {
            InitializeComponent();
        }

        private void ListTransacProd_Load(object sender, EventArgs e)
        {
           //bunifuFormFadeTransition1.ShowAsyc(this);
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            var b = new T_Transaction();
            var a = new FrmAddToCart();
            a.lblprodID.Text = label2.Text;
            b.Show(this);
            a.ShowDialog();
            //c.lblinvoice.Text = a.inv_num;
            b.Dispose();
            a.Dispose();
            Focus();
        }

        private void ListTransacProd_MouseEnter(object sender, EventArgs e)
        {
            BackColor = Color.FromArgb(69, 70, 73);
        }

        private void ListTransacProd_MouseLeave(object sender, EventArgs e)
        {
            BackColor = Color.FromArgb(30, 30, 32);
        }
    }
}
