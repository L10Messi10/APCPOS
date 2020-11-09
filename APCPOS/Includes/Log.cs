using System;
using System.IO;

namespace APCPOS.Includes
{
    public static  class Log
    {
        public static void LogFile(string sExceptionName, string sEventName, string sControlName, int nErrorLineNo, string sFormName)
        {
            StreamWriter log;
            if (!File.Exists("logfile.txt"))
            {
                log = new StreamWriter("logfile.txt");
            }
            else
            {
                log = File.AppendText("logfile.txt");
            }
            // Write to the file:
            log.WriteLine("");
            log.WriteLine("***************** Execution date/Time:" + DateTime.Now +"******************");
            log.WriteLine("Exception Name:" + sExceptionName);
            log.WriteLine("Event Name:" + sEventName);
            log.WriteLine("Control Name:" + sControlName);
            log.WriteLine("Error Line No.:" + nErrorLineNo);
            log.WriteLine("Form Name:" + sFormName);
            // Close the stream:
            log.Close();
        }
    }
}
