namespace Medical_Clinic.Doctor
{
    partial class MyProfileDoctorForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.DoctorDescription = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.DoctorEmail = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.DoctorFIO = new System.Windows.Forms.TextBox();
            this.label = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.DoctorDescription);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.DoctorEmail);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.DoctorFIO);
            this.groupBox1.Controls.Add(this.label);
            this.groupBox1.Location = new System.Drawing.Point(165, 57);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(461, 290);
            this.groupBox1.TabIndex = 31;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Profile";
            // 
            // DoctorDescription
            // 
            this.DoctorDescription.Enabled = false;
            this.DoctorDescription.Location = new System.Drawing.Point(148, 154);
            this.DoctorDescription.Name = "DoctorDescription";
            this.DoctorDescription.Size = new System.Drawing.Size(282, 96);
            this.DoctorDescription.TabIndex = 21;
            this.DoctorDescription.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 20;
            this.label2.Text = "Description";
            // 
            // DoctorEmail
            // 
            this.DoctorEmail.Enabled = false;
            this.DoctorEmail.Location = new System.Drawing.Point(148, 87);
            this.DoctorEmail.Name = "DoctorEmail";
            this.DoctorEmail.Size = new System.Drawing.Size(282, 23);
            this.DoctorEmail.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 15);
            this.label1.TabIndex = 18;
            this.label1.Text = "Email";
            // 
            // DoctorFIO
            // 
            this.DoctorFIO.Enabled = false;
            this.DoctorFIO.Location = new System.Drawing.Point(148, 31);
            this.DoctorFIO.Name = "DoctorFIO";
            this.DoctorFIO.Size = new System.Drawing.Size(282, 23);
            this.DoctorFIO.TabIndex = 15;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(32, 31);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(25, 15);
            this.label.TabIndex = 16;
            this.label.Text = "FIO";
            // 
            // MyProfileDoctorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "MyProfileDoctorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MyProfileDoctorForm";
            this.Load += new System.EventHandler(this.MyProfileDoctorForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private GroupBox groupBox1;
        private TextBox DoctorFIO;
        private Label label;
        private RichTextBox DoctorDescription;
        private Label label2;
        private TextBox DoctorEmail;
        private Label label1;
    }
}