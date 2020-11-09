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
