namespace Medical_Clinic.Admin
{
    partial class LoginProfileForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Email = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Role = new System.Windows.Forms.ComboBox();
            this.editButton = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.resetPasswordbutton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.resetButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.ConfirmPassword = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.NewPassword = new System.Windows.Forms.TextBox();
            this.PasswordGB = new System.Windows.Forms.GroupBox();
            this.prevButton = new System.Windows.Forms.Button();
            this.nextButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.PasswordGB.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Role";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Email";
            // 
            // Email
            // 
            this.Email.Enabled = false;
            this.Email.Location = new System.Drawing.Point(129, 97);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(343, 23);
            this.Email.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Role);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.Email);
            this.groupBox1.Location = new System.Drawing.Point(252, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(488, 152);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Login";
            // 
            // Role
            // 
            this.Role.Enabled = false;
            this.Role.FormattingEnabled = true;
            this.Role.Location = new System.Drawing.Point(129, 45);
            this.Role.Name = "Role";
            this.Role.Size = new System.Drawing.Size(343, 23);
            this.Role.TabIndex = 4;
            // 
            // editButton
            // 
            this.editButton.Location = new System.Drawing.Point(25, 41);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(147, 23);
            this.editButton.TabIndex = 5;
            this.editButton.Text = "Edit";
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.resetPasswordbutton);
            this.groupBox2.Controls.Add(this.saveButton);
            this.groupBox2.Controls.Add(this.editButton);
            this.groupBox2.Location = new System.Drawing.Point(24, 22);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 194);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Action";
            // 
            // resetPasswordbutton
            // 
            this.resetPasswordbutton.Location = new System.Drawing.Point(25, 146);
            this.resetPasswordbutton.Name = "resetPasswordbutton";
            this.resetPasswordbutton.Size = new System.Drawing.Size(147, 23);
            this.resetPasswordbutton.TabIndex = 7;
            this.resetPasswordbutton.Text = "Reset Password";
            this.resetPasswordbutton.UseVisualStyleBackColor = true;
            this.resetPasswordbutton.Click += new System.EventHandler(this.resetPasswordbutton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(25, 93);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(147, 23);
            this.saveButton.TabIndex = 6;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // resetButton
            // 
            this.resetButton.Location = new System.Drawing.Point(37, 118);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(398, 23);
            this.resetButton.TabIndex = 20;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 15);
            this.label4.TabIndex = 19;
            this.label4.Text = "Confirm Password";
            // 
            // ConfirmPassword
            // 
            this.ConfirmPassword.Location = new System.Drawing.Point(153, 73);
            this.ConfirmPassword.Name = "ConfirmPassword";
            this.ConfirmPassword.Size = new System.Drawing.Size(282, 23);
            this.ConfirmPassword.TabIndex = 18;
            this.ConfirmPassword.UseSystemPasswordChar = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(37, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 15);
            this.label5.TabIndex = 17;
            this.label5.Text = "New Password";
            // 
            // NewPassword
            // 
            this.NewPassword.Location = new System.Drawing.Point(153, 22);
            this.NewPassword.Name = "NewPassword";
            this.NewPassword.Size = new System.Drawing.Size(282, 23);
            this.NewPassword.TabIndex = 16;
            this.NewPassword.UseSystemPasswordChar = true;
            // 
            // PasswordGB
            // 
            this.PasswordGB.Controls.Add(this.NewPassword);
            this.PasswordGB.Controls.Add(this.resetButton);
            this.PasswordGB.Controls.Add(this.label5);
            this.PasswordGB.Controls.Add(this.label4);
            this.PasswordGB.Controls.Add(this.ConfirmPassword);
            this.PasswordGB.Location = new System.Drawing.Point(252, 268);
            this.PasswordGB.Name = "PasswordGB";
            this.PasswordGB.Size = new System.Drawing.Size(488, 152);
            this.PasswordGB.TabIndex = 21;
            this.PasswordGB.TabStop = false;
            this.PasswordGB.Text = "Password";
            this.PasswordGB.Visible = false;
            // 
            // prevButton
            // 
            this.prevButton.Location = new System.Drawing.Point(252, 193);
            this.prevButton.Name = "prevButton";
            this.prevButton.Size = new System.Drawing.Size(147, 23);
            this.prevButton.TabIndex = 7;
            this.prevButton.Text = "Prev";
            this.prevButton.UseVisualStyleBackColor = true;
            this.prevButton.Click += new System.EventHandler(this.prevButton_Click);
            // 
            // nextButton
            // 
            this.nextButton.Location = new System.Drawing.Point(593, 193);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(147, 23);
            this.nextButton.TabIndex = 22;
            this.nextButton.Text = "Next";
            this.nextButton.UseVisualStyleBackColor = true;
            this.nextButton.Click += new System.EventHandler(this.nextButton_Click);
            // 
            // LoginProfileForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.nextButton);
            this.Controls.Add(this.prevButton);
            this.Controls.Add(this.PasswordGB);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "LoginProfileForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PatientProfileForm";
            this.Load += new System.EventHandler(this.LoginProfileForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.PasswordGB.ResumeLayout(false);
            this.PasswordGB.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Label label1;
        private Label label2;
        private TextBox Email;
        private GroupBox groupBox1;
        private Button editButton;
        private GroupBox groupBox2;
        private Button saveButton;
        private Button resetPasswordbutton;
        private Button resetButton;
        private Label label4;
        private TextBox ConfirmPassword;
        private Label label5;
        private TextBox NewPassword;
        private GroupBox PasswordGB;
        private Button prevButton;
        private Button nextButton;
        private ComboBox Role;
    }
}