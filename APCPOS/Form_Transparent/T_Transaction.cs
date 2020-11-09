using System;
using System.Windows.Forms;

namespace APCPOS.Form_Transparent
{
    public partial class T_Transaction : Form
    {
        public T_Transaction()
        {
            InitializeComponent();
        }

        private void T_Transaction_Load(object sender, EventArgs e)
        {
            Location = Owner.Location;
            Size = Owner.Size;
        }
    }
}
