﻿using System;
using System.Windows.Forms;

namespace APCPOS.Form_Transparent
{
    public partial class T_Message : Form
    {
        public T_Message()
        {
            InitializeComponent();
        }

        private void T_Message_Load(object sender, EventArgs e)
        {
            Location = Owner.Location;
            Size = Owner.Size;
        }
    }
}
