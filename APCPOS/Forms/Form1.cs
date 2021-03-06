﻿using System;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using APCPOS.Form_Transparent;
using APCPOS.Forms;
using APCPOS.Messageboxes;
using APCPOS.Properties;
using APCPOS.UserControl;
using Bunifu.DataViz.WinForms;
using Bunifu.UI.WinForms;
using System.Net.NetworkInformation;
using System.Reflection;
using static APCPOS.Includes.SqlConfig;
using static System.DateTime;

namespace APCPOS
{
    public partial class Form1 : Form
    {
        private Int32 _criticalprod;
        private bool _proppanelopen;
        public static string debtSelected, xfullname;
        private string log1;
        private string log2;
        private string log3;
        private string log4;
        private string log5;
        int sec,mins, mins1 = 0;
        public static bool XRetrieveDebt;
        bool recentcalled = false;

        public Form1()
        {
            InitializeComponent();

            #region DoubleBuffered
            typeof(Panel).InvokeMember("DoubleBuffered", BindingFlags.SetProperty
                                                         | BindingFlags.Instance | BindingFlags.NonPublic, null,
                panel1, new object[] { true });

            typeof(Panel).InvokeMember("DoubleBuffered", BindingFlags.SetProperty
                                                         | BindingFlags.Instance | BindingFlags.NonPublic, null,
                panel18, new object[] { true });
            typeof(Panel).InvokeMember("DoubleBuffered", BindingFlags.SetProperty
                                                         | BindingFlags.Instance | BindingFlags.NonPublic, null,
                paneldashboard, new object[] { true });
            typeof(Panel).InvokeMember("DoubleBuffered", BindingFlags.SetProperty
                                                         | BindingFlags.Instance | BindingFlags.NonPublic, null,
                panel14, new object[] { true });
            typeof(Panel).InvokeMember("DoubleBuffered", BindingFlags.SetProperty
                                                         | BindingFlags.Instance | BindingFlags.NonPublic, null,
                panel20, new object[] { true });
            typeof(Panel).InvokeMember("DoubleBuffered", BindingFlags.SetProperty
                                                         | BindingFlags.Instance | BindingFlags.NonPublic, null,
                panel32, new object[] { true });
            typeof(Panel).InvokeMember("DoubleBuffered", BindingFlags.SetProperty
                                                         | BindingFlags.Instance | BindingFlags.NonPublic, null,
                panel3, new object[] { true });
            typeof(Panel).InvokeMember("DoubleBuffered", BindingFlags.SetProperty
                                                         | BindingFlags.Instance | BindingFlags.NonPublic, null,
                panel34, new object[] { true });
            typeof(Panel).InvokeMember("DoubleBuffered", BindingFlags.SetProperty
                                                         | BindingFlags.Instance | BindingFlags.NonPublic, null,
                panel21, new object[] { true });
            typeof(Panel).InvokeMember("DoubleBuffered", BindingFlags.SetProperty
                                                         | BindingFlags.Instance | BindingFlags.NonPublic, null,
                panel56, new object[] { true });
            typeof(Panel).InvokeMember("DoubleBuffered", BindingFlags.SetProperty
                                                         | BindingFlags.Instance | BindingFlags.NonPublic, null,
                panel15, new object[] { true });
            typeof(Panel).InvokeMember("DoubleBuffered", BindingFlags.SetProperty
                                                         | BindingFlags.Instance | BindingFlags.NonPublic, null,
                panel57, new object[] { true });
            typeof(Panel).InvokeMember("DoubleBuffered", BindingFlags.SetProperty
                                                         | BindingFlags.Instance | BindingFlags.NonPublic, null,
                panel16, new object[] { true });
            typeof(Panel).InvokeMember("DoubleBuffered", BindingFlags.SetProperty
                                                         | BindingFlags.Instance | BindingFlags.NonPublic, null,
                panel58, new object[] { true });
            typeof(Panel).InvokeMember("DoubleBuffered", BindingFlags.SetProperty
                                                         | BindingFlags.Instance | BindingFlags.NonPublic, null,
                panel17, new object[] { true });
            typeof(Panel).InvokeMember("DoubleBuffered", BindingFlags.SetProperty
                                                         | BindingFlags.Instance | BindingFlags.NonPublic, null,
                panel59, new object[] { true });
            typeof(Panel).InvokeMember("DoubleBuffered", BindingFlags.SetProperty
                                                         | BindingFlags.Instance | BindingFlags.NonPublic, null,
                panel24, new object[] { true });
            typeof(Panel).InvokeMember("DoubleBuffered", BindingFlags.SetProperty
                                                         | BindingFlags.Instance | BindingFlags.NonPublic, null,
                panel60, new object[] { true });
            typeof(Panel).InvokeMember("DoubleBuffered", BindingFlags.SetProperty
                                                         | BindingFlags.Instance | BindingFlags.NonPublic, null,
                panel23, new object[] { true });
            typeof(Panel).InvokeMember("DoubleBuffered", BindingFlags.SetProperty
                                                         | BindingFlags.Instance | BindingFlags.NonPublic, null,
                panel45, new object[] { true });
            typeof(Panel).InvokeMember("DoubleBuffered", BindingFlags.SetProperty
                                                         | BindingFlags.Instance | BindingFlags.NonPublic, null,
                panel29, new object[] { true });
            typeof(Panel).InvokeMember("DoubleBuffered", BindingFlags.SetProperty
                                                         | BindingFlags.Instance | BindingFlags.NonPublic, null,
                panel37, new object[] { true });
            typeof(Panel).InvokeMember("DoubleBuffered", BindingFlags.SetProperty
                                                         | BindingFlags.Instance | BindingFlags.NonPublic, null,
                panel27, new object[] { true });
            typeof(Panel).InvokeMember("DoubleBuffered", BindingFlags.SetProperty
                                                         | BindingFlags.Instance | BindingFlags.NonPublic, null,
                bunifuDataViz2, new object[] { true });
            typeof(Panel).InvokeMember("DoubleBuffered", BindingFlags.SetProperty
                                                         | BindingFlags.Instance | BindingFlags.NonPublic, null,
                bunifuDataViz1, new object[] { true });
            typeof(Panel).InvokeMember("DoubleBuffered", BindingFlags.SetProperty
                                                         | BindingFlags.Instance | BindingFlags.NonPublic, null,
                panel36, new object[] { true });
            typeof(Panel).InvokeMember("DoubleBuffered", BindingFlags.SetProperty
                                                         | BindingFlags.Instance | BindingFlags.NonPublic, null,
                panel31, new object[] { true });
            typeof(Panel).InvokeMember("DoubleBuffered", BindingFlags.SetProperty
                                                         | BindingFlags.Instance | BindingFlags.NonPublic, null,
                panel22, new object[] { true });
            typeof(Panel).InvokeMember("DoubleBuffered", BindingFlags.SetProperty
                                                         | BindingFlags.Instance | BindingFlags.NonPublic, null,
                flowpaneltopselling, new object[] { true });
            typeof(Panel).InvokeMember("DoubleBuffered", BindingFlags.SetProperty
                                                         | BindingFlags.Instance | BindingFlags.NonPublic, null,
                panel33, new object[] { true });
            typeof(Panel).InvokeMember("DoubleBuffered", BindingFlags.SetProperty
                                                         | BindingFlags.Instance | BindingFlags.NonPublic, null,
                panel30, new object[] { true });
            typeof(Panel).InvokeMember("DoubleBuffered", BindingFlags.SetProperty
                                                         | BindingFlags.Instance | BindingFlags.NonPublic, null,
                flowpanelcriticalproducts, new object[] { true });
            typeof(Panel).InvokeMember("DoubleBuffered", BindingFlags.SetProperty
                                                         | BindingFlags.Instance | BindingFlags.NonPublic, null,
                flowpanelnearexpire, new object[] { true });
            typeof(Panel).InvokeMember("DoubleBuffered", BindingFlags.SetProperty
                                                         | BindingFlags.Instance | BindingFlags.NonPublic, null,
                panel35, new object[] { true });
            typeof(Panel).InvokeMember("DoubleBuffered", BindingFlags.SetProperty
                                                         | BindingFlags.Instance | BindingFlags.NonPublic, null,
                panel31, new object[] { true });
            typeof(Panel).InvokeMember("DoubleBuffered", BindingFlags.SetProperty
                                                         | BindingFlags.Instance | BindingFlags.NonPublic, null,
                panel54, new object[] { true });
            typeof(Panel).InvokeMember("DoubleBuffered", BindingFlags.SetProperty
                                                         | BindingFlags.Instance | BindingFlags.NonPublic, null,
                panel55, new object[] { true });
            typeof(Panel).InvokeMember("DoubleBuffered", BindingFlags.SetProperty
                                                         | BindingFlags.Instance | BindingFlags.NonPublic, null,
                panel23, new object[] { true });
            typeof(Panel).InvokeMember("DoubleBuffered", BindingFlags.SetProperty
                                                         | BindingFlags.Instance | BindingFlags.NonPublic, null,
                bunifuSeparator14, new object[] { true });
            typeof(Panel).InvokeMember("DoubleBuffered", BindingFlags.SetProperty
                                                         | BindingFlags.Instance | BindingFlags.NonPublic, null,
                panel9, new object[] { true });
            typeof(Panel).InvokeMember("DoubleBuffered", BindingFlags.SetProperty
                                                         | BindingFlags.Instance | BindingFlags.NonPublic, null,
                panel65, new object[] { true });

            #endregion
        }

        #region Debts


        private async Task XShowDebtInfo()
        {
            await Conopen();
            Sqlcmd.Parameters.Clear();
            Strsql = "Select * from v_debt where cus_id='" + debtSelected + "'";
            Sqlcmd.CommandText = Strsql;
            Sqlcmd.Connection = Cnn;
            Sqladapter.SelectCommand = Sqlcmd;
            Sqlreader = Sqlcmd.ExecuteReader();
            lbldebtfullname.Text = xfullname;
            bunifuDataGridView2.Rows.Clear();
            var picted=false;
            float tot = 0;
            while (Sqlreader.Read())
            {
                var a = Sqlreader.GetValue(7).ToString();
                var dte = (DateTime)(Sqlreader.GetValue(8));
                var b = dte.ToString("D");
                var c = Sqlreader.GetValue(9).ToString();
                var d = Sqlreader.GetValue(10).ToString();
                var subtot = Convert.ToSingle((Sqlreader.GetValue(11)));
                tot += subtot;
                var e = subtot.ToString("N");
                var f = Sqlreader.GetValue(12).ToString();
                bunifuDataGridView2.Rows.Add(a, b, c, d, e, f);
                if (picted) continue;
                var img = (byte[])(Sqlreader.GetValue(16));
                bunifuPictureBox1.Image = Image.FromStream(new MemoryStream(img));
                picted = true;

            }
            label38.Text = tot.ToString(CultureInfo.InvariantCulture);
            //}
            Sqlcmd.Dispose();
            Sqlreader.Close();
            Cnn.Close();
            Strsql = "";
        }

