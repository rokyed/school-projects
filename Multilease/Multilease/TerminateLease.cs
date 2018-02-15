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
    public partial class TerminateLease : Form
    {
        int leaseId = 0;
        public TerminateLease()
        {
            InitializeComponent();
            selectLeases();
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
        private void button2_Click(object sender, EventArgs e)
        {
            leaseId = Int32.Parse(comboBox4.SelectedValue.ToString());
            
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
            SqlConnection sc2 = new System.Data.SqlClient.SqlConnection("Server=(local);Database=MLY5741_2;Trusted_Connection=True;");
            using (sc2)
            {
                sc2.Open();
                SqlCommand scom = new SqlCommand("execute terminate_lease " + leaseId + ";", sc2);
                using (scom)
                {
                    scom.ExecuteNonQuery();
                }
                sc2.Close();

            }
            MessageBox.Show("Lease terminated!");
            selectLeases();

        }
    }
}
