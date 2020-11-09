using System;
using System.Drawing;
using System.Media;
using System.Windows.Forms;

namespace APCPOS.Messageboxes
{
    public partial class Frm_OK : Form
    {
        public string OkDescription;
        public Frm_OK()
        {
            InitializeComponent();
        }

        private void Frm_OK_Load(object sender, EventArgs e)
        {
            SystemSounds.Asterisk.Play();
            switch (OkDescription)
            {
                case "Error":
                    panel1.BackColor = Color.FromArgb(232, 76, 61);
                    panel2.BackColor = Color.FromArgb(232, 76, 61);
                    button1.BackColor = Color.FromArgb(232, 76, 61);
                    titletxt.ForeColor = Color.FromArgb(232, 76, 61);
                    bunifuSeparator1.LineColor= Color.FromArgb(232, 76, 61);
                    break;
                case "Warn":
                    panel1.BackColor = Color.FromArgb(243, 156, 17);
                    panel2.BackColor = Color.FromArgb(243, 156, 17);
                    button1.BackColor = Color.FromArgb(243, 156, 17);
                    titletxt.ForeColor = Color.FromArgb(243, 156, 17);
                    bunifuSeparator1.LineColor = Color.FromArgb(243, 156, 17);
                    break;
                case "Success":
                    panel1.BackColor = Color.FromArgb(24, 187, 156);
                    panel2.BackColor = Color.FromArgb(24, 187, 156);
                    button1.BackColor = Color.FromArgb(24, 187, 156);
                    titletxt.ForeColor = Color.FromArgb(24, 187, 156);
                    bunifuSeparator1.LineColor = Color.FromArgb(24, 187, 156);
                    break;
                case "info":
                    panel1.BackColor = Color.FromArgb(53, 152, 219);
                    panel2.BackColor = Color.FromArgb(53, 152, 219);
                    button1.BackColor = Color.FromArgb(53, 152, 219);
                    titletxt.ForeColor = Color.FromArgb(53, 152, 219);
                    bunifuSeparator1.LineColor = Color.FromArgb(53, 152, 219);
                    break;
            }
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            switch (OkDescription)
            {
                case "Error":
                    error.Visible = false;
                    anim.ShowSync(error);
                    break;
                case "Warn":
                    warn.Visible = false;
                    anim.ShowSync(warn);
                    break;
                case "Success":
                    success.Visible = false;
                    anim.ShowSync(success);
                    break;
                case "info":
                    info.Visible = false;
                    anim.ShowSync(info);
                    break;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }
    }
}
