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
    public partial class AddCustomer : Form
    {
        public AddCustomer()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string phoneNumber = maskedTextBox2.Text;

                phoneNumber = phoneNumber.Replace("(", "");
                phoneNumber = phoneNumber.Replace(")", "");
                phoneNumber = phoneNumber.Replace(" ", "");
                phoneNumber = phoneNumber.Replace("-", "");

                if (textBox1.Text != "" && textBox1.Text != "" && textBox1.Text != "" && textBox1.Text != "" && textBox1.Text != "" && maskedTextBox1.Text != "" && phoneNumber != "")
                {

                    SqlConnection sc = new System.Data.SqlClient.SqlConnection("Server=(local);Database=MLY5741_2;Trusted_Connection=True;");

                    using (sc)
                    {
                        sc.Open();
                        SqlCommand scom = new SqlCommand("execute add_customer @fn,@ln,@adrs,@c,@prov,@pc,@phone;", sc);
                        using (scom)
                        {
                            scom.Parameters.Add("@fn", SqlDbType.VarChar);
                            scom.Parameters.Add("@ln", SqlDbType.VarChar);
                            scom.Parameters.Add("@adrs", SqlDbType.VarChar);
                            scom.Parameters.Add("@c", SqlDbType.VarChar);
                            scom.Parameters.Add("@prov", SqlDbType.VarChar);
                            scom.Parameters.Add("@pc", SqlDbType.VarChar);
                            scom.Parameters.Add("@phone", SqlDbType.VarChar);
                            scom.Parameters["@fn"].Value = textBox1.Text;
                            scom.Parameters["@ln"].Value = textBox2.Text;
                            scom.Parameters["@adrs"].Value = textBox3.Text;
                            scom.Parameters["@c"].Value = textBox4.Text;
                            scom.Parameters["@prov"].Value = textBox5.Text;
                            scom.Parameters["@pc"].Value = maskedTextBox1.Text;
                            scom.Parameters["@phone"].Value = phoneNumber;


                            scom.ExecuteNonQuery();
                        }
                        sc.Close();
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("All fields needed to be filled.");
                }
        }
    }
}
