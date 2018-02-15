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
    public partial class VoidPayment : Form
    {
        public VoidPayment()
        {
            InitializeComponent();
            comboBox1Fill();
        }
        private void comboBox1Fill()
        {
            string queryToCall = "Select id from payments;";
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
                    comboBox1.DisplayMember = "id";
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

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection sc = new System.Data.SqlClient.SqlConnection("Server=(local);Database=MLY5741_2;Trusted_Connection=True;");
            using (sc)
            {
                sc.Open();
                SqlCommand scom = new SqlCommand("execute void_payment "+comboBox1.SelectedValue+";", sc);
                using (scom)
                {
                    scom.ExecuteNonQuery();
                    MessageBox.Show("Payment voided!");
                    this.Close();
                }
                sc.Close();

            }
        }
    }
}
