using System.Data.SqlClient;
using System.Threading.Tasks;

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
        public static bool en_vat, en_debt, direct_print;

        public static async Task Conopen()
        {
            //try
            //{
            //ipaddress = Properties.Settings.Default.ipadd;
            //uid = Properties.Settings.Default.uid;
            //upass = Properties.Settings.Default.pass;
            string cstring = null;
            cstring =
                "Data Source = 25.37.196.40;Network Library=DBMSSOCN;Initial Catalog=DBAPC_POS;User ID=sa;Password=administrator01;";
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
       

    }

}

