using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Doctor : Form
    {
        public Doctor()
        {
            InitializeComponent();
            // initiate combobox.
            loadAssignedPatients();
        }
        protected override void OnClosing(CancelEventArgs e)
        {
            Application.Exit();


            base.OnClosing(e);

        }
        private void discharge_btn_Click(object sender, EventArgs e)
        {
            // free patient from hospital.
            SQLDataSimplifier.SQLVarContainer id= new SQLDataSimplifier.SQLVarContainer(SqlDbType.Int, "@id", comboBox1.SelectedValue.ToString());
            Program.SQL.SetDataQuery("exec free_patient ", id, ";");
            // refresh data onto combobox.
            loadAssignedPatients();
                
        }


        private void loadAssignedPatients()
        {
            // clears text into combobox.
            comboBox1.ResetText();
            // adds data into combobox.
            comboBox1.DataSource = Program.SQL.GetDataQuery("exec select_assigned_patients;").Tables[0];
            comboBox1.ValueMember = "id";
            comboBox1.DisplayMember = "details";
            // don't allow user press button if no patients into the list.
            if (comboBox1.Items.Count > 0)
            {
               
                discharge_btn.Enabled = true;
            }
            else
            {
                discharge_btn.Enabled = false;
            }

        }
    }
}
