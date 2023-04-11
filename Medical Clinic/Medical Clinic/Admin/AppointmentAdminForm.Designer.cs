namespace Medical_Clinic.Admin
{
    partial class AppointmentAdminForm
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
            this.makeButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Service = new System.Windows.Forms.ComboBox();
            this.Doctor = new System.Windows.Forms.ComboBox();
            this.Patient = new System.Windows.Forms.ComboBox();
            this.Date = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // makeButton
            // 
            this.makeButton.Location = new System.Drawing.Point(362, 310);
            this.makeButton.Name = "makeButton";
            this.makeButton.Size = new System.Drawing.Size(139, 23);
            this.makeButton.TabIndex = 20;
            this.makeButton.Text = "Make";
            this.makeButton.UseVisualStyleBackColor = true;
            this.makeButton.Click += new System.EventHandler(this.makeButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(507, 310);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(139, 23);
            this.cancelButton.TabIndex = 19;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(120, 240);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 15);
            this.label4.TabIndex = 18;
            this.label4.Text = "Patient";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(120, 193);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 15);
            this.label3.TabIndex = 17;
            this.label3.Text = "Service";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(120, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 15);
            this.label2.TabIndex = 16;
            this.label2.Text = "Doctor";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(120, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 15);
            this.label1.TabIndex = 15;
            this.label1.Text = "Date";
            // 
            // Service
            // 
            this.Service.FormattingEnabled = true;
            this.Service.Location = new System.Drawing.Point(286, 193);
            this.Service.Name = "Service";
            this.Service.Size = new System.Drawing.Size(360, 23);
            this.Service.TabIndex = 12;
            // 
            // Doctor
            // 
            this.Doctor.FormattingEnabled = true;
            this.Doctor.Location = new System.Drawing.Point(286, 141);
            this.Doctor.Name = "Doctor";
            this.Doctor.Size = new System.Drawing.Size(360, 23);
            this.Doctor.TabIndex = 11;
            // 
            // Patient
            // 
            this.Patient.FormattingEnabled = true;
            this.Patient.Location = new System.Drawing.Point(286, 249);
            this.Patient.Name = "Patient";
            this.Patient.Size = new System.Drawing.Size(360, 23);
            this.Patient.TabIndex = 22;
            // 
            // Date
            // 
            this.Date.Location = new System.Drawing.Point(286, 86);
            this.Date.Name = "Date";
            this.Date.Size = new System.Drawing.Size(360, 23);
            this.Date.TabIndex = 23;
            this.Date.ValueChanged += new System.EventHandler(this.Date_ValueChanged);
            // 
            // AppointmentAdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Date);
            this.Controls.Add(this.Patient);
            this.Controls.Add(this.makeButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Service);
            this.Controls.Add(this.Doctor);
            this.Name = "AppointmentAdminForm";
            this.Text = "AppointmentAdminForm";
            this.Load += new System.EventHandler(this.AppointmentAdminForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button makeButton;
        private Button cancelButton;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private ComboBox Service;
        private ComboBox Doctor;
        private ComboBox Patient;
        private DateTimePicker Date;
    }
}