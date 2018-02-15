using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using SQLDataSimplifier;
namespace WindowsFormsApplication1
{
    static class Program
    {

      static public SqlDataConnector SQL = new SqlDataConnector("(local)", "NHL_y5741");
        static void Main()
        {
           
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LoginForm());
        }
    }
}
