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
    public partial class DeleteForm : Form
    {
        public DeleteForm()
        {
            InitializeComponent();
            fillAll();

        }
        private void fillAll()
        {
            comboBox1Fill();
            comboBox2Fill();
            comboBox3Fill(); 
            comboBox4Fill();
            comboBox5Fill();
            comboBox6Fill();
            comboBox7Fill();
        }
        private void comboBox1Fill()
        {
            string queryToCall = "execute select_free_customers;";
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
                button1.Enabled = false;

            }
            else
            {
                button1.Enabled = true;
            }
        }
        private void comboBox2Fill()
        {
            string queryToCall = "execute select_free_vehicles;";
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
                    comboBox2.DisplayMember = "vin";
                    comboBox2.ValueMember = "id";


                }
                catch
                {
                    // MessageBox.Show("There is nothing into the database");
                }

                sc.Close();

            }
            if (comboBox2.Items.Count <= 0)
            {
                button2.Enabled = false;

            }
            else
            {
                button2.Enabled = true;
            }

        }
        private void comboBox3Fill()
        {
            string queryToCall = "execute select_all_leases;";
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
                    comboBox3.DisplayMember = "details";
                    comboBox3.ValueMember = "id";


                }
                catch
                {
                    // MessageBox.Show("There is nothing into the database");
                }

                sc.Close();

            }
            if (comboBox3.Items.Count <= 0)
            {
                button3.Enabled = false;

            }
            else
            {
                button3.Enabled = true;
            }
        }
        private void comboBox4Fill()
        {
            string queryToCall = "execute select_terms;";
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
                    comboBox4.DataSource = ds.Tables[0];
                    comboBox4.DisplayMember = "id";
                    comboBox4.ValueMember = "id";


                }
                catch
                {
                    // MessageBox.Show("There is nothing into the database");
                }

                sc.Close();

            }
            if (comboBox4.Items.Count <= 0)
            {
                button4.Enabled = false;

            }
            else
            {
                button4.Enabled = true;
            }
        }
        private void comboBox5Fill()
        {
            string queryToCall = "execute select_models;";
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
                    comboBox5.DataSource = ds.Tables[0];
                    comboBox5.DisplayMember = "model";
                    comboBox5.ValueMember = "id";


                }
                catch
                {
                    // MessageBox.Show("There is nothing into the database");
                }

                sc.Close();

            }
            if (comboBox5.Items.Count <= 0)
            {
                button5.Enabled = false;

            }
            else
            {
                button5.Enabled = true;
            }
        }
        private void comboBox6Fill()
        {
            string queryToCall = "execute select_vehicle_type;";
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
                    comboBox6.DataSource = ds.Tables[0];
                    comboBox6.DisplayMember = "car_type";
                    comboBox6.ValueMember = "id";


                }
                catch
                {
                    // MessageBox.Show("There is nothing into the database");
                }

                sc.Close();

            }
            if (comboBox6.Items.Count <= 0)
            {
                button6.Enabled = false;

            }
            else
            {
                button6.Enabled = true;
            }
        }
        private void comboBox7Fill()
        {
            string queryToCall = "execute select_colors;";
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
                    comboBox7.DataSource = ds.Tables[0];
                    comboBox7.DisplayMember = "color";
                    comboBox7.ValueMember = "id";


                }
                catch
                {
                    // MessageBox.Show("There is nothing into the database");
                }

                sc.Close();

            }
            if (comboBox7.Items.Count <= 0)
            {
                button7.Enabled = false;

            }
            else
            {
                button7.Enabled = true;
            }
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection sc = new System.Data.SqlClient.SqlConnection("Server=(local);Database=MLY5741_2;Trusted_Connection=True;");
            using (sc)
            {
                sc.Open();
                SqlCommand scom = new SqlCommand("execute delete_customer @id;", sc);
                using (scom)
                {
                    scom.Parameters.Add("@id", SqlDbType.Int);
                    scom.Parameters["@id"].Value = comboBox1.SelectedValue;
                    scom.ExecuteNonQuery();
                    MessageBox.Show("Customer deleted!");
                }
                sc.Close();

            }
            fillAll();
        }

        

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection sc = new System.Data.SqlClient.SqlConnection("Server=(local);Database=MLY5741_2;Trusted_Connection=True;");
            using (sc)
            {
                sc.Open();
                SqlCommand scom = new SqlCommand("execute delete_vehicle @id;", sc);
                using (scom)
                {
                    scom.Parameters.Add("@id", SqlDbType.Int);
                    scom.Parameters["@id"].Value = comboBox2.SelectedValue;
                    scom.ExecuteNonQuery();
                    MessageBox.Show("Vehicle deleted!");
                }
                sc.Close();

            }
            fillAll();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection sc = new System.Data.SqlClient.SqlConnection("Server=(local);Database=MLY5741_2;Trusted_Connection=True;");
            using (sc)
            {
                sc.Open();
                SqlCommand scom = new SqlCommand("execute delete_lease @id;", sc);
                using (scom)
                {
                    scom.Parameters.Add("@id", SqlDbType.Int);
                    scom.Parameters["@id"].Value = comboBox3.SelectedValue;
                    scom.ExecuteNonQuery();
                    MessageBox.Show("Lease deleted!");
                }
                sc.Close();

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlConnection sc = new System.Data.SqlClient.SqlConnection("Server=(local);Database=MLY5741_2;Trusted_Connection=True;");
            using (sc)
            {
                sc.Open();
                SqlCommand scom = new SqlCommand("delete from terms where id = @id;", sc);
                using (scom)
                {
                    scom.Parameters.Add("@id", SqlDbType.Int);
                    scom.Parameters["@id"].Value = comboBox4.SelectedValue;
                    scom.ExecuteNonQuery();
                    MessageBox.Show("Term deleted!");
                }
                sc.Close();

            }
            fillAll();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            SqlConnection sc = new System.Data.SqlClient.SqlConnection("Server=(local);Database=MLY5741_2;Trusted_Connection=True;");
            using (sc)
            {
                sc.Open();
                SqlCommand scom = new SqlCommand("delete from model where id = @id;", sc);
                using (scom)
                {
                    scom.Parameters.Add("@id", SqlDbType.Int);
                    scom.Parameters["@id"].Value = comboBox5.SelectedValue;

                    scom.ExecuteNonQuery();
                    MessageBox.Show("Model deleted!");
                }
                sc.Close();

            }
            fillAll();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            SqlConnection sc = new System.Data.SqlClient.SqlConnection("Server=(local);Database=MLY5741_2;Trusted_Connection=True;");
            using (sc)
            {
                sc.Open();
                SqlCommand scom = new SqlCommand("delete from car_type where id = @id;", sc);
                using (scom)
                {
                    scom.Parameters.Add("@id", SqlDbType.Int);
                    scom.Parameters["@id"].Value = comboBox6.SelectedValue;
                    scom.ExecuteNonQuery();
                    MessageBox.Show("Vehicle type deleted!");
                }
                sc.Close();

            }
            fillAll();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            SqlConnection sc = new System.Data.SqlClient.SqlConnection("Server=(local);Database=MLY5741_2;Trusted_Connection=True;");
            using (sc)
            {
                sc.Open();
                SqlCommand scom = new SqlCommand("delete from color where id = @id;", sc);
                using (scom)
                {
                    scom.Parameters.Add("@id", SqlDbType.Int);
                    scom.Parameters["@id"].Value = comboBox7.SelectedValue;
                    scom.ExecuteNonQuery();
                    MessageBox.Show("Color deleted!");
                }
                sc.Close();

            }
            fillAll();
        }
    }
}