        private async Task XLoadDebts()
        {

            await Conopen();
            Sqlcmd.Parameters.Clear();
            Strsql = "Select Distinct fullname,cus_address,cus_mobile,cus_email,cus_id,cus_img from v_debt";
            Sqlcmd.CommandText = Strsql;
            Sqlcmd.Connection = Cnn;
            Sqladapter.SelectCommand = Sqlcmd;
            Sqlreader = Sqlcmd.ExecuteReader();
            bunifuDataGridView1.Rows.Clear();
            while (Sqlreader.Read())
            {
                var img = (byte[])(Sqlreader.GetValue(5));
                var a = Sqlreader.GetValue(0).ToString();
                var b = Sqlreader.GetValue(1).ToString();
                var c = Sqlreader.GetValue(2).ToString();
                var d = Sqlreader.GetValue(3).ToString();
                var e = Sqlreader.GetValue(4).ToString();
                bunifuDataGridView1.Rows.Add(img, a, b, c, d, e);
            }
            Sqlcmd.Dispose();
            Sqlreader.Close();
            Cnn.Close();
            Strsql = "";
            bunifuTextBox4.Text = "";
            label38.Text = @"0";
            lbldebtfullname.Text = "";
            bunifuPictureBox1.Image = null;
            debtSelected = null;
        }

        #endregion
        #region Dashboard

        private async Task XLoadNearExpiration()
        {
            await Conopen();
            Sqlcmd.Parameters.Clear();
            Strsql = "Select * from V_TobeExp_Prods ORDER BY prod_exp_date DESC";
            Sqlcmd.CommandText = Strsql;
            Sqlcmd.Connection = Cnn;
            Sqladapter.SelectCommand = Sqlcmd;
            Sqlreader = Sqlcmd.ExecuteReader();
            flowpanelnearexpire.Rows.Clear();
            while (Sqlreader.Read())
            {
                var a = Sqlreader.GetValue(2).ToString();
                flowpanelnearexpire.Rows.Add(a);
            }
            Sqlcmd.Dispose();
            Sqlreader.Close();
            Cnn.Close();
            Strsql = "";

            //((date1.Year - date2.Year) * 12) + date1.Month - date2.Month
            //var month = (endDate - StartDate).TotalMonths;
        }
        private async Task XLoadRecentActivities()
        {
            await Conopen();
            Sqlcmd.Parameters.Clear();
            Strsql = "Select TOP 5 * from tbl_logs ORDER BY log_num DESC";
            Sqlcmd.CommandText = Strsql;
            Sqlcmd.Connection = Cnn;
            Sqladapter.SelectCommand = Sqlcmd;
            Sqlreader = Sqlcmd.ExecuteReader();
            var ctr = 1;
            while (Sqlreader.Read())
            {
                switch (ctr)
                {
                    case 1:
                        lbllog1.Text = Sqlreader.GetValue(2).ToString();
                        log1 = Sqlreader.GetValue(4).ToString();
                        ctr++;
                        break;
                    case 2:
                        lbllog2.Text = Sqlreader.GetValue(2).ToString();
                        log2 = Sqlreader.GetValue(4).ToString();
                        ctr++;
                        break;
                    case 3:
                        lbllog3.Text = Sqlreader.GetValue(2).ToString();
                        log3 = Sqlreader.GetValue(4).ToString();
                        ctr++;
                        break;
                    case 4:
                        lbllog4.Text = Sqlreader.GetValue(2).ToString();
                        log4 = Sqlreader.GetValue(4).ToString();
                        ctr++;
                        break;
                    case 5:
                        lbllog5.Text = Sqlreader.GetValue(2).ToString();
                        log5 = Sqlreader.GetValue(4).ToString();
                        ctr++;
                        break;
                }
            }

            Sqlcmd.Dispose();
            Sqlreader.Close();
            Cnn.Close();
            Strsql = "";
        }

        private async Task XCountCustomer()
        {
            await Conopen();
            Sqlcmd.Parameters.Clear();
            Strsql = "Select Count (cus_ID) as cuscount from tbl_customer";
            Sqlcmd.CommandText = Strsql;
            Sqlcmd.Connection = Cnn;
            Sqladapter.SelectCommand = Sqlcmd;
            Sqlreader = Sqlcmd.ExecuteReader();
            if (!Sqlreader.Read())
            {
                lblcustomercount.Text = @"0";
            }
            else
            {
                var a = Convert.ToInt32(Sqlreader.GetValue(0));
                lblcustomercount.Text = a.ToString("##,###");
            }

            Sqlcmd.Dispose();
            Sqlreader.Close();
            Cnn.Close();
            Strsql = "";
        }

        private async Task XCountVoided()
        {
            await Conopen();
            Sqlcmd.Parameters.Clear();
            Strsql = "Select Count (inv_num) as voidcount from V_TransCount where tran_stat = 'Voided' and Inv_date = '" + DateTime.Today +"'";
            Sqlcmd.CommandText = Strsql;
            Sqlcmd.Connection = Cnn;
            Sqladapter.SelectCommand = Sqlcmd;
            Sqlreader = Sqlcmd.ExecuteReader();
            if (!Sqlreader.Read())
            {
                label13.Text = @"0";
            }
            else
            {
                var a = Convert.ToInt32(Sqlreader.GetValue(0));
                label13.Text = a.ToString("##,###");
            }

            Sqlcmd.Dispose();
            Sqlreader.Close();
            Cnn.Close();
            Strsql = "";
        }

        private async Task XLoadCollectables()
        {
            await Conopen();
            Sqlcmd.Parameters.Clear();
            Strsql = "Select * from V_Tot_Debt";
            Sqlcmd.CommandText = Strsql;
            Sqlcmd.Connection = Cnn;
            Sqladapter.SelectCommand = Sqlcmd;
            Sqlreader = Sqlcmd.ExecuteReader();
            if (Sqlreader.Read())
            {
                var a = Convert.ToInt32(Sqlreader.GetValue(1));
                if (a >= 100000000)
                {
                    lblcollectables.Text = (a / 1000000D).ToString("0.#M");
                    label20.Text = (a / 1000000D).ToString("0.#M");
                }
                if (a >= 1000000)
                {
                    lblcollectables.Text = (a / 1000000D).ToString("0.##M");
                    label20.Text = (a / 1000000D).ToString("0.##M");
                }
                if (a >= 100000)
                {
                    lblcollectables.Text = (a / 1000D).ToString("0.#K");
                    label20.Text = (a / 1000D).ToString("0.#K");
                }
                if (a >= 10000)
                {
                    lblcollectables.Text = (a / 1000D).ToString("0.##K");
                    label20.Text = (a / 1000D).ToString("0.##K");
                }
            }

            Sqlcmd.Dispose();
            Sqlreader.Close();
            Cnn.Close();
            Strsql = "";
            
        }

        private async Task XloadUserTransOvrvw()
        {
            var canvas = new Canvas();
            var datapoint = new DataPoint(BunifuDataViz._type.Bunifu_bar);
            bunifuDataViz2.colorSet.Add(Color.FromArgb(218, 243, 53));
            bunifuDataViz2.ForeColor = Color.Snow;
            await Conopen();
            Sqlcmd.Parameters.Clear();
            Strsql = $"Select Prod_name, sum(qty) as total_sales from V_Receipt where Inv_date ='{DateTime.Today:yyyy-MM-dd}' and tran_stat = 'Cash' GROUP BY Prod_Name order by total_sales";
            Sqlcmd.CommandText = Strsql;
            Sqlcmd.Connection = Cnn;
            Sqladapter.SelectCommand = Sqlcmd;
            Sqlreader = Sqlcmd.ExecuteReader();
            while (Sqlreader.Read())
            {
                datapoint.addLabely(Sqlreader.GetValue(0).ToString(), Sqlreader.GetValue(1).ToString());
            }
            canvas.addData(datapoint);
            bunifuDataViz2.Render(canvas);
            Sqlcmd.Dispose();
            Sqlreader.Close();
            Cnn.Close();
            Strsql = "";
        }

        private async Task XLoadRevenue()
        {
            var c = DateTime.Today.ToString("Y");
            await Conopen();
            Sqlcmd.Parameters.Clear();
            Strsql = "Select * from V_Revenue where num_date like '%" + c +"%'";
            Sqlcmd.CommandText = Strsql;
            Sqlcmd.Connection = Cnn;
            Sqladapter.SelectCommand = Sqlcmd;
            Sqlreader = Sqlcmd.ExecuteReader();
            if (Sqlreader.Read())
            {
                var dd = Sqlreader.GetValue(1).ToString();
                var a = Convert.ToInt32(Sqlreader.GetValue(1));
                if (a >= 100000000)
                {
                    lblrevenue.Text = (a / 1000000D).ToString("0.#M");
                }
                if (a >= 1000000)
                {
                    lblrevenue.Text = (a / 1000000D).ToString("0.##M");
                }
                if (a >= 100000)
                {
                    lblrevenue.Text = (a / 1000D).ToString("0.#K");
                }
                if (a >= 10000)
                {
                    lblrevenue.Text = (a / 1000D).ToString("0.##K");
                }
                if (a >= 1000)
                {
                    lblrevenue.Text = (a / 1000D).ToString("0.#K");
                }
                if (a < 1000)
                {
                    lblrevenue.Text = (a).ToString("N");
                }

            }
            else
            {
                lblrevenue.Text = @"0";
            }
            Sqlcmd.Dispose();
            Sqlreader.Close();
            Cnn.Close();
            Strsql = "";
        }
        private async Task XLoadNewOrders()
        {
            await Conopen();
            Sqlcmd.Parameters.Clear();
            Strsql = $"Select count(*) as totneworder from tbl_Transaction where inv_date ='{DateTime.Today}'";
            Sqlcmd.CommandText = Strsql;
            Sqlcmd.Connection = Cnn;
            Sqladapter.SelectCommand = Sqlcmd;
            Sqlreader = Sqlcmd.ExecuteReader();
            if (!Sqlreader.Read())
            {
                lblneworders.Text = @"0";
            }
            else
            {
                var a = Convert.ToInt32(Sqlreader.GetValue(0));
                lblneworders.Text = a.ToString("##,###");
            }

            Sqlcmd.Dispose();
            Sqlreader.Close();
            Cnn.Close();
            Strsql = "";
        }

        private async Task XLoadWeeklylySales()
        {
            var dtealt = (DateTime.Now.Subtract(TimeSpan.FromDays(7)));
            var canvas = new Canvas();
            var datapoint = new DataPoint(BunifuDataViz._type.Bunifu_spline);
            bunifuDataViz1.Theme = BunifuDataViz._theme.theme2;
            bunifuDataViz1.colorSet.Add(Color.FromArgb(218, 243, 53));
            bunifuDataViz1.ForeColor = Color.Snow;
            await Conopen();
            Sqlcmd.Parameters.Clear();
            Strsql = $"Select * from V_Chart_Sales_Custom where Inv_date <= '{DateTime.Today:yyyy-MM-dd}' AND Inv_date >= '{dtealt:yyyy-MM-dd}' order by Inv_date desc";
            Sqlcmd.CommandText = Strsql;
            Sqlcmd.Connection = Cnn;
            Sqladapter.SelectCommand = Sqlcmd;
            Sqlreader = Sqlcmd.ExecuteReader();
            while (Sqlreader.Read())
            {
                var x = (DateTime)Sqlreader.GetValue(0);
                datapoint.addLabely(x.ToString("MMM-d"), y: Sqlreader.GetValue(1).ToString());
            }
            canvas.addData(datapoint);
            bunifuDataViz1.Render(canvas);
            Sqlcmd.Dispose();
            Sqlreader.Close();
            Cnn.Close();
            Strsql = "";
            label34.Text = @"Your weekly sales data";

        }

