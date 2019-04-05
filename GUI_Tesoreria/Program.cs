using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace GUI_Tesoreria
{
    static class Program
    {
        public static String ConnStr = "";
        public static String OurReportSource = "";
        public static String OurLogSource = "";
        public static String OurImagelocation = "";
        public static String Server = "";
        public static String database = "";
        public static String dbUsername = "";
        public static String dbPassword = "";

        public static String database2 = "";
        public static String dbUsername2 = "";
        public static String dbPassword2 = "";

        public static DateTime Datetoday = DateTime.Now;
        public static DatabasePicker databasepcker = null;
        [STAThread]
        static void Main()
        {
            databasepcker = new DatabasePicker();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            databasepcker.SetConnctionString();
            Application.Run(new control.frmLogin());
        }
    }
}
