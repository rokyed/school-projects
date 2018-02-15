namespace WindowsFormsApplication1
{
    partial class Doctor
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
            this.discharge_btn = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // discharge_btn
            // 
            this.discharge_btn.Location = new System.Drawing.Point(386, 10);
            this.discharge_btn.Name = "discharge_btn";
            this.discharge_btn.Size = new System.Drawing.Size(75, 23);
            this.discharge_btn.TabIndex = 0;
            this.discharge_btn.Text = "Discharge";
            this.discharge_btn.UseVisualStyleBackColor = true;
            this.discharge_btn.Click += new System.EventHandler(this.discharge_btn_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(12, 12);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(368, 21);
            this.comboBox1.TabIndex = 1;
            // 
            // Doctor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 50);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.discharge_btn);
            this.Name = "Doctor";
            this.Text = "Doctor";
            
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button discharge_btn;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}