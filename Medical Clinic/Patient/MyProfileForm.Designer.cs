namespace Medical_Clinic.Patient
{
    partial class MyProfileForm
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
            this.FIO = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ConfirmPassword = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.NewPassword = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Password = new System.Windows.Forms.TextBox();
            this.editButton = new System.Windows.Forms.Button();
            this.resetButton = new System.Windows.Forms.Button();
            this.DateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.Gender = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CancelProfile = new System.Windows.Forms.Button();
            this.SaveProfile = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // FIO
            // 
            this.FIO.Enabled = false;
            this.FIO.Location = new System.Drawing.Point(141, 38);
            this.FIO.Name = "FIO";
            this.FIO.Size = new System.Drawing.Size(282, 23);
            this.FIO.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "FIO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Gender";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Date of Birth";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 15);
            this.label4.TabIndex = 11;
            this.label4.Text = "Confirm Password";
            // 
            // ConfirmPassword
            // 
            this.ConfirmPassword.Location = new System.Drawing.Point(134, 132);
            this.ConfirmPassword.Name = "ConfirmPassword";
            this.ConfirmPassword.Size = new System.Drawing.Size(139, 23);
            this.ConfirmPassword.TabIndex = 10;
            this.ConfirmPassword.UseSystemPasswordChar = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 81);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "New Password";
            // 
            // NewPassword
            // 
            this.NewPassword.Location = new System.Drawing.Point(134, 81);
            this.NewPassword.Name = "NewPassword";
            this.NewPassword.Size = new System.Drawing.Size(139, 23);
            this.NewPassword.TabIndex = 8;
            this.NewPassword.UseSystemPasswordChar = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 35);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 15);
            this.label6.TabIndex = 7;
            this.label6.Text = "Password";
            // 
            // Password
            // 
            this.Password.Location = new System.Drawing.Point(134, 35);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(139, 23);
            this.Password.TabIndex = 6;
            this.Password.UseSystemPasswordChar = true;
            // 
            // editButton
            // 
            this.editButton.Location = new System.Drawing.Point(25, 188);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(398, 23);
            this.editButton.TabIndex = 12;
            this.editButton.Text = "Edit";
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // resetButton
            // 
            this.resetButton.Location = new System.Drawing.Point(18, 177);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(255, 23);
            this.resetButton.TabIndex = 13;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.createButton_Click);
            // 
            // DateOfBirth
            // 
            this.DateOfBirth.Enabled = false;
            this.DateOfBirth.Location = new System.Drawing.Point(141, 135);
            this.DateOfBirth.Name = "DateOfBirth";
            this.DateOfBirth.Size = new System.Drawing.Size(282, 23);
            this.DateOfBirth.TabIndex = 14;
            // 
            // Gender
            // 
            this.Gender.Enabled = false;
            this.Gender.FormattingEnabled = true;
            this.Gender.Location = new System.Drawing.Point(141, 84);
            this.Gender.Name = "Gender";
            this.Gender.Size = new System.Drawing.Size(282, 23);
            this.Gender.TabIndex = 15;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CancelProfile);
            this.groupBox1.Controls.Add(this.SaveProfile);
            this.groupBox1.Controls.Add(this.Gender);
            this.groupBox1.Controls.Add(this.FIO);
            this.groupBox1.Controls.Add(this.DateOfBirth);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.editButton);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(447, 315);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Profile";
            // 
            // CancelProfile
            // 
            this.CancelProfile.Location = new System.Drawing.Point(25, 275);
            this.CancelProfile.Name = "CancelProfile";
            this.CancelProfile.Size = new System.Drawing.Size(398, 23);
            this.CancelProfile.TabIndex = 17;
            this.CancelProfile.Text = "Cancel";
            this.CancelProfile.UseVisualStyleBackColor = true;
            this.CancelProfile.Click += new System.EventHandler(this.CancelProfile_Click);
            // 
            // SaveProfile
            // 
            this.SaveProfile.Location = new System.Drawing.Point(25, 230);
            this.SaveProfile.Name = "SaveProfile";
            this.SaveProfile.Size = new System.Drawing.Size(398, 23);
            this.SaveProfile.TabIndex = 16;
            this.SaveProfile.Text = "Save";
            this.SaveProfile.UseVisualStyleBackColor = true;
            this.SaveProfile.Click += new System.EventHandler(this.SaveProfile_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Password);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.resetButton);
            this.groupBox2.Controls.Add(this.NewPassword);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.ConfirmPassword);
            this.groupBox2.Location = new System.Drawing.Point(485, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(291, 315);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Password";
            // 
            // MyProfileForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "MyProfileForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "My Profile";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MyProfileForm_FormClosing);
            this.Load += new System.EventHandler(this.MyProfileForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TextBox FIO;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox ConfirmPassword;
        private Label label5;
        private TextBox NewPassword;
        private Label label6;
        private TextBox Password;
        private Button editButton;
        private Button resetButton;
        private DateTimePicker DateOfBirth;
        private ComboBox Gender;
        private GroupBox groupBox1;
        private Button CancelProfile;
        private Button SaveProfile;
        private GroupBox groupBox2;
    }
}