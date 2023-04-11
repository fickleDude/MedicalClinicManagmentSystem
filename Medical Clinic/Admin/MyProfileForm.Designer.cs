namespace Medical_Clinic.Admin
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
            this.createButton = new System.Windows.Forms.Button();
            this.editButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.ConfirmPassword = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.NewPassword = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Password = new System.Windows.Forms.TextBox();
            this.Email = new System.Windows.Forms.Label();
            this.MyProfileEmail = new System.Windows.Forms.TextBox();
            this.myProfileSavebutton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // createButton
            // 
            this.createButton.Location = new System.Drawing.Point(32, 164);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(398, 23);
            this.createButton.TabIndex = 27;
            this.createButton.Text = "Create";
            this.createButton.UseVisualStyleBackColor = true;
            this.createButton.Click += new System.EventHandler(this.createButton_Click);
            // 
            // editButton
            // 
            this.editButton.Location = new System.Drawing.Point(32, 73);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(398, 23);
            this.editButton.TabIndex = 26;
            this.editButton.Text = "Edit";
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 15);
            this.label4.TabIndex = 25;
            this.label4.Text = "Confirm Password";
            // 
            // ConfirmPassword
            // 
            this.ConfirmPassword.Location = new System.Drawing.Point(148, 119);
            this.ConfirmPassword.Name = "ConfirmPassword";
            this.ConfirmPassword.Size = new System.Drawing.Size(282, 23);
            this.ConfirmPassword.TabIndex = 24;
            this.ConfirmPassword.UseSystemPasswordChar = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 15);
            this.label5.TabIndex = 23;
            this.label5.Text = "New Password";
            // 
            // NewPassword
            // 
            this.NewPassword.Location = new System.Drawing.Point(148, 68);
            this.NewPassword.Name = "NewPassword";
            this.NewPassword.Size = new System.Drawing.Size(282, 23);
            this.NewPassword.TabIndex = 22;
            this.NewPassword.UseSystemPasswordChar = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(32, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 15);
            this.label6.TabIndex = 21;
            this.label6.Text = "Password";
            // 
            // Password
            // 
            this.Password.Location = new System.Drawing.Point(148, 22);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(282, 23);
            this.Password.TabIndex = 20;
            this.Password.UseSystemPasswordChar = true;
            // 
            // Email
            // 
            this.Email.AutoSize = true;
            this.Email.Location = new System.Drawing.Point(32, 31);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(36, 15);
            this.Email.TabIndex = 16;
            this.Email.Text = "Email";
            // 
            // MyProfileEmail
            // 
            this.MyProfileEmail.Enabled = false;
            this.MyProfileEmail.Location = new System.Drawing.Point(148, 31);
            this.MyProfileEmail.Name = "MyProfileEmail";
            this.MyProfileEmail.Size = new System.Drawing.Size(282, 23);
            this.MyProfileEmail.TabIndex = 15;
            // 
            // myProfileSavebutton
            // 
            this.myProfileSavebutton.Location = new System.Drawing.Point(32, 115);
            this.myProfileSavebutton.Name = "myProfileSavebutton";
            this.myProfileSavebutton.Size = new System.Drawing.Size(398, 23);
            this.myProfileSavebutton.TabIndex = 28;
            this.myProfileSavebutton.Text = "Save";
            this.myProfileSavebutton.UseVisualStyleBackColor = true;
            this.myProfileSavebutton.Click += new System.EventHandler(this.myProfileSavebutton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.MyProfileEmail);
            this.groupBox1.Controls.Add(this.myProfileSavebutton);
            this.groupBox1.Controls.Add(this.Email);
            this.groupBox1.Controls.Add(this.editButton);
            this.groupBox1.Location = new System.Drawing.Point(165, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(461, 153);
            this.groupBox1.TabIndex = 29;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Profile";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.NewPassword);
            this.groupBox2.Controls.Add(this.Password);
            this.groupBox2.Controls.Add(this.createButton);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.ConfirmPassword);
            this.groupBox2.Location = new System.Drawing.Point(165, 219);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(461, 204);
            this.groupBox2.TabIndex = 30;
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
            this.Text = "MyProfileForm";
            this.Load += new System.EventHandler(this.MyProfileForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Button createButton;
        private Button editButton;
        private Label label4;
        private TextBox ConfirmPassword;
        private Label label5;
        private TextBox NewPassword;
        private Label label6;
        private TextBox Password;
        private Label Email;
        private TextBox MyProfileEmail;
        private Button myProfileSavebutton;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
    }
}