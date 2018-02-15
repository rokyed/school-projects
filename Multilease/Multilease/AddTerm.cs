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
    public partial class AddTerm : Form
    {
        public AddTerm()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection sc = new System.Data.SqlClient.SqlConnection("Server=(local);Database=MLY5741_2;Trusted_Connection=True;");
        
            using (sc)
            {
                sc.Open();
                SqlCommand scom = new SqlCommand("insert into terms(max_km,extra,no_years) values (@mkm,@ext,@yr);", sc);
                using (scom)
                {
                    scom.Parameters.Add("@mkm", SqlDbType.Int);
                    scom.Parameters["@mkm"].Value = numericUpDown1.Value;
                    scom.Parameters.Add("@yr", SqlDbType.Int);
                    scom.Parameters["@yr"].Value = numericUpDown2.Value;
                    scom.Parameters.Add("@ext", SqlDbType.Money);
                    scom.Parameters["@ext"].Value = maskedTextBox1.Text;
                    scom.ExecuteNonQuery();
                }
                sc.Close();
                this.Close();
            }
        }

        private void AddTerm_Load(object sender, EventArgs e)
        {

        }
    }
}
