using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Multilease
{
    static class Program
    {
        
        public static string privileges = "";
        [STAThread]
        static void Main()
        {
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Login());
        }
     
    }
}
