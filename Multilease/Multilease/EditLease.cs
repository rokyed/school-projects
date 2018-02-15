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
    public partial class EditLease : Form
    {
        int leaseId = 0;
       
        public EditLease()
        {
            InitializeComponent();
            selectLeases();

            
        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            if (leaseId != 0 )
            {
                SqlConnection sc3 = new System.Data.SqlClient.SqlConnection("Server=(local);Database=MLY5741_2;Trusted_Connection=True;");
                using (sc3)
                {
                    sc3.Open();
                    SqlCommand scom = new SqlCommand("declare @vid int; set @vid = (select vehicle from leases where id =" + leaseId + ");execute vehicle_currently_leased @vid;", sc3);
                    using (scom)
                    {
                        scom.ExecuteNonQuery();
                    }
                    sc3.Close();

                }
            }

            base.OnFormClosing(e);
        }
        private void selectLeases()
        {
            string queryToCall = "execute select_leases;";
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
                    comboBox4.DisplayMember = "details";
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
                button2.Enabled = false;

            }
            else
            {
                button2.Enabled = true;
            }
        }
        private void gatherData()
        {
            SqlConnection sc3 = new System.Data.SqlClient.SqlConnection("Server=(local);Database=MLY5741_2;Trusted_Connection=True;");
            using (sc3)
            {
                sc3.Open();
                SqlCommand scom = new SqlCommand("declare @vid int; set @vid = (select vehicle from leases where id =" + leaseId + ");execute vehicle_not_currently_leased @vid;", sc3);
                using (scom)
                {
                    scom.ExecuteNonQuery();
                }
                sc3.Close();

            }
            comboBox1Fill();
            comboBox2Fill();
            comboBox3Fill();
            // gather data procedure here
            string queryToCall = "select * from leases where id = " + leaseId + ";";
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

                        maskedTextBox1.Text = Convert.ToDateTime(sda.GetValue(1)).ToString("dd-MM-yyyy");
                        maskedTextBox2.Text = Convert.ToDateTime(sda.GetValue(2)).ToString("dd-MM-yyyy");
                       string money ="";
                        money =sda.GetValue(3).ToString();

                        do
                        {
                            money = " " + money;
                        } while (money.Length < 12);

                        maskedTextBox3.Text = money;
                        numericUpDown1.Value = Int32.Parse(sda.GetValue(4).ToString());
                        comboBox1.SelectedValue = sda.GetValue(5).ToString();
                        comboBox2.SelectedValue = sda.GetValue(6).ToString();
                        comboBox3.SelectedValue = sda.GetValue(7).ToString();
                       
                    }
                }
                catch
                {
                }
            }
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
                    comboBox2.DisplayMember = "details";
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
                SqlCommand scom = new SqlCommand("execute edit_lease @id,@bd,@fp,@amt,@pays,@vehicle,@customer,@term;", sc);
                using (scom)
                {
                    scom.Parameters.Add("@id", SqlDbType.Int);
                    scom.Parameters.Add("@pays", SqlDbType.Int);
                    scom.Parameters.Add("@vehicle", SqlDbType.Int);
                    scom.Parameters.Add("@customer", SqlDbType.Int);
                    scom.Parameters.Add("@term", SqlDbType.Int);
                    scom.Parameters.Add("@amt", SqlDbType.Money);
                    scom.Parameters.Add("@bd", SqlDbType.Date);
                    scom.Parameters.Add("@fp", SqlDbType.Date);
                    scom.Parameters["@id"].Value = leaseId;
                    scom.Parameters["@bd"].Value = maskedTextBox1.Text;
                    scom.Parameters["@fp"].Value = maskedTextBox2.Text;
                    scom.Parameters["@amt"].Value = maskedTextBox3.Text;
                    scom.Parameters["@vehicle"].Value = comboBox1.SelectedValue;
                    scom.Parameters["@customer"].Value = comboBox2.SelectedValue;
                    scom.Parameters["@term"].Value = comboBox3.SelectedValue;
                    scom.Parameters["@pays"].Value = numericUpDown1.Value;
                    MessageBox.Show("Lease Edited!");
                    groupBox1.Enabled = true;
                    groupBox2.Enabled = false;
                    
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
        }

        private void button2_Click(object sender, EventArgs e)
        {
            groupBox1.Enabled = false;
            groupBox2.Enabled = true;
            leaseId = Int32.Parse(comboBox4.SelectedValue.ToString());
            gatherData();
                    
        }
    }
}
