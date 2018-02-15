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
    public partial class ComboBoxSelect : Form
    {
        
        public string selectedValueReturn;
        public bool canceled = false;
        public ComboBoxSelect()
        {
            InitializeComponent();
        }
        public ComboBoxSelect(string title,string label_message,string queryDisplayValue)
        {
           


           InitializeComponent();
           label1.Text = label_message;
           this.Text = title;
           initiate_combo(queryDisplayValue);
          
         

        }
        private void initiate_combo(string queryDisplayValue)
        {
            string[] arr = queryDisplayValue.Split('|');
            if (arr.Length == 3)
            {

              
                comboBox1.DataSource = Program.SQL.GetDataQuery(arr[0].ToString()).Tables[0];

                try
                {
                    comboBox1.DisplayMember = arr[1];
                    comboBox1.ValueMember = arr[2];
                }
                catch
                {
                    
                    MessageBox.Show("FAILED TO SET DISPLAY AND VALUE ON COMBOBOX    " + Program.SQL.command_out + " " + Program.SQL.error);


                }

            }
            else
            {
                canceled = true;
                this.Close();
            }
            if (comboBox1.Items.Count > 0)
            {
                button1.Enabled = true;

            }
            else
            {
                button1.Enabled = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            // do query here
            selectedValueReturn = comboBox1.SelectedValue.ToString();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            canceled = true;
            this.Close();
        }
    }
}
