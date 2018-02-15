using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Multilease
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection sc = new System.Data.SqlClient.SqlConnection("Server=(local);Database=MLY5741_2;Trusted_Connection=True;");
            
             using (sc)
            {
                sc.Open();
                SqlCommand scom = new SqlCommand("exec user_select @user_ , @pwd_;", sc);
                scom.Parameters.Add("@user_",SqlDbType.VarChar);
                scom.Parameters["@user_"].Value = textBox1.Text;
                scom.Parameters.Add("@pwd_", SqlDbType.VarChar);
                scom.Parameters["@pwd_"].Value = textBox1.Text;
                using (scom)
                {
                    SqlDataReader myReader = scom.ExecuteReader();
                   
                   myReader.Read();
                   if (myReader.VisibleFieldCount >0)
                   {
                       try
                       {
                           Program.privileges = myReader[0].ToString();
                       }
                       catch
                       {
                           Program.privileges = "";
                           MessageBox.Show("Wrong user or password");
                       }
                       if (Program.privileges != "")
                       {
                           Menu m = new Menu();
                           this.Hide();
                           m.Show();
                       }
                   }
                }
                sc.Close();
               
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