        private async Task XLoadTopSellingProducts()
        {
            await Conopen();
            Sqlcmd.Parameters.Clear();
            Strsql = "Select top 20 * from V_TopSelling_Prod ORDER BY Total_Sales DESC";
            Sqlcmd.CommandText = Strsql;
            Sqlcmd.Connection = Cnn;
            Sqladapter.SelectCommand = Sqlcmd;
            Sqlreader = Sqlcmd.ExecuteReader();
            flowpaneltopselling.Rows.Clear();
            while (Sqlreader.Read())
            {
                var a = Sqlreader.GetValue(0).ToString();
                var b = Convert.ToDouble(Sqlreader.GetValue(1));
                var c = b.ToString("N");
                flowpaneltopselling.Rows.Add(a, c);
            }
            Sqlcmd.Dispose();
            Sqlreader.Close();
            Cnn.Close();
            Strsql = "";
            //w.Hide();
        }

        private async Task XLoadCriticalProducts()
        {
            await Conopen();
            Sqlcmd.Parameters.Clear();
            Strsql = "Select * from V_Products_Critical ORDER BY Prod_Stock";
            Sqlcmd.CommandText = Strsql;
            Sqlcmd.Connection = Cnn;
            Sqladapter.SelectCommand = Sqlcmd;
            Sqlreader = Sqlcmd.ExecuteReader();
            flowpanelcriticalproducts.Controls.Clear();
            while (Sqlreader.Read())
            {
                var a = Sqlreader.GetValue(2).ToString();
                var b = Sqlreader.GetValue(3).ToString();
                var c = "R. Stocks " + b;
                    flowpanelcriticalproducts.Rows.Add(a, c);
            }
            //bunifuHScrollBar1.BindTo(flowpanelcriticalproducts);
            Sqlcmd.Dispose();
            Sqlreader.Close();
            Cnn.Close();
            Strsql = "";
            //w.Hide();
            UseWaitCursor = false;
        }
        //Dim canvas = New Canvas()
        //Dim datapoint = New Bunifu.DataViz.WinForms.DataPoint(BunifuDataViz._type.Bunifu_column)

        //    Main()
        //strsql = "Select TOP 12 * from V_Chart_Report_Income order by num_Month_Year desc"
        //sqlcmd.CommandText = strsql
        //    sqlcmd.Connection = Con
        //    sqladapter.SelectCommand = sqlcmd
        //    sqlreader = sqlcmd.ExecuteReader
        //While sqlreader.Read
        //datapoint.addLabely(sqlreader("Month_Year"), sqlreader("Total_Sales").ToString)
        //'Chart1.Series("Income").Points.AddXY(sqlreader("Month_Year"), sqlreader("Total_Sales"))
        //End While
        //canvas.addData(datapoint)
        //BunifuDataViz1.colorSet.Add(Color.FromArgb(191, 1, 255))
        //BunifuDataViz1.Render(canvas)
        //    sqlreader.Close()
        //sqlcmd.Dispose()
        //    Con.Close()

        #endregion
        #region Data Loaders

        private async Task XLoadUserList()
        {
            await Conopen();
            Sqlcmd.Parameters.Clear();
            Strsql = "Select TOP "+ Settings.Default.data_display + " * from tbl_Users";
            Sqlcmd.CommandText = Strsql;
            Sqlcmd.Connection = Cnn;
            Sqladapter.SelectCommand = Sqlcmd;
            Sqlreader = Sqlcmd.ExecuteReader();
            flowLayoutPaneluser.Controls.Clear();
            DataTable dt = new DataTable();
            dt.Load(Sqlreader);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ListUsers a = new ListUsers();
                byte[] img = (byte[])(dt.Rows[i]["u_img"]);
                if (img.Length != 0)
                {
                    MemoryStream ms = new MemoryStream(img);
                    a.userpic.Image = Image.FromStream(ms);
                }
                a.lblid.Text = dt.Rows[i]["U_ID"].ToString();
                a.lblfullname.Text = dt.Rows[i]["u_Fname"].ToString();
                a.lbladd.Text = dt.Rows[i]["u_address"].ToString();
                a.lblmobile.Text = dt.Rows[i]["u_c_num"].ToString();
                a.lblemail.Text = dt.Rows[i]["u_email"].ToString();
                var stat = dt.Rows[i]["approval_stat"].ToString();
                switch (stat)
                {
                    case "1":
                        a.lblstat.Text = @"Approved";
                        a.lblstat.ForeColor = Color.LawnGreen;
                        a.approvedToolStripMenuItem.Checked = true;
                        break;
                    case "0":
                        a.lblstat.Text = @"Pending";
                        a.lblstat.ForeColor = Color.IndianRed;
                        break;
                    case "2":
                        a.lblstat.Text = @"Blocked";
                        a.lblstat.ForeColor = Color.Gray;
                        a.blockedToolStripMenuItem.Checked = true;
                        break;
                    case "3":
                        a.lblstat.Text = @"Temporarily Blocked";
                        a.lblstat.ForeColor = Color.Coral;
                        a.temporaryBlockedToolStripMenuItem.Checked = true;
                        break;
                }
                flowLayoutPaneluser.Controls.Add(a);
            }
            Sqlcmd.Dispose();
            Sqlreader.Close();
            Cnn.Close();
            Strsql = "";
            //w.Hide();
            UseWaitCursor = false;
        }

