using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using APCPOS.UserControl;
using static APCPOS.Includes.SqlConfig;

namespace APCPOS.Forms
{
    public partial class FrmNotification : Form
    {
        private string act_time;
        private string not_date;
        public FrmNotification()
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
        protected override bool ProcessCmdKey(ref Message message, Keys keyData)
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
        private void FrmNotification_Leave(object sender, EventArgs e)
        {
            Dispose();
        }

        private void FrmNotification_MouseLeave(object sender, EventArgs e)
        {
            
        }

        private async void FrmNotification_Load(object sender, EventArgs e)
        {
            await XLoadNotification();
        }

        private async Task XLoadNotification()
        {
            await Conopen();
            Sqlcmd.Parameters.Clear();
            Strsql = "Select * from tbl_notification ORDER BY not_num DESC";
            Sqlcmd.CommandText = Strsql;
            Sqlcmd.Connection = Cnn;
            Sqladapter.SelectCommand = Sqlcmd;
            Sqlreader = Sqlcmd.ExecuteReader();
            flowLayoutPanel1.Controls.Clear();
            var dt = new DataTable();
            dt.Load(Sqlreader);
            for (var i = 0; i < dt.Rows.Count; i++)
            {
                act_time = dt.Rows[i]["not_date"].ToString();
                XLog1();
                var a = new ListNotification {label1 = {Text = not_date}, lblnottitle = {Text = dt.Rows[i]["not_title"].ToString()}, lblnotdesc = {Text = dt.Rows[i]["not_desc"].ToString()}};
                switch (a.lblnottitle.Text)
                {
                    case @"Voided Transaction":
                        a.bunifuImageButton2.Image = Properties.Resources.error;
                        break;
                    case @"Report printed":
                        a.bunifuImageButton2.Image = Properties.Resources.print_50px;
                        break;
                }

                flowLayoutPanel1.Controls.Add(a);
            }
            Sqlcmd.Dispose();
            Sqlreader.Close();
            Cnn.Close();
            Strsql = "";
            Focus();
            lblnotcount.Text = flowLayoutPanel1.Controls.Count + @" total";
        }
        private void XLog1()
        {
            const int second = 1;
            const int minute = 60 * second;
            const int hour = 60 * minute;
            const int day = 24 * hour;
            const int month = 30 * day;
            var aDateTime = Convert.ToDateTime(act_time);
            var ts = new TimeSpan(DateTime.Now.Ticks - aDateTime.Ticks);
            var delta = Math.Abs(ts.TotalSeconds);
            if (delta < 1 * minute)
            {
                not_date = ts.Seconds == 1 ? " one second ago" : ts.Seconds + " seconds ago";
                return;
            }
            if (delta < 2 * minute)
            {
                not_date = @"a minute ago";
                return;
            }
            if (delta < 45 * minute)
            {
                not_date = ts.Minutes + @" minutes ago";
                return;
            }
            if (delta < 90 * minute)
            {
                not_date = @"an hr ago";
                return;
            }
            if (delta < 24 * hour)
            {
                not_date = ts.Hours == 1 ? ts.Hours + " hr ago" : ts.Hours + " hrs ago";
                return;
            }
            if (delta < 48 * hour)
            {
                not_date = @"yesterday";
                return;
            }
            if (delta < 30 * day)
            {
                not_date = ts.Days + @" days ago";
                return;
            }
            if (delta < 12 * month)
            {
                var months = Convert.ToInt32(Math.Floor((double)ts.Days / 30));
                not_date = months <= 1 ? "one month ago" : months + " months ago";
            }
            else
            {
                var years = Convert.ToInt32(Math.Floor((double)ts.Days / 365));
                not_date = years <= 1 ? "one year ago" : years + " years ago";
            }
        }

        private void flowLayoutPanel1_MouseLeave(object sender, EventArgs e)
        {
           
        }

        private void flowLayoutPanel1_Leave(object sender, EventArgs e)
        {
            Dispose();
        }

        private void FrmNotification_MouseEnter(object sender, EventArgs e)
        {
           
        }

        private void FrmNotification_Deactivate(object sender, EventArgs e)
        {
            Dispose();
        }

        private async void bunifuImageButton9_Click(object sender, EventArgs e)
        {
            Sqlcmd.Parameters.Clear();
            await Conopen();
            Strsql = "Delete from tbl_notification";
            Sqlcmd.Connection = Cnn;
            Sqlcmd.CommandText = Strsql;
            Sqlcmd.ExecuteNonQuery();
            Sqlcmd.Dispose();
            Strsql = "";
            Cnn.Close();
            await XLoadNotification();

        }
    }
}
