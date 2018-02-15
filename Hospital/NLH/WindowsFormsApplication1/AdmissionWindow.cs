using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SQLDataSimplifier;

namespace WindowsFormsApplication1
{
    public partial class AdmissionWindow : Form
    {

        string current_patient_id = "";
        string current_patient_age = "";
        public AdmissionWindow()
        {
            InitializeComponent();
            add_patient_insurance_fill();
            tabControl1.SelectedIndexChanged += new EventHandler(tabControl1_SelectedIndexChanged);
            fill_data_grid();
           
        }
        protected override void OnClosing(CancelEventArgs e)
        {             
            Application.Exit();


            base.OnClosing(e);

        }
        

        private void assign_patient_Click(object sender, EventArgs e)
        {
            action_pib_patient();
            fill_data_grid();
        }

        private void edit_button_Click(object sender, EventArgs e)
        {
            action_edit_patient();
            fill_data_grid();
        }

        private void add_button_Click(object sender, EventArgs e)
        {
            add_patient();
            fill_data_grid();
        }
        private void change_btn_Click(object sender, EventArgs e)
        {
            action_change_patient();
            fill_data_grid();
        }
        public void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 1)
            {
                //edit
                fill_edit_patient();
            }
            else if (tabControl1.SelectedIndex == 2)
            {
                //assign
                fill_pib_patient();
                
            }
            else if (tabControl1.SelectedIndex == 3)
            {
                //change
                fill_change_patient();

            }
            else if (tabControl1.SelectedIndex == 0)
            {
                // add
                add_patient_insurance_fill();
            }
            fill_data_grid();
        }
        

      

     
        // -------------------------------data grid view ----------------------------

        //---------------------------------ADD PATIENT -------------------------
        //------------FILL BOXES--------------------
        private void add_patient_insurance_fill()
        {
            add_name.Text = "";
            add_rel_contact.Text = "";
            add_phone.Text = "";
            add_address.Text = "";
            add_birthday.Text = "";
            add_insurance.DataSource = Program.SQL.GetDataQuery("exec select_insurance;").Tables[0];
            add_insurance.DisplayMember = "description";
            add_insurance.ValueMember = "id";
            

        }
        //------------TAKE ACTION-------------------
        private void add_patient()
        {
            if (add_name.Text != "" &&
               add_rel_contact.Text != "" &&
               add_address.Text != "" &&
                add_phone.Text != add_phone.Mask &&
                add_birthday.Text != add_birthday.Mask
               )
            {
                SQLVarContainer[] vars = {  new SQLVarContainer(SqlDbType.VarChar,"@name",add_name.Text),
                                        new SQLVarContainer(SqlDbType.VarChar,"@contact",add_rel_contact.Text),
                                        new SQLVarContainer(SqlDbType.Text,"@address",add_address.Text),
                                        new SQLVarContainer(SqlDbType.VarChar,"@phone",add_phone.Text),
                                        new SQLVarContainer(SqlDbType.Date,"@birthday",add_birthday.Text),
                                        new SQLVarContainer(SqlDbType.Int,"@insurance",add_insurance.SelectedValue.ToString())
                                   };
                Program.SQL.SetDataQuery("exec add_patient", vars, ";");
                MessageBox.Show("Patient added!");
            }
            else
            {
                MessageBox.Show("/" + add_birthday.Text.Replace(' ','@') + "/");
                MessageBox.Show("Fill all information ,please!");
            }

        }
        //---------------------------------EDIT PATIENT ------------------------- 
        //------------FILL BOXES--------------------
        private void fill_edit_patient()
        {
            ComboBoxSelect cbs = new ComboBoxSelect("Edit patient", "Select patient", "exec select_free_patients;|details|id");
            cbs.ShowDialog();
            if (cbs.canceled)
            {
                tabControl1.SelectedIndex = 0;
            }
            else
            {
                SQLVarContainer id = new SQLVarContainer(SqlDbType.Int, "@id", cbs.selectedValueReturn);

                DataSet ds = Program.SQL.GetDataQuery("exec select_patients_by_id", id, ";");
                edit_name.Text = ds.Tables[0].Rows[0]["fullname"].ToString();
                edit_rel_contact.Text = ds.Tables[0].Rows[0]["contact"].ToString();
                edit_phone.Text = ds.Tables[0].Rows[0]["phone"].ToString();
                edit_address.Text = ds.Tables[0].Rows[0]["address"].ToString();
                DateTime dt = Convert.ToDateTime(ds.Tables[0].Rows[0]["birthday"].ToString());
                dt = Convert.ToDateTime(dt.ToShortDateString());
                edit_birthday.Text =dt.ToString("yyyy-MM-dd");
                edit_insurance.DataSource = Program.SQL.GetDataQuery("exec select_insurance").Tables[0];
                edit_insurance.DisplayMember = "description";
                edit_insurance.ValueMember = "id";
                edit_insurance.SelectedValue = ds.Tables[0].Rows[0]["insurance"].ToString();
                current_patient_id = ds.Tables[0].Rows[0]["id"].ToString();
            }
        }
        //------------TAKE ACTION-------------------
        private void action_edit_patient()
        {
            if (edit_name.Text != "" &&
                edit_rel_contact.Text != "" &&
                edit_address.Text != "" &&
                 edit_phone.Text != edit_phone.Mask &&
                 edit_birthday.Text != edit_birthday.Mask
                )
            {

                SQLVarContainer[] vars = {  new SQLVarContainer(SqlDbType.Int,"@id",current_patient_id),
                                        new SQLVarContainer(SqlDbType.VarChar,"@name",edit_name.Text),
                                        new SQLVarContainer(SqlDbType.VarChar,"@contact",edit_rel_contact.Text),
                                        new SQLVarContainer(SqlDbType.Text,"@address",edit_address.Text),
                                        new SQLVarContainer(SqlDbType.VarChar,"@phone",edit_phone.Text),
                                        new SQLVarContainer(SqlDbType.Date,"@birthday",edit_birthday.Text),
                                        new SQLVarContainer(SqlDbType.Int,"@insurance",edit_insurance.SelectedValue.ToString())
                                   };
                Program.SQL.SetDataQuery("exec edit_patient", vars, ";");
                MessageBox.Show("Patient edited!");
            }
            else
            {
                MessageBox.Show("Fill all information ,please!");
            }
          
            

        }
        //---------------------------------PUT IN BED PATIENT -------------------------
        //------------FILL BOXES--------------------
        private void fill_pib_patient()
        {

            ComboBoxSelect cbs = new ComboBoxSelect("Edit patient", "Select patient", "exec select_free_patients;|details|id");
            cbs.ShowDialog();
            if (cbs.canceled)
            {
                tabControl1.SelectedIndex = 0;
            }
            else
            {
                current_patient_id = cbs.selectedValueReturn;
                SQLVarContainer id = new SQLVarContainer(SqlDbType.Int, "@id", current_patient_id);
                DataSet ds = Program.SQL.GetDataQuery("exec select_patients_by_id", id, ";");
                current_patient_age = ds.Tables[0].Rows[0]["age"].ToString();
                SQLVarContainer insurance = new SQLVarContainer(SqlDbType.Int, "@insu", ds.Tables[0].Rows[0]["insurance"].ToString());
                SQLVarContainer age = new SQLVarContainer(SqlDbType.Int, "@age", current_patient_age);
                SQLVarContainer[] vars = { insurance, age };
                assign_bed.DataSource = Program.SQL.GetDataQuery("exec select_beds_by_insurance", vars, ";").Tables[0];
                assign_bed.DisplayMember = "label";
                assign_bed.ValueMember = "id";
                assing_doctor.DataSource = Program.SQL.GetDataQuery("exec select_doctor;").Tables[0];
                assing_doctor.DisplayMember = "details";
                assing_doctor.ValueMember = "id";

            }
        }
        //------------TAKE ACTION-------------------
        private void action_pib_patient()
        {
            SQLVarContainer[] vars ={ new SQLVarContainer(SqlDbType.Int, "@id", current_patient_id),
                                  new SQLVarContainer(SqlDbType.Int, "@doc", assing_doctor.SelectedValue.ToString()),
                                   new SQLVarContainer(SqlDbType.Int, "@bed", assign_bed.SelectedValue.ToString())
                                    };
            Program.SQL.SetDataQuery("exec assign_patient", vars, ";");
            MessageBox.Show("Patient sssigned!");
            tabControl1.SelectedIndex = 0;

        }
        //---------------------------------CHANGE PATIENT -------------------------
        //------------FILL BOXES--------------------
        private void fill_change_patient()
        {
            ComboBoxSelect cbs = new ComboBoxSelect("Edit patient", "Select patient", "exec select_assigned_patients;|details|id");
            cbs.ShowDialog();
            if (cbs.canceled)
            {
                tabControl1.SelectedIndex = 0;
            }
            else
            {
                current_patient_id = cbs.selectedValueReturn;
                SQLVarContainer id = new SQLVarContainer(SqlDbType.Int, "@id", current_patient_id);
                DataSet ds = Program.SQL.GetDataQuery("exec select_patients_by_id", id, ";");
                current_patient_age = ds.Tables[0].Rows[0]["age"].ToString();
                SQLVarContainer insurance = new SQLVarContainer(SqlDbType.Int, "@insu", ds.Tables[0].Rows[0]["insurance"].ToString());
                SQLVarContainer age = new SQLVarContainer(SqlDbType.Int, "@age", current_patient_age);
                SQLVarContainer[] vars = { insurance, age };
                change_bed.DataSource = Program.SQL.GetDataQuery("exec select_beds_by_insurance", vars, ";").Tables[0];
                change_bed.DisplayMember = "label";
                change_bed.ValueMember = "id";
                change_doctor.DataSource = Program.SQL.GetDataQuery("exec select_doctor;").Tables[0];
                change_doctor.DisplayMember = "details";
                change_doctor.ValueMember = "id";
                change_bed.SelectedValue = ds.Tables[0].Rows[0]["bed"].ToString();
                change_doctor.SelectedValue = ds.Tables[0].Rows[0]["doctor"].ToString();
            }
        }
        //------------TAKE ACTION-------------------
        private void action_change_patient()
        {
            SQLVarContainer[] vars ={ new SQLVarContainer(SqlDbType.Int, "@id", current_patient_id),
                                  new SQLVarContainer(SqlDbType.Int, "@doc",change_doctor.SelectedValue.ToString()),
                                   new SQLVarContainer(SqlDbType.Int, "@bed", change_bed.SelectedValue.ToString())
                                    };
            Program.SQL.SetDataQuery("exec change_patient", vars, ";");
            MessageBox.Show("Patient changed bed!");
            tabControl1.SelectedIndex = 0;
        }
        //--------------------------------------fill datagrid----------------------------------------
        private void fill_data_grid()
        {
            dataGridView1.DataSource = Program.SQL.GetDataQuery("exec datagrid_patients;").Tables[0];
        }

        
       
    }
}
