namespace Medical_Clinic.Doctor
{
    partial class DoctorClinicForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Journal = new System.Windows.Forms.MonthCalendar();
            this.NextAppointment = new System.Windows.Forms.Button();
            this.PrevAppointment = new System.Windows.Forms.Button();
            this.Appointment = new System.Windows.Forms.GroupBox();
            this.PatientAppointment = new System.Windows.Forms.ComboBox();
            this.DateAppointment = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.StatusAppointment = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ServiceAppointment = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.PatientsTP = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.SelectPatient = new System.Windows.Forms.ComboBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.SimptomsNote = new System.Windows.Forms.RichTextBox();
            this.DiagnosisNote = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.editButton = new System.Windows.Forms.Button();
            this.nextButton = new System.Windows.Forms.Button();
            this.prevButton = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.NoteService = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.NoteDate = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.PrescriptionTP = new System.Windows.Forms.TabPage();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.NextPresc = new System.Windows.Forms.Button();
            this.PrevPresc = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.PrescMedicine = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.PrescDiagnosis = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.SelectDatePresc = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.SelectPatientPresc = new System.Windows.Forms.ComboBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.reloadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1.SuspendLayout();
            this.JournalTP.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.Appointment.SuspendLayout();
            this.PatientsTP.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.PrescriptionTP.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.JournalTP);
            this.tabControl1.Controls.Add(this.PatientsTP);
            this.tabControl1.Controls.Add(this.PrescriptionTP);
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
            this.JournalTP.Controls.Add(this.groupBox1);
            this.JournalTP.Controls.Add(this.NextAppointment);
            this.JournalTP.Controls.Add(this.PrevAppointment);
            this.JournalTP.Controls.Add(this.Appointment);
            this.JournalTP.Location = new System.Drawing.Point(4, 24);
            this.JournalTP.Name = "JournalTP";
            this.JournalTP.Padding = new System.Windows.Forms.Padding(3);
            this.JournalTP.Size = new System.Drawing.Size(792, 422);
            this.JournalTP.TabIndex = 0;
            this.JournalTP.Text = "Journal";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Journal);
            this.groupBox1.Location = new System.Drawing.Point(32, 52);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(256, 246);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Journal";
            // 
            // Journal
            // 
            this.Journal.Location = new System.Drawing.Point(17, 28);
            this.Journal.Name = "Journal";
            this.Journal.TabIndex = 0;
            this.Journal.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.Journal_DateSelected);
            // 
            // NextAppointment
            // 
            this.NextAppointment.Location = new System.Drawing.Point(688, 315);
            this.NextAppointment.Name = "NextAppointment";
            this.NextAppointment.Size = new System.Drawing.Size(75, 23);
            this.NextAppointment.TabIndex = 6;
            this.NextAppointment.Text = "Next";
            this.NextAppointment.UseVisualStyleBackColor = true;
            this.NextAppointment.Click += new System.EventHandler(this.NextAppointment_Click);
            // 
            // PrevAppointment
            // 
            this.PrevAppointment.Location = new System.Drawing.Point(334, 315);
            this.PrevAppointment.Name = "PrevAppointment";
            this.PrevAppointment.Size = new System.Drawing.Size(75, 23);
            this.PrevAppointment.TabIndex = 5;
            this.PrevAppointment.Text = "Prev";
            this.PrevAppointment.UseVisualStyleBackColor = true;
            this.PrevAppointment.Click += new System.EventHandler(this.PrevAppointment_Click);
            // 
            // Appointment
            // 
            this.Appointment.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Appointment.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Appointment.Controls.Add(this.PatientAppointment);
            this.Appointment.Controls.Add(this.DateAppointment);
            this.Appointment.Controls.Add(this.label5);
            this.Appointment.Controls.Add(this.label4);
            this.Appointment.Controls.Add(this.label3);
            this.Appointment.Controls.Add(this.StatusAppointment);
            this.Appointment.Controls.Add(this.label2);
            this.Appointment.Controls.Add(this.ServiceAppointment);
            this.Appointment.Controls.Add(this.label1);
            this.Appointment.Location = new System.Drawing.Point(334, 52);
            this.Appointment.Name = "Appointment";
            this.Appointment.Size = new System.Drawing.Size(429, 246);
            this.Appointment.TabIndex = 4;
            this.Appointment.TabStop = false;
            this.Appointment.Text = "Appointment";
            // 
            // PatientAppointment
            // 
            this.PatientAppointment.Enabled = false;
            this.PatientAppointment.FormattingEnabled = true;
            this.PatientAppointment.Location = new System.Drawing.Point(148, 45);
            this.PatientAppointment.Name = "PatientAppointment";
            this.PatientAppointment.Size = new System.Drawing.Size(259, 23);
            this.PatientAppointment.TabIndex = 22;
            // 
            // DateAppointment
            // 
            this.DateAppointment.Enabled = false;
            this.DateAppointment.Location = new System.Drawing.Point(148, 92);
            this.DateAppointment.Name = "DateAppointment";
            this.DateAppointment.Size = new System.Drawing.Size(259, 23);
            this.DateAppointment.TabIndex = 21;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 45);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 15);
            this.label5.TabIndex = 20;
            this.label5.Text = "Patient";
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 195);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 15);
            this.label3.TabIndex = 15;
            this.label3.Text = "Status";
            // 
            // StatusAppointment
            // 
            this.StatusAppointment.Enabled = false;
            this.StatusAppointment.Location = new System.Drawing.Point(148, 195);
            this.StatusAppointment.Name = "StatusAppointment";
            this.StatusAppointment.Size = new System.Drawing.Size(259, 23);
            this.StatusAppointment.TabIndex = 14;
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
            // ServiceAppointment
            // 
            this.ServiceAppointment.Enabled = false;
            this.ServiceAppointment.Location = new System.Drawing.Point(148, 142);
            this.ServiceAppointment.Name = "ServiceAppointment";
            this.ServiceAppointment.Size = new System.Drawing.Size(259, 23);
            this.ServiceAppointment.TabIndex = 12;
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
            // PatientsTP
            // 
            this.PatientsTP.BackColor = System.Drawing.Color.LightSkyBlue;
            this.PatientsTP.Controls.Add(this.label7);
            this.PatientsTP.Controls.Add(this.SelectPatient);
            this.PatientsTP.Controls.Add(this.groupBox4);
            this.PatientsTP.Controls.Add(this.groupBox3);
            this.PatientsTP.Controls.Add(this.nextButton);
            this.PatientsTP.Controls.Add(this.prevButton);
            this.PatientsTP.Controls.Add(this.groupBox2);
            this.PatientsTP.Location = new System.Drawing.Point(4, 24);
            this.PatientsTP.Name = "PatientsTP";
            this.PatientsTP.Padding = new System.Windows.Forms.Padding(3);
            this.PatientsTP.Size = new System.Drawing.Size(792, 422);
            this.PatientsTP.TabIndex = 1;
            this.PatientsTP.Text = "My Notes";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(27, 28);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 15);
            this.label7.TabIndex = 7;
            this.label7.Text = "Select Patient";
            // 
            // SelectPatient
            // 
            this.SelectPatient.FormattingEnabled = true;
            this.SelectPatient.Location = new System.Drawing.Point(27, 52);
            this.SelectPatient.Name = "SelectPatient";
            this.SelectPatient.Size = new System.Drawing.Size(165, 23);
            this.SelectPatient.TabIndex = 14;
            this.SelectPatient.SelectedIndexChanged += new System.EventHandler(this.SelectPatient_SelectedIndexChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.SimptomsNote);
            this.groupBox4.Controls.Add(this.DiagnosisNote);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Location = new System.Drawing.Point(223, 28);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(532, 197);
            this.groupBox4.TabIndex = 13;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Note";
            // 
            // SimptomsNote
            // 
            this.SimptomsNote.Enabled = false;
            this.SimptomsNote.Location = new System.Drawing.Point(127, 79);
            this.SimptomsNote.Name = "SimptomsNote";
            this.SimptomsNote.Size = new System.Drawing.Size(384, 96);
            this.SimptomsNote.TabIndex = 10;
            this.SimptomsNote.Text = "";
            // 
            // DiagnosisNote
            // 
            this.DiagnosisNote.Enabled = false;
            this.DiagnosisNote.Location = new System.Drawing.Point(127, 34);
            this.DiagnosisNote.Name = "DiagnosisNote";
            this.DiagnosisNote.Size = new System.Drawing.Size(384, 23);
            this.DiagnosisNote.TabIndex = 8;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(19, 79);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 15);
            this.label9.TabIndex = 9;
            this.label9.Text = "Symptoms";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(19, 34);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 15);
            this.label10.TabIndex = 7;
            this.label10.Text = "Diagnosis";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.saveButton);
            this.groupBox3.Controls.Add(this.editButton);
            this.groupBox3.Location = new System.Drawing.Point(27, 99);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(165, 126);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Action";
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
            this.nextButton.Location = new System.Drawing.Point(669, 231);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(86, 23);
            this.nextButton.TabIndex = 11;
            this.nextButton.Text = "Next";
            this.nextButton.UseVisualStyleBackColor = true;
            this.nextButton.Click += new System.EventHandler(this.nextButton_Click);
            // 
            // prevButton
            // 
            this.prevButton.Location = new System.Drawing.Point(223, 231);
            this.prevButton.Name = "prevButton";
            this.prevButton.Size = new System.Drawing.Size(86, 23);
            this.prevButton.TabIndex = 10;
            this.prevButton.Text = "Prev";
            this.prevButton.UseVisualStyleBackColor = true;
            this.prevButton.Click += new System.EventHandler(this.prevButton_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.NoteService);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.NoteDate);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(223, 272);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(532, 120);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Info";
            // 
            // NoteService
            // 
            this.NoteService.Enabled = false;
            this.NoteService.Location = new System.Drawing.Point(127, 79);
            this.NoteService.Name = "NoteService";
            this.NoteService.Size = new System.Drawing.Size(384, 23);
            this.NoteService.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(19, 79);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 15);
            this.label8.TabIndex = 5;
            this.label8.Text = "Service";
            // 
            // NoteDate
            // 
            this.NoteDate.Enabled = false;
            this.NoteDate.Location = new System.Drawing.Point(127, 34);
            this.NoteDate.Name = "NoteDate";
            this.NoteDate.Size = new System.Drawing.Size(384, 23);
            this.NoteDate.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 34);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 15);
            this.label6.TabIndex = 1;
            this.label6.Text = "Date";
            // 
            // PrescriptionTP
            // 
            this.PrescriptionTP.BackColor = System.Drawing.Color.LightSkyBlue;
            this.PrescriptionTP.Controls.Add(this.groupBox7);
            this.PrescriptionTP.Controls.Add(this.NextPresc);
            this.PrescriptionTP.Controls.Add(this.PrevPresc);
            this.PrescriptionTP.Controls.Add(this.groupBox6);
            this.PrescriptionTP.Controls.Add(this.groupBox5);
            this.PrescriptionTP.Location = new System.Drawing.Point(4, 24);
            this.PrescriptionTP.Name = "PrescriptionTP";
            this.PrescriptionTP.Size = new System.Drawing.Size(792, 422);
            this.PrescriptionTP.TabIndex = 2;
            this.PrescriptionTP.Text = "Prescriptions";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.button4);
            this.groupBox7.Controls.Add(this.button3);
            this.groupBox7.Location = new System.Drawing.Point(22, 198);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(200, 133);
            this.groupBox7.TabIndex = 4;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Action";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(24, 77);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(143, 23);
            this.button4.TabIndex = 6;
            this.button4.Text = "Save";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(24, 30);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(143, 23);
            this.button3.TabIndex = 5;
            this.button3.Text = "Add";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // NextPresc
            // 
            this.NextPresc.Location = new System.Drawing.Point(611, 350);
            this.NextPresc.Name = "NextPresc";
            this.NextPresc.Size = new System.Drawing.Size(75, 23);
            this.NextPresc.TabIndex = 3;
            this.NextPresc.Text = "Next";
            this.NextPresc.UseVisualStyleBackColor = true;
            this.NextPresc.Click += new System.EventHandler(this.NextPresc_Click);
            // 
            // PrevPresc
            // 
            this.PrevPresc.Location = new System.Drawing.Point(252, 350);
            this.PrevPresc.Name = "PrevPresc";
            this.PrevPresc.Size = new System.Drawing.Size(75, 23);
            this.PrevPresc.TabIndex = 2;
            this.PrevPresc.Text = "Prev";
            this.PrevPresc.UseVisualStyleBackColor = true;
            this.PrevPresc.Click += new System.EventHandler(this.PrevPresc_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.PrescMedicine);
            this.groupBox6.Controls.Add(this.label14);
            this.groupBox6.Controls.Add(this.PrescDiagnosis);
            this.groupBox6.Controls.Add(this.label13);
            this.groupBox6.Location = new System.Drawing.Point(252, 189);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(434, 142);
            this.groupBox6.TabIndex = 1;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Prescription";
            // 
            // PrescMedicine
            // 
            this.PrescMedicine.Enabled = false;
            this.PrescMedicine.FormattingEnabled = true;
            this.PrescMedicine.Location = new System.Drawing.Point(161, 39);
            this.PrescMedicine.Name = "PrescMedicine";
            this.PrescMedicine.Size = new System.Drawing.Size(238, 23);
            this.PrescMedicine.TabIndex = 4;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(31, 86);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(58, 15);
            this.label14.TabIndex = 6;
            this.label14.Text = "Diagnosis";
            // 
            // PrescDiagnosis
            // 
            this.PrescDiagnosis.Enabled = false;
            this.PrescDiagnosis.Location = new System.Drawing.Point(161, 86);
            this.PrescDiagnosis.Name = "PrescDiagnosis";
            this.PrescDiagnosis.Size = new System.Drawing.Size(238, 23);
            this.PrescDiagnosis.TabIndex = 5;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(31, 39);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(56, 15);
            this.label13.TabIndex = 4;
            this.label13.Text = "Medicine";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label12);
            this.groupBox5.Controls.Add(this.SelectDatePresc);
            this.groupBox5.Controls.Add(this.label11);
            this.groupBox5.Controls.Add(this.SelectPatientPresc);
            this.groupBox5.Location = new System.Drawing.Point(22, 36);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(664, 124);
            this.groupBox5.TabIndex = 0;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Selection";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 84);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(139, 15);
            this.label12.TabIndex = 3;
            this.label12.Text = "Select Appointment Date";
            // 
            // SelectDatePresc
            // 
            this.SelectDatePresc.FormattingEnabled = true;
            this.SelectDatePresc.Location = new System.Drawing.Point(261, 81);
            this.SelectDatePresc.Name = "SelectDatePresc";
            this.SelectDatePresc.Size = new System.Drawing.Size(368, 23);
            this.SelectDatePresc.TabIndex = 2;
            this.SelectDatePresc.SelectedIndexChanged += new System.EventHandler(this.SelectDatePresc_SelectedIndexChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 33);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(78, 15);
            this.label11.TabIndex = 1;
            this.label11.Text = "Select Patient";
            // 
            // SelectPatientPresc
            // 
            this.SelectPatientPresc.FormattingEnabled = true;
            this.SelectPatientPresc.Location = new System.Drawing.Point(261, 33);
            this.SelectPatientPresc.Name = "SelectPatientPresc";
            this.SelectPatientPresc.Size = new System.Drawing.Size(368, 23);
            this.SelectPatientPresc.TabIndex = 0;
            this.SelectPatientPresc.SelectedIndexChanged += new System.EventHandler(this.SelectPatientPresc_SelectedIndexChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reloadToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(111, 26);
            // 
            // reloadToolStripMenuItem
            // 
            this.reloadToolStripMenuItem.Name = "reloadToolStripMenuItem";
            this.reloadToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.reloadToolStripMenuItem.Text = "Reload";
            this.reloadToolStripMenuItem.Click += new System.EventHandler(this.reloadToolStripMenuItem_Click);
            // 
            // DoctorClinicForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "DoctorClinicForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DoctorClinicForm";
            this.Load += new System.EventHandler(this.DoctorClinicForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.JournalTP.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.Appointment.ResumeLayout(false);
            this.Appointment.PerformLayout();
            this.PatientsTP.ResumeLayout(false);
            this.PatientsTP.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.PrescriptionTP.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl tabControl1;
        private TabPage JournalTP;
        private TabPage PatientsTP;
        private TabPage PrescriptionTP;
        private GroupBox Appointment;
        private TextBox DateAppointment;
        private Label label5;
        private Label label4;
        private Label label3;
        private TextBox StatusAppointment;
        private Label label2;
        private TextBox ServiceAppointment;
        private Label label1;
        private Button NextAppointment;
        private Button PrevAppointment;
        private ComboBox PatientAppointment;
        private GroupBox groupBox1;
        private MonthCalendar Journal;
        private GroupBox groupBox2;
        private TextBox NoteService;
        private Label label8;
        private TextBox NoteDate;
        private Label label6;
        private Label label7;
        private ComboBox SelectPatient;
        private GroupBox groupBox4;
        private RichTextBox SimptomsNote;
        private TextBox DiagnosisNote;
        private Label label9;
        private Label label10;
        private GroupBox groupBox3;
        private Button saveButton;
        private Button editButton;
        private Button nextButton;
        private Button prevButton;
        private GroupBox groupBox6;
        private GroupBox groupBox5;
        private Label label12;
        private ComboBox SelectDatePresc;
        private Label label11;
        private ComboBox SelectPatientPresc;
        private Button NextPresc;
        private Button PrevPresc;
        private Label label14;
        private TextBox PrescDiagnosis;
        private Label label13;
        private GroupBox groupBox7;
        private Button button4;
        private Button button3;
        private ComboBox PrescMedicine;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem reloadToolStripMenuItem;
    }
}