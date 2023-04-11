namespace Medical_Clinic.Admin
{
    partial class ClinicForm
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
            this.components = new System.ComponentModel.Container();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.JournalTP = new System.Windows.Forms.TabPage();
            this.ActionGB = new System.Windows.Forms.GroupBox();
            this.cancelJournalbutton = new System.Windows.Forms.Button();
            this.addJournalButton = new System.Windows.Forms.Button();
            this.JournalCalendar = new System.Windows.Forms.MonthCalendar();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.JournalDoctor = new System.Windows.Forms.ComboBox();
            this.AppointmentDG = new System.Windows.Forms.DataGridView();
            this.ServiceTP = new System.Windows.Forms.TabPage();
            this.deleteButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.Service = new System.Windows.Forms.GroupBox();
            this.cancelButton = new System.Windows.Forms.Button();
            this.editButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.ServicePrice = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ServiceName = new System.Windows.Forms.TextBox();
            this.ServiceDG = new System.Windows.Forms.DataGridView();
            this.SpecializationTP = new System.Windows.Forms.TabPage();
            this.deleteSpecializationbutton = new System.Windows.Forms.Button();
            this.addSpecializationbutton = new System.Windows.Forms.Button();
            this.Specialization = new System.Windows.Forms.GroupBox();
            this.cancelSpecializationbutton = new System.Windows.Forms.Button();
            this.editSpecializationbutton = new System.Windows.Forms.Button();
            this.saveSpecializationbutton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.SpecializationName = new System.Windows.Forms.TextBox();
            this.SpecializationGD = new System.Windows.Forms.DataGridView();
            this.DoctorTP = new System.Windows.Forms.TabPage();
            this.nextButton = new System.Windows.Forms.Button();
            this.prevButton = new System.Windows.Forms.Button();
            this.DeleteDoctor = new System.Windows.Forms.Button();
            this.AddDoctor = new System.Windows.Forms.Button();
            this.Action = new System.Windows.Forms.GroupBox();
            this.CancelDoctor = new System.Windows.Forms.Button();
            this.SaveDoctor = new System.Windows.Forms.Button();
            this.EditDoctor = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Specializations = new System.Windows.Forms.CheckedListBox();
            this.Email = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Description = new System.Windows.Forms.RichTextBox();
            this.FIO = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.ClinicReload = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.reloadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1.SuspendLayout();
            this.JournalTP.SuspendLayout();
            this.ActionGB.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AppointmentDG)).BeginInit();
            this.ServiceTP.SuspendLayout();
            this.Service.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ServicePrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ServiceDG)).BeginInit();
            this.SpecializationTP.SuspendLayout();
            this.Specialization.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SpecializationGD)).BeginInit();
            this.DoctorTP.SuspendLayout();
            this.Action.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.ClinicReload.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.JournalTP);
            this.tabControl1.Controls.Add(this.ServiceTP);
            this.tabControl1.Controls.Add(this.SpecializationTP);
            this.tabControl1.Controls.Add(this.DoctorTP);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 450);
            this.tabControl1.TabIndex = 0;
            // 
            // JournalTP
            // 
            this.JournalTP.BackColor = System.Drawing.Color.LightSkyBlue;
            this.JournalTP.Controls.Add(this.ActionGB);
            this.JournalTP.Controls.Add(this.JournalCalendar);
            this.JournalTP.Controls.Add(this.groupBox1);
            this.JournalTP.Location = new System.Drawing.Point(4, 24);
            this.JournalTP.Name = "JournalTP";
            this.JournalTP.Padding = new System.Windows.Forms.Padding(3);
            this.JournalTP.Size = new System.Drawing.Size(792, 422);
            this.JournalTP.TabIndex = 0;
            this.JournalTP.Text = "Journal";
            // 
            // ActionGB
            // 
            this.ActionGB.Controls.Add(this.cancelJournalbutton);
            this.ActionGB.Controls.Add(this.addJournalButton);
            this.ActionGB.Location = new System.Drawing.Point(521, 262);
            this.ActionGB.Name = "ActionGB";
            this.ActionGB.Size = new System.Drawing.Size(227, 132);
            this.ActionGB.TabIndex = 3;
            this.ActionGB.TabStop = false;
            this.ActionGB.Text = "Action";
            this.ActionGB.Visible = false;
            // 
            // cancelJournalbutton
            // 
            this.cancelJournalbutton.Location = new System.Drawing.Point(25, 82);
            this.cancelJournalbutton.Name = "cancelJournalbutton";
            this.cancelJournalbutton.Size = new System.Drawing.Size(180, 23);
            this.cancelJournalbutton.TabIndex = 1;
            this.cancelJournalbutton.Text = "Cancel Appointment";
            this.cancelJournalbutton.UseVisualStyleBackColor = true;
            this.cancelJournalbutton.Click += new System.EventHandler(this.cancelJournalbutton_Click);
            // 
            // addJournalButton
            // 
            this.addJournalButton.Location = new System.Drawing.Point(25, 43);
            this.addJournalButton.Name = "addJournalButton";
            this.addJournalButton.Size = new System.Drawing.Size(180, 23);
            this.addJournalButton.TabIndex = 0;
            this.addJournalButton.Text = "Make Appointment";
            this.addJournalButton.UseVisualStyleBackColor = true;
            this.addJournalButton.Click += new System.EventHandler(this.addJournalButton_Click);
            // 
            // JournalCalendar
            // 
            this.JournalCalendar.Location = new System.Drawing.Point(521, 34);
            this.JournalCalendar.Name = "JournalCalendar";
            this.JournalCalendar.TabIndex = 2;
            this.JournalCalendar.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateSelected);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.JournalDoctor);
            this.groupBox1.Controls.Add(this.AppointmentDG);
            this.groupBox1.Location = new System.Drawing.Point(23, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(472, 372);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Appointment";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Doctor";
            // 
            // JournalDoctor
            // 
            this.JournalDoctor.FormattingEnabled = true;
            this.JournalDoctor.Location = new System.Drawing.Point(139, 38);
            this.JournalDoctor.Name = "JournalDoctor";
            this.JournalDoctor.Size = new System.Drawing.Size(312, 23);
            this.JournalDoctor.TabIndex = 1;
            this.JournalDoctor.SelectedIndexChanged += new System.EventHandler(this.JournalDoctor_SelectedIndexChanged);
            // 
            // AppointmentDG
            // 
            this.AppointmentDG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AppointmentDG.Location = new System.Drawing.Point(15, 78);
            this.AppointmentDG.Name = "AppointmentDG";
            this.AppointmentDG.RowTemplate.Height = 25;
            this.AppointmentDG.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.AppointmentDG.Size = new System.Drawing.Size(436, 278);
            this.AppointmentDG.TabIndex = 0;
            this.AppointmentDG.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.AppointmentDG_CellContentClick);
            // 
            // ServiceTP
            // 
            this.ServiceTP.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ServiceTP.Controls.Add(this.deleteButton);
            this.ServiceTP.Controls.Add(this.addButton);
            this.ServiceTP.Controls.Add(this.Service);
            this.ServiceTP.Controls.Add(this.ServiceDG);
            this.ServiceTP.Location = new System.Drawing.Point(4, 24);
            this.ServiceTP.Name = "ServiceTP";
            this.ServiceTP.Padding = new System.Windows.Forms.Padding(3);
            this.ServiceTP.Size = new System.Drawing.Size(792, 422);
            this.ServiceTP.TabIndex = 1;
            this.ServiceTP.Text = "Services";
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(223, 240);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(92, 23);
            this.deleteButton.TabIndex = 6;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(63, 240);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(92, 23);
            this.addButton.TabIndex = 7;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // Service
            // 
            this.Service.Controls.Add(this.cancelButton);
            this.Service.Controls.Add(this.editButton);
            this.Service.Controls.Add(this.saveButton);
            this.Service.Controls.Add(this.ServicePrice);
            this.Service.Controls.Add(this.label3);
            this.Service.Controls.Add(this.label2);
            this.Service.Controls.Add(this.ServiceName);
            this.Service.Location = new System.Drawing.Point(365, 29);
            this.Service.Name = "Service";
            this.Service.Size = new System.Drawing.Size(347, 244);
            this.Service.TabIndex = 1;
            this.Service.TabStop = false;
            this.Service.Text = "Service";
            this.Service.Visible = false;
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(15, 202);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(317, 23);
            this.cancelButton.TabIndex = 6;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // editButton
            // 
            this.editButton.Location = new System.Drawing.Point(15, 165);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(317, 23);
            this.editButton.TabIndex = 5;
            this.editButton.Text = "Edit";
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(15, 127);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(317, 23);
            this.saveButton.TabIndex = 4;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // ServicePrice
            // 
            this.ServicePrice.Enabled = false;
            this.ServicePrice.Location = new System.Drawing.Point(97, 73);
            this.ServicePrice.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.ServicePrice.Name = "ServicePrice";
            this.ServicePrice.Size = new System.Drawing.Size(235, 23);
            this.ServicePrice.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Price";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name";
            // 
            // ServiceName
            // 
            this.ServiceName.Enabled = false;
            this.ServiceName.Location = new System.Drawing.Point(97, 31);
            this.ServiceName.Name = "ServiceName";
            this.ServiceName.Size = new System.Drawing.Size(235, 23);
            this.ServiceName.TabIndex = 0;
            // 
            // ServiceDG
            // 
            this.ServiceDG.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ServiceDG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ServiceDG.Location = new System.Drawing.Point(63, 38);
            this.ServiceDG.MultiSelect = false;
            this.ServiceDG.Name = "ServiceDG";
            this.ServiceDG.RowTemplate.Height = 25;
            this.ServiceDG.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ServiceDG.Size = new System.Drawing.Size(252, 188);
            this.ServiceDG.TabIndex = 0;
            this.ServiceDG.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ServiceDG_CellContentClick);
            // 
            // SpecializationTP
            // 
            this.SpecializationTP.BackColor = System.Drawing.Color.LightSkyBlue;
            this.SpecializationTP.Controls.Add(this.deleteSpecializationbutton);
            this.SpecializationTP.Controls.Add(this.addSpecializationbutton);
            this.SpecializationTP.Controls.Add(this.Specialization);
            this.SpecializationTP.Controls.Add(this.SpecializationGD);
            this.SpecializationTP.Location = new System.Drawing.Point(4, 24);
            this.SpecializationTP.Name = "SpecializationTP";
            this.SpecializationTP.Size = new System.Drawing.Size(792, 422);
            this.SpecializationTP.TabIndex = 2;
            this.SpecializationTP.Text = "Specializations";
            // 
            // deleteSpecializationbutton
            // 
            this.deleteSpecializationbutton.Location = new System.Drawing.Point(228, 272);
            this.deleteSpecializationbutton.Name = "deleteSpecializationbutton";
            this.deleteSpecializationbutton.Size = new System.Drawing.Size(64, 23);
            this.deleteSpecializationbutton.TabIndex = 4;
            this.deleteSpecializationbutton.Text = "Delete";
            this.deleteSpecializationbutton.UseVisualStyleBackColor = true;
            this.deleteSpecializationbutton.Click += new System.EventHandler(this.deleteSpecializationbutton_Click_1);
            // 
            // addSpecializationbutton
            // 
            this.addSpecializationbutton.Location = new System.Drawing.Point(116, 272);
            this.addSpecializationbutton.Name = "addSpecializationbutton";
            this.addSpecializationbutton.Size = new System.Drawing.Size(64, 23);
            this.addSpecializationbutton.TabIndex = 3;
            this.addSpecializationbutton.Text = "Add";
            this.addSpecializationbutton.UseVisualStyleBackColor = true;
            this.addSpecializationbutton.Click += new System.EventHandler(this.addSpecializationbutton_Click);
            // 
            // Specialization
            // 
            this.Specialization.Controls.Add(this.cancelSpecializationbutton);
            this.Specialization.Controls.Add(this.editSpecializationbutton);
            this.Specialization.Controls.Add(this.saveSpecializationbutton);
            this.Specialization.Controls.Add(this.label4);
            this.Specialization.Controls.Add(this.SpecializationName);
            this.Specialization.Location = new System.Drawing.Point(348, 42);
            this.Specialization.Name = "Specialization";
            this.Specialization.Size = new System.Drawing.Size(316, 244);
            this.Specialization.TabIndex = 1;
            this.Specialization.TabStop = false;
            this.Specialization.Text = "Specialization";
            this.Specialization.Visible = false;
            // 
            // cancelSpecializationbutton
            // 
            this.cancelSpecializationbutton.Location = new System.Drawing.Point(27, 193);
            this.cancelSpecializationbutton.Name = "cancelSpecializationbutton";
            this.cancelSpecializationbutton.Size = new System.Drawing.Size(268, 23);
            this.cancelSpecializationbutton.TabIndex = 4;
            this.cancelSpecializationbutton.Text = "Cancel";
            this.cancelSpecializationbutton.UseVisualStyleBackColor = true;
            this.cancelSpecializationbutton.Click += new System.EventHandler(this.cancelSpecializationbutton_Click);
            // 
            // editSpecializationbutton
            // 
            this.editSpecializationbutton.Location = new System.Drawing.Point(27, 147);
            this.editSpecializationbutton.Name = "editSpecializationbutton";
            this.editSpecializationbutton.Size = new System.Drawing.Size(268, 23);
            this.editSpecializationbutton.TabIndex = 3;
            this.editSpecializationbutton.Text = "Edit";
            this.editSpecializationbutton.UseVisualStyleBackColor = true;
            this.editSpecializationbutton.Click += new System.EventHandler(this.editSpecializationbutton_Click);
            // 
            // saveSpecializationbutton
            // 
            this.saveSpecializationbutton.Location = new System.Drawing.Point(27, 105);
            this.saveSpecializationbutton.Name = "saveSpecializationbutton";
            this.saveSpecializationbutton.Size = new System.Drawing.Size(268, 23);
            this.saveSpecializationbutton.TabIndex = 2;
            this.saveSpecializationbutton.Text = "Save";
            this.saveSpecializationbutton.UseVisualStyleBackColor = true;
            this.saveSpecializationbutton.Click += new System.EventHandler(this.saveSpecializationbutton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 15);
            this.label4.TabIndex = 1;
            this.label4.Text = "Name";
            // 
            // SpecializationName
            // 
            this.SpecializationName.Enabled = false;
            this.SpecializationName.Location = new System.Drawing.Point(125, 38);
            this.SpecializationName.Name = "SpecializationName";
            this.SpecializationName.Size = new System.Drawing.Size(170, 23);
            this.SpecializationName.TabIndex = 0;
            // 
            // SpecializationGD
            // 
            this.SpecializationGD.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.SpecializationGD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SpecializationGD.Location = new System.Drawing.Point(116, 51);
            this.SpecializationGD.Name = "SpecializationGD";
            this.SpecializationGD.RowTemplate.Height = 25;
            this.SpecializationGD.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.SpecializationGD.Size = new System.Drawing.Size(176, 207);
            this.SpecializationGD.TabIndex = 0;
            this.SpecializationGD.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.SpecializationGD_CellContentClick);
            // 
            // DoctorTP
            // 
            this.DoctorTP.BackColor = System.Drawing.Color.LightSkyBlue;
            this.DoctorTP.Controls.Add(this.nextButton);
            this.DoctorTP.Controls.Add(this.prevButton);
            this.DoctorTP.Controls.Add(this.DeleteDoctor);
            this.DoctorTP.Controls.Add(this.AddDoctor);
            this.DoctorTP.Controls.Add(this.Action);
            this.DoctorTP.Controls.Add(this.groupBox2);
            this.DoctorTP.Location = new System.Drawing.Point(4, 24);
            this.DoctorTP.Name = "DoctorTP";
            this.DoctorTP.Size = new System.Drawing.Size(792, 422);
            this.DoctorTP.TabIndex = 3;
            this.DoctorTP.Text = "Doctors";
            // 
            // nextButton
            // 
            this.nextButton.Location = new System.Drawing.Point(590, 380);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(147, 23);
            this.nextButton.TabIndex = 12;
            this.nextButton.Text = "Next";
            this.nextButton.UseVisualStyleBackColor = true;
            this.nextButton.Click += new System.EventHandler(this.nextButton_Click);
            // 
            // prevButton
            // 
            this.prevButton.Location = new System.Drawing.Point(239, 380);
            this.prevButton.Name = "prevButton";
            this.prevButton.Size = new System.Drawing.Size(147, 23);
            this.prevButton.TabIndex = 11;
            this.prevButton.Text = "Prev";
            this.prevButton.UseVisualStyleBackColor = true;
            this.prevButton.Click += new System.EventHandler(this.prevButton_Click);
            // 
            // DeleteDoctor
            // 
            this.DeleteDoctor.Location = new System.Drawing.Point(42, 269);
            this.DeleteDoctor.Name = "DeleteDoctor";
            this.DeleteDoctor.Size = new System.Drawing.Size(147, 23);
            this.DeleteDoctor.TabIndex = 10;
            this.DeleteDoctor.Text = "Delete";
            this.DeleteDoctor.UseVisualStyleBackColor = true;
            this.DeleteDoctor.Click += new System.EventHandler(this.DeleteDoctor_Click);
            // 
            // AddDoctor
            // 
            this.AddDoctor.Location = new System.Drawing.Point(42, 240);
            this.AddDoctor.Name = "AddDoctor";
            this.AddDoctor.Size = new System.Drawing.Size(147, 23);
            this.AddDoctor.TabIndex = 9;
            this.AddDoctor.Text = "Add";
            this.AddDoctor.UseVisualStyleBackColor = true;
            this.AddDoctor.Click += new System.EventHandler(this.AddDoctor_Click);
            // 
            // Action
            // 
            this.Action.Controls.Add(this.CancelDoctor);
            this.Action.Controls.Add(this.SaveDoctor);
            this.Action.Controls.Add(this.EditDoctor);
            this.Action.Location = new System.Drawing.Point(42, 20);
            this.Action.Name = "Action";
            this.Action.Size = new System.Drawing.Size(147, 205);
            this.Action.TabIndex = 8;
            this.Action.TabStop = false;
            this.Action.Text = "Action";
            // 
            // CancelDoctor
            // 
            this.CancelDoctor.Location = new System.Drawing.Point(33, 150);
            this.CancelDoctor.Name = "CancelDoctor";
            this.CancelDoctor.Size = new System.Drawing.Size(75, 23);
            this.CancelDoctor.TabIndex = 2;
            this.CancelDoctor.Text = "Cancel";
            this.CancelDoctor.UseVisualStyleBackColor = true;
            this.CancelDoctor.Click += new System.EventHandler(this.CancelDoctor_Click);
            // 
            // SaveDoctor
            // 
            this.SaveDoctor.Location = new System.Drawing.Point(33, 92);
            this.SaveDoctor.Name = "SaveDoctor";
            this.SaveDoctor.Size = new System.Drawing.Size(75, 23);
            this.SaveDoctor.TabIndex = 1;
            this.SaveDoctor.Text = "Save";
            this.SaveDoctor.UseVisualStyleBackColor = true;
            this.SaveDoctor.Click += new System.EventHandler(this.SaveDoctor_Click);
            // 
            // EditDoctor
            // 
            this.EditDoctor.Location = new System.Drawing.Point(33, 36);
            this.EditDoctor.Name = "EditDoctor";
            this.EditDoctor.Size = new System.Drawing.Size(75, 23);
            this.EditDoctor.TabIndex = 0;
            this.EditDoctor.Text = "Edit";
            this.EditDoctor.UseVisualStyleBackColor = true;
            this.EditDoctor.Click += new System.EventHandler(this.EditDoctor_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Specializations);
            this.groupBox2.Controls.Add(this.Email);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.Description);
            this.groupBox2.Controls.Add(this.FIO);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Location = new System.Drawing.Point(239, 20);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(498, 328);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Profile";
            // 
            // Specializations
            // 
            this.Specializations.FormattingEnabled = true;
            this.Specializations.Location = new System.Drawing.Point(147, 220);
            this.Specializations.Name = "Specializations";
            this.Specializations.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.Specializations.Size = new System.Drawing.Size(318, 94);
            this.Specializations.TabIndex = 10;
            // 
            // Email
            // 
            this.Email.Enabled = false;
            this.Email.Location = new System.Drawing.Point(147, 89);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(318, 23);
            this.Email.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 89);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "Email";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 220);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 15);
            this.label6.TabIndex = 6;
            this.label6.Text = "Specialization";
            // 
            // Description
            // 
            this.Description.Enabled = false;
            this.Description.Location = new System.Drawing.Point(147, 139);
            this.Description.Name = "Description";
            this.Description.Size = new System.Drawing.Size(318, 54);
            this.Description.TabIndex = 3;
            this.Description.Text = "";
            // 
            // FIO
            // 
            this.FIO.Enabled = false;
            this.FIO.Location = new System.Drawing.Point(147, 36);
            this.FIO.Name = "FIO";
            this.FIO.Size = new System.Drawing.Size(318, 23);
            this.FIO.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 142);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 15);
            this.label7.TabIndex = 4;
            this.label7.Text = "Description";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(20, 36);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(25, 15);
            this.label8.TabIndex = 2;
            this.label8.Text = "FIO";
            // 
            // ClinicReload
            // 
            this.ClinicReload.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reloadToolStripMenuItem});
            this.ClinicReload.Name = "contextMenuStrip1";
            this.ClinicReload.Size = new System.Drawing.Size(111, 26);
            // 
            // reloadToolStripMenuItem
            // 
            this.reloadToolStripMenuItem.Name = "reloadToolStripMenuItem";
            this.reloadToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.reloadToolStripMenuItem.Text = "Reload";
            this.reloadToolStripMenuItem.Click += new System.EventHandler(this.reloadToolStripMenuItem_Click);
            // 
            // ClinicForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "ClinicForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ClinicForm";
            this.Load += new System.EventHandler(this.ClinicForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.JournalTP.ResumeLayout(false);
            this.ActionGB.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AppointmentDG)).EndInit();
            this.ServiceTP.ResumeLayout(false);
            this.Service.ResumeLayout(false);
            this.Service.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ServicePrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ServiceDG)).EndInit();
            this.SpecializationTP.ResumeLayout(false);
            this.Specialization.ResumeLayout(false);
            this.Specialization.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SpecializationGD)).EndInit();
            this.DoctorTP.ResumeLayout(false);
            this.Action.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ClinicReload.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl tabControl1;
        private TabPage JournalTP;
        private TabPage ServiceTP;
        private TabPage SpecializationTP;
        private GroupBox ActionGB;
        private Button addJournalButton;
        private MonthCalendar JournalCalendar;
        private GroupBox groupBox1;
        private Label label1;
        private ComboBox JournalDoctor;
        private DataGridView AppointmentDG;
        private Button cancelJournalbutton;
        private DataGridView ServiceDG;
        private Button deleteButton;
        private Button addButton;
        private GroupBox Service;
        private Button cancelButton;
        private Button editButton;
        private Button saveButton;
        private NumericUpDown ServicePrice;
        private Label label3;
        private Label label2;
        private TextBox ServiceName;
        private GroupBox Specialization;
        private DataGridView SpecializationGD;
        private TextBox SpecializationName;
        private Button deleteSpecializationbutton;
        private Button addSpecializationbutton;
        private Button cancelSpecializationbutton;
        private Button editSpecializationbutton;
        private Button saveSpecializationbutton;
        private Label label4;
        private TabPage DoctorTP;
        private Button nextButton;
        private Button prevButton;
        private Button DeleteDoctor;
        private Button AddDoctor;
        private GroupBox Action;
        private Button CancelDoctor;
        private Button SaveDoctor;
        private Button EditDoctor;
        private GroupBox groupBox2;
        private CheckedListBox Specializations;
        private TextBox Email;
        private Label label5;
        private Label label6;
        private RichTextBox Description;
        private TextBox FIO;
        private Label label7;
        private Label label8;
        private ContextMenuStrip ClinicReload;
        private ToolStripMenuItem reloadToolStripMenuItem;
    }
}