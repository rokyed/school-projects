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
    public partial class Menu : Form
    {
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            Application.Exit();
            base.OnFormClosing(e);
        }
        public Menu()
        {
            InitializeComponent();
            SetPrivileges();
           
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            AddCustomer ac = new AddCustomer();
            ac.Show();
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void SetPrivileges()
        {
            if (Program.privileges != "" && Program.privileges.Length >= 13)
            {
                //disable buttons 
                button1.Enabled = false;
                button2.Enabled = false;
                button21.Enabled = false;
                button6.Enabled = false;
                button7.Enabled = false;
                button8.Enabled = false;
                button9.Enabled = false;
                button10.Enabled = false;
                button11.Enabled = false;
                button12.Enabled = false;
                button3.Enabled = false;
                button3.Visible = false;
                // now activate on need:
                for (int i = 0; i < Program.privileges.Length; i++)
                {
                    string subString = Program.privileges.Substring(i, 1);
                    switch (i)
                    {
                        case 0:
                            if (subString == "y")
                            {
                                button6.Enabled = true;
                                button9.Enabled = true;
                                button10.Enabled = true;
                                button21.Enabled = true;
                            }
                            break;
                        case 1:
                            if (subString == "y")
                            {
                                button12.Enabled = true;
                                
                            }
                            break;
                        case 2:
                            if (subString == "y")
                            {
                                button17.Enabled = true;

                            }
                            break;
                       
                        case 4:
                            if (subString == "y")
                            {
                                button1.Enabled = true;
                                button2.Enabled = true;
                                button11.Enabled = true;
                            }
                            break;
                        case 5:
                            if (subString == "y")
                            {
                                button12.Enabled = true;
                                button3.Enabled = true;
                                button3.Visible = true;
                               

                            }
                            break;
                        case 6:
                            if (subString == "y")
                            {
                                button15.Enabled = true;
                                button16.Enabled = true;
                            }
                            break;
                     
                        case 8:
                            if (subString == "y")
                            {
                                button13.Enabled = true;

                            }
                            break;
                        case 9:
                            if (subString == "y")
                            {
                                button8.Enabled = true;

                            }
                            break;
                        case 10:
                            if (subString == "y")
                            {
                                button7.Enabled = true;

                            }
                            break;
                        case 11:
                            if (subString == "y")
                            {
                                
                            }
                            break;
                       
                        
                        default:
                            break;
                    }
                }

            }
            else
            {
                //disable buttons 
                button1.Enabled = false;
                button2.Enabled = false;
                button21.Enabled = false;
                button6.Enabled = false;
                button7.Enabled = false;
                button8.Enabled = false;
                button9.Enabled = false;
                button10.Enabled = false;
                button11.Enabled = false;
                button12.Enabled = false;
            }
        }

        private void button20_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            AddVehicle veh_add = new AddVehicle();
            veh_add.Show();
           
        }

        private void button11_Click(object sender, EventArgs e)
        {
            AddTerm at = new AddTerm();
            at.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            AddColor ac = new AddColor();
            ac.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            AddVehicleModel avm = new AddVehicleModel();
            avm.Show();
        }

        

        private void button21_Click(object sender, EventArgs e)
        {
            AddVehicleType avt = new AddVehicleType();
            avt.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AddLease al = new AddLease();
            al.Show();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            DeleteForm df = new DeleteForm();
            df.Show();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            EditCar ec = new EditCar();
            ec.Show();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            EditCustomer ecu = new EditCustomer();
            ecu.Show();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            EditLease el = new EditLease();
            el.Show();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            TerminateLease tl = new TerminateLease();
            tl.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            MakePayment mp = new MakePayment();
            mp.Show();
        }

        private string queryQ = "Select * from leases";

        private void vleases_Click(object sender, EventArgs e)
        {
            initiateQuery("execute select_leases_full_data");
        }

        private void vcust_Click(object sender, EventArgs e)
        {
            initiateQuery("Select * from customer");
        }
        private void initiateQuery(string queryToCall)
        {
            queryQ = queryToCall;

            SqlConnection sc = new System.Data.SqlClient.SqlConnection("Server=(local);Database=MLY5741_2;Trusted_Connection=True;");

            using (sc)
            {
                sc.Open();
                SqlDataAdapter dataAdapter = new SqlDataAdapter(queryToCall, sc); //c.con is the connection string
                SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);

                DataTable dt = new DataTable();
                DataSet ds = new DataSet();
                try
                {
                    dataAdapter.Fill(ds);
                    dgv.ReadOnly = true;
                    dgv.DataSource = ds.Tables[0];
                }
                catch
                {
                    MessageBox.Show("There is nothing into the database");
                }

                sc.Close();

            }
        }

        private void vpay_Click(object sender, EventArgs e)
        {
            initiateQuery("Select * from payments");
        }

        private void vveh_Click(object sender, EventArgs e)
        {
            initiateQuery("execute select_all_vehicles_detailed");
        }

        private void vterms_Click(object sender, EventArgs e)
        {
            initiateQuery("Select * from terms");
        }

        private void vmodel_Click(object sender, EventArgs e)
        {
            initiateQuery("Select * from model");
        }

        private void vtype_Click(object sender, EventArgs e)
        {
            initiateQuery("Select * from car_type");
        }

        private void vcolor_Click(object sender, EventArgs e)
        {
            initiateQuery("Select * from color");
        }

      

        private void timer1_Tick(object sender, EventArgs e)
        {
            initiateQuery(queryQ);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            initiateQuery("Select * from payments");
            VoidPayment vp = new VoidPayment();
            vp.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            initiateQuery("select * from audit");
        }

        

    }
}
