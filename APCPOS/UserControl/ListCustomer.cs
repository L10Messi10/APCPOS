using System;
using System.Drawing;
using System.Windows.Forms;
using APCPOS.Form_Transparent;
using APCPOS.Forms;
using APCPOS.Messageboxes;
using static APCPOS.Forms.FrmPOSTransaction;

namespace APCPOS.UserControl
{
    public partial class ListCustomer : System.Windows.Forms.UserControl
    {
        public ListCustomer()
        {
            InitializeComponent();
        }

        private void ListCustomer_MouseEnter(object sender, EventArgs e)
        {
            BackColor = Color.FromArgb(69, 70, 73);
        }

        private void ListCustomer_MouseLeave(object sender, EventArgs e)
        {
            BackColor = Color.FromArgb(30, 30, 32);
        }

        private void bunifuImageButton9_Click(object sender, EventArgs e)
        {
            var tQuestion = new T_Question();
            var question = new Frm_Question();
            question.titletxt.Text = @"Confirmation";
            question.msgtxt.Text = @"Do you want to load this customer?";
            tQuestion.Show(this);
            question.ShowDialog();
            
            if (question.DialogResult == DialogResult.Yes)
            {
                CustomerRetrieve = true;
                CustomerId = lblid.Text;
                question.Hide();
                tQuestion.Close();
                popup.TitleText = @"Information";
                popup.Image = Properties.Resources.information;
                popup.ContentText = @""+ lblfullname.Text + " has been loaded in this this transaction";
                popup.Popup();
                Focus();
            }
            question.Dispose();
            tQuestion.Close();
            Focus();
        }

        private void ListCustomer_Load(object sender, EventArgs e)
        {

        }
    }
}
