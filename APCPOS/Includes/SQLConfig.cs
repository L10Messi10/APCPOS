using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Windows;
using APCPOS.Forms;

namespace APCPOS.Includes
{
    public static class SqlConfig
    {
        public static SqlDataReader Sqlreader;
        public static readonly SqlDataAdapter Sqladapter = new SqlDataAdapter();
        public static readonly SqlCommand Sqlcmd = new SqlCommand();
        public static SqlConnection Cnn = new SqlConnection();
        public static string Strsql;
        public static string username;
        public static string userpassword;
        public static string userfullname;
        public static string logaction;
        public static bool en_vat, en_debt, direct_print, Connected;
        public static string IP_Add, user_id, user_pass;

        public static async Task Conopen()
        {
            //try
            //{
            //ipaddress = Properties.Settings.Default.ipadd;
            //uid = Properties.Settings.Default.uid;
            //upass = Properties.Settings.Default.pass;
            IP_Add = Properties.Settings.Default.ip_add;
            user_id = Properties.Settings.Default.user_id;
            user_pass = Properties.Settings.Default.user_pass;
            string cstring;
            cstring =
                "Data Source = "+ IP_Add +";Network Library=DBMSSOCN;Initial Catalog=DBAPC_POS;User ID=" + user_id +";Password=" + user_pass +";";
            Cnn = new SqlConnection(cstring);
            await Cnn.OpenAsync();
            //}
            //catch
            //{
            //    //Form frm = new Form();
            //    //MetroFramework.MetroMessageBox.Show(frm, "Connection Failed! Please Ensure that all Server Settings are fully set-up!", "Connection Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    // MessageBox.Show("", "Connection Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}

        }
        public static async Task TestConnection()
        {
            var cstring = "Data Source = " + IP_Add + ";Network Library=DBMSSOCN;Initial Catalog=DBAPC_POS;User ID=" + user_id + ";Password=" + user_pass + ";";
            Cnn = new SqlConnection(cstring);
            await Cnn.OpenAsync();
            Connected = Cnn.State == ConnectionState.Open;
            if (Connected)
            {
                MessageBox.Show("Server connection and credentials were successfully established!", "Server settings", MessageBoxButton.OK, MessageBoxImage.Information);
                var server = new FrmServerSettings();
                server.Dispose();
                Cnn.Close();
            }
            else
            {
                MessageBox.Show("Server connection and credentials were not successfully established!", "Server settings", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }

}

