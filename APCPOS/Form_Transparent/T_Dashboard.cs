using System;
using System.Windows.Forms;

namespace APCPOS.Form_Transparent
{
    public partial class T_Dashboard : Form
    {
        public T_Dashboard()
        {
            InitializeComponent();
        }

        private void T_Dashboard_Load(object sender, EventArgs e)
        {
            Location = Owner.Location;
            Size = Owner.Size;
        }
    }
}
