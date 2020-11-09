using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.DateTime;
using static APCPOS.Includes.SqlConfig;

namespace APCPOS.UserControl
{
    public partial class ListUsers : System.Windows.Forms.UserControl
    {
        public ListUsers()
        {
            InitializeComponent();
        }

        private async void approvedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            approvedToolStripMenuItem.Checked = true;
            blockedToolStripMenuItem.Checked = false;
            temporaryBlockedToolStripMenuItem.Checked = false;
            UseWaitCursor = true;
            Sqlcmd.Parameters.Clear();
            await Conopen();
            Strsql =
                "Update tbl_Users set approval_stat=@approval_stat Where U_ID=@U_ID";
            Sqlcmd.Parameters.AddWithValue("@approval_stat", "1");
            Sqlcmd.Parameters.AddWithValue("@U_ID", lblid.Text);
            Sqlcmd.Connection = Cnn;
            Sqlcmd.CommandText = Strsql;
            Sqlcmd.ExecuteNonQuery();
            Sqlcmd.Dispose();
            Strsql = "";
            Cnn.Close();
            UseWaitCursor = false;
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            metroContextMenu1.Show(bunifuImageButton1, 0, bunifuImageButton1.Height);
        }

        private async void blockedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            approvedToolStripMenuItem.Checked = false;
            blockedToolStripMenuItem.Checked = true;
            temporaryBlockedToolStripMenuItem.Checked = false;
            UseWaitCursor = true;
            Sqlcmd.Parameters.Clear();
            await Conopen();
            Strsql =
                "Update tbl_Users set approval_stat=@approval_stat Where U_ID=@U_ID";
            Sqlcmd.Parameters.AddWithValue("@approval_stat", "2");
            Sqlcmd.Parameters.AddWithValue("@U_ID", lblid.Text);
            Sqlcmd.Connection = Cnn;
            Sqlcmd.CommandText = Strsql;
            Sqlcmd.ExecuteNonQuery();
            Sqlcmd.Dispose();
            Strsql = "";
            Cnn.Close();
            UseWaitCursor = false;
        }

        private async void temporaryBlockedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            approvedToolStripMenuItem.Checked = false;
            blockedToolStripMenuItem.Checked = false;
            temporaryBlockedToolStripMenuItem.Checked = true;
            UseWaitCursor = true;
            Sqlcmd.Parameters.Clear();
            await Conopen();
            Strsql =
                "Update tbl_Users set approval_stat=@approval_stat Where U_ID=@U_ID";
            Sqlcmd.Parameters.AddWithValue("@approval_stat", "3");
            Sqlcmd.Parameters.AddWithValue("@U_ID", lblid.Text);
            Sqlcmd.Connection = Cnn;
            Sqlcmd.CommandText = Strsql;
            Sqlcmd.ExecuteNonQuery();
            Sqlcmd.Dispose();
            Strsql = "";
            Cnn.Close();
            UseWaitCursor = false;
        }
    }
}
