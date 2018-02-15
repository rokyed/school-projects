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
    public partial class EditCar : Form
    {
        int vehicle_id = 0;
        public EditCar()
        {
            InitializeComponent();
            fillVehicleList();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length == 20)
            {
                SqlConnection sc = new System.Data.SqlClient.SqlConnection("Server=(local);Database=MLY5741_2;Trusted_Connection=True;");

                using (sc)
                {
                    sc.Open();
                    SqlCommand scom = new SqlCommand("execute edit_vehicle @id,@vin,@model,@type,@color,@my,@odo,@le,@auto,@elock;", sc);
                    using (scom)
                    {
                        scom.Parameters.Add("@id", SqlDbType.Int);
                        scom.Parameters.Add("@vin", SqlDbType.VarChar);
                        scom.Parameters.Add("@model", SqlDbType.Int);
                        scom.Parameters.Add("@type", SqlDbType.Int);
                        scom.Parameters.Add("@color", SqlDbType.Int);
                        scom.Parameters.Add("@my", SqlDbType.Int);
                        scom.Parameters.Add("@odo", SqlDbType.Int);
                        scom.Parameters.Add("@le", SqlDbType.Bit);
                        scom.Parameters.Add("@auto", SqlDbType.Bit);
                        scom.Parameters.Add("@elock", SqlDbType.Bit);
                        scom.Parameters["@id"].Value = vehicle_id;
                        scom.Parameters["@vin"].Value = textBox1.Text;
                        scom.Parameters["@model"].Value = comboBox4.SelectedValue;
                        scom.Parameters["@type"].Value = comboBox2.SelectedValue;
                        scom.Parameters["@color"].Value = comboBox3.SelectedValue;
                        scom.Parameters["@my"].Value = numericUpDown1.Value;
                        scom.Parameters["@odo"].Value = numericUpDown2.Value;
                        if (checkBox1.Checked == true)
                        {
                            scom.Parameters["@le"].Value = 1;
                        }
                        else
                        {
                            scom.Parameters["@le"].Value = 0;
                        }

                        if (checkBox2.Checked == true)
                        {
                            scom.Parameters["@auto"].Value = 1;
                        }
                        else
                        {
                            scom.Parameters["@auto"].Value = 0;
                        }

                        if (checkBox3.Checked == true)
                        {
                            scom.Parameters["@elock"].Value = 1;
                        }
                        else
                        {
                            scom.Parameters["@elock"].Value = 0;
                        }
                        scom.ExecuteNonQuery();
                        MessageBox.Show("Vehicle edited!");
                        fillVehicleList();
                        groupBox1.Enabled = true;
                        groupBox2.Enabled = false;

                    }
                    sc.Close();
                    
                }
            }
            else
            {
                MessageBox.Show("The VIN is not complete.");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            groupBox1.Enabled = false;
            groupBox2.Enabled = true;

            vehicle_id = Int32.Parse(comboBox1.SelectedValue.ToString());
            getExtras();
            setDataToForm();
            
        }
        private void fillVehicleList()
        {
            string queryToCall = "execute select_all_vehicles;";
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
        private void getExtras()
        {

            string queryToCall1 = "select * from model;";
            SqlConnection sc = new System.Data.SqlClient.SqlConnection("Server=(local);Database=MLY5741_2;Trusted_Connection=True;");

            using (sc)
            {
                sc.Open();
                SqlDataAdapter dataAdapter = new SqlDataAdapter(queryToCall1, sc); //c.con is the connection string
                SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);
                DataSet ds = new DataSet();
                try
                {
                    dataAdapter.Fill(ds);
                    comboBox4.DataSource = ds.Tables[0];
                    comboBox4.DisplayMember = "model";
                    comboBox4.ValueMember = "id";


                }
                catch
                {
                    // MessageBox.Show("There is nothing into the database");
                }

                sc.Close();

            }

            string queryToCall2 = "select * from car_type;";
            SqlConnection sc2 = new System.Data.SqlClient.SqlConnection("Server=(local);Database=MLY5741_2;Trusted_Connection=True;");

            using (sc2)
            {
                sc2.Open();
                SqlDataAdapter dataAdapter = new SqlDataAdapter(queryToCall2, sc2); //c.con is the connection string
                SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);
                DataSet ds = new DataSet();
                try
                {
                    dataAdapter.Fill(ds);
                    comboBox2.DataSource = ds.Tables[0];
                    comboBox2.DisplayMember = "car_type";
                    comboBox2.ValueMember = "id";

                }
                catch
                {
                    // MessageBox.Show("There is nothing into the database");
                }

                sc2.Close();

            }

            string queryToCall3 = "select id,color from color;";
            SqlConnection sc3 = new System.Data.SqlClient.SqlConnection("Server=(local);Database=MLY5741_2;Trusted_Connection=True;");

            using (sc3)
            {
                sc3.Open();
                SqlDataAdapter dataAdapter = new SqlDataAdapter(queryToCall3, sc3); //c.con is the connection string
                SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);
                DataSet ds = new DataSet();
                try
                {
                    dataAdapter.Fill(ds);
                    comboBox3.DataSource = ds.Tables[0];
                    comboBox3.DisplayMember = "color";
                    comboBox3.ValueMember = "id";



                }
                catch
                {
                    // MessageBox.Show("There is nothing into the database");
                }

                sc3.Close();


            }
        }

        private void setDataToForm()
        {
            
            string queryToCall = "select * from vehicle where id = " + comboBox1.SelectedValue + ";";
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
                        textBox1.Text = sda.GetValue(1).ToString() ;
                        numericUpDown1.Value =Int32.Parse(sda.GetValue(5).ToString());
                        numericUpDown2.Value = Int32.Parse(sda.GetValue(6).ToString());
                        if (Boolean.Parse(sda.GetValue(7).ToString()) == true)
                        {
                            checkBox1.Checked = true;
                        }
                        else
                        {
                            checkBox1.Checked = false;
                        }
                        if (Boolean.Parse(sda.GetValue(8).ToString()) == true)
                        {
                            checkBox2.Checked = true;
                        }
                        else
                        {
                            checkBox2.Checked = false;
                        }
                        if (Boolean.Parse(sda.GetValue(9).ToString()) == true)
                        {
                            checkBox3.Checked = true;
                        }
                        else
                        {
                            checkBox3.Checked = false;
                        }
                        comboBox4.SelectedValue = sda.GetValue(2).ToString();
                        comboBox2.SelectedValue = sda.GetValue(3).ToString();
                        comboBox3.SelectedValue = sda.GetValue(4).ToString();
                    }


                }
                catch
                {
                    // MessageBox.Show("There is nothing into the database");
                }

                sc.Close();

            }
        }
    }
}
