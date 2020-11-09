using System;
using System.Windows.Forms;

namespace APCPOS.Messageboxes
{
    public partial class Frm_Question : Form
    {
        public Frm_Question()
        {
            InitializeComponent();
        }
        protected override CreateParams CreateParams
        {
            get
            {
                const int CS_DROPSHADOW = 0x20000;
                CreateParams cp = base.CreateParams;
                cp.ClassStyle |= CS_DROPSHADOW;
                return cp;
            }
        }
        protected override bool ProcessCmdKey(ref Message _message, Keys keyData)
        {
            // ReSharper disable once SwitchStatementMissingSomeEnumCasesNoDefault
            switch (keyData)
            {
                case Keys.Escape:
                    Dispose();
                    //
                    break;
            }
            return false;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            question.Visible = false;
            anim.ShowSync(question);
        }

        private void Frm_Question_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            Close();
        }
    }
}
