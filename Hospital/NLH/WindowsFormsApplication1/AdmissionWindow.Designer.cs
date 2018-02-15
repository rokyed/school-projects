namespace WindowsFormsApplication1
{
    partial class AdmissionWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.add_insurance = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.add_birthday = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.add_phone = new System.Windows.Forms.MaskedTextBox();
            this.add_address = new System.Windows.Forms.TextBox();
            this.add_rel_contact = new System.Windows.Forms.TextBox();
            this.add_name = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.add_button = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.edit_insurance = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.edit_birthday = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.edit_phone = new System.Windows.Forms.MaskedTextBox();
            this.edit_address = new System.Windows.Forms.TextBox();
            this.edit_rel_contact = new System.Windows.Forms.TextBox();
            this.edit_name = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.edit_button = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label18 = new System.Windows.Forms.Label();
            this.assing_doctor = new System.Windows.Forms.ComboBox();
            this.assign_bed = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.assign_patient = new System.Windows.Forms.Button();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.change_doctor = new System.Windows.Forms.ComboBox();
            this.change_bed = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.change_btn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(325, 505);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.add_insurance);
            this.tabPage1.Controls.Add(this.label16);
            this.tabPage1.Controls.Add(this.add_birthday);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.add_phone);
            this.tabPage1.Controls.Add(this.add_address);
            this.tabPage1.Controls.Add(this.add_rel_contact);
            this.tabPage1.Controls.Add(this.add_name);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.add_button);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(317, 479);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Add Patient";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // add_insurance
            // 
            this.add_insurance.FormattingEnabled = true;
            this.add_insurance.Location = new System.Drawing.Point(170, 133);
            this.add_insurance.Name = "add_insurance";
            this.add_insurance.Size = new System.Drawing.Size(141, 21);
            this.add_insurance.TabIndex = 34;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(107, 136);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(57, 13);
            this.label16.TabIndex = 33;
            this.label16.Text = "Insurance:";
            // 
            // add_birthday
            // 
            this.add_birthday.Location = new System.Drawing.Point(173, 107);
            this.add_birthday.Mask = "0000-00-00";
            this.add_birthday.Name = "add_birthday";
            this.add_birthday.Size = new System.Drawing.Size(141, 20);
            this.add_birthday.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(119, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Birthday:";
            // 
            // add_phone
            // 
            this.add_phone.Location = new System.Drawing.Point(173, 81);
            this.add_phone.Mask = "(999) 000-0000";
            this.add_phone.Name = "add_phone";
            this.add_phone.Size = new System.Drawing.Size(141, 20);
            this.add_phone.TabIndex = 10;
            // 
            // add_address
            // 
            this.add_address.Location = new System.Drawing.Point(173, 55);
            this.add_address.MaxLength = 10000;
            this.add_address.Name = "add_address";
            this.add_address.Size = new System.Drawing.Size(141, 20);
            this.add_address.TabIndex = 9;
            // 
            // add_rel_contact
            // 
            this.add_rel_contact.Location = new System.Drawing.Point(173, 29);
            this.add_rel_contact.MaxLength = 100;
            this.add_rel_contact.Name = "add_rel_contact";
            this.add_rel_contact.Size = new System.Drawing.Size(141, 20);
            this.add_rel_contact.TabIndex = 8;
            // 
            // add_name
            // 
            this.add_name.Location = new System.Drawing.Point(173, 3);
            this.add_name.MaxLength = 100;
            this.add_name.Name = "add_name";
            this.add_name.Size = new System.Drawing.Size(141, 20);
            this.add_name.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(119, 58);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Address:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(126, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Phone:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(81, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Related contact:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(129, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name:";
            // 
            // add_button
            // 
            this.add_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.add_button.Location = new System.Drawing.Point(239, 453);
            this.add_button.Name = "add_button";
            this.add_button.Size = new System.Drawing.Size(75, 23);
            this.add_button.TabIndex = 0;
            this.add_button.Text = "Add";
            this.add_button.UseVisualStyleBackColor = true;
            this.add_button.Click += new System.EventHandler(this.add_button_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.edit_insurance);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.edit_birthday);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.edit_phone);
            this.tabPage2.Controls.Add(this.edit_address);
            this.tabPage2.Controls.Add(this.edit_rel_contact);
            this.tabPage2.Controls.Add(this.edit_name);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.label13);
            this.tabPage2.Controls.Add(this.label14);
            this.tabPage2.Controls.Add(this.edit_button);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(317, 479);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Edit Patient";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // edit_insurance
            // 
            this.edit_insurance.FormattingEnabled = true;
            this.edit_insurance.Location = new System.Drawing.Point(173, 133);
            this.edit_insurance.Name = "edit_insurance";
            this.edit_insurance.Size = new System.Drawing.Size(141, 21);
            this.edit_insurance.TabIndex = 34;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(110, 136);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(57, 13);
            this.label10.TabIndex = 33;
            this.label10.Text = "Insurance:";
            // 
            // edit_birthday
            // 
            this.edit_birthday.Location = new System.Drawing.Point(173, 107);
            this.edit_birthday.Mask = "0000-00-00";
            this.edit_birthday.Name = "edit_birthday";
            this.edit_birthday.Size = new System.Drawing.Size(141, 20);
            this.edit_birthday.TabIndex = 27;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(119, 110);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 13);
            this.label5.TabIndex = 26;
            this.label5.Text = "Birthday:";
            // 
            // edit_phone
            // 
            this.edit_phone.Location = new System.Drawing.Point(173, 81);
            this.edit_phone.Mask = "(999) 000-0000";
            this.edit_phone.Name = "edit_phone";
            this.edit_phone.Size = new System.Drawing.Size(141, 20);
            this.edit_phone.TabIndex = 25;
            // 
            // edit_address
            // 
            this.edit_address.Location = new System.Drawing.Point(173, 55);
            this.edit_address.MaxLength = 10000;
            this.edit_address.Name = "edit_address";
            this.edit_address.Size = new System.Drawing.Size(141, 20);
            this.edit_address.TabIndex = 24;
            // 
            // edit_rel_contact
            // 
            this.edit_rel_contact.Location = new System.Drawing.Point(173, 29);
            this.edit_rel_contact.MaxLength = 100;
            this.edit_rel_contact.Name = "edit_rel_contact";
            this.edit_rel_contact.Size = new System.Drawing.Size(141, 20);
            this.edit_rel_contact.TabIndex = 23;
            // 
            // edit_name
            // 
            this.edit_name.Location = new System.Drawing.Point(173, 3);
            this.edit_name.MaxLength = 100;
            this.edit_name.Name = "edit_name";
            this.edit_name.Size = new System.Drawing.Size(141, 20);
            this.edit_name.TabIndex = 22;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(119, 58);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 13);
            this.label9.TabIndex = 21;
            this.label9.Text = "Address:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(126, 84);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(41, 13);
            this.label12.TabIndex = 18;
            this.label12.Text = "Phone:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(81, 32);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(86, 13);
            this.label13.TabIndex = 17;
            this.label13.Text = "Related contact:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(129, 6);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(38, 13);
            this.label14.TabIndex = 16;
            this.label14.Text = "Name:";
            // 
            // edit_button
            // 
            this.edit_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.edit_button.Location = new System.Drawing.Point(239, 453);
            this.edit_button.Name = "edit_button";
            this.edit_button.Size = new System.Drawing.Size(75, 23);
            this.edit_button.TabIndex = 15;
            this.edit_button.Text = "Edit";
            this.edit_button.UseVisualStyleBackColor = true;
            this.edit_button.Click += new System.EventHandler(this.edit_button_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.label18);
            this.tabPage3.Controls.Add(this.assing_doctor);
            this.tabPage3.Controls.Add(this.assign_bed);
            this.tabPage3.Controls.Add(this.label15);
            this.tabPage3.Controls.Add(this.assign_patient);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(317, 479);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Assing to bed";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(125, 6);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(42, 13);
            this.label18.TabIndex = 34;
            this.label18.Text = "Doctor:";
            // 
            // assing_doctor
            // 
            this.assing_doctor.FormattingEnabled = true;
            this.assing_doctor.Location = new System.Drawing.Point(173, 3);
            this.assing_doctor.Name = "assing_doctor";
            this.assing_doctor.Size = new System.Drawing.Size(141, 21);
            this.assing_doctor.TabIndex = 33;
            // 
            // assign_bed
            // 
            this.assign_bed.FormattingEnabled = true;
            this.assign_bed.Location = new System.Drawing.Point(173, 30);
            this.assign_bed.Name = "assign_bed";
            this.assign_bed.Size = new System.Drawing.Size(141, 21);
            this.assign_bed.TabIndex = 28;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(138, 33);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(29, 13);
            this.label15.TabIndex = 27;
            this.label15.Text = "Bed:";
            // 
            // assign_patient
            // 
            this.assign_patient.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.assign_patient.Location = new System.Drawing.Point(239, 453);
            this.assign_patient.Name = "assign_patient";
            this.assign_patient.Size = new System.Drawing.Size(75, 23);
            this.assign_patient.TabIndex = 16;
            this.assign_patient.Text = "Assign";
            this.assign_patient.UseVisualStyleBackColor = true;
            this.assign_patient.Click += new System.EventHandler(this.assign_patient_Click);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.label7);
            this.tabPage4.Controls.Add(this.change_doctor);
            this.tabPage4.Controls.Add(this.change_bed);
            this.tabPage4.Controls.Add(this.label11);
            this.tabPage4.Controls.Add(this.change_btn);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(317, 479);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Change bed";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(125, 6);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 13);
            this.label7.TabIndex = 43;
            this.label7.Text = "Doctor:";
            // 
            // change_doctor
            // 
            this.change_doctor.FormattingEnabled = true;
            this.change_doctor.Location = new System.Drawing.Point(173, 3);
            this.change_doctor.Name = "change_doctor";
            this.change_doctor.Size = new System.Drawing.Size(141, 21);
            this.change_doctor.TabIndex = 42;
            // 
            // change_bed
            // 
            this.change_bed.FormattingEnabled = true;
            this.change_bed.Location = new System.Drawing.Point(173, 30);
            this.change_bed.Name = "change_bed";
            this.change_bed.Size = new System.Drawing.Size(141, 21);
            this.change_bed.TabIndex = 37;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(138, 33);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(29, 13);
            this.label11.TabIndex = 36;
            this.label11.Text = "Bed:";
            // 
            // change_btn
            // 
            this.change_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.change_btn.Location = new System.Drawing.Point(239, 453);
            this.change_btn.Name = "change_btn";
            this.change_btn.Size = new System.Drawing.Size(75, 23);
            this.change_btn.TabIndex = 35;
            this.change_btn.Text = "Change";
            this.change_btn.UseVisualStyleBackColor = true;
            this.change_btn.Click += new System.EventHandler(this.change_btn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(343, 34);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(579, 483);
            this.dataGridView1.TabIndex = 3;
            // 
            // AdmissionWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 529);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.tabControl1);
            this.MinimumSize = new System.Drawing.Size(950, 567);
            this.Name = "AdmissionWindow";
            this.Text = "Admission";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.MaskedTextBox edit_phone;
        private System.Windows.Forms.TextBox edit_address;
        private System.Windows.Forms.TextBox edit_rel_contact;
        private System.Windows.Forms.TextBox edit_name;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button edit_button;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.ComboBox assign_bed;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button assign_patient;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.ComboBox assing_doctor;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.MaskedTextBox add_phone;
        private System.Windows.Forms.TextBox add_address;
        private System.Windows.Forms.TextBox add_rel_contact;
        private System.Windows.Forms.TextBox add_name;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button add_button;
        private System.Windows.Forms.MaskedTextBox add_birthday;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox edit_birthday;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox change_doctor;
        private System.Windows.Forms.ComboBox change_bed;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button change_btn;
        private System.Windows.Forms.ComboBox add_insurance;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox edit_insurance;
        private System.Windows.Forms.Label label10;
    }
}