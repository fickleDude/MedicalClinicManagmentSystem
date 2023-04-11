namespace Medical_Clinic.Patient
{
    partial class AppointmentForm
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
            this.Doctor = new System.Windows.Forms.ComboBox();
            this.Service = new System.Windows.Forms.ComboBox();
            this.Date = new System.Windows.Forms.TextBox();
            this.Price = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cancelButton = new System.Windows.Forms.Button();
            this.makeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Doctor
            // 
            this.Doctor.FormattingEnabled = true;
            this.Doctor.Location = new System.Drawing.Point(313, 139);
            this.Doctor.Name = "Doctor";
            this.Doctor.Size = new System.Drawing.Size(360, 23);
            this.Doctor.TabIndex = 0;
            // 
            // Service
            // 
            this.Service.FormattingEnabled = true;
            this.Service.Location = new System.Drawing.Point(313, 191);
            this.Service.Name = "Service";
            this.Service.Size = new System.Drawing.Size(360, 23);
            this.Service.TabIndex = 1;
            this.Service.SelectedIndexChanged += new System.EventHandler(this.Service_SelectedIndexChanged);
            // 
            // Date
            // 
            this.Date.Location = new System.Drawing.Point(313, 90);
            this.Date.Name = "Date";
            this.Date.Size = new System.Drawing.Size(360, 23);
            this.Date.TabIndex = 2;
            // 
            // Price
            // 
            this.Price.Location = new System.Drawing.Point(313, 238);
            this.Price.Name = "Price";
            this.Price.Size = new System.Drawing.Size(360, 23);
            this.Price.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(147, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(147, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Doctor";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(147, 191);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Service";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(147, 238);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Price";
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(534, 308);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(139, 23);
            this.cancelButton.TabIndex = 9;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // makeButton
            // 
            this.makeButton.Location = new System.Drawing.Point(389, 308);
            this.makeButton.Name = "makeButton";
            this.makeButton.Size = new System.Drawing.Size(139, 23);
            this.makeButton.TabIndex = 10;
            this.makeButton.Text = "Make";
            this.makeButton.UseVisualStyleBackColor = true;
            this.makeButton.Click += new System.EventHandler(this.makeButton_Click);
            // 
            // AppointmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.makeButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Price);
            this.Controls.Add(this.Date);
            this.Controls.Add(this.Service);
            this.Controls.Add(this.Doctor);
            this.Name = "AppointmentForm";
            this.Text = "AppointmentForm";
            this.Load += new System.EventHandler(this.AppointmentForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox Doctor;
        private ComboBox Service;
        private TextBox Date;
        private TextBox Price;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button cancelButton;
        private Button makeButton;
    }
}