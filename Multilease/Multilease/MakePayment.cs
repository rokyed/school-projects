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
    public partial class MakePayment : Form
    {
        int leaseId = 0;
        public MakePayment()
        {
            InitializeComponent();
            selectLeases();
        }
        public void selectLeases()
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
        private void button1_Click(object sender, EventArgs e)
        {

            leaseId = Int32.Parse(comboBox1.SelectedValue.ToString());
            SqlConnection sc2 = new System.Data.SqlClient.SqlConnection("Server=(local);Database=MLY5741_2;Trusted_Connection=True;");
            using (sc2)
            {
                sc2.Open();
                SqlCommand scom = new SqlCommand("execute make_payment @id,@amt ;", sc2);
                using (scom)
                {

                    scom.Parameters.Add("@id", SqlDbType.Int);
                    scom.Parameters.Add("@amt", SqlDbType.Money);
                    scom.Parameters["@id"].Value = leaseId;
                    scom.Parameters["@amt"].Value = maskedTextBox3.Text;
                    scom.ExecuteNonQuery();
                }
                sc2.Close();
                this.Close();

            }
        }
    }
}
