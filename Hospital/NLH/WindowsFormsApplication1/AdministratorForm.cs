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
    public partial class AdministratorForm : Form
    {
        public AdministratorForm()
        {
            InitializeComponent();
            tabControl1.SelectedIndexChanged += new EventHandler(tabControl1_SelectedIndexChanged);
            fillDoctorList();
            fillRemove();
        }
        // force program exit on form close
        protected override void OnClosing(CancelEventArgs e)
        {
            Application.Exit();
            base.OnClosing(e);
        }

        public void fillDoctorList()
        {
            doctor_grid_view.DataSource = Program.SQL.GetDataQuery("exec select_doctor;").Tables[0];
        }
        public void fillRemove()
        {
            //clear and fill the combo 
            remove_doctor_combo.ResetText();
            remove_doctor_combo.DataSource = Program.SQL.GetDataQuery("exec select_doctor_to_delete").Tables[0];
            remove_doctor_combo.ValueMember = "id";
            remove_doctor_combo.DisplayMember = "details";
            //prevent user from deleting nothing.
            if (remove_doctor_combo.Items.Count > 0)
            {
                remove_doctor_button.Enabled = true;
            }
            else
            {
                remove_doctor_button.Enabled = false;
            }

        }
        
        public void tabControl1_SelectedIndexChanged(object sender , EventArgs e)
        {
            if (tabControl1.SelectedIndex == 0)
            {
                fillDoctorList();


            }
            else if (tabControl1.SelectedIndex == 2)
            {
                fillRemove();
            }
        }

        private void add_doctor_button_Click(object sender, EventArgs e)
        {
            // do check if fields are empty  and password matches.
            if (add_doctor_fullname_textbox.Text != "" && add_doctor_id_textbox.Text != "")
            {
                if (pass.Text == pass_c.Text)
                {
                    SQLDataSimplifier.SQLVarContainer[] vars = { new SQLDataSimplifier.SQLVarContainer(SqlDbType.VarChar,"@docid",add_doctor_id_textbox.Text),
                                                            new SQLDataSimplifier.SQLVarContainer(SqlDbType.VarChar,"@name",add_doctor_fullname_textbox.Text),
                                                            new SQLDataSimplifier.SQLVarContainer(SqlDbType.VarChar,"@pass",pass.Text)};
                    Program.SQL.SetDataQuery("exec add_doctor ", vars, ";");
                    add_doctor_id_textbox.Text = "";
                    add_doctor_fullname_textbox.Text = "";
                    pass.Text = "";
                    pass_c.Text = "";
                }
                else
                {
                    MessageBox.Show("Password does not match the confirmation");
                    pass.Text = "";
                    pass_c.Text = "";
                }
            }
            else
            {
                MessageBox.Show("Fields are empty, please fill them");
            }
        }

        private void remove_doctor_button_Click(object sender, EventArgs e)
        {
            SQLDataSimplifier.SQLVarContainer[] vars = {new SQLDataSimplifier.SQLVarContainer(SqlDbType.Int,"@id",remove_doctor_combo.SelectedValue.ToString())
                                                       };
            Program.SQL.SetDataQuery("exec delete_doctor",vars,";");
            fillRemove();
        }
    }
}
