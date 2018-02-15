using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
           

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //stop button login from showing enabled if nothing into text box.
            if (textBox1.Text != "" && textBox2.Text != "")
            {
                button1.Enabled = true;
            }
            else
            {

                button1.Enabled = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /* logically explanation :
             * if we try to look into the database and we try to recover the first row on the first column ( privileges) 
             * if it cannot be retreived then gives error then we suppose he entered wrong the user or
             * password since the database cannot return privileges title.
             */
            string privilege = "";
            SQLDataSimplifier.SQLVarContainer[] vars = { new SQLDataSimplifier.SQLVarContainer(SqlDbType.VarChar,"@name",textBox1.Text),
                                                           new SQLDataSimplifier.SQLVarContainer(SqlDbType.VarChar,"@pass",textBox2.Text)};
            try
            {
                privilege = Program.SQL.GetDataQuery("exec user_login ", vars, ";").Tables[0].Rows[0]["priv"].ToString();
            }
            catch
            {
                MessageBox.Show("Username or password are wrong");
            }

            // do a checkup for what's the user. if it fails that means no privileges that comply with below .
            if (privilege == "admin")
            {
                AdministratorForm af = new AdministratorForm();
                af.Show();
                this.Hide();
            }
            else if (privilege == "doctor")
            {
                Doctor d = new Doctor();
                d.Show();
                this.Hide();
            }
            else if (privilege == "admiss")
            {
                AdmissionWindow aw = new AdmissionWindow();
                aw.Show();
                this.Hide();
            }

        }

       
      
      
    }
}
