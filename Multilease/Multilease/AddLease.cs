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
    public partial class AddLease : Form
    {
        public AddLease()
        {
            InitializeComponent();
            comboBox1Fill();
            comboBox2Fill();
            comboBox3Fill();
            if (comboBox1.Items.Count <= 0 || comboBox2.Items.Count <= 0 || comboBox3.Items.Count <= 0)
            {
                button1.Enabled = false;
            }
        }
        private void comboBox1Fill()
        {
            string queryToCall = "select * from vehicle where currently_leased = 0;";
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
                    comboBox1.DisplayMember = "vin";
                    comboBox1.ValueMember = "id";


                }
                catch
                {
                    // MessageBox.Show("There is nothing into the database");
                }

                sc.Close();

            }
        }
        private void comboBox2Fill()
        {
            string queryToCall = "select id,(first_name+' '+ last_name+' '+phone_no) as details from customer;";
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
                    comboBox2.DataSource = ds.Tables[0];
                    comboBox2.DisplayMember ="details";
                    comboBox2.ValueMember = "id";


                }
                catch
                {
                    // MessageBox.Show("There is nothing into the database");
                }

                sc.Close();

            }
        }
        private void comboBox3Fill()
        {
            string queryToCall = "select * from terms;";
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
                    comboBox3.DataSource = ds.Tables[0];
                    comboBox3.DisplayMember = "id";
                    comboBox3.ValueMember = "id";


                }
                catch
                {
                    // MessageBox.Show("There is nothing into the database");
                }

                sc.Close();

            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection sc = new System.Data.SqlClient.SqlConnection("Server=(local);Database=MLY5741_2;Trusted_Connection=True;");
            using (sc)
            {
                sc.Open();
                SqlCommand scom = new SqlCommand("insert into leases(begin_date,first_pay,amt,pays,vehicle,customer,term,terminated)values(@bd,@fp,@amt,@pays,@vehicle,@customer,@term,0);", sc);
                using (scom)
                {
                   
                    scom.Parameters.Add("@pays", SqlDbType.Int);
                    scom.Parameters.Add("@vehicle", SqlDbType.Int);
                    scom.Parameters.Add("@customer", SqlDbType.Int);
                    scom.Parameters.Add("@term", SqlDbType.Int);
                    scom.Parameters.Add("@amt", SqlDbType.Money);
                    scom.Parameters.Add("@bd", SqlDbType.Date);
                    scom.Parameters.Add("@fp", SqlDbType.Date);
                    scom.Parameters["@bd"].Value = maskedTextBox1.Text;
                    scom.Parameters["@fp"].Value = maskedTextBox2.Text;
                    scom.Parameters["@amt"].Value = maskedTextBox3.Text;
                    scom.Parameters["@vehicle"].Value = comboBox1.SelectedValue;
                    scom.Parameters["@customer"].Value = comboBox2.SelectedValue;
                    scom.Parameters["@term"].Value = comboBox3.SelectedValue;
                    scom.Parameters["@pays"].Value = numericUpDown1.Value;
                    
                    scom.ExecuteNonQuery();
                   
                }
                sc.Close();
                
            }
            SqlConnection sc2 = new System.Data.SqlClient.SqlConnection("Server=(local);Database=MLY5741_2;Trusted_Connection=True;");
            using (sc2)
            {
                sc2.Open();
                SqlCommand scom = new SqlCommand("execute vehicle_currently_leased @vehicle ;", sc2);
                using (scom)
                {

                    scom.Parameters.Add("@vehicle", SqlDbType.Int);                  
                    scom.Parameters["@vehicle"].Value = comboBox1.SelectedValue;
                    scom.ExecuteNonQuery();
                }
                sc2.Close();

            }
            this.Close();
        }
    }
}
