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
    public partial class AddVehicle : Form
    {
        public AddVehicle()
        {
            InitializeComponent();
            comboBox1Fill();
            comboBox2Fill();
            comboBox3Fill();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (textBox1.Text.Length == 20)
            {
                SqlConnection sc = new System.Data.SqlClient.SqlConnection("Server=(local);Database=MLY5741_2;Trusted_Connection=True;");

                using (sc)
                {
                    sc.Open();
                    SqlCommand scom = new SqlCommand("execute add_vehicle @vin,@model,@type,@color,@my,@odo,@le,@auto,@elock;", sc);
                    using (scom)
                    {
                        scom.Parameters.Add("@vin", SqlDbType.VarChar);
                        scom.Parameters.Add("@model", SqlDbType.Int);
                        scom.Parameters.Add("@type", SqlDbType.Int);
                        scom.Parameters.Add("@color", SqlDbType.Int);
                        scom.Parameters.Add("@my", SqlDbType.Int);
                        scom.Parameters.Add("@odo", SqlDbType.Int);
                        scom.Parameters.Add("@le", SqlDbType.Bit);
                        scom.Parameters.Add("@auto", SqlDbType.Bit);
                        scom.Parameters.Add("@elock", SqlDbType.Bit);
                        scom.Parameters["@vin"].Value = textBox1.Text;
                        scom.Parameters["@model"].Value = comboBox1.SelectedValue;
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
                    }
                    sc.Close();
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("The VIN is not complete.");
            }
        }
        private void comboBox1Fill()
        {
            string queryToCall = "select * from model;";
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
                    comboBox1.DisplayMember = "model";
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
            string queryToCall = "select * from car_type;";
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
                    comboBox2.DisplayMember = "car_type";
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
            string queryToCall = "select id,color from color;";
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
                    comboBox3.DisplayMember = "color";
                    comboBox3.ValueMember = "id";
                   
                    

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
