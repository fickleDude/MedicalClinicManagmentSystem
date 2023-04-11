namespace Medical_Clinic.Patient
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
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.MakeAppointmentButton = new System.Windows.Forms.Button();
            this.Journal = new System.Windows.Forms.MonthCalendar();
            this.Appointment = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cancelButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.Doctor = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Status = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Service = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Date = new System.Windows.Forms.DateTimePicker();
            this.MyNotesTP = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.NoteService = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.NoteDoctor = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.NoteDate = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.editButton = new System.Windows.Forms.Button();
            this.nextButton = new System.Windows.Forms.Button();
            this.prevButton = new System.Windows.Forms.Button();
            this.Note = new System.Windows.Forms.RichTextBox();
            this.MyPrescriptionsTP = new System.Windows.Forms.TabPage();
            this.toOrderbutton = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.Left = new System.Windows.Forms.TextBox();
            this.Vendor = new System.Windows.Forms.TextBox();
            this.Price = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.prevPrescriptionButton = new System.Windows.Forms.Button();
            this.nextPrescriptionButton = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.Diagnosis = new System.Windows.Forms.TextBox();
            this.PrescriptionDoctor = new System.Windows.Forms.TextBox();
            this.PrescriptionDate = new System.Windows.Forms.TextBox();
            this.Medicine = new System.Windows.Forms.TextBox();
            this.PatientClinicReload = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.reloadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1.SuspendLayout();
            this.JournalTP.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.Appointment.SuspendLayout();
            this.MyNotesTP.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.MyPrescriptionsTP.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.PatientClinicReload.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.JournalTP);
            this.tabControl1.Controls.Add(this.MyNotesTP);
            this.tabControl1.Controls.Add(this.MyPrescriptionsTP);
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
            this.JournalTP.Controls.Add(this.groupBox5);
            this.JournalTP.Controls.Add(this.Appointment);
            this.JournalTP.Location = new System.Drawing.Point(4, 24);
            this.JournalTP.Name = "JournalTP";
            this.JournalTP.Padding = new System.Windows.Forms.Padding(3);
            this.JournalTP.Size = new System.Drawing.Size(792, 422);
            this.JournalTP.TabIndex = 0;
            this.JournalTP.Text = "Journal";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.MakeAppointmentButton);
            this.groupBox5.Controls.Add(this.Journal);
            this.groupBox5.Location = new System.Drawing.Point(26, 28);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(259, 289);
            this.groupBox5.TabIndex = 3;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Journal";
            // 
            // MakeAppointmentButton
            // 
            this.MakeAppointmentButton.Location = new System.Drawing.Point(6, 249);
            this.MakeAppointmentButton.Name = "MakeAppointmentButton";
            this.MakeAppointmentButton.Size = new System.Drawing.Size(227, 23);
            this.MakeAppointmentButton.TabIndex = 1;
            this.MakeAppointmentButton.Text = "Make Appointment";
            this.MakeAppointmentButton.UseVisualStyleBackColor = true;
            this.MakeAppointmentButton.Click += new System.EventHandler(this.MakeAppointmentButton_Click);
            // 
            // Journal
            // 
            this.Journal.Location = new System.Drawing.Point(12, 28);
            this.Journal.Name = "Journal";
            this.Journal.TabIndex = 0;
            this.Journal.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateSelected);
            // 
            // Appointment
            // 
            this.Appointment.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Appointment.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Appointment.Controls.Add(this.label5);
            this.Appointment.Controls.Add(this.cancelButton);
            this.Appointment.Controls.Add(this.label4);
            this.Appointment.Controls.Add(this.Doctor);
            this.Appointment.Controls.Add(this.label3);
            this.Appointment.Controls.Add(this.Status);
            this.Appointment.Controls.Add(this.label2);
            this.Appointment.Controls.Add(this.Service);
            this.Appointment.Controls.Add(this.label1);
            this.Appointment.Controls.Add(this.Date);
            this.Appointment.Location = new System.Drawing.Point(333, 37);
            this.Appointment.Name = "Appointment";
            this.Appointment.Size = new System.Drawing.Size(429, 289);
            this.Appointment.TabIndex = 2;
            this.Appointment.TabStop = false;
            this.Appointment.Text = "Appointment";
            this.Appointment.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 45);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 15);
            this.label5.TabIndex = 20;
            this.label5.Text = "Doctor";
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(28, 240);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(379, 23);
            this.cancelButton.TabIndex = 19;
            this.cancelButton.Text = "Cancel Appointment";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(180, -16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 15);
            this.label4.TabIndex = 17;
            this.label4.Text = "Doctor";
            // 
            // Doctor
            // 
            this.Doctor.FormattingEnabled = true;
            this.Doctor.Location = new System.Drawing.Point(148, 42);
            this.Doctor.Name = "Doctor";
            this.Doctor.Size = new System.Drawing.Size(259, 23);
            this.Doctor.TabIndex = 16;
            this.Doctor.SelectedIndexChanged += new System.EventHandler(this.Doctor_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 195);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 15);
            this.label3.TabIndex = 15;
            this.label3.Text = "Status";
            // 
            // Status
            // 
            this.Status.Location = new System.Drawing.Point(148, 195);
            this.Status.Name = "Status";
            this.Status.Size = new System.Drawing.Size(259, 23);
            this.Status.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 15);
            this.label2.TabIndex = 13;
            this.label2.Text = "Service";
            // 
            // Service
            // 
            this.Service.Location = new System.Drawing.Point(148, 142);
            this.Service.Name = "Service";
            this.Service.Size = new System.Drawing.Size(259, 23);
            this.Service.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 15);
            this.label1.TabIndex = 11;
            this.label1.Text = "Date";
            // 
            // Date
            // 
            this.Date.Location = new System.Drawing.Point(148, 92);
            this.Date.Name = "Date";
            this.Date.Size = new System.Drawing.Size(259, 23);
            this.Date.TabIndex = 10;
            // 
            // MyNotesTP
            // 
            this.MyNotesTP.BackColor = System.Drawing.Color.LightSkyBlue;
            this.MyNotesTP.Controls.Add(this.groupBox2);
            this.MyNotesTP.Controls.Add(this.groupBox1);
            this.MyNotesTP.Controls.Add(this.nextButton);
            this.MyNotesTP.Controls.Add(this.prevButton);
            this.MyNotesTP.Controls.Add(this.Note);
            this.MyNotesTP.Location = new System.Drawing.Point(4, 24);
            this.MyNotesTP.Name = "MyNotesTP";
            this.MyNotesTP.Padding = new System.Windows.Forms.Padding(3);
            this.MyNotesTP.Size = new System.Drawing.Size(792, 422);
            this.MyNotesTP.TabIndex = 1;
            this.MyNotesTP.Text = "My Notes";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.NoteService);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.NoteDoctor);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.NoteDate);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(214, 220);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(557, 168);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Info";
            // 
            // NoteService
            // 
            this.NoteService.Enabled = false;
            this.NoteService.Location = new System.Drawing.Point(147, 127);
            this.NoteService.Name = "NoteService";
            this.NoteService.Size = new System.Drawing.Size(384, 23);
            this.NoteService.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(23, 127);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 15);
            this.label8.TabIndex = 5;
            this.label8.Text = "Service";
            // 
            // NoteDoctor
            // 
            this.NoteDoctor.Enabled = false;
            this.NoteDoctor.Location = new System.Drawing.Point(147, 84);
            this.NoteDoctor.Name = "NoteDoctor";
            this.NoteDoctor.Size = new System.Drawing.Size(384, 23);
            this.NoteDoctor.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(23, 84);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 15);
            this.label7.TabIndex = 3;
            this.label7.Text = "Doctor";
            // 
            // NoteDate
            // 
            this.NoteDate.Enabled = false;
            this.NoteDate.Location = new System.Drawing.Point(147, 39);
            this.NoteDate.Name = "NoteDate";
            this.NoteDate.Size = new System.Drawing.Size(384, 23);
            this.NoteDate.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 39);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 15);
            this.label6.TabIndex = 1;
            this.label6.Text = "Date";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.saveButton);
            this.groupBox1.Controls.Add(this.editButton);
            this.groupBox1.Location = new System.Drawing.Point(20, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(165, 126);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Note";
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(17, 77);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(128, 23);
            this.saveButton.TabIndex = 8;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // editButton
            // 
            this.editButton.Location = new System.Drawing.Point(17, 36);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(128, 23);
            this.editButton.TabIndex = 7;
            this.editButton.Text = "Edit";
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // nextButton
            // 
            this.nextButton.Location = new System.Drawing.Point(696, 173);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(75, 23);
            this.nextButton.TabIndex = 5;
            this.nextButton.Text = "Next";
            this.nextButton.UseVisualStyleBackColor = true;
            this.nextButton.Click += new System.EventHandler(this.nextButton_Click);
            // 
            // prevButton
            // 
            this.prevButton.Location = new System.Drawing.Point(214, 173);
            this.prevButton.Name = "prevButton";
            this.prevButton.Size = new System.Drawing.Size(75, 23);
            this.prevButton.TabIndex = 4;
            this.prevButton.Text = "Prev";
            this.prevButton.UseVisualStyleBackColor = true;
            this.prevButton.Click += new System.EventHandler(this.prevButton_Click);
            // 
            // Note
            // 
            this.Note.Enabled = false;
            this.Note.Location = new System.Drawing.Point(214, 24);
            this.Note.Name = "Note";
            this.Note.Size = new System.Drawing.Size(557, 126);
            this.Note.TabIndex = 3;
            this.Note.Text = "";
            // 
            // MyPrescriptionsTP
            // 
            this.MyPrescriptionsTP.BackColor = System.Drawing.Color.LightSkyBlue;
            this.MyPrescriptionsTP.Controls.Add(this.toOrderbutton);
            this.MyPrescriptionsTP.Controls.Add(this.groupBox4);
            this.MyPrescriptionsTP.Controls.Add(this.button3);
            this.MyPrescriptionsTP.Controls.Add(this.prevPrescriptionButton);
            this.MyPrescriptionsTP.Controls.Add(this.nextPrescriptionButton);
            this.MyPrescriptionsTP.Controls.Add(this.groupBox3);
            this.MyPrescriptionsTP.Location = new System.Drawing.Point(4, 24);
            this.MyPrescriptionsTP.Name = "MyPrescriptionsTP";
            this.MyPrescriptionsTP.Size = new System.Drawing.Size(792, 422);
            this.MyPrescriptionsTP.TabIndex = 2;
            this.MyPrescriptionsTP.Text = "My Prescriptions";
            // 
            // toOrderbutton
            // 
            this.toOrderbutton.Location = new System.Drawing.Point(22, 256);
            this.toOrderbutton.Name = "toOrderbutton";
            this.toOrderbutton.Size = new System.Drawing.Size(189, 23);
            this.toOrderbutton.TabIndex = 5;
            this.toOrderbutton.Text = "Go To Order";
            this.toOrderbutton.UseVisualStyleBackColor = true;
            this.toOrderbutton.Click += new System.EventHandler(this.toOrderbutton_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label15);
            this.groupBox4.Controls.Add(this.label14);
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Controls.Add(this.Left);
            this.groupBox4.Controls.Add(this.Vendor);
            this.groupBox4.Controls.Add(this.Price);
            this.groupBox4.Location = new System.Drawing.Point(22, 39);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(189, 187);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "In Pharmacy";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(18, 141);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(27, 15);
            this.label15.TabIndex = 5;
            this.label15.Text = "Left";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(18, 88);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(44, 15);
            this.label14.TabIndex = 4;
            this.label14.Text = "Vendor";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(18, 23);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(33, 15);
            this.label13.TabIndex = 3;
            this.label13.Text = "Price";
            // 
            // Left
            // 
            this.Left.Enabled = false;
            this.Left.Location = new System.Drawing.Point(18, 157);
            this.Left.Name = "Left";
            this.Left.Size = new System.Drawing.Size(151, 23);
            this.Left.TabIndex = 2;
            // 
            // Vendor
            // 
            this.Vendor.Enabled = false;
            this.Vendor.Location = new System.Drawing.Point(18, 106);
            this.Vendor.Name = "Vendor";
            this.Vendor.Size = new System.Drawing.Size(151, 23);
            this.Vendor.TabIndex = 1;
            // 
            // Price
            // 
            this.Price.Enabled = false;
            this.Price.Location = new System.Drawing.Point(18, 47);
            this.Price.Name = "Price";
            this.Price.Size = new System.Drawing.Size(151, 23);
            this.Price.TabIndex = 0;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(240, 330);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(514, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "Add to Order";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // prevPrescriptionButton
            // 
            this.prevPrescriptionButton.Location = new System.Drawing.Point(240, 376);
            this.prevPrescriptionButton.Name = "prevPrescriptionButton";
            this.prevPrescriptionButton.Size = new System.Drawing.Size(75, 23);
            this.prevPrescriptionButton.TabIndex = 2;
            this.prevPrescriptionButton.Text = "Prev";
            this.prevPrescriptionButton.UseVisualStyleBackColor = true;
            this.prevPrescriptionButton.Click += new System.EventHandler(this.prevPrescriptionButton_Click);
            // 
            // nextPrescriptionButton
            // 
            this.nextPrescriptionButton.Location = new System.Drawing.Point(679, 376);
            this.nextPrescriptionButton.Name = "nextPrescriptionButton";
            this.nextPrescriptionButton.Size = new System.Drawing.Size(75, 23);
            this.nextPrescriptionButton.TabIndex = 1;
            this.nextPrescriptionButton.Text = "Next";
            this.nextPrescriptionButton.UseVisualStyleBackColor = true;
            this.nextPrescriptionButton.Click += new System.EventHandler(this.nextPrescriptionButton_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.Diagnosis);
            this.groupBox3.Controls.Add(this.PrescriptionDoctor);
            this.groupBox3.Controls.Add(this.PrescriptionDate);
            this.groupBox3.Controls.Add(this.Medicine);
            this.groupBox3.Location = new System.Drawing.Point(240, 38);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(514, 276);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Prescription";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(22, 218);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(43, 15);
            this.label12.TabIndex = 9;
            this.label12.Text = "Doctor";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(22, 163);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(31, 15);
            this.label11.TabIndex = 8;
            this.label11.Text = "Date";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(22, 112);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 15);
            this.label10.TabIndex = 7;
            this.label10.Text = "Diagnosis";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(22, 56);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(91, 15);
            this.label9.TabIndex = 6;
            this.label9.Text = "Medicine Name";
            // 
            // Diagnosis
            // 
            this.Diagnosis.Enabled = false;
            this.Diagnosis.Location = new System.Drawing.Point(131, 112);
            this.Diagnosis.Name = "Diagnosis";
            this.Diagnosis.Size = new System.Drawing.Size(357, 23);
            this.Diagnosis.TabIndex = 5;
            // 
            // PrescriptionDoctor
            // 
            this.PrescriptionDoctor.Enabled = false;
            this.PrescriptionDoctor.Location = new System.Drawing.Point(131, 224);
            this.PrescriptionDoctor.Name = "PrescriptionDoctor";
            this.PrescriptionDoctor.Size = new System.Drawing.Size(357, 23);
            this.PrescriptionDoctor.TabIndex = 4;
            // 
            // PrescriptionDate
            // 
            this.PrescriptionDate.Enabled = false;
            this.PrescriptionDate.Location = new System.Drawing.Point(131, 165);
            this.PrescriptionDate.Name = "PrescriptionDate";
            this.PrescriptionDate.Size = new System.Drawing.Size(357, 23);
            this.PrescriptionDate.TabIndex = 2;
            // 
            // Medicine
            // 
            this.Medicine.Enabled = false;
            this.Medicine.Location = new System.Drawing.Point(131, 56);
            this.Medicine.Name = "Medicine";
            this.Medicine.Size = new System.Drawing.Size(357, 23);
            this.Medicine.TabIndex = 0;
            // 
            // PatientClinicReload
            // 
            this.PatientClinicReload.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reloadToolStripMenuItem});
            this.PatientClinicReload.Name = "PatientClinicReload";
            this.PatientClinicReload.Size = new System.Drawing.Size(111, 26);
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
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "ClinicForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Clinic";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ClinicForm_FormClosing);
            this.Load += new System.EventHandler(this.ClinicForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.JournalTP.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.Appointment.ResumeLayout(false);
            this.Appointment.PerformLayout();
            this.MyNotesTP.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.MyPrescriptionsTP.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.PatientClinicReload.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl tabControl1;
        private TabPage JournalTP;
        private TabPage MyNotesTP;
        private TabPage MyPrescriptionsTP;
        private MonthCalendar Journal;
        private Button MakeAppointment;
        private GroupBox Appointment;
        private Label label5;
        private Button cancelButton;
        private Label label4;
        private ComboBox Doctor;
        private Label label3;
        private TextBox Status;
        private Label label2;
        private TextBox Service;
        private Label label1;
        private DateTimePicker Date;
        private RichTextBox Note;
        private Label label6;
        private GroupBox groupBox1;
        private Button saveButton;
        private Button editButton;
        private Button nextButton;
        private Button prevButton;
        private GroupBox groupBox2;
        private TextBox NoteService;
        private Label label8;
        private TextBox NoteDoctor;
        private Label label7;
        private TextBox NoteDate;
        private GroupBox groupBox4;
        private Label label15;
        private Label label14;
        private Label label13;
        private TextBox Left;
        private TextBox Vendor;
        private TextBox Price;
        private Button button3;
        private Button prevPrescriptionButton;
        private Button nextPrescriptionButton;
        private GroupBox groupBox3;
        private Label label12;
        private Label label11;
        private Label label10;
        private Label label9;
        private TextBox Diagnosis;
        private TextBox PrescriptionDoctor;
        private TextBox PrescriptionDate;
        private TextBox Medicine;
        private Button toOrderbutton;
        private GroupBox groupBox5;
        private Button MakeAppointmentButton;
        private ContextMenuStrip PatientClinicReload;
        private ToolStripMenuItem reloadToolStripMenuItem;
    }
}