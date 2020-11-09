using System;
using System.Drawing;

namespace APCPOS.UserControl
{
    public partial class ListProdCategory : System.Windows.Forms.UserControl
    {
        public ListProdCategory()
        {
            InitializeComponent();
        }
        
        private void ListProdCategory_Load(object sender, EventArgs e)
        {
            
        }

        private void ListProdCategory_Click(object sender, EventArgs e)
        {
            BackColor = Color.FromArgb(243, 119, 53);
            folderclose.Visible = false;
            folderopen.Visible = true;
        }

        private void ListProdCategory_Leave(object sender, EventArgs e)
        {
            BackColor = Color.FromArgb(29, 32, 38);
            folderclose.Visible = true;
            folderopen.Visible = false;
        }

        private void ListProdCategory_MouseEnter(object sender, EventArgs e)
        {
            //BackColor = Color.FromArgb(69, 70, 73);
        }

        private void ListProdCategory_MouseLeave(object sender, EventArgs e)
        {
            //BackColor = Color.FromArgb(29, 32, 38);
        }
    }
}
