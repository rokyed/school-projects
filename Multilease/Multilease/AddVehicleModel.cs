﻿using System;
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
    public partial class AddVehicleModel : Form
    {
        public AddVehicleModel()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection sc = new System.Data.SqlClient.SqlConnection("Server=(local);Database=MLY5741_2;Trusted_Connection=True;");

            using (sc)
            {
                sc.Open();
                SqlCommand scom = new SqlCommand("execute add_model @mkm;", sc);
                using (scom)
                {
                    scom.Parameters.Add("@mkm", SqlDbType.VarChar);
                    scom.Parameters["@mkm"].Value = vehicle_model.Text;

                    scom.ExecuteNonQuery();
                }
                sc.Close();
                this.Close();
            }
        }

        
    }
}
