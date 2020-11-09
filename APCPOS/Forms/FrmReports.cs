using System;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;

namespace APCPOS.Forms
{
    public partial class FrmReports : Form
    {
        public string PrintWhere, StrReport;
        private static readonly ReportDocument Mreport = new ReportDocument();
        public FrmReports()
        {
            InitializeComponent();
        }

        private void FrmReports_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.direct_print)
            {
                XDirectPrint();
            }
            else
            {
                XNotDirectPrint();
            }
        }
        private void XDirectPrint()
        {
            Tables crTables;
            ConnectionInfo crConnectionInfo;
            TableLogOnInfo crtableLogoninfo;
            string path;
            splashScreenManager1.ShowWaitForm();
            switch (StrReport)
            {
                case "ProdCritical":
                    //Text = "Receipt Preview"();
                    path = (@"..\Reports\Critical_Products.rpt");
                    Mreport.Load(path);
                    // new TableLogOnInfos();
                    crConnectionInfo = new ConnectionInfo();

                    crConnectionInfo.ServerName = "APC_POS";
                    crConnectionInfo.DatabaseName = "DBAPC_POS";
                    crConnectionInfo.UserID = "sa";
                    crConnectionInfo.Password = "administrator01";
                    crTables = Mreport.Database.Tables;
                    foreach (Table crTable in crTables)
                    {
                        crtableLogoninfo = crTable.LogOnInfo;
                        crtableLogoninfo.ConnectionInfo = crConnectionInfo;
                        crTable.ApplyLogOnInfo(crtableLogoninfo);
                    }
                    crystalReportViewer1.ReportSource = Mreport;
                    crystalReportViewer1.Zoom(200);
                    crystalReportViewer1.RefreshReport();
                    splashScreenManager1.CloseWaitForm();
                    crystalReportViewer1.PrintReport();
                    break;
                case "ProdNearExpr":
                    path = (@"..\Reports\ProductsnearExpr.rpt");
                    Mreport.Load(path);
                    crConnectionInfo = new ConnectionInfo();
                    crConnectionInfo.ServerName = "APC_POS";
                    crConnectionInfo.DatabaseName = "DBAPC_POS";
                    crConnectionInfo.UserID = "sa";
                    crConnectionInfo.Password = "administrator01";
                    crTables = Mreport.Database.Tables;
                    foreach (Table crTable in crTables)
                    {
                        crtableLogoninfo = crTable.LogOnInfo;
                        crtableLogoninfo.ConnectionInfo = crConnectionInfo;
                        crTable.ApplyLogOnInfo(crtableLogoninfo);
                    }
                    Mreport.RecordSelectionFormula = PrintWhere;
                    crystalReportViewer1.Zoom(200);
                    crystalReportViewer1.RefreshReport();
                    splashScreenManager1.CloseWaitForm();
                    crystalReportViewer1.PrintReport();
                    break;
                case "Receipt":
                    //Text = "Receipt Preview"();
                    path = (@"..\Reports\Receipt.rpt");
                    Mreport.Load(path);
                    // new TableLogOnInfos();
                    crConnectionInfo = new ConnectionInfo();

                    crConnectionInfo.ServerName = "APC_POS";
                    crConnectionInfo.DatabaseName = "DBAPC_POS";
                    crConnectionInfo.UserID = "sa";
                    crConnectionInfo.Password = "administrator01";
                    crTables = Mreport.Database.Tables;
                    foreach (Table crTable in crTables)
                    {
                        crtableLogoninfo = crTable.LogOnInfo;
                        crtableLogoninfo.ConnectionInfo = crConnectionInfo;
                        crTable.ApplyLogOnInfo(crtableLogoninfo);
                    }
                    Mreport.RecordSelectionFormula = PrintWhere;
                    crystalReportViewer1.ReportSource = Mreport;
                    crystalReportViewer1.Zoom(200);
                    crystalReportViewer1.RefreshReport();
                    splashScreenManager1.CloseWaitForm();
                    crystalReportViewer1.PrintReport();
                    break;
                case "Receipt_Customer":
                    //Text = "Receipt Preview"();
                    path = (@"..\Reports\Receipt_Customer.rpt");
                    Mreport.Load(path);
                    // new TableLogOnInfos();
                    crConnectionInfo = new ConnectionInfo();

                    crConnectionInfo.ServerName = "APC_POS";
                    crConnectionInfo.DatabaseName = "DBAPC_POS";
                    crConnectionInfo.UserID = "sa";
                    crConnectionInfo.Password = "administrator01";
                    crTables = Mreport.Database.Tables;
                    foreach (Table crTable in crTables)
                    {
                        crtableLogoninfo = crTable.LogOnInfo;
                        crtableLogoninfo.ConnectionInfo = crConnectionInfo;
                        crTable.ApplyLogOnInfo(crtableLogoninfo);
                    }
                    Mreport.RecordSelectionFormula = PrintWhere;
                    crystalReportViewer1.ReportSource = Mreport;
                    crystalReportViewer1.Zoom(200);
                    crystalReportViewer1.RefreshReport();
                    splashScreenManager1.CloseWaitForm();
                    crystalReportViewer1.PrintReport();
                    break;
                case "MyLogs":
                    //Text = "Receipt Preview"();
                    path = (@"..\Reports\Logs.rpt");
                    Mreport.Load(path);
                    // new TableLogOnInfos();
                    crConnectionInfo = new ConnectionInfo();
                    crConnectionInfo.ServerName = "APC_POS";
                    crConnectionInfo.DatabaseName = "DBAPC_POS";
                    crConnectionInfo.UserID = "sa";
                    crConnectionInfo.Password = "administrator01";
                    crTables = Mreport.Database.Tables;
                    foreach (Table crTable in crTables)
                    {
                        crtableLogoninfo = crTable.LogOnInfo;
                        crtableLogoninfo.ConnectionInfo = crConnectionInfo;
                        crTable.ApplyLogOnInfo(crtableLogoninfo);
                    }
                    Mreport.RecordSelectionFormula = PrintWhere;
                    crystalReportViewer1.ReportSource = Mreport;
                    crystalReportViewer1.Zoom(100);
                    crystalReportViewer1.RefreshReport();
                    splashScreenManager1.CloseWaitForm();
                    crystalReportViewer1.PrintReport();
                    break;
                case "DebtReport":
                    //Text = "Receipt Preview"();
                    path = (@"..\Reports\Debt_Report.rpt");
                    Mreport.Load(path);
                    // new TableLogOnInfos();
                    crConnectionInfo = new ConnectionInfo();
                    crConnectionInfo.ServerName = "APC_POS";
                    crConnectionInfo.DatabaseName = "DBAPC_POS";
                    crConnectionInfo.UserID = "sa";
                    crConnectionInfo.Password = "administrator01";
                    crTables = Mreport.Database.Tables;
                    foreach (Table crTable in crTables)
                    {
                        crtableLogoninfo = crTable.LogOnInfo;
                        crtableLogoninfo.ConnectionInfo = crConnectionInfo;
                        crTable.ApplyLogOnInfo(crtableLogoninfo);
                    }
                    crystalReportViewer1.ReportSource = Mreport;
                    crystalReportViewer1.Zoom(100);
                    crystalReportViewer1.RefreshReport();
                    splashScreenManager1.CloseWaitForm();
                    crystalReportViewer1.PrintReport();
                    break;
                case "DebtIndividual":
                    //Text = "Receipt Preview"();
                    path = (@"..\Reports\Debt_In_Report.rpt");
                    Mreport.Load(path);
                    // new TableLogOnInfos();
                    crConnectionInfo = new ConnectionInfo();
                    crConnectionInfo.ServerName = "APC_POS";
                    crConnectionInfo.DatabaseName = "DBAPC_POS";
                    crConnectionInfo.UserID = "sa";
                    crConnectionInfo.Password = "administrator01";
                    crTables = Mreport.Database.Tables;
                    foreach (Table crTable in crTables)
                    {
                        crtableLogoninfo = crTable.LogOnInfo;
                        crtableLogoninfo.ConnectionInfo = crConnectionInfo;
                        crTable.ApplyLogOnInfo(crtableLogoninfo);
                    }
                    Mreport.RecordSelectionFormula = PrintWhere;
                    crystalReportViewer1.ReportSource = Mreport;
                    crystalReportViewer1.Zoom(100);
                    crystalReportViewer1.RefreshReport();
                    splashScreenManager1.CloseWaitForm();
                    crystalReportViewer1.PrintReport();
                    break;
            }
        }

        private void XNotDirectPrint()
        {
            Tables crTables;
            ConnectionInfo crConnectionInfo;
            TableLogOnInfo crtableLogoninfo;
            string path;
            splashScreenManager1.ShowWaitForm();
            switch (StrReport)
            {
                case "ProdCritical":
                    //Text = "Receipt Preview"();
                    path = (@"..\Reports\Critical_Products.rpt");
                    Mreport.Load(path);
                    // new TableLogOnInfos();
                    crConnectionInfo = new ConnectionInfo();

                    crConnectionInfo.ServerName = "APC_POS";
                    crConnectionInfo.DatabaseName = "DBAPC_POS";
                    crConnectionInfo.UserID = "sa";
                    crConnectionInfo.Password = "administrator01";
                    crTables = Mreport.Database.Tables;
                    foreach (Table crTable in crTables)
                    {
                        crtableLogoninfo = crTable.LogOnInfo;
                        crtableLogoninfo.ConnectionInfo = crConnectionInfo;
                        crTable.ApplyLogOnInfo(crtableLogoninfo);
                    }
                    crystalReportViewer1.ReportSource = Mreport;
                    crystalReportViewer1.Zoom(200);
                    crystalReportViewer1.RefreshReport();
                    splashScreenManager1.CloseWaitForm();
                    break;
                case "ProdNearExpr":
                    //Text = "Receipt Preview"();
                    path = (@"..\Reports\ProductsnearExpr.rpt");
                    Mreport.Load(path);
                    // new TableLogOnInfos();
                    crConnectionInfo = new ConnectionInfo();

                    crConnectionInfo.ServerName = "APC_POS";
                    crConnectionInfo.DatabaseName = "DBAPC_POS";
                    crConnectionInfo.UserID = "sa";
                    crConnectionInfo.Password = "administrator01";
                    crTables = Mreport.Database.Tables;
                    foreach (Table crTable in crTables)
                    {
                        crtableLogoninfo = crTable.LogOnInfo;
                        crtableLogoninfo.ConnectionInfo = crConnectionInfo;
                        crTable.ApplyLogOnInfo(crtableLogoninfo);
                    }
                    crystalReportViewer1.ReportSource = Mreport;
                    crystalReportViewer1.Zoom(200);
                    crystalReportViewer1.RefreshReport();
                    splashScreenManager1.CloseWaitForm();
                    break;
                case "Receipt":
                    //Text = "Receipt Preview"();
                    path = (@"..\Reports\Receipt.rpt");
                    Mreport.Load(path);
                    // new TableLogOnInfos();
                    crConnectionInfo = new ConnectionInfo();

                    crConnectionInfo.ServerName = "APC_POS";
                    crConnectionInfo.DatabaseName = "DBAPC_POS";
                    crConnectionInfo.UserID = "sa";
                    crConnectionInfo.Password = "administrator01";
                    crTables = Mreport.Database.Tables;
                    foreach (Table crTable in crTables)
                    {
                        crtableLogoninfo = crTable.LogOnInfo;
                        crtableLogoninfo.ConnectionInfo = crConnectionInfo;
                        crTable.ApplyLogOnInfo(crtableLogoninfo);
                    }
                    Mreport.RecordSelectionFormula = PrintWhere;
                    crystalReportViewer1.ReportSource = Mreport;
                    crystalReportViewer1.Zoom(100);
                    crystalReportViewer1.RefreshReport();
                    splashScreenManager1.CloseWaitForm();
                    break;
                case "Receipt_Customer":
                    //Text = "Receipt Preview"();
                    path = (@"..\Reports\Receipt_Customer.rpt");
                    Mreport.Load(path);
                    // new TableLogOnInfos();
                    crConnectionInfo = new ConnectionInfo();

                    crConnectionInfo.ServerName = "APC_POS";
                    crConnectionInfo.DatabaseName = "DBAPC_POS";
                    crConnectionInfo.UserID = "sa";
                    crConnectionInfo.Password = "administrator01";
                    crTables = Mreport.Database.Tables;
                    foreach (Table crTable in crTables)
                    {
                        crtableLogoninfo = crTable.LogOnInfo;
                        crtableLogoninfo.ConnectionInfo = crConnectionInfo;
                        crTable.ApplyLogOnInfo(crtableLogoninfo);
                    }
                    Mreport.RecordSelectionFormula = PrintWhere;
                    crystalReportViewer1.ReportSource = Mreport;
                    crystalReportViewer1.Zoom(200);
                    crystalReportViewer1.RefreshReport();
                    splashScreenManager1.CloseWaitForm();
                    break;
                case "MyLogs":
                    //Text = "Receipt Preview"();
                    path = (@"..\Reports\Logs.rpt");
                    Mreport.Load(path);
                    // new TableLogOnInfos();
                    crConnectionInfo = new ConnectionInfo();
                    crConnectionInfo.ServerName = "APC_POS";
                    crConnectionInfo.DatabaseName = "DBAPC_POS";
                    crConnectionInfo.UserID = "sa";
                    crConnectionInfo.Password = "administrator01";
                    crTables = Mreport.Database.Tables;
                    foreach (Table crTable in crTables)
                    {
                        crtableLogoninfo = crTable.LogOnInfo;
                        crtableLogoninfo.ConnectionInfo = crConnectionInfo;
                        crTable.ApplyLogOnInfo(crtableLogoninfo);
                    }
                    Mreport.RecordSelectionFormula = PrintWhere;
                    crystalReportViewer1.ReportSource = Mreport;
                    crystalReportViewer1.Zoom(100);
                    crystalReportViewer1.RefreshReport();
                    splashScreenManager1.CloseWaitForm();
                    break;
                case "DebtReport":
                    //Text = "Receipt Preview"();
                    path = (@"..\Reports\Debt_Report.rpt");
                    Mreport.Load(path);
                    // new TableLogOnInfos();
                    crConnectionInfo = new ConnectionInfo();
                    crConnectionInfo.ServerName = "APC_POS";
                    crConnectionInfo.DatabaseName = "DBAPC_POS";
                    crConnectionInfo.UserID = "sa";
                    crConnectionInfo.Password = "administrator01";
                    crTables = Mreport.Database.Tables;
                    foreach (Table crTable in crTables)
                    {
                        crtableLogoninfo = crTable.LogOnInfo;
                        crtableLogoninfo.ConnectionInfo = crConnectionInfo;
                        crTable.ApplyLogOnInfo(crtableLogoninfo);
                    }
                    crystalReportViewer1.ReportSource = Mreport;
                    crystalReportViewer1.Zoom(100);
                    crystalReportViewer1.RefreshReport();
                    splashScreenManager1.CloseWaitForm();
                    break;
                case "DebtIndividual":
                    //Text = "Receipt Preview"();
                    path = (@"..\Reports\Debt_In_Report.rpt");
                    Mreport.Load(path);
                    // new TableLogOnInfos();
                    crConnectionInfo = new ConnectionInfo();
                    crConnectionInfo.ServerName = "APC_POS";
                    crConnectionInfo.DatabaseName = "DBAPC_POS";
                    crConnectionInfo.UserID = "sa";
                    crConnectionInfo.Password = "administrator01";
                    crTables = Mreport.Database.Tables;
                    foreach (Table crTable in crTables)
                    {
                        crtableLogoninfo = crTable.LogOnInfo;
                        crtableLogoninfo.ConnectionInfo = crConnectionInfo;
                        crTable.ApplyLogOnInfo(crtableLogoninfo);
                    }
                    Mreport.RecordSelectionFormula = PrintWhere;
                    crystalReportViewer1.ReportSource = Mreport;
                    crystalReportViewer1.Zoom(100);
                    crystalReportViewer1.RefreshReport();
                    splashScreenManager1.CloseWaitForm();
                    break;
            }
        }
    }
}
