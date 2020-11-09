using System;
using System.Windows.Forms;

namespace APCPOS.Form_Transparent
{
    public partial class T_Question : Form
    {
        public T_Question()
        {
            InitializeComponent();
        }

        private void T_Question_Load(object sender, EventArgs e)
        {
            Location = Owner.Location;
            Size = Owner.Size;
        }
    }
}
