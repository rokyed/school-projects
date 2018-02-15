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
    public partial class EditCustomer : Form
    {
        int id = 0;
        public EditCustomer()
        {
            InitializeComponent();
            fillCustomers();
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
                    SqlCommand scom = new SqlCommand("execute edit_customer @id,@fn,@ln,@adrs,@c,@prov,@pc,@phone;", sc);
                    using (scom)
                    {
                        scom.Parameters.Add("@id", SqlDbType.Int);
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
                        scom.Parameters["@id"].Value = id;

                        scom.ExecuteNonQuery();
                        MessageBox.Show("Customer edited!");
                        groupBox2.Enabled = false;
                        groupBox1.Enabled = true;
                        fillCustomers();
                    }
                    sc.Close();
                    
                }
            }
            else
            {
                MessageBox.Show("All fields needed to be filled.");
            }
        }
        private void fillCustomers()
        {
            string queryToCall = "execute select_all_customers;";
            SqlConnection sc = new System.Data.SqlClient.SqlConnection("Server=(local);Database=MLY5741_2;Trusted_Connection=True;");

            using (sc)
            {
                sc.Open();
                SqlDataAdapter dataAdapter = new SqlDataAdapter(queryToCall, sc); //c.con is the connection string
                SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);
                DataSet ds = new DataSet();
                try
                {
                    dataAdapter.Fill(ds);
                    comboBox1.DataSource = ds.Tables[0];
                    comboBox1.DisplayMember = "details";
                    comboBox1.ValueMember = "id";


                }
                catch
                {
                    // MessageBox.Show("There is nothing into the database");
                }

                sc.Close();

            }
            if (comboBox1.Items.Count <= 0)
            {
                button2.Enabled = false;

            }
            else
            {
                button2.Enabled = true;
            }

        }
        private void fillFields()
        {
             string queryToCall = "select * from customer where id = " + comboBox1.SelectedValue + ";";
            SqlConnection sc = new System.Data.SqlClient.SqlConnection("Server=(local);Database=MLY5741_2;Trusted_Connection=True;");

            using (sc)
            {
                sc.Open();
                SqlCommand scom = new SqlCommand(queryToCall, sc); //c.con is the connection string

                SqlDataReader sda = scom.ExecuteReader();

                try
                {
                    while (sda.Read())
                    {
                        textBox1.Text = sda.GetValue(1).ToString();
                        textBox2.Text = sda.GetValue(2).ToString();
                        textBox3.Text = sda.GetValue(3).ToString();
                        textBox4.Text = sda.GetValue(4).ToString();
                        textBox5.Text = sda.GetValue(5).ToString();
                        maskedTextBox1.Text = sda.GetValue(6).ToString();
                        maskedTextBox2.Text = sda.GetValue(7).ToString();
                    }
                }
                catch { 
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            groupBox2.Enabled = true;
            groupBox1.Enabled = false;
            id = Int32.Parse(comboBox1.SelectedValue.ToString());
            fillFields();
        } 
    }
}
