namespace Medical_Clinic.Admin
{
    partial class PharmacyAdminForm
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
            this.ProductTB = new System.Windows.Forms.TabPage();
            this.deleteButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.ProductProduct = new System.Windows.Forms.GroupBox();
            this.cancelButton = new System.Windows.Forms.Button();
            this.editButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.ProductAmount = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.ProductPrice = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Vendor = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Medicine = new System.Windows.Forms.ComboBox();
            this.ProductDG = new System.Windows.Forms.DataGridView();
            this.MedicineTB = new System.Windows.Forms.TabPage();
            this.deleteMedicinebutton = new System.Windows.Forms.Button();
            this.addMedicinebutton = new System.Windows.Forms.Button();
            this.MedicineMedicine = new System.Windows.Forms.GroupBox();
            this.CancelMedicine = new System.Windows.Forms.Button();
            this.EditMedicine = new System.Windows.Forms.Button();
            this.SaveMedicine = new System.Windows.Forms.Button();
            this.MedicineCompany = new System.Windows.Forms.ComboBox();
            this.Company = new System.Windows.Forms.Label();
            this.Name = new System.Windows.Forms.Label();
            this.MedicineName = new System.Windows.Forms.TextBox();
            this.MedicineDG = new System.Windows.Forms.DataGridView();
            this.VendorTB = new System.Windows.Forms.TabPage();
            this.DeleteVendor = new System.Windows.Forms.Button();
            this.AddVendor = new System.Windows.Forms.Button();
            this.VendorGB = new System.Windows.Forms.GroupBox();
            this.VendorNumber = new System.Windows.Forms.MaskedTextBox();
            this.CancelVendor = new System.Windows.Forms.Button();
            this.EditVendor = new System.Windows.Forms.Button();
            this.SaveVendor = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.VendorLocation = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.VendorName = new System.Windows.Forms.TextBox();
            this.VendorDG = new System.Windows.Forms.DataGridView();
            this.OrderTB = new System.Windows.Forms.TabPage();
            this.OrderAction = new System.Windows.Forms.GroupBox();
            this.SortByTotal = new System.Windows.Forms.Button();
            this.SortByDate = new System.Windows.Forms.Button();
            this.CancelOrder = new System.Windows.Forms.Button();
            this.CompleteOrder = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ClearOrderFilters = new System.Windows.Forms.Button();
            this.DateOrder = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.PatientOrder = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.OrderDG = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.updateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1.SuspendLayout();
            this.ProductTB.SuspendLayout();
            this.ProductProduct.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProductAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductDG)).BeginInit();
            this.MedicineTB.SuspendLayout();
            this.MedicineMedicine.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MedicineDG)).BeginInit();
            this.VendorTB.SuspendLayout();
            this.VendorGB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.VendorDG)).BeginInit();
            this.OrderTB.SuspendLayout();
            this.OrderAction.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OrderDG)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.ProductTB);
            this.tabControl1.Controls.Add(this.MedicineTB);
            this.tabControl1.Controls.Add(this.VendorTB);
            this.tabControl1.Controls.Add(this.OrderTB);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 450);
            this.tabControl1.TabIndex = 0;
            // 
            // ProductTB
            // 
            this.ProductTB.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ProductTB.Controls.Add(this.deleteButton);
            this.ProductTB.Controls.Add(this.addButton);
            this.ProductTB.Controls.Add(this.ProductProduct);
            this.ProductTB.Controls.Add(this.ProductDG);
            this.ProductTB.Location = new System.Drawing.Point(4, 24);
            this.ProductTB.Name = "ProductTB";
            this.ProductTB.Padding = new System.Windows.Forms.Padding(3);
            this.ProductTB.Size = new System.Drawing.Size(792, 422);
            this.ProductTB.TabIndex = 0;
            this.ProductTB.Text = "Products";
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(290, 341);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(108, 23);
            this.deleteButton.TabIndex = 13;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(21, 341);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(108, 23);
            this.addButton.TabIndex = 12;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // ProductProduct
            // 
            this.ProductProduct.Controls.Add(this.cancelButton);
            this.ProductProduct.Controls.Add(this.editButton);
            this.ProductProduct.Controls.Add(this.saveButton);
            this.ProductProduct.Controls.Add(this.ProductAmount);
            this.ProductProduct.Controls.Add(this.label4);
            this.ProductProduct.Controls.Add(this.ProductPrice);
            this.ProductProduct.Controls.Add(this.label3);
            this.ProductProduct.Controls.Add(this.label2);
            this.ProductProduct.Controls.Add(this.Vendor);
            this.ProductProduct.Controls.Add(this.label1);
            this.ProductProduct.Controls.Add(this.Medicine);
            this.ProductProduct.Location = new System.Drawing.Point(426, 19);
            this.ProductProduct.Name = "ProductProduct";
            this.ProductProduct.Size = new System.Drawing.Size(337, 362);
            this.ProductProduct.TabIndex = 1;
            this.ProductProduct.TabStop = false;
            this.ProductProduct.Text = "Product";
            this.ProductProduct.Visible = false;
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(19, 322);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(303, 23);
            this.cancelButton.TabIndex = 11;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // editButton
            // 
            this.editButton.Location = new System.Drawing.Point(19, 284);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(303, 23);
            this.editButton.TabIndex = 10;
            this.editButton.Text = "Edit";
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(19, 243);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(303, 23);
            this.saveButton.TabIndex = 9;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // ProductAmount
            // 
            this.ProductAmount.Enabled = false;
            this.ProductAmount.Location = new System.Drawing.Point(116, 188);
            this.ProductAmount.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.ProductAmount.Name = "ProductAmount";
            this.ProductAmount.Size = new System.Drawing.Size(206, 23);
            this.ProductAmount.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 188);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Amount";
            // 
            // ProductPrice
            // 
            this.ProductPrice.Enabled = false;
            this.ProductPrice.Location = new System.Drawing.Point(116, 136);
            this.ProductPrice.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.ProductPrice.Name = "ProductPrice";
            this.ProductPrice.Size = new System.Drawing.Size(206, 23);
            this.ProductPrice.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Price";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Vendor";
            // 
            // Vendor
            // 
            this.Vendor.Enabled = false;
            this.Vendor.FormattingEnabled = true;
            this.Vendor.Location = new System.Drawing.Point(116, 80);
            this.Vendor.Name = "Vendor";
            this.Vendor.Size = new System.Drawing.Size(206, 23);
            this.Vendor.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Medicine";
            // 
            // Medicine
            // 
            this.Medicine.Enabled = false;
            this.Medicine.FormattingEnabled = true;
            this.Medicine.Location = new System.Drawing.Point(116, 25);
            this.Medicine.Name = "Medicine";
            this.Medicine.Size = new System.Drawing.Size(206, 23);
            this.Medicine.TabIndex = 0;
            // 
            // ProductDG
            // 
            this.ProductDG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProductDG.Location = new System.Drawing.Point(21, 19);
            this.ProductDG.Name = "ProductDG";
            this.ProductDG.RowTemplate.Height = 25;
            this.ProductDG.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ProductDG.Size = new System.Drawing.Size(377, 307);
            this.ProductDG.TabIndex = 0;
            this.ProductDG.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ProductDG_CellContentClick);
            // 
            // MedicineTB
            // 
            this.MedicineTB.BackColor = System.Drawing.Color.LightSkyBlue;
            this.MedicineTB.Controls.Add(this.deleteMedicinebutton);
            this.MedicineTB.Controls.Add(this.addMedicinebutton);
            this.MedicineTB.Controls.Add(this.MedicineMedicine);
            this.MedicineTB.Controls.Add(this.MedicineDG);
            this.MedicineTB.Location = new System.Drawing.Point(4, 24);
            this.MedicineTB.Name = "MedicineTB";
            this.MedicineTB.Size = new System.Drawing.Size(792, 422);
            this.MedicineTB.TabIndex = 3;
            this.MedicineTB.Text = "Medicines";
            // 
            // deleteMedicinebutton
            // 
            this.deleteMedicinebutton.Location = new System.Drawing.Point(216, 298);
            this.deleteMedicinebutton.Name = "deleteMedicinebutton";
            this.deleteMedicinebutton.Size = new System.Drawing.Size(75, 23);
            this.deleteMedicinebutton.TabIndex = 3;
            this.deleteMedicinebutton.Text = "Delete";
            this.deleteMedicinebutton.UseVisualStyleBackColor = true;
            this.deleteMedicinebutton.Click += new System.EventHandler(this.deleteMedicinebutton_Click);
            // 
            // addMedicinebutton
            // 
            this.addMedicinebutton.Location = new System.Drawing.Point(23, 298);
            this.addMedicinebutton.Name = "addMedicinebutton";
            this.addMedicinebutton.Size = new System.Drawing.Size(75, 23);
            this.addMedicinebutton.TabIndex = 2;
            this.addMedicinebutton.Text = "Add";
            this.addMedicinebutton.UseVisualStyleBackColor = true;
            this.addMedicinebutton.Click += new System.EventHandler(this.addMedicinebutton_Click);
            // 
            // MedicineMedicine
            // 
            this.MedicineMedicine.Controls.Add(this.CancelMedicine);
            this.MedicineMedicine.Controls.Add(this.EditMedicine);
            this.MedicineMedicine.Controls.Add(this.SaveMedicine);
            this.MedicineMedicine.Controls.Add(this.MedicineCompany);
            this.MedicineMedicine.Controls.Add(this.Company);
            this.MedicineMedicine.Controls.Add(this.Name);
            this.MedicineMedicine.Controls.Add(this.MedicineName);
            this.MedicineMedicine.Location = new System.Drawing.Point(365, 44);
            this.MedicineMedicine.Name = "MedicineMedicine";
            this.MedicineMedicine.Size = new System.Drawing.Size(383, 304);
            this.MedicineMedicine.TabIndex = 1;
            this.MedicineMedicine.TabStop = false;
            this.MedicineMedicine.Text = "Medicine";
            this.MedicineMedicine.Visible = false;
            // 
            // CancelMedicine
            // 
            this.CancelMedicine.Location = new System.Drawing.Point(22, 254);
            this.CancelMedicine.Name = "CancelMedicine";
            this.CancelMedicine.Size = new System.Drawing.Size(343, 23);
            this.CancelMedicine.TabIndex = 7;
            this.CancelMedicine.Text = "Cancel";
            this.CancelMedicine.UseVisualStyleBackColor = true;
            this.CancelMedicine.Click += new System.EventHandler(this.CancelMedicine_Click);
            // 
            // EditMedicine
            // 
            this.EditMedicine.Location = new System.Drawing.Point(22, 211);
            this.EditMedicine.Name = "EditMedicine";
            this.EditMedicine.Size = new System.Drawing.Size(343, 23);
            this.EditMedicine.TabIndex = 6;
            this.EditMedicine.Text = "Edit";
            this.EditMedicine.UseVisualStyleBackColor = true;
            this.EditMedicine.Click += new System.EventHandler(this.EditMedicine_Click);
            // 
            // SaveMedicine
            // 
            this.SaveMedicine.Location = new System.Drawing.Point(22, 166);
            this.SaveMedicine.Name = "SaveMedicine";
            this.SaveMedicine.Size = new System.Drawing.Size(343, 23);
            this.SaveMedicine.TabIndex = 5;
            this.SaveMedicine.Text = "Save";
            this.SaveMedicine.UseVisualStyleBackColor = true;
            this.SaveMedicine.Click += new System.EventHandler(this.SaveMedicine_Click);
            // 
            // MedicineCompany
            // 
            this.MedicineCompany.Enabled = false;
            this.MedicineCompany.FormattingEnabled = true;
            this.MedicineCompany.Location = new System.Drawing.Point(129, 108);
            this.MedicineCompany.Name = "MedicineCompany";
            this.MedicineCompany.Size = new System.Drawing.Size(236, 23);
            this.MedicineCompany.TabIndex = 4;
            // 
            // Company
            // 
            this.Company.AutoSize = true;
            this.Company.Location = new System.Drawing.Point(22, 108);
            this.Company.Name = "Company";
            this.Company.Size = new System.Drawing.Size(59, 15);
            this.Company.TabIndex = 3;
            this.Company.Text = "Company";
            // 
            // Name
            // 
            this.Name.AutoSize = true;
            this.Name.Location = new System.Drawing.Point(22, 54);
            this.Name.Name = "Name";
            this.Name.Size = new System.Drawing.Size(39, 15);
            this.Name.TabIndex = 1;
            this.Name.Text = "Name";
            // 
            // MedicineName
            // 
            this.MedicineName.Enabled = false;
            this.MedicineName.Location = new System.Drawing.Point(129, 54);
            this.MedicineName.Name = "MedicineName";
            this.MedicineName.Size = new System.Drawing.Size(236, 23);
            this.MedicineName.TabIndex = 0;
            // 
            // MedicineDG
            // 
            this.MedicineDG.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.MedicineDG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MedicineDG.Location = new System.Drawing.Point(23, 44);
            this.MedicineDG.Name = "MedicineDG";
            this.MedicineDG.RowTemplate.Height = 25;
            this.MedicineDG.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.MedicineDG.Size = new System.Drawing.Size(268, 234);
            this.MedicineDG.TabIndex = 0;
            this.MedicineDG.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.MedicineDG_CellContentClick);
            // 
            // VendorTB
            // 
            this.VendorTB.BackColor = System.Drawing.Color.LightSkyBlue;
            this.VendorTB.Controls.Add(this.DeleteVendor);
            this.VendorTB.Controls.Add(this.AddVendor);
            this.VendorTB.Controls.Add(this.VendorGB);
            this.VendorTB.Controls.Add(this.VendorDG);
            this.VendorTB.Location = new System.Drawing.Point(4, 24);
            this.VendorTB.Name = "VendorTB";
            this.VendorTB.Size = new System.Drawing.Size(792, 422);
            this.VendorTB.TabIndex = 2;
            this.VendorTB.Text = "Vendors";
            // 
            // DeleteVendor
            // 
            this.DeleteVendor.Location = new System.Drawing.Point(250, 243);
            this.DeleteVendor.Name = "DeleteVendor";
            this.DeleteVendor.Size = new System.Drawing.Size(75, 23);
            this.DeleteVendor.TabIndex = 3;
            this.DeleteVendor.Text = "Delete";
            this.DeleteVendor.UseVisualStyleBackColor = true;
            this.DeleteVendor.Click += new System.EventHandler(this.DeleteVendor_Click);
            // 
            // AddVendor
            // 
            this.AddVendor.Location = new System.Drawing.Point(22, 243);
            this.AddVendor.Name = "AddVendor";
            this.AddVendor.Size = new System.Drawing.Size(75, 23);
            this.AddVendor.TabIndex = 2;
            this.AddVendor.Text = "Add";
            this.AddVendor.UseVisualStyleBackColor = true;
            this.AddVendor.Click += new System.EventHandler(this.AddVendor_Click);
            // 
            // VendorGB
            // 
            this.VendorGB.Controls.Add(this.VendorNumber);
            this.VendorGB.Controls.Add(this.CancelVendor);
            this.VendorGB.Controls.Add(this.EditVendor);
            this.VendorGB.Controls.Add(this.SaveVendor);
            this.VendorGB.Controls.Add(this.label7);
            this.VendorGB.Controls.Add(this.VendorLocation);
            this.VendorGB.Controls.Add(this.label6);
            this.VendorGB.Controls.Add(this.label5);
            this.VendorGB.Controls.Add(this.VendorName);
            this.VendorGB.Location = new System.Drawing.Point(358, 51);
            this.VendorGB.Name = "VendorGB";
            this.VendorGB.Size = new System.Drawing.Size(393, 348);
            this.VendorGB.TabIndex = 1;
            this.VendorGB.TabStop = false;
            this.VendorGB.Text = "Vendor";
            this.VendorGB.Visible = false;
            // 
            // VendorNumber
            // 
            this.VendorNumber.Enabled = false;
            this.VendorNumber.Location = new System.Drawing.Point(140, 104);
            this.VendorNumber.Mask = "(+0) 000-000-0000";
            this.VendorNumber.Name = "VendorNumber";
            this.VendorNumber.Size = new System.Drawing.Size(225, 23);
            this.VendorNumber.TabIndex = 9;
            // 
            // CancelVendor
            // 
            this.CancelVendor.Location = new System.Drawing.Point(30, 305);
            this.CancelVendor.Name = "CancelVendor";
            this.CancelVendor.Size = new System.Drawing.Size(335, 23);
            this.CancelVendor.TabIndex = 8;
            this.CancelVendor.Text = "Cancel";
            this.CancelVendor.UseVisualStyleBackColor = true;
            this.CancelVendor.Click += new System.EventHandler(this.CancelVendor_Click);
            // 
            // EditVendor
            // 
            this.EditVendor.Location = new System.Drawing.Point(30, 261);
            this.EditVendor.Name = "EditVendor";
            this.EditVendor.Size = new System.Drawing.Size(335, 23);
            this.EditVendor.TabIndex = 7;
            this.EditVendor.Text = "Edit";
            this.EditVendor.UseVisualStyleBackColor = true;
            this.EditVendor.Click += new System.EventHandler(this.EditVendor_Click);
            // 
            // SaveVendor
            // 
            this.SaveVendor.Location = new System.Drawing.Point(30, 217);
            this.SaveVendor.Name = "SaveVendor";
            this.SaveVendor.Size = new System.Drawing.Size(335, 23);
            this.SaveVendor.TabIndex = 6;
            this.SaveVendor.Text = "Save";
            this.SaveVendor.UseVisualStyleBackColor = true;
            this.SaveVendor.Click += new System.EventHandler(this.SaveVendor_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(30, 155);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 15);
            this.label7.TabIndex = 5;
            this.label7.Text = "Location";
            // 
            // VendorLocation
            // 
            this.VendorLocation.Enabled = false;
            this.VendorLocation.Location = new System.Drawing.Point(140, 156);
            this.VendorLocation.Name = "VendorLocation";
            this.VendorLocation.Size = new System.Drawing.Size(225, 23);
            this.VendorLocation.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(30, 104);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 15);
            this.label6.TabIndex = 3;
            this.label6.Text = "Number";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 15);
            this.label5.TabIndex = 1;
            this.label5.Text = "Name";
            // 
            // VendorName
            // 
            this.VendorName.Enabled = false;
            this.VendorName.Location = new System.Drawing.Point(140, 56);
            this.VendorName.Name = "VendorName";
            this.VendorName.Size = new System.Drawing.Size(225, 23);
            this.VendorName.TabIndex = 0;
            // 
            // VendorDG
            // 
            this.VendorDG.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.VendorDG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.VendorDG.Location = new System.Drawing.Point(22, 51);
            this.VendorDG.Name = "VendorDG";
            this.VendorDG.RowTemplate.Height = 25;
            this.VendorDG.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.VendorDG.Size = new System.Drawing.Size(303, 170);
            this.VendorDG.TabIndex = 0;
            this.VendorDG.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.VendorDG_CellContentClick);
            // 
            // OrderTB
            // 
            this.OrderTB.BackColor = System.Drawing.Color.LightSkyBlue;
            this.OrderTB.Controls.Add(this.OrderAction);
            this.OrderTB.Controls.Add(this.groupBox1);
            this.OrderTB.Controls.Add(this.OrderDG);
            this.OrderTB.Location = new System.Drawing.Point(4, 24);
            this.OrderTB.Name = "OrderTB";
            this.OrderTB.Padding = new System.Windows.Forms.Padding(3);
            this.OrderTB.Size = new System.Drawing.Size(792, 422);
            this.OrderTB.TabIndex = 1;
            this.OrderTB.Text = "Orders";
            // 
            // OrderAction
            // 
            this.OrderAction.Controls.Add(this.SortByTotal);
            this.OrderAction.Controls.Add(this.SortByDate);
            this.OrderAction.Controls.Add(this.CancelOrder);
            this.OrderAction.Controls.Add(this.CompleteOrder);
            this.OrderAction.Location = new System.Drawing.Point(568, 99);
            this.OrderAction.Name = "OrderAction";
            this.OrderAction.Size = new System.Drawing.Size(190, 239);
            this.OrderAction.TabIndex = 4;
            this.OrderAction.TabStop = false;
            this.OrderAction.Text = "Action";
            this.OrderAction.Visible = false;
            // 
            // SortByTotal
            // 
            this.SortByTotal.Location = new System.Drawing.Point(20, 193);
            this.SortByTotal.Name = "SortByTotal";
            this.SortByTotal.Size = new System.Drawing.Size(150, 23);
            this.SortByTotal.TabIndex = 4;
            this.SortByTotal.Text = "Sort by Total";
            this.SortByTotal.UseVisualStyleBackColor = true;
            this.SortByTotal.Click += new System.EventHandler(this.SortByTotal_Click);
            // 
            // SortByDate
            // 
            this.SortByDate.Location = new System.Drawing.Point(20, 151);
            this.SortByDate.Name = "SortByDate";
            this.SortByDate.Size = new System.Drawing.Size(150, 23);
            this.SortByDate.TabIndex = 3;
            this.SortByDate.Text = "Sort by Date";
            this.SortByDate.UseVisualStyleBackColor = true;
            this.SortByDate.Click += new System.EventHandler(this.SortByDate_Click);
            // 
            // CancelOrder
            // 
            this.CancelOrder.Location = new System.Drawing.Point(20, 75);
            this.CancelOrder.Name = "CancelOrder";
            this.CancelOrder.Size = new System.Drawing.Size(150, 23);
            this.CancelOrder.TabIndex = 2;
            this.CancelOrder.Text = "Cancel";
            this.CancelOrder.UseVisualStyleBackColor = true;
            this.CancelOrder.Click += new System.EventHandler(this.CancelOrder_Click);
            // 
            // CompleteOrder
            // 
            this.CompleteOrder.Location = new System.Drawing.Point(20, 33);
            this.CompleteOrder.Name = "CompleteOrder";
            this.CompleteOrder.Size = new System.Drawing.Size(150, 23);
            this.CompleteOrder.TabIndex = 1;
            this.CompleteOrder.Text = "Complete";
            this.CompleteOrder.UseVisualStyleBackColor = true;
            this.CompleteOrder.Click += new System.EventHandler(this.CompleteOrder_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ClearOrderFilters);
            this.groupBox1.Controls.Add(this.DateOrder);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.PatientOrder);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Location = new System.Drawing.Point(27, 20);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(731, 61);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filter";
            // 
            // ClearOrderFilters
            // 
            this.ClearOrderFilters.Location = new System.Drawing.Point(620, 23);
            this.ClearOrderFilters.Name = "ClearOrderFilters";
            this.ClearOrderFilters.Size = new System.Drawing.Size(91, 23);
            this.ClearOrderFilters.TabIndex = 5;
            this.ClearOrderFilters.Text = "Clear";
            this.ClearOrderFilters.UseVisualStyleBackColor = true;
            this.ClearOrderFilters.Click += new System.EventHandler(this.ClearOrderFilters_Click);
            // 
            // DateOrder
            // 
            this.DateOrder.FormattingEnabled = true;
            this.DateOrder.Location = new System.Drawing.Point(69, 22);
            this.DateOrder.Name = "DateOrder";
            this.DateOrder.Size = new System.Drawing.Size(218, 23);
            this.DateOrder.TabIndex = 3;
            this.DateOrder.SelectedIndexChanged += new System.EventHandler(this.DateOrder_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(17, 22);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(31, 15);
            this.label9.TabIndex = 4;
            this.label9.Text = "Date";
            // 
            // PatientOrder
            // 
            this.PatientOrder.FormattingEnabled = true;
            this.PatientOrder.Location = new System.Drawing.Point(379, 22);
            this.PatientOrder.Name = "PatientOrder";
            this.PatientOrder.Size = new System.Drawing.Size(218, 23);
            this.PatientOrder.TabIndex = 1;
            this.PatientOrder.SelectedIndexChanged += new System.EventHandler(this.PatientOrder_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(314, 23);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 15);
            this.label8.TabIndex = 2;
            this.label8.Text = "Patient";
            // 
            // OrderDG
            // 
            this.OrderDG.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.OrderDG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OrderDG.Location = new System.Drawing.Point(27, 99);
            this.OrderDG.Name = "OrderDG";
            this.OrderDG.RowTemplate.Height = 25;
            this.OrderDG.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.OrderDG.Size = new System.Drawing.Size(506, 239);
            this.OrderDG.TabIndex = 0;
            this.OrderDG.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.OrederDG_CellContentClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.updateToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(111, 26);
            // 
            // updateToolStripMenuItem
            // 
            this.updateToolStripMenuItem.Name = "updateToolStripMenuItem";
            this.updateToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.updateToolStripMenuItem.Text = "Reload";
            this.updateToolStripMenuItem.Click += new System.EventHandler(this.updateToolStripMenuItem_Click);
            // 
            // PharmacyAdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            //this.Name = "PharmacyAdminForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PharmacyAdminForm";
            this.Load += new System.EventHandler(this.PharmacyAdminForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.ProductTB.ResumeLayout(false);
            this.ProductProduct.ResumeLayout(false);
            this.ProductProduct.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProductAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductDG)).EndInit();
            this.MedicineTB.ResumeLayout(false);
            this.MedicineMedicine.ResumeLayout(false);
            this.MedicineMedicine.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MedicineDG)).EndInit();
            this.VendorTB.ResumeLayout(false);
            this.VendorGB.ResumeLayout(false);
            this.VendorGB.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.VendorDG)).EndInit();
            this.OrderTB.ResumeLayout(false);
            this.OrderAction.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OrderDG)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl tabControl1;
        private TabPage ProductTB;
        private TabPage OrderTB;
        private DataGridView ProductDG;
        private TabPage MedicineTB;
        private TabPage VendorTB;
        private Button deleteButton;
        private Button addButton;
        private GroupBox ProductProduct;
        private Button cancelButton;
        private Button editButton;
        private Button saveButton;
        private NumericUpDown ProductAmount;
        private Label label4;
        private NumericUpDown ProductPrice;
        private Label label3;
        private Label label2;
        private ComboBox Vendor;
        private Label label1;
        private ComboBox Medicine;
        private GroupBox MedicineMedicine;
        private TextBox MedicineName;
        private DataGridView MedicineDG;
        private Button deleteMedicinebutton;
        private Button addMedicinebutton;
        private Button CancelMedicine;
        private Button EditMedicine;
        private Button SaveMedicine;
        private ComboBox MedicineCompany;
        private Label Company;
        private Label Name;
        private Button DeleteVendor;
        private Button AddVendor;
        private GroupBox VendorGB;
        private Button CancelVendor;
        private Button EditVendor;
        private Button SaveVendor;
        private Label label7;
        private TextBox VendorLocation;
        private Label label6;
        private Label label5;
        private TextBox VendorName;
        private DataGridView VendorDG;
        private MaskedTextBox VendorNumber;
        private GroupBox groupBox1;
        private ComboBox DateOrder;
        private Label label9;
        private ComboBox PatientOrder;
        private Label label8;
        private DataGridView OrderDG;
        private GroupBox OrderAction;
        private Button CancelOrder;
        private Button CompleteOrder;
        private Button SortByTotal;
        private Button SortByDate;
        private Button ClearOrderFilters;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem updateToolStripMenuItem;
    }
}