        private async Task XLoadUser()
        {
            await Conopen();
            Sqlcmd.Parameters.Clear();
            Strsql = "Select * from tbl_Users where u_name='" + username + "'";
            Sqlcmd.CommandText = Strsql;
            Sqlcmd.Connection = Cnn;
            Sqladapter.SelectCommand = Sqlcmd;
            Sqlreader = Sqlcmd.ExecuteReader();
            if (Sqlreader.Read())
            {
                lblfullname.Text = Sqlreader.GetValue(1).ToString();
                userfullname = lblfullname.Text;
                lbldesignation.Text = Sqlreader.GetValue(8).ToString();
                var img = (byte[])(Sqlreader.GetValue(9));
                if (img.Length != 0)
                {
                    userpic.Image = Image.FromStream(new MemoryStream(img));
                }
            }
            Sqlcmd.Dispose();
            Sqlreader.Close();
            Cnn.Close();
            Strsql = "";
        }
        private async Task FillStock()
        {
            //var w = new FrmWait();
            //w.Show(this);
            await Conopen();
            Sqlcmd.Parameters.Clear();
            Strsql = "Select * from tbl_Settings";
            Sqlcmd.CommandText = Strsql;
            Sqlcmd.Connection = Cnn;
            Sqladapter.SelectCommand = Sqlcmd;
            Sqlreader = Sqlcmd.ExecuteReader();
            if (Sqlreader.Read())
            {
                _criticalprod = Convert.ToInt32(Sqlreader.GetValue(1));
            }
            Sqlcmd.Dispose();
            Sqlreader.Close();
            Cnn.Close();
            Strsql = "";
            //*************************************************************
            flowLayoutPanel2.FlowDirection = Settings.Default.hor_flow ? FlowDirection.TopDown : FlowDirection.LeftToRight;
            UseWaitCursor = true;
            bunifuTextBox1.Text = "";
            await Conopen();
            Sqlcmd.Parameters.Clear();
            Strsql = "Select TOP "+ Settings.Default.data_display + " * from V_Products";
            Sqlcmd.CommandText = Strsql;
            Sqlcmd.Connection = Cnn;
            Sqladapter.SelectCommand = Sqlcmd;
            Sqlreader = Sqlcmd.ExecuteReader();
            flowLayoutPanel2.Controls.Clear();
            DataTable dt = new DataTable();
            dt.Load(Sqlreader);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ListStock a = new ListStock();
                byte[] img = (byte[])(dt.Rows[i]["Prod_Img"]);
                if (img.Length != 0)
                {
                    MemoryStream ms = new MemoryStream(img);
                    a.bunifuPictureBox1.Image = Image.FromStream(ms);
                }
                a.lblID.Text = dt.Rows[i]["Prod_Number"].ToString();
                a.lblprodname.Text = dt.Rows[i]["Prod_Name"].ToString();
                var fs = dt.Rows[i]["prod_fs"].ToString();
                if (fs != "1")
                {
                    a.lblprodname.ForeColor = Color.FromArgb(255, 227, 0);
                }
                a.lblstock.Text = dt.Rows[i]["tot_stock"].ToString();
                var currStock = Convert.ToInt32(dt.Rows[i]["Prod_Stock"].ToString());
                if (currStock <= _criticalprod)
                {
                    a.label6.Text = @"Critical";
                    a.label6.BackColor = Color.FromArgb(232, 76, 61);
                }
                else
                {
                    a.label6.Text = @"Not Critical";
                    a.label6.BackColor = Color.FromArgb(16, 124, 16);
                }
                flowLayoutPanel2.Controls.Add(a);
            }
            Sqlcmd.Dispose();
            Sqlreader.Close();
            Cnn.Close();
            Strsql = "";
            //w.Hide();
            UseWaitCursor = false;
        }

        private async Task FillProducts()
        {
            //backgroundWorker1.RunWorkerAsync();
            flowLayoutPanel1.FlowDirection = Settings.Default.hor_flow ? FlowDirection.TopDown : FlowDirection.LeftToRight;
            UseWaitCursor = true;
            bunifuTextBox1.Text = "";
            await Conopen();
            Sqlcmd.Parameters.Clear();
            Strsql = "Select TOP " + Settings.Default.data_display + " * from tbl_Products";
            Sqlcmd.CommandText = Strsql;
            Sqlcmd.Connection = Cnn;
            Sqladapter.SelectCommand = Sqlcmd;
            Sqlreader = Sqlcmd.ExecuteReader();
            flowLayoutPanel1.Controls.Clear();
            DataTable dt = new DataTable();
            dt.Load(Sqlreader);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ListProducts a = new ListProducts();
                byte[] img = (byte[])(dt.Rows[i]["Prod_Img"]);
                if (img.Length != 0)
                {
                    MemoryStream ms = new MemoryStream(img);
                    a.bunifuPictureBox1.Image = Image.FromStream(ms);
                }
                a.lblID.Text = dt.Rows[i]["Prod_Number"].ToString();
                a.lblprodname.Text = dt.Rows[i]["Prod_Name"].ToString();
                var fs = dt.Rows[i]["prod_fs"].ToString();
                if (fs != "1")
                {
                    a.lblprodname.ForeColor = Color.FromArgb(255, 227, 0);
                }
                a.lblstock.Text = dt.Rows[i]["Prod_Stock"].ToString();
                a.lblbrcode.Text = dt.Rows[i]["Prod_Barcode"].ToString();
                a.lblunit.Text = dt.Rows[i]["Unit_Desc"].ToString();
                var price = Convert.ToDouble(dt.Rows[i]["Prod_Price"]);
                a.lblprice.Text = price.ToString("N");
                flowLayoutPanel1.Controls.Add(a);
            }
            Sqlcmd.Dispose();
            Sqlreader.Close();
            Cnn.Close();
            Strsql = "";
            //*************************************************************
            await Conopen();
            Sqlcmd.Parameters.Clear();
            Strsql = "Select * from V_ProdCategoryCount";
            Sqlcmd.CommandText = Strsql;
            Sqlcmd.Connection = Cnn;
            Sqladapter.SelectCommand = Sqlcmd;
            Sqlreader = Sqlcmd.ExecuteReader();
            flowLayoutPanelprodcategory.Controls.Clear();
            DataTable dtble = new DataTable();
            dtble.Load(Sqlreader);
            for (int i = 0; i < dtble.Rows.Count; i++)
            {
                ListProdCategory a = new ListProdCategory();
                //byte[] img = (byte[])(dt.Rows[i]["Prod_Img"]);
                //if (img.Length != 0)
                //{
                //    MemoryStream ms = new MemoryStream(img);
                //    a.bunifuPictureBox1.Image = Image.FromStream(ms);
                //}
                a.label1.Text = dtble.Rows[i]["total_cat"].ToString();
                a.lbltitle.Text = dtble.Rows[i]["cat_desc"].ToString();
                flowLayoutPanelprodcategory.Controls.Add(a);
            }
            Sqlcmd.Dispose();
            Sqlreader.Close();
            Cnn.Close();
            Strsql = "";
            UseWaitCursor = false;
        }

        private async Task XseachProducts()
        {
            UseWaitCursor = true;
            await Conopen();
            Sqlcmd.Parameters.Clear();
            Strsql = "Select * from tbl_Products where prod_name+prod_barcode+unit_desc like '%" + bunifuTextBox1.Text + "%'";
            Sqlcmd.CommandText = Strsql;
            Sqlcmd.Connection = Cnn;
            Sqladapter.SelectCommand = Sqlcmd;
            Sqlreader = Sqlcmd.ExecuteReader();
            flowLayoutPanel1.Controls.Clear();
            DataTable dt = new DataTable();
            dt.Load(Sqlreader);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ListProducts a = new ListProducts();
                byte[] img = (byte[])(dt.Rows[i]["Prod_Img"]);
                MemoryStream ms = new MemoryStream(img);
                a.bunifuPictureBox1.Image = Image.FromStream(ms);
                a.lblID.Text = dt.Rows[i]["Prod_Number"].ToString();
                a.lblprodname.Text = dt.Rows[i]["Prod_Name"].ToString();
                var fs = dt.Rows[i]["prod_fs"].ToString();
                if (fs != "1")
                {
                    a.lblprodname.ForeColor = Color.FromArgb(255, 227, 0);
                }
                a.lblstock.Text = dt.Rows[i]["Prod_Stock"].ToString();
                a.lblbrcode.Text = dt.Rows[i]["Prod_Barcode"].ToString();
                a.lblunit.Text = dt.Rows[i]["Unit_Desc"].ToString();
                var price = Convert.ToDouble(dt.Rows[i]["Prod_Price"]);
                a.lblprice.Text = price.ToString("N");
                flowLayoutPanel1.Controls.Add(a);
            }
            Sqlcmd.Dispose();
            Sqlreader.Close();
            Cnn.Close();
            Strsql = "";
            if (flowLayoutPanel1.Controls.Count != 0)
            {
                //***************Sum inventory and sales for searched product************
                float x = 0;
                await Conopen();
                Sqlcmd.Parameters.Clear();
                Strsql =
                    "Select sum(Prod_Stock) as totstock from tbl_Products where prod_name+prod_barcode+unit_desc like '%" +
                    bunifuTextBox1.Text + "%'";
                Sqlcmd.CommandText = Strsql;
                Sqlcmd.Connection = Cnn;
                Sqladapter.SelectCommand = Sqlcmd;
                Sqlreader = Sqlcmd.ExecuteReader();
                if (Sqlreader.Read())
                {
                    x = Convert.ToSingle(Sqlreader.GetValue(0).ToString());
                    lblinventory.Text = x.ToString(CultureInfo.InvariantCulture);
                }

                Sqlcmd.Dispose();
                Sqlreader.Close();
                Cnn.Close();
                Strsql = "";
                //****************************Sales**********************

                await Conopen();
                Sqlcmd.Parameters.Clear();
                Strsql =
                    "Select sum(Prod_Price) as totprice from tbl_Products where prod_name+prod_barcode+unit_desc like '%" +
                    bunifuTextBox1.Text + "%'";
                Sqlcmd.CommandText = Strsql;
                Sqlcmd.Connection = Cnn;
                Sqladapter.SelectCommand = Sqlcmd;
                Sqlreader = Sqlcmd.ExecuteReader();
                if (Sqlreader.Read())
                {
                    var b = Convert.ToSingle(Sqlreader.GetValue(0).ToString());
                    var sales = x * b;
                    lblsales.Text = sales.ToString("N");
                }

                Sqlcmd.Dispose();
                Sqlreader.Close();
                Cnn.Close();
                Strsql = "";
            }
            else
            {
                lblinventory.Text = 0.ToString();
                lblsales.Text = 0.ToString();
            }
            UseWaitCursor = false;
        }
        private async Task XProdCount()
        {
            UseWaitCursor = true;
            if (flowLayoutPanel1.Controls.Count != 0)
            {
                //Inventory
                float a = 0;
                await Conopen();
                Sqlcmd.Parameters.Clear();
                Strsql = "Select sum(Prod_Stock) as totstock from tbl_Products";
                Sqlcmd.CommandText = Strsql;
                Sqlcmd.Connection = Cnn;
                Sqladapter.SelectCommand = Sqlcmd;
                Sqlreader = Sqlcmd.ExecuteReader();
                if (Sqlreader.Read())
                {
                    a = Convert.ToSingle(Sqlreader.GetValue(0).ToString());
                    lblinventory.Text = a.ToString(CultureInfo.InvariantCulture);
                }

                Sqlcmd.Dispose();
                Sqlreader.Close();
                Cnn.Close();
                Strsql = "";
                //****************************Sales**********************

                await Conopen();
                Sqlcmd.Parameters.Clear();
                Strsql = "Select sum(Prod_Price) as totprice from tbl_Products";
                Sqlcmd.CommandText = Strsql;
                Sqlcmd.Connection = Cnn;
                Sqladapter.SelectCommand = Sqlcmd;
                Sqlreader = Sqlcmd.ExecuteReader();
                if (Sqlreader.Read())
                {
                    var b = Convert.ToDecimal(Sqlreader.GetValue(0).ToString());
                    var sales = a * (double)b;
                    lblsales.Text = sales.ToString("N");
                }

                Sqlcmd.Dispose();
                Sqlreader.Close();
                Cnn.Close();
                Strsql = "";
                //************************************************************
                await Conopen();
                Sqlcmd.Parameters.Clear();
                Strsql = "Select count(*) as totproduct from tbl_Products";
                Sqlcmd.CommandText = Strsql;
                Sqlcmd.Connection = Cnn;
                Sqladapter.SelectCommand = Sqlcmd;
                Sqlreader = Sqlcmd.ExecuteReader();
                if (Sqlreader.Read())
                {
                    string pro = Sqlreader.GetValue(0).ToString();
                    label2.Text = @"Total record found " + flowLayoutPanel1.Controls.Count + @" of " + pro;
                    label1.Text = @"Total record found " + flowLayoutPanel2.Controls.Count + @" of " + pro;
                }
                else label2.Text = @"No record found!";

                Sqlcmd.Dispose();
                Sqlreader.Close();
                Cnn.Close();
                Strsql = "";
            }
            UseWaitCursor = false;
        }
        private async Task XLoadNotification()
        {
            await Conopen();
            Sqlcmd.Parameters.Clear();
            Strsql = "Select count(not_num) as totcount from tbl_notification";
            Sqlcmd.CommandText = Strsql;
            Sqlcmd.Connection = Cnn;
            Sqladapter.SelectCommand = Sqlcmd;
            Sqlreader = Sqlcmd.ExecuteReader();
            lblnotifcount.Text = Sqlreader.Read() ? Sqlreader.GetValue(0).ToString() : @"0";
            Sqlcmd.Dispose();
            Sqlreader.Close();
            Cnn.Close();
            Strsql = "";
            Focus();
            lblnotifcount.BackColor = Convert.ToInt32(lblnotifcount.Text) >= 1 ? Color.FromArgb(255, 227, 0) : Color.Gray;
            lblnotifcount.Visible = true;
            //lblnotcount.Text = flowLayoutPanel1.Controls.Count + @" total";
        }

        #endregion


        private async void Form1_Load(object sender, EventArgs e)
        {
            
            
            //bunifuFormFadeTransition1.ShowAsyc(this);
            splashScreenManager1.ShowWaitForm();
            bunifuDatepicker1.Value = Now;
            UseWaitCursor = true;
            await FillProducts();
            //await FillStock();
            await XProdCount();
            await XLoadUser();
            await XLoadUserList();
            await XLoadNewOrders();
            await XLoadTopSellingProducts();
            await XLoadCriticalProducts();
            await XLoadRevenue();
            await XLoadCollectables();
            await XCountVoided();
            await XCountCustomer();
            await XLoadRecentActivities();
            await XloadUserTransOvrvw();
            await XLoadWeeklylySales();
            await XLoadNotification();
            await XLoadNearExpiration();
            UseWaitCursor = false;
            switch (Settings.Default.bg)
            {
                case @"BG1":
                    panel18.BackgroundImage = Resources.dashbgbg;
                    break;
                case @"BG2":
                    panel18.BackgroundImage = Resources.dashbgbg1;
                    break;
                case @"BG3":
                    panel18.BackgroundImage = Resources.dashbgbg2;
                    break;
                case @"BG4":
                    panel18.BackgroundImage = Resources.dashbgbg3;
                    break;
                case @"None":
                    panel18.BackgroundImage = null;
                    panel18.BackColor = Color.FromArgb(44, 48, 57);
                    break;
            }
            splashScreenManager1.CloseWaitForm();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            var a = new T_Dashboard();
            var b = new FrmProductAe {lbltitle = {Text = @"Product Registration"}};
            a.Show(this);
            b._PAdd = true;
            b.ShowDialog();
            a.Hide();
            Focus();
        }

        private void bunifuImageButton4_Click(object sender, EventArgs e)
        {
            if (sidepanel.Width == 193)
            {
                sidepanel.Visible = false;
                sidepanel.Width = 60;
                btn_product.Width = 47;
                btndashboard.Width = 47;
                btn_stock.Width = 47;
                btnusers.Width = 47;
                btnuserlog.Width = 47;
                btnpostransac.Width = 47;
                btnreports.Width = 47;
                bunifuTransition1.ShowSync(sidepanel);
            }
            else
            {
                sidepanel.Visible = false;
                sidepanel.Width = 193;
                btn_product.Width = 180;
                btndashboard.Width = 180;
                btn_stock.Width = 180;
                btnusers.Width = 180;
                btnuserlog.Width = 180;
                btnpostransac.Width = 180;
                btnreports.Width = 180;
                bunifuTransition1.ShowSync(sidepanel);
            }
        }

        private void btndashboard_Click(object sender, EventArgs e)
        {
            lbltitle.Text = @"Dashboard";
            indicator.Top = btndashboard.Top;
            indicator.Visible = false;
            bunifuTransition2.ShowSync(indicator);
            panelproducts.Visible = false;
            paneldashboard.Visible = true;
            panelusers.Visible = false;
            panelstock.Visible = false;
            panelreports.Visible = false;
        }

        private void btn_product_Click(object sender, EventArgs e)
        {
            lbltitle.Text = @"Products";
            indicator.Top = btn_product.Top;
            indicator.Visible = false;
            bunifuTransition2.ShowSync(indicator);
            panelstock.Visible = false;
            paneldashboard.Visible = false;
            panelusers.Visible = false;
            panelproducts.Visible = true;
            panelreports.Visible = false;
        }

        private void btn_stock_Click(object sender, EventArgs e)
        {
            lbltitle.Text = @"Stocks";
            indicator.Top = btn_stock.Top;
            indicator.Visible = false;
            bunifuTransition2.ShowSync(indicator);
            panelproducts.Visible = false;
            paneldashboard.Visible = false;
            panelusers.Visible = false;
            panelstock.Visible = true;
            panelreports.Visible = false;
        }

        private async void bunifuTextBox1_OnIconRightClick(object sender, EventArgs e)
        {
            if (bunifuTextBox1.Text != "")
            {
                await FillProducts();
                await XProdCount();
            }
        }

        private async void bunifuTextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
              await XseachProducts();

            }
        }

        private async void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            await FillProducts();
            await XProdCount();
        }

        private async void bunifuImageButton3_Click(object sender, EventArgs e)
        { 
            splashScreenManager1.ShowWaitForm();
            await FillStock();
           await XProdCount();
           splashScreenManager1.CloseWaitForm();
        }

        private void btnusers_Click(object sender, EventArgs e)
        {
            indicator.Top = btnusers.Top;
            indicator.Visible = false;
            bunifuTransition2.ShowSync(indicator);
            panelproducts.Visible = false;
            paneldashboard.Visible = false;
            panelusers.Visible = true;
            panelstock.Visible = false;
            panelreports.Visible = false;
        }

        private void btnuserlog_Click(object sender, EventArgs e)
        {
            indicator.Top = btnuserlog.Top;
            indicator.Visible = false;
            bunifuTransition2.ShowSync(indicator);
        }

        private void btnpostransac_Click(object sender, EventArgs e)
        {
            Hide();
            timer1.Stop();
            var a = new FrmPOSTransaction();
            a.ShowDialog();
            Show();
            Focus();
            timer1.Start();
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            if (_proppanelopen == false)
            {
                flowLayoutPanelprodcategory.Visible = false;
                _proppanelopen = true;
            }
            else
            {
                flowLayoutPanelprodcategory.Visible = true;
                _proppanelopen = false;
            }
        }

        private async void bunifuImageButton18_Click(object sender, EventArgs e)
        {
            await XLoadUserList();
        }

        private async void btnreports_Click(object sender, EventArgs e)
        {
            lbltitle.Text = @"Reports (Debts)";
            splashScreenManager1.ShowWaitForm();
            await XLoadDebts();
            indicator.Top = btnreports.Top;
            indicator.Visible = false;
            bunifuTransition2.ShowSync(indicator);
            panelproducts.Visible = false;
            paneldashboard.Visible = false;
            panelusers.Visible = false;
            panelstock.Visible = false;
            panelreports.Visible = true;
            splashScreenManager1.CloseWaitForm();
        }

        private async void refreshDashboardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            splashScreenManager1.ShowWaitForm();
            UseWaitCursor = true;
            await XLoadNewOrders();
            await XLoadWeeklylySales();
            await XLoadTopSellingProducts();
            await XLoadCriticalProducts();
            await XLoadRevenue();
            await XloadUserTransOvrvw();
            await XLoadCollectables();
            await XCountVoided();
            await XLoadNotification();
            await XLoadNearExpiration();
            UseWaitCursor = false;
            splashScreenManager1.CloseWaitForm();
        }

        private void bunifuImageButton10_Click(object sender, EventArgs e)
        {
            try
            {
                var a = new FrmProfileDialog {Location = panelaccnt.Location, 
                    Top = bunifuImageButton10.Top,};
                a.Top += 30;
                a.Left += 180;
                if (Application.OpenForms["Form1"] as FrmProfileDialog != null)
                {
                    //Form is already open
                }
                else
                {
                    a.Show();
                }

            }
            catch
            {
                //ignored
            }
        }

        private void bunifuImageButton22_Click(object sender, EventArgs e)
        {
            var frmReports = new FrmReports { StrReport = "DebtReport"};
            frmReports.ShowDialog();
            frmReports.Close();
        }

        private async void bunifuTextBox4_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                await Conopen();
                Sqlcmd.Parameters.Clear();
                Strsql = "Select Distinct fullname,cus_address,cus_mobile,cus_email,cus_id from v_debt where fullname like '%" + bunifuTextBox4.Text +"%'";
                Sqlcmd.CommandText = Strsql;
                Sqlcmd.Connection = Cnn;
                Sqladapter.SelectCommand = Sqlcmd;
                Sqlreader = Sqlcmd.ExecuteReader();
                //lvidebt.Items.Clear();
                while (Sqlreader.Read())
                {
                    //var lvi = lvidebt.Items.Add(Sqlreader.GetValue(0).ToString(), 0);
                    //lvi.SubItems.Add(Sqlreader.GetValue(1).ToString());
                    //lvi.SubItems.Add(Sqlreader.GetValue(2).ToString());
                    //lvi.SubItems.Add(Sqlreader.GetValue(3).ToString());
                    //lvi.SubItems.Add(Sqlreader.GetValue(4).ToString());
                    var a = Sqlreader.GetValue(0).ToString();
                    var b = Sqlreader.GetValue(1).ToString();
                    var c = Sqlreader.GetValue(2).ToString();
                    var d = Sqlreader.GetValue(3).ToString();
                    var f = Sqlreader.GetValue(4).ToString();
                    bunifuDataGridView1.Rows.Add(a, b, c, d, f);
                }
                Sqlcmd.Dispose();
                Sqlreader.Close();
                Cnn.Close();
                Strsql = "";
            }
        }

        private async void bunifuTextBox4_OnIconRightClick(object sender, EventArgs e)
        {
            if (bunifuTextBox4.Text != "")
            {
                await XLoadDebts();
            }
        }

        private void bunifuImageButton21_Click(object sender, EventArgs e)
        {
            if (debtSelected != null)
            {
                var frmReports = new FrmReports {StrReport = "DebtIndividual", PrintWhere = ("{V_Debt.cus_id} ='" + debtSelected + "'")};
                frmReports.ShowDialog();
                frmReports.Close();
            }
            else
            {
                popup.TitleText = "Print Error";
                popup.ContentText = "Please Select a customer first to print it's report!";
                popup.Image = Resources.error;
                popup.Popup();
                Focus();
            }
            

        }

        private void Form1_Shown(object sender, EventArgs e)
        {
        }
        #region Logs

        private void XPingServer()
        {
            try
            {
                var p = new Ping();
                var s = IP_Add;
                var r = p.Send(s);
                networkimg.Image = r != null && r.Status == IPStatus.Success ? Resources.wifi_on : Resources.wifi_off;
                if (r != null && r.Status == IPStatus.Success)
                {
                    //btnnetworkstatus.Text = @"Response delay = " + r.RoundtripTime + @" ms";
                }
            }
            catch
            {
                Connected = false;
                networkimg.Image = Resources.wifi_off;
                Cnn.Close();
                //btnnetworkstatus.Text = @"Server unreachable.";
                timer1.Stop();
                var tr = new T_Dashboard();
                var svr = new FrmServerSettings();
                tr.Show(this);
                svr.ShowDialog();
                tr.Dispose();
                Focus();
            }
            
        }

        private async void timer1_Tick(object sender, EventArgs e)
        {
            lbldate.Text = Now.ToString("D");
            lbltime.Text = Now.ToString("h:mm:ss tt");
            XPingServer();
            if (networkimg.Image == Resources.wifi_off) return;
            XLog1();
            XLog2();
            XLog3();
            XLog4();
            XLog5();
            
            sec++;
            label15.Text = sec.ToString();
            label22.Text = mins.ToString();
            if (sec == 60)
            {
                mins++;
                mins1++;
                sec = 0;
                switch (mins)
                {
                    case 3:
                        recentcalled = false;
                        break;
                    case 5:
                        if (recentcalled == false)
                        {
                            
                            splashScreenManager1.ShowWaitForm();
                            UseWaitCursor = true;
                            await XLoadRecentActivities();
                            await XLoadNewOrders();
                            await XLoadWeeklylySales();
                            await XLoadTopSellingProducts();
                            await XLoadCriticalProducts();
                            await XLoadRevenue();
                            await XloadUserTransOvrvw();
                            await XLoadCollectables();
                            await XCountVoided();
                            await XLoadNotification();
                            await XLoadNearExpiration();
                            UseWaitCursor = false;
                            splashScreenManager1.CloseWaitForm();
                            sec = 0;
                            mins = 0;
                            recentcalled = true;
                        }
                        break;
                    default:
                    {
                        if (mins1 == 30)
                        {
                            await XLoadNewOrders();
                            sec = 0;
                            mins1 = 0;
                        }

                        break;
                    }
                }
                
            }
        }
        private void XLog1()
        {
            const int second = 1;
            const int minute = 60 * second;
            const int hour = 60 * minute;
            const int day = 24 * hour;
            const int month = 30 * day;
            var aDateTime = Convert.ToDateTime(log1);
            var ts = new TimeSpan(DateTime.Now.Ticks - aDateTime.Ticks);
            var delta = Math.Abs(ts.TotalSeconds);
            if (delta < 1 * minute)
            {
                bunifuFlatButton4.Text = ts.Seconds == 1 ? " one second ago" : ts.Seconds + " seconds ago";
                return;
            }
            if (delta < 2 * minute)
            {
                bunifuFlatButton4.Text = @"a minute ago";
                return;
            }
            if (delta < 45 * minute)
            {
                bunifuFlatButton4.Text = ts.Minutes + @" minutes ago";
                return;
            }
            if (delta < 90 * minute)
            {
                bunifuFlatButton4.Text = @"an hr ago";
                return;
            }
            if (delta < 24 * hour)
            {
                bunifuFlatButton4.Text = ts.Hours == 1 ? ts.Hours + " hr ago" : ts.Hours + " hrs ago";
                return;
            }
            if (delta < 48 * hour)
            {
                bunifuFlatButton4.Text = @"yesterday";
                return;
            }
            if (delta < 30 * day)
            {
                bunifuFlatButton4.Text = ts.Days + @" days ago";
                return;
            }
            if (delta < 12 * month)
            {
                var months = Convert.ToInt32(Math.Floor((double)ts.Days / 30));
                bunifuFlatButton4.Text = months <= 1 ? "one month ago" : months + " months ago";
            }
            else
            {
                var years = Convert.ToInt32(Math.Floor((double)ts.Days / 365));
                bunifuFlatButton4.Text = years <= 1 ? "one year ago" : years + " years ago";
            }
        }
        private void XLog2()
        {
            const int second = 1;
            const int minute = 60 * second;
            const int hour = 60 * minute;
            const int day = 24 * hour;
            const int month = 30 * day;
            var aDateTime = Convert.ToDateTime(log2);
            var ts = new TimeSpan(DateTime.Now.Ticks - aDateTime.Ticks);
            var delta = Math.Abs(ts.TotalSeconds);
            if (delta < 1 * minute)
            {
                bunifuFlatButton5.Text = ts.Seconds == 1 ? " one second ago" : ts.Seconds + " seconds ago";
                return;
            }
            if (delta < 2 * minute)
            {
                bunifuFlatButton5.Text = @"a minute ago";
                return;
            }
            if (delta < 45 * minute)
            {
                bunifuFlatButton5.Text = ts.Minutes + @" minutes ago";
                return;
            }
            if (delta < 90 * minute)
            {
                bunifuFlatButton5.Text = @"an hr ago";
                return;
            }
            if (delta < 24 * hour)
            {
                bunifuFlatButton5.Text = ts.Hours == 1 ? ts.Hours + " hr ago" : ts.Hours + " hrs ago";
                return;
            }
            if (delta < 48 * hour)
            {
                bunifuFlatButton5.Text = @"yesterday";
                return;
            }
            if (delta < 30 * day)
            {
                bunifuFlatButton5.Text = ts.Days + @" days ago";
                return;
            }
            if (delta < 12 * month)
            {
                var months = Convert.ToInt32(Math.Floor((double)ts.Days / 30));
                bunifuFlatButton5.Text = months <= 1 ? "one month ago" : months + " months ago";
            }
            else
            {
                var years = Convert.ToInt32(Math.Floor((double)ts.Days / 365));
                bunifuFlatButton5.Text = years <= 1 ? "one year ago" : years + " years ago";
            }
        }
        private void XLog3()
        {
            const int second = 1;
            const int minute = 60 * second;
            const int hour = 60 * minute;
            const int day = 24 * hour;
            const int month = 30 * day;
            var aDateTime = Convert.ToDateTime(log3);
            var ts = new TimeSpan(DateTime.Now.Ticks - aDateTime.Ticks);
            var delta = Math.Abs(ts.TotalSeconds);

            if (delta < 1 * minute)
            {
                bunifuFlatButton6.Text = ts.Seconds == 1 ? " one second ago" : ts.Seconds + " seconds ago";
                return;
            }
            if (delta < 2 * minute)
            {
                bunifuFlatButton6.Text = @"a minute ago";
                return;
            }
            if (delta < 45 * minute)
            {
                bunifuFlatButton6.Text = ts.Minutes + @" minutes ago";
                return;
            }
            if (delta < 90 * minute)
            {
                bunifuFlatButton6.Text = @"an hr ago";
                return;
            }
            if (delta < 24 * hour)
            {
                bunifuFlatButton6.Text = ts.Hours == 1 ? ts.Hours + " hr ago" : ts.Hours + " hrs ago";
                return;
            }
            if (delta < 48 * hour)
            {
                bunifuFlatButton6.Text = @"yesterday";
                return;
            }
            if (delta < 30 * day)
            {
                bunifuFlatButton6.Text = ts.Days + @" days ago";
                return;
            }
            if (delta < 12 * month)
            {
                var months = Convert.ToInt32(Math.Floor((double)ts.Days / 30));
                bunifuFlatButton6.Text = months <= 1 ? "one month ago" : months + " months ago";
            }
            else
            {
                var years = Convert.ToInt32(Math.Floor((double)ts.Days / 365));
                bunifuFlatButton6.Text = years <= 1 ? "one year ago" : years + " years ago";
            }
        }

        private void bunifuVScrollBar3_Scroll(object sender, BunifuVScrollBar.ScrollEventArgs e)
        {
            //flowpanelcriticalproducts.AutoScrollPosition = new Point(flowpanelcriticalproducts.AutoScrollPosition.X, e.Value);
            bunifuDataGridView1.AutoScrollOffset = new Point(bunifuDataGridView1.AutoScrollOffset.X, e.Value);
        }

        private void Form1_Leave(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private async void bunifuDataGridView1_Click(object sender, EventArgs e)
        {
            try
            {
                debtSelected = (string)bunifuDataGridView1.SelectedRows[0].Cells[5].Value;
                xfullname = (string)bunifuDataGridView1.SelectedRows[0].Cells[1].Value;
                await XShowDebtInfo();
            }
            catch
            {
                //ignored
            }
        }

        private async void bunifuDataGridView1_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                debtSelected = (string)bunifuDataGridView1.SelectedRows[0].Cells[5].Value;
                xfullname = (string)bunifuDataGridView1.SelectedRows[0].Cells[1].Value;
                await XShowDebtInfo();
            }
            catch
            {
                //ignored
            }
        }

        private async void bunifuDataGridView1_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                debtSelected = (string)bunifuDataGridView1.SelectedRows[0].Cells[5].Value;
                xfullname = (string)bunifuDataGridView1.SelectedRows[0].Cells[1].Value;
                await XShowDebtInfo();
            }
            catch
            {
                //ignored
            }
        }

        private async void bunifuImageButton23_Click(object sender, EventArgs e)
        {
            //Settle all of debts
            var ques = new Frm_Question();
            var tQues = new T_Question();
            if (bunifuDataGridView1.RowCount==0) return;
            tQues.Show(this);
            ques.msgtxt.Text = @"Do you want to settle all of these/this debt(s)?";
            ques.titletxt.Text = @"Confirmation";
            ques.ShowDialog();
            switch (ques.DialogResult)
            {
                case DialogResult.Yes:
                    tQues.Dispose();
                    splashScreenManager1.ShowWaitForm();
                    Sqlcmd.Parameters.Clear();
                    await Conopen();
                    Strsql =
                        "Update tbl_Transaction set tran_stat=@tran_stat Where tran_stat=@tran_stat1";
                    Sqlcmd.Parameters.AddWithValue("@tran_stat1",
                        "Debt");
                    Sqlcmd.Parameters.AddWithValue("@tran_stat",
                        "Cash");
                    Sqlcmd.Connection = Cnn;
                    Sqlcmd.CommandText = Strsql;
                    Sqlcmd.ExecuteNonQuery();
                    Sqlcmd.Dispose();
                    Strsql = "";
                    Cnn.Close();
                    bunifuDataGridView1.Rows.Clear();
                    bunifuDataGridView2.Rows.Clear();
                    lbldebtfullname.Text = "";
                    bunifuPictureBox1.Image = null;
                    label38.Text = @"0";
                    splashScreenManager1.CloseWaitForm();
                    break;
                default:
                    tQues.Dispose();
                    break;
            }
        }

        private void bunifuDropdown2_DropDownClosed(object sender, EventArgs e)
        {
            
        }

        private async void bunifuDropdown2_SelectedIndexChanged(object sender, EventArgs e)
        {
            DateTime dtealt;
            Canvas canvas;
            DataPoint datapoint;
            switch (bunifuDropdown2.Text)
            {
                case "Weekly":
                    dtealt = (DateTime.Now.Subtract(TimeSpan.FromDays(7)));
                    canvas = new Canvas();
                    datapoint = new DataPoint(BunifuDataViz._type.Bunifu_spline);
                    bunifuDataViz1.Theme = BunifuDataViz._theme.theme2;
                    bunifuDataViz1.colorSet.Add(Color.FromArgb(218, 243, 53));
                    bunifuDataViz1.ForeColor = Color.Snow;
                    await Conopen();
                    Sqlcmd.Parameters.Clear();
                    Strsql = $"Select * from V_Chart_Sales_Custom where Inv_date <= '{Today:yyyy-MM-dd}' AND Inv_date >= '{dtealt:yyyy-MM-dd}' order by Inv_date desc";
                    Sqlcmd.CommandText = Strsql;
                    Sqlcmd.Connection = Cnn;
                    Sqladapter.SelectCommand = Sqlcmd;
                    Sqlreader = Sqlcmd.ExecuteReader();
                    while (Sqlreader.Read())
                    {
                        var x = (DateTime)Sqlreader.GetValue(0);
                        datapoint.addLabely(x.ToString("M"), y: Sqlreader.GetValue(1).ToString());
                        //bunifuDataViz1.ser
                    }
                    canvas.addData(datapoint);
                    bunifuDataViz1.Render(canvas);
                    Sqlcmd.Dispose();
                    Sqlreader.Close();
                    Cnn.Close();
                    Strsql = "";
                    label34.Text = @"Your weekly sales data";
                    break;
                case "2 Months":
                    //dtealt = (DateTime.Now.Subtract(TimeSpan.FromDays(31)));
                    canvas = new Canvas();
                    datapoint = new DataPoint(BunifuDataViz._type.Bunifu_spline);
                    bunifuDataViz1.Theme = BunifuDataViz._theme.theme2;
                    bunifuDataViz1.colorSet.Add(Color.FromArgb(218, 243, 53));
                    bunifuDataViz1.ForeColor = Color.Snow;
                    await Conopen();
                    Sqlcmd.Parameters.Clear();
                    Strsql = $"Select TOP 2 * from V_Chart_Sales ORDER BY num_Month_Year DESC";
                    Sqlcmd.CommandText = Strsql;
                    Sqlcmd.Connection = Cnn;
                    Sqladapter.SelectCommand = Sqlcmd;
                    Sqlreader = Sqlcmd.ExecuteReader();
                    while (Sqlreader.Read())
                    {
                        datapoint.addLabely(Sqlreader.GetValue(0).ToString(), y: Sqlreader.GetValue(1).ToString());
                        //bunifuDataViz1.ser
                    }
                    canvas.addData(datapoint);
                    bunifuDataViz1.Render(canvas);
                    Sqlcmd.Dispose();
                    Sqlreader.Close();
                    Cnn.Close();
                    Strsql = "";
                    label34.Text = @"Your 2 months sales data";
                    break;
                case "3 Months":
                    //dtealt = (DateTime.Now.Subtract(TimeSpan.FromDays(31)));
                    canvas = new Canvas();
                    datapoint = new DataPoint(BunifuDataViz._type.Bunifu_spline);
                    bunifuDataViz1.Theme = BunifuDataViz._theme.theme2;
                    bunifuDataViz1.colorSet.Add(Color.FromArgb(218, 243, 53));
                    bunifuDataViz1.ForeColor = Color.Snow;
                    await Conopen();
                    Sqlcmd.Parameters.Clear();
                    Strsql = $"Select TOP 3 * from V_Chart_Sales ORDER BY num_Month_Year DESC";
                    Sqlcmd.CommandText = Strsql;
                    Sqlcmd.Connection = Cnn;
                    Sqladapter.SelectCommand = Sqlcmd;
                    Sqlreader = Sqlcmd.ExecuteReader();
                    while (Sqlreader.Read())
                    {
                        datapoint.addLabely(Sqlreader.GetValue(0).ToString(), y: Sqlreader.GetValue(1).ToString());
                        //bunifuDataViz1.ser
                    }
                    canvas.addData(datapoint);
                    bunifuDataViz1.Render(canvas);
                    Sqlcmd.Dispose();
                    Sqlreader.Close();
                    Cnn.Close();
                    Strsql = "";
                    label34.Text = @"Your 3 months sales data";
                    break;
                case "6 Months":
                    //dtealt = (DateTime.Now.Subtract(TimeSpan.FromDays(31)));
                    canvas = new Canvas();
                    datapoint = new DataPoint(BunifuDataViz._type.Bunifu_spline);
                    bunifuDataViz1.Theme = BunifuDataViz._theme.theme2;
                    bunifuDataViz1.colorSet.Add(Color.FromArgb(218, 243, 53));
                    bunifuDataViz1.ForeColor = Color.Snow;
                    await Conopen();
                    Sqlcmd.Parameters.Clear();
                    Strsql = $"Select TOP 6 * from V_Chart_Sales ORDER BY num_Month_Year DESC";
                    Sqlcmd.CommandText = Strsql;
                    Sqlcmd.Connection = Cnn;
                    Sqladapter.SelectCommand = Sqlcmd;
                    Sqlreader = Sqlcmd.ExecuteReader();
                    while (Sqlreader.Read())
                    {
                        datapoint.addLabely(Sqlreader.GetValue(0).ToString(), y: Sqlreader.GetValue(1).ToString());
                        //bunifuDataViz1.ser
                    }
                    canvas.addData(datapoint);
                    bunifuDataViz1.Render(canvas);
                    Sqlcmd.Dispose();
                    Sqlreader.Close();
                    Cnn.Close();
                    Strsql = "";
                    label34.Text = @"Your 6 months sales data";
                    break;
                case "Yearly":
                    canvas = new Canvas();
                    datapoint = new DataPoint(BunifuDataViz._type.Bunifu_spline);
                    bunifuDataViz1.Theme = BunifuDataViz._theme.theme2;
                    bunifuDataViz1.colorSet.Add(Color.FromArgb(218, 243, 53));
                    bunifuDataViz1.ForeColor = Color.Snow;
                    await Conopen();
                    Sqlcmd.Parameters.Clear();
                    Strsql = $"Select TOP 12 * from V_Chart_Sales ORDER BY num_Month_Year DESC";
                    Sqlcmd.CommandText = Strsql;
                    Sqlcmd.Connection = Cnn;
                    Sqladapter.SelectCommand = Sqlcmd;
                    Sqlreader = Sqlcmd.ExecuteReader();
                    while (Sqlreader.Read())
                    {
                        datapoint.addLabely(Sqlreader.GetValue(0).ToString(), y: Sqlreader.GetValue(1).ToString());
                        //bunifuDataViz1.ser
                    }
                    canvas.addData(datapoint);
                    bunifuDataViz1.Render(canvas);
                    Sqlcmd.Dispose();
                    Sqlreader.Close();
                    Cnn.Close();
                    Strsql = "";
                    label34.Text = @"Your year long sales data";
                    break;
            }
        }

        private async void bunifuDropdown1_SelectedIndexChanged(object sender, EventArgs e)
        {

            DateTime dtealt;
            Canvas canvas;
            DataPoint datapoint;
            bunifuDataViz2.Theme = BunifuDataViz._theme.theme2;
            switch (bunifuDropdown1.Text)
            {
                case "Today":
                    canvas = new Canvas();
                    datapoint = new DataPoint(BunifuDataViz._type.Bunifu_bar);
                    bunifuDataViz2.colorSet.Add(Color.FromArgb(218, 243, 53));
                    bunifuDataViz2.ForeColor = Color.Snow;
                    await Conopen();
                    Sqlcmd.Parameters.Clear();
                    Strsql = $"Select Prod_name, sum(qty) as total_sales from V_Receipt where Inv_date ='{DateTime.Today:yyyy-MM-dd}' and tran_stat = 'Cash' GROUP BY Prod_Name order by total_sales";
                    Sqlcmd.CommandText = Strsql;
                    Sqlcmd.Connection = Cnn;
                    Sqladapter.SelectCommand = Sqlcmd;
                    Sqlreader = Sqlcmd.ExecuteReader();
                    while (Sqlreader.Read())
                    {
                        datapoint.addLabely(Sqlreader.GetValue(0).ToString(), Sqlreader.GetValue(1).ToString());
                        //bunifuDataViz1.ser
                    }
                    canvas.addData(datapoint);
                    bunifuDataViz2.Render(canvas);
                    //bunifuDataViz2.Title = "as of" + DateTime.Today.ToString(" yyyy - MM - dd ") + " and " + dtealt.ToString(" yyyy - MM - dd ");
                    Sqlcmd.Dispose();
                    Sqlreader.Close();
                    Cnn.Close();
                    Strsql = "";
                    break;
                case "2 Days":
                    dtealt = (DateTime.Now.Subtract(TimeSpan.FromDays(1)));
                    canvas = new Canvas();
                    datapoint = new DataPoint(BunifuDataViz._type.Bunifu_bar);
                    bunifuDataViz2.colorSet.Add(Color.FromArgb(218, 243, 53));
                    bunifuDataViz2.ForeColor = Color.Snow;
                    await Conopen();
                    Sqlcmd.Parameters.Clear();
                    Strsql = $"Select Prod_name, sum(qty) as total_sales from V_Receipt where Inv_date <='{DateTime.Today:yyyy-MM-dd}' and Inv_date >='{dtealt:yyyy-MM-dd}' and tran_stat = 'Cash' GROUP BY Prod_Name order by total_sales";
                    Sqlcmd.CommandText = Strsql;
                    Sqlcmd.Connection = Cnn;
                    Sqladapter.SelectCommand = Sqlcmd;
                    Sqlreader = Sqlcmd.ExecuteReader();
                    while (Sqlreader.Read())
                    {
                        datapoint.addLabely(Sqlreader.GetValue(0).ToString(), Sqlreader.GetValue(1).ToString());
                        //bunifuDataViz1.ser
                    }
                    canvas.addData(datapoint);
                    bunifuDataViz2.Render(canvas);
                    //bunifuDataViz2.Title = "as of" + DateTime.Today.ToString(" yyyy - MM - dd ") + " and " + dtealt.ToString(" yyyy - MM - dd ");
                    Sqlcmd.Dispose();
                    Sqlreader.Close();
                    Cnn.Close();
                    Strsql = "";
                    break;
                case "1 Week":
                    dtealt = (DateTime.Now.Subtract(TimeSpan.FromDays(7)));
                    canvas = new Canvas();
                    datapoint = new DataPoint(BunifuDataViz._type.Bunifu_bar);
                    bunifuDataViz2.colorSet.Add(Color.FromArgb(218, 243, 53));
                    bunifuDataViz2.ForeColor = Color.Snow;
                    await Conopen();
                    Sqlcmd.Parameters.Clear();
                    Strsql = $"Select Prod_name, sum(qty) as total_sales from V_Receipt where Inv_date <='{DateTime.Today:yyyy-MM-dd}' and Inv_date >='{dtealt:yyyy-MM-dd}' and tran_stat = 'Cash' GROUP BY Prod_Name order by total_sales";
                    Sqlcmd.CommandText = Strsql;
                    Sqlcmd.Connection = Cnn;
                    Sqladapter.SelectCommand = Sqlcmd;
                    Sqlreader = Sqlcmd.ExecuteReader();
                    while (Sqlreader.Read())
                    {
                        datapoint.addLabely(Sqlreader.GetValue(0).ToString(), Sqlreader.GetValue(1).ToString());
                        //bunifuDataViz1.ser
                    }
                    canvas.addData(datapoint);
                    bunifuDataViz2.Render(canvas);
                    Sqlcmd.Dispose();
                    Sqlreader.Close();
                    Cnn.Close();
                    Strsql = "";
                    break;
                case "This Month":
                    canvas = new Canvas();
                    datapoint = new DataPoint(BunifuDataViz._type.Bunifu_bar);
                    bunifuDataViz2.colorSet.Add(Color.FromArgb(218, 243, 53));
                    bunifuDataViz2.ForeColor = Color.Snow;
                    await Conopen();
                    Sqlcmd.Parameters.Clear();
                    Strsql = $"Select Prod_name, sum(qty) as total_sales from V_Receipt where month_year ='{DateTime.Today:y}' and tran_stat = 'Cash' GROUP BY Prod_Name order by total_sales";
                    Sqlcmd.CommandText = Strsql;
                    Sqlcmd.Connection = Cnn;
                    Sqladapter.SelectCommand = Sqlcmd;
                    Sqlreader = Sqlcmd.ExecuteReader();
                    while (Sqlreader.Read())
                    {
                        datapoint.addLabely(Sqlreader.GetValue(0).ToString(), Sqlreader.GetValue(1).ToString());
                        //bunifuDataViz1.ser
                    }
                    canvas.addData(datapoint);
                    bunifuDataViz2.Render(canvas);
                    //bunifuDataViz2.Title = "as of" + DateTime.Today.ToString(" yyyy - MM - dd ") + " and " + dtealt.ToString(" yyyy - MM - dd ");
                    Sqlcmd.Dispose();
                    Sqlreader.Close();
                    Cnn.Close();
                    Strsql = "";
                    break;
            }
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            try
            {
                var a = new FrmNotification();
                a.Location = panelaccnt.Location;
                a.Top = bunifuImageButton2.Top;
                a.Top += 30;
                if (Application.OpenForms["Form1"] as FrmNotification != null)
                {
                    //Form is already open
                }
                else
                {
                    lblnotifcount.Visible = false;
                    a.Show();
                }
                
            }
            catch
            {
                //ignored
            }
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            var a = new FrmNotification();
            a.Dispose();
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            //btnipadd.Text = Settings.Default.ip_add;
            if (Connected)
            {
                timer1.Start();
            }
            else
            {
                Cnn.Close();
                timer1.Stop();
                var tr = new T_Dashboard();
                var svr = new FrmServerSettings();
                tr.Show(this);
                svr.ShowDialog();
                tr.Dispose();
                Focus();
            }
        }

        private void networkimg_Click(object sender, EventArgs e)
        {
            try
            {
                var a = new FrmServerStatus {Location = panelaccnt.Location, Top = networkimg.Top};
                a.Top += 30;
                if (Application.OpenForms["Form1"] is FrmServerStatus)
                {
                    //Form is already open
                }
                else
                {
                    a.Show();
                }

            }
            catch
            {
                //ignored
            }
        }

        private void bunifuImageButton28_Click(object sender, EventArgs e)
        {
            var frmReports = new FrmReports { StrReport = "ProdNearExpr"};
            frmReports.ShowDialog();
            frmReports.Close();
        }

        private async void bunifuTextBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                await Conopen();
                Strsql = "Select * from V_Products where prod_name+prod_barcode+unit_desc like '%" + bunifuTextBox2.Text + "%'";
                Sqlcmd.CommandText = Strsql;
                Sqlcmd.Connection = Cnn;
                Sqladapter.SelectCommand = Sqlcmd;
                Sqlreader = Sqlcmd.ExecuteReader();
                flowLayoutPanel2.Controls.Clear();
                DataTable dt = new DataTable();
                dt.Load(Sqlreader);
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    ListStock a = new ListStock();
                    byte[] img = (byte[])(dt.Rows[i]["Prod_Img"]);
                    if (img.Length != 0)
                    {
                        MemoryStream ms = new MemoryStream(img);
                        a.bunifuPictureBox1.Image = Image.FromStream(ms);
                    }
                    a.lblID.Text = dt.Rows[i]["Prod_Number"].ToString();
                    a.lblprodname.Text = dt.Rows[i]["Prod_Name"].ToString();
                    var fs = dt.Rows[i]["prod_fs"].ToString();
                    if (fs != "1")
                    {
                        a.lblprodname.ForeColor = Color.FromArgb(255, 227, 0);
                    }
                    a.lblstock.Text = dt.Rows[i]["tot_stock"].ToString();
                    var currStock = Convert.ToInt32(dt.Rows[i]["Prod_Stock"].ToString());
                    if (currStock <= _criticalprod)
                    {
                        a.label6.Text = @"Critical";
                        a.label6.BackColor = Color.FromArgb(232, 76, 61);
                    }
                    else
                    {
                        a.label6.Text = @"Not Critical";
                        a.label6.BackColor = Color.FromArgb(16, 124, 16);
                    }
                    flowLayoutPanel2.Controls.Add(a);
                }
                Sqlcmd.Dispose();
                Sqlreader.Close();
                Cnn.Close();
                Strsql = "";
                //w.Hide();
                UseWaitCursor = false;
            }
        }

        private void bunifuImageButton27_Click(object sender, EventArgs e)
        {
            var frmReports = new FrmReports { StrReport = "ProdCritical" };
            frmReports.ShowDialog();
            frmReports.Close();
        }

        private void bunifuDropdown5_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (bunifuDropdown5.Text)
            {
                case @"BG1":
                    panel18.BackgroundImage = Resources.dashbgbg;
                    Settings.Default.bg = "BG1";
                    Settings.Default.Save();
                    break;
                case @"BG2":
                    panel18.BackgroundImage = Resources.dashbgbg1;
                    Settings.Default.bg = "BG2";
                    Settings.Default.Save();
                    break;
                case @"BG3":
                    panel18.BackgroundImage = Resources.dashbgbg2;
                    Settings.Default.bg = "BG3";
                    Settings.Default.Save();
                    break;
                case @"BG4":
                    panel18.BackgroundImage = Resources.dashbgbg3;
                    Settings.Default.bg = "BG4";
                    Settings.Default.Save();
                    break;
                case @"None":
                    panel18.BackgroundImage = null;
                    Settings.Default.bg = "None";
                    Settings.Default.Save();
                    break;
            }
        }

        private async void bunifuFlatButton9_Click(object sender, EventArgs e)
        {
            await LoadNearExpireproducts();
            lbltitle.Text = @"Reports (Expired Products)";
            indicator2.Location = bunifuFlatButton9.Location;
            panelexpiredproducts.Visible = true;
            paneldebts.Visible = false;
            indicator2.Visible = false;
            panelreportcharts.Visible = false;
            bunifuTransition3.ShowSync(indicator2);
        }
        private async Task LoadNearExpireproducts()
        {
            splashScreenManager1.ShowWaitForm();
            UseWaitCursor = true;
            await Conopen();
            Sqlcmd.Parameters.Clear();
            Strsql = "Select * from V_TobeExp_Prods ORDER BY prod_exp_date DESC";
            Sqlcmd.CommandText = Strsql;
            Sqlcmd.Connection = Cnn;
            Sqladapter.SelectCommand = Sqlcmd;
            Sqlreader = Sqlcmd.ExecuteReader();
            bunifuCustomDataGrid1.Controls.Clear();
            while (Sqlreader.Read())
            {
                var a = Sqlreader.GetValue(0).ToString();
                var b = Sqlreader.GetValue(2).ToString();
                var c = Sqlreader.GetValue(3).ToString();
                var d = Sqlreader.GetValue(6).ToString();
                var e = Sqlreader.GetValue(7).ToString();
                var f = Sqlreader.GetValue(9).ToString();
                bunifuCustomDataGrid1.Rows.Add(a, b, c, d, e, f);
            }
            Sqlcmd.Dispose();
            Sqlreader.Close();
            Cnn.Close();
            Strsql = "";
            UseWaitCursor=false;
            splashScreenManager1.CloseWaitForm();

            //((date1.Year - date2.Year) * 12) + date1.Month - date2.Month
            //var month = (endDate - StartDate).TotalMonths;
        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            lbltitle.Text = @"Reports (Debts)";
            indicator2.Location = bunifuFlatButton3.Location;
            panelexpiredproducts.Visible = false;
            paneldebts.Visible = true;
            indicator2.Visible = false;
            panelreportcharts.Visible = false;
            bunifuTransition3.ShowSync(indicator2);
        }

        private void bunifuImageButton32_Click(object sender, EventArgs e)
        {
            var frmReports = new FrmReports { StrReport = "ProdNearExpr" };
            frmReports.ShowDialog();
            frmReports.Close();
        }

        private async void bunifuFlatButton10_Click(object sender, EventArgs e)
        {
            await XCat_sales();
            lbltitle.Text = @"Reports (Charts)";
            indicator2.Location = bunifuFlatButton10.Location;
            panelexpiredproducts.Visible = false;
            paneldebts.Visible = false;
            indicator2.Visible = false;
            panelreportcharts.Visible = true;
            bunifuTransition3.ShowSync(indicator2);
        }

        private async Task XCat_sales()
        {
            var canvas = new Canvas();
            var datapoint = new DataPoint(BunifuDataViz._type.Bunifu_pie);
            //bunifuDataViz3.colorSet.Add(Color.FromArgb(165, 70, 113));
            bunifuDataViz3.ForeColor = Color.Snow;
            //bunifuDataViz3.Font.FontFamily=;
            await Conopen();
            Sqlcmd.Parameters.Clear();
            Strsql = $"Select * from V_Category_sales";
            Sqlcmd.CommandText = Strsql;
            Sqlcmd.Connection = Cnn;
            Sqladapter.SelectCommand = Sqlcmd;
            Sqlreader = Sqlcmd.ExecuteReader();
            while (Sqlreader.Read())
            {
                datapoint.addLabely(Sqlreader.GetValue(0).ToString(), Sqlreader.GetValue(1).ToString());
                //datapoint.
            }
            canvas.addData(datapoint);
            bunifuDataViz3.Render(canvas);
            Sqlcmd.Dispose();
            Sqlreader.Close();
            Cnn.Close();
            Strsql = "";
        }

        private void bunifuImageButton9_Click(object sender, EventArgs e)
        {
            var set = new FrmSystemSettings();
            var tr = new T_Dashboard();
            tr.Show(this);
            set.ShowDialog();
            tr.Dispose();
            Focus();
        }

        private async void bunifuImageButton39_Click(object sender, EventArgs e)
        {
            var canvas = new Canvas();
            var datapoint = new DataPoint(BunifuDataViz._type.Bunifu_spline);
            //bunifuDataViz3.colorSet.Add(Color.FromArgb(165, 70, 113));
            bunifuDataViz3.ForeColor = Color.Snow;
            //bunifuDataViz3.Font.FontFamily=;
            await Conopen();
            Sqlcmd.Parameters.Clear();
            Strsql = $"Select * from V_Transact_Summary WHERE inv_date = '{bunifuDatepicker1.Value}' and CAST(inv_time AS TIME) BETWEEN '{dateTimePicker1.Value}' and '{dateTimePicker2.Value}'";
            Sqlcmd.CommandText = Strsql;
            Sqlcmd.Connection = Cnn;
            Sqladapter.SelectCommand = Sqlcmd;
            Sqlreader = Sqlcmd.ExecuteReader();
            while (Sqlreader.Read())
            {
                datapoint.addLabely(Sqlreader.GetValue(2).ToString(), Sqlreader.GetValue(3).ToString());
                //datapoint.
            }
            canvas.addData(datapoint);
            bunifuDataViz5.Render(canvas);
            Sqlcmd.Dispose();
            Sqlreader.Close();
            Cnn.Close();
            Strsql = "";
        }

        private void Form1_Enter(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void XLog4()
        {
            const int second = 1;
            const int minute = 60 * second;
            const int hour = 60 * minute;
            const int day = 24 * hour;
            const int month = 30 * day;
            var aDateTime = Convert.ToDateTime(log4);
            var ts = new TimeSpan(DateTime.Now.Ticks - aDateTime.Ticks);
            var delta = Math.Abs(ts.TotalSeconds);

            if (delta < 1 * minute)
            {
                bunifuFlatButton7.Text = ts.Seconds == 1 ? " one second ago" : ts.Seconds + " seconds ago";
                return;
            }
            if (delta < 2 * minute)
            {
                bunifuFlatButton7.Text = @"a minute ago";
                return;
            }
            if (delta < 45 * minute)
            {
                bunifuFlatButton7.Text = ts.Minutes + @" minutes ago";
                return;
            }
            if (delta < 90 * minute)
            {
                bunifuFlatButton7.Text = @"an hr ago";
                return;
            }
            if (delta < 24 * hour)
            {
                bunifuFlatButton7.Text = ts.Hours == 1 ? ts.Hours +" hr ago" : ts.Hours + " hrs ago";
                return;
            }
            if (delta < 48 * hour)
            {
                bunifuFlatButton7.Text = @"yesterday";
                return;
            }
            if (delta < 30 * day)
            {
                bunifuFlatButton7.Text = ts.Days + @" days ago";
                return;
            }
            if (delta < 12 * month)
            {
                var months = Convert.ToInt32(Math.Floor((double)ts.Days / 30));
                bunifuFlatButton7.Text = months <= 1 ? "one month ago" : months + " months ago";
            }
            else
            {
                var years = Convert.ToInt32(Math.Floor((double)ts.Days / 365));
                bunifuFlatButton7.Text = years <= 1 ? "one year ago" : years + " years ago";
            }
        }
        private void XLog5()
        {
            const int second = 1;
            const int minute = 60 * second;
            const int hour = 60 * minute;
            const int day = 24 * hour;
            const int month = 30 * day;
            var aDateTime = Convert.ToDateTime(log5);
            var ts = new TimeSpan(DateTime.Now.Ticks - aDateTime.Ticks);
            var delta = Math.Abs(ts.TotalSeconds);

            if (delta < 1 * minute)
            {
                bunifuFlatButton8.Text = ts.Seconds == 1 ? " one second ago" : ts.Seconds + " seconds ago";
                return;
            }
            if (delta < 2 * minute)
            {
                bunifuFlatButton8.Text = @"a minute ago";
                return;
            }
            if (delta < 45 * minute)
            {
                bunifuFlatButton8.Text = ts.Minutes + @" minutes ago";
                return;
            }
            if (delta < 90 * minute)
            {
                bunifuFlatButton8.Text = @"an hr ago";
                return;
            }
            if (delta < 24 * hour)
            {
                bunifuFlatButton8.Text = ts.Hours == 1 ? ts.Hours + " hr ago" : ts.Hours + " hrs ago";
                return;
            }
            if (delta < 48 * hour)
            {
                bunifuFlatButton8.Text = @"yesterday";
                return;
            }
            if (delta < 30 * day)
            {
                bunifuFlatButton8.Text = ts.Days + @" days ago";
                return;
            }
            if (delta < 12 * month)
            {
                var months = Convert.ToInt32(Math.Floor((double)ts.Days / 30));
                bunifuFlatButton8.Text = months <= 1 ? "one month ago" : months + " months ago";
            }
            else
            {
                var years = Convert.ToInt32(Math.Floor((double)ts.Days / 365));
                bunifuFlatButton8.Text = years <= 1 ? "one year ago" : years + " years ago";
            }
        }

        #endregion

    }
}
