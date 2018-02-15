namespace WindowsFormsApplication1
{
    partial class AdministratorForm
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
            this.list_doctors = new System.Windows.Forms.TabPage();
            this.doctor_grid_view = new System.Windows.Forms.DataGridView();
            this.add_doctor = new System.Windows.Forms.TabPage();
            this.add_doctor_id_textbox = new System.Windows.Forms.TextBox();
            this.add_doctor_id_label = new System.Windows.Forms.Label();
            this.add_doctor_fullname_textbox = new System.Windows.Forms.TextBox();
            this.add_doctor_fullname_label = new System.Windows.Forms.Label();
            this.add_doctor_button = new System.Windows.Forms.Button();
            this.delete_doctor = new System.Windows.Forms.TabPage();
            this.remove_doctor_combo_label = new System.Windows.Forms.Label();
            this.remove_doctor_combo = new System.Windows.Forms.ComboBox();
            this.remove_doctor_button = new System.Windows.Forms.Button();
            this.pass = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pass_c = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.list_doctors.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.doctor_grid_view)).BeginInit();
            this.add_doctor.SuspendLayout();
            this.delete_doctor.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.list_doctors);
            this.tabControl1.Controls.Add(this.add_doctor);
            this.tabControl1.Controls.Add(this.delete_doctor);
            this.tabControl1.Location = new System.Drawing.Point(13, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(316, 282);
            this.tabControl1.TabIndex = 0;
            // 
            // list_doctors
            // 
            this.list_doctors.Controls.Add(this.doctor_grid_view);
            this.list_doctors.Location = new System.Drawing.Point(4, 22);
            this.list_doctors.Name = "list_doctors";
            this.list_doctors.Padding = new System.Windows.Forms.Padding(3);
            this.list_doctors.Size = new System.Drawing.Size(308, 256);
            this.list_doctors.TabIndex = 0;
            this.list_doctors.Text = "List Doctors";
            this.list_doctors.UseVisualStyleBackColor = true;
            // 
            // doctor_grid_view
            // 
            this.doctor_grid_view.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.doctor_grid_view.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.doctor_grid_view.Location = new System.Drawing.Point(6, 6);
            this.doctor_grid_view.Name = "doctor_grid_view";
            this.doctor_grid_view.Size = new System.Drawing.Size(296, 244);
            this.doctor_grid_view.TabIndex = 0;
            // 
            // add_doctor
            // 
            this.add_doctor.Controls.Add(this.label2);
            this.add_doctor.Controls.Add(this.pass_c);
            this.add_doctor.Controls.Add(this.label1);
            this.add_doctor.Controls.Add(this.pass);
            this.add_doctor.Controls.Add(this.add_doctor_id_textbox);
            this.add_doctor.Controls.Add(this.add_doctor_id_label);
            this.add_doctor.Controls.Add(this.add_doctor_fullname_textbox);
            this.add_doctor.Controls.Add(this.add_doctor_fullname_label);
            this.add_doctor.Controls.Add(this.add_doctor_button);
            this.add_doctor.Location = new System.Drawing.Point(4, 22);
            this.add_doctor.Name = "add_doctor";
            this.add_doctor.Padding = new System.Windows.Forms.Padding(3);
            this.add_doctor.Size = new System.Drawing.Size(308, 256);
            this.add_doctor.TabIndex = 1;
            this.add_doctor.Text = "Add Doctor";
            this.add_doctor.UseVisualStyleBackColor = true;
            // 
            // add_doctor_id_textbox
            // 
            this.add_doctor_id_textbox.Location = new System.Drawing.Point(6, 55);
            this.add_doctor_id_textbox.MaxLength = 25;
            this.add_doctor_id_textbox.Name = "add_doctor_id_textbox";
            this.add_doctor_id_textbox.Size = new System.Drawing.Size(100, 20);
            this.add_doctor_id_textbox.TabIndex = 4;
            // 
            // add_doctor_id_label
            // 
            this.add_doctor_id_label.AutoSize = true;
            this.add_doctor_id_label.Location = new System.Drawing.Point(3, 39);
            this.add_doctor_id_label.Name = "add_doctor_id_label";
            this.add_doctor_id_label.Size = new System.Drawing.Size(56, 13);
            this.add_doctor_id_label.TabIndex = 3;
            this.add_doctor_id_label.Text = "Doctor ID:";
            // 
            // add_doctor_fullname_textbox
            // 
            this.add_doctor_fullname_textbox.Location = new System.Drawing.Point(6, 16);
            this.add_doctor_fullname_textbox.MaxLength = 100;
            this.add_doctor_fullname_textbox.Name = "add_doctor_fullname_textbox";
            this.add_doctor_fullname_textbox.Size = new System.Drawing.Size(100, 20);
            this.add_doctor_fullname_textbox.TabIndex = 2;
            // 
            // add_doctor_fullname_label
            // 
            this.add_doctor_fullname_label.AutoSize = true;
            this.add_doctor_fullname_label.Location = new System.Drawing.Point(3, 0);
            this.add_doctor_fullname_label.Name = "add_doctor_fullname_label";
            this.add_doctor_fullname_label.Size = new System.Drawing.Size(55, 13);
            this.add_doctor_fullname_label.TabIndex = 1;
            this.add_doctor_fullname_label.Text = "Full name:";
            // 
            // add_doctor_button
            // 
            this.add_doctor_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.add_doctor_button.Location = new System.Drawing.Point(227, 226);
            this.add_doctor_button.Name = "add_doctor_button";
            this.add_doctor_button.Size = new System.Drawing.Size(75, 23);
            this.add_doctor_button.TabIndex = 0;
            this.add_doctor_button.Text = "Add Doctor";
            this.add_doctor_button.UseVisualStyleBackColor = true;
            this.add_doctor_button.Click += new System.EventHandler(this.add_doctor_button_Click);
            // 
            // delete_doctor
            // 
            this.delete_doctor.Controls.Add(this.remove_doctor_combo_label);
            this.delete_doctor.Controls.Add(this.remove_doctor_combo);
            this.delete_doctor.Controls.Add(this.remove_doctor_button);
            this.delete_doctor.Location = new System.Drawing.Point(4, 22);
            this.delete_doctor.Name = "delete_doctor";
            this.delete_doctor.Padding = new System.Windows.Forms.Padding(3);
            this.delete_doctor.Size = new System.Drawing.Size(308, 256);
            this.delete_doctor.TabIndex = 2;
            this.delete_doctor.Text = "Remove Doctor";
            this.delete_doctor.UseVisualStyleBackColor = true;
            // 
            // remove_doctor_combo_label
            // 
            this.remove_doctor_combo_label.AutoSize = true;
            this.remove_doctor_combo_label.Location = new System.Drawing.Point(7, 7);
            this.remove_doctor_combo_label.Name = "remove_doctor_combo_label";
            this.remove_doctor_combo_label.Size = new System.Drawing.Size(132, 13);
            this.remove_doctor_combo_label.TabIndex = 2;
            this.remove_doctor_combo_label.Text = "Select a doctor to remove:";
            // 
            // remove_doctor_combo
            // 
            this.remove_doctor_combo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.remove_doctor_combo.FormattingEnabled = true;
            this.remove_doctor_combo.Location = new System.Drawing.Point(6, 26);
            this.remove_doctor_combo.Name = "remove_doctor_combo";
            this.remove_doctor_combo.Size = new System.Drawing.Size(295, 21);
            this.remove_doctor_combo.TabIndex = 1;
            // 
            // remove_doctor_button
            // 
            this.remove_doctor_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.remove_doctor_button.Location = new System.Drawing.Point(227, 226);
            this.remove_doctor_button.Name = "remove_doctor_button";
            this.remove_doctor_button.Size = new System.Drawing.Size(75, 23);
            this.remove_doctor_button.TabIndex = 0;
            this.remove_doctor_button.Text = "Remove";
            this.remove_doctor_button.UseVisualStyleBackColor = true;
            this.remove_doctor_button.Click += new System.EventHandler(this.remove_doctor_button_Click);
            // 
            // pass
            // 
            this.pass.Location = new System.Drawing.Point(6, 94);
            this.pass.MaxLength = 100;
            this.pass.Name = "pass";
            this.pass.PasswordChar = '.';
            this.pass.Size = new System.Drawing.Size(100, 20);
            this.pass.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Password:";
            // 
            // pass_c
            // 
            this.pass_c.Location = new System.Drawing.Point(6, 133);
            this.pass_c.MaxLength = 100;
            this.pass_c.Name = "pass_c";
            this.pass_c.PasswordChar = '.';
            this.pass_c.Size = new System.Drawing.Size(100, 20);
            this.pass_c.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Confirm:";
            // 
            // AdministratorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(341, 306);
            this.Controls.Add(this.tabControl1);
            this.MinimumSize = new System.Drawing.Size(357, 344);
            this.Name = "AdministratorForm";
            this.Text = "Administrator";
            this.tabControl1.ResumeLayout(false);
            this.list_doctors.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.doctor_grid_view)).EndInit();
            this.add_doctor.ResumeLayout(false);
            this.add_doctor.PerformLayout();
            this.delete_doctor.ResumeLayout(false);
            this.delete_doctor.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage list_doctors;
        private System.Windows.Forms.TabPage add_doctor;
        private System.Windows.Forms.TabPage delete_doctor;
        private System.Windows.Forms.Button add_doctor_button;
        private System.Windows.Forms.ComboBox remove_doctor_combo;
        private System.Windows.Forms.Button remove_doctor_button;
        private System.Windows.Forms.DataGridView doctor_grid_view;
        private System.Windows.Forms.TextBox add_doctor_id_textbox;
        private System.Windows.Forms.Label add_doctor_id_label;
        private System.Windows.Forms.TextBox add_doctor_fullname_textbox;
        private System.Windows.Forms.Label add_doctor_fullname_label;
        private System.Windows.Forms.Label remove_doctor_combo_label;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox pass_c;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox pass;
    }
}