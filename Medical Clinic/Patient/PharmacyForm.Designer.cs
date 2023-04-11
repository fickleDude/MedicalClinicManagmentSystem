namespace Medical_Clinic.Patient
{
    partial class PharmacyForm
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
            this.ProductsTB = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Amount = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.Price = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.addButton = new System.Windows.Forms.Button();
            this.nextButton = new System.Windows.Forms.Button();
            this.prevButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Vendor = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Company = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Medicine = new System.Windows.Forms.TextBox();
            this.OrderTB = new System.Windows.Forms.TabPage();
            this.clearButton = new System.Windows.Forms.Button();
            this.orderButton = new System.Windows.Forms.Button();
            this.editButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.OrderAmount = new System.Windows.Forms.NumericUpDown();
            this.Total = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.OrderItems = new System.Windows.Forms.ListBox();
            this.OrderPrice = new System.Windows.Forms.TextBox();
            this.Prescriptions = new System.Windows.Forms.CheckedListBox();
            this.HistoryTB = new System.Windows.Forms.TabPage();
            this.NextOrder = new System.Windows.Forms.Button();
            this.PrevOrder = new System.Windows.Forms.Button();
            this.Items = new System.Windows.Forms.ListBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.ListProducts = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.TotalOrder = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.StatusOrder = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.OrderDate = new System.Windows.Forms.TextBox();
            this.PatientPharmacyReload = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.reloadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1.SuspendLayout();
            this.ProductsTB.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Amount)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.OrderTB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OrderAmount)).BeginInit();
            this.HistoryTB.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.PatientPharmacyReload.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.ProductsTB);
            this.tabControl1.Controls.Add(this.OrderTB);
            this.tabControl1.Controls.Add(this.HistoryTB);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 450);
            this.tabControl1.TabIndex = 0;
            // 
            // ProductsTB
            // 
            this.ProductsTB.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ProductsTB.Controls.Add(this.groupBox2);
            this.ProductsTB.Controls.Add(this.addButton);
            this.ProductsTB.Controls.Add(this.nextButton);
            this.ProductsTB.Controls.Add(this.prevButton);
            this.ProductsTB.Controls.Add(this.groupBox1);
            this.ProductsTB.Location = new System.Drawing.Point(4, 24);
            this.ProductsTB.Name = "ProductsTB";
            this.ProductsTB.Padding = new System.Windows.Forms.Padding(3);
            this.ProductsTB.Size = new System.Drawing.Size(792, 422);
            this.ProductsTB.TabIndex = 0;
            this.ProductsTB.Text = "Products";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Amount);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.Price);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(86, 198);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(594, 75);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Price";
            // 
            // Amount
            // 
            this.Amount.Location = new System.Drawing.Point(171, 36);
            this.Amount.Name = "Amount";
            this.Amount.Size = new System.Drawing.Size(73, 23);
            this.Amount.TabIndex = 8;
            this.Amount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Amount.ValueChanged += new System.EventHandler(this.Amount_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(349, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "Price";
            // 
            // Price
            // 
            this.Price.Location = new System.Drawing.Point(493, 36);
            this.Price.Name = "Price";
            this.Price.Size = new System.Drawing.Size(75, 23);
            this.Price.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Amount";
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(86, 279);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(594, 23);
            this.addButton.TabIndex = 4;
            this.addButton.Text = "Add To Order";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // nextButton
            // 
            this.nextButton.Location = new System.Drawing.Point(605, 322);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(75, 23);
            this.nextButton.TabIndex = 3;
            this.nextButton.Text = "Next";
            this.nextButton.UseVisualStyleBackColor = true;
            this.nextButton.Click += new System.EventHandler(this.nextButton_Click);
            // 
            // prevButton
            // 
            this.prevButton.Location = new System.Drawing.Point(86, 322);
            this.prevButton.Name = "prevButton";
            this.prevButton.Size = new System.Drawing.Size(75, 23);
            this.prevButton.TabIndex = 2;
            this.prevButton.Text = "Prev";
            this.prevButton.UseVisualStyleBackColor = true;
            this.prevButton.Click += new System.EventHandler(this.prevButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.Vendor);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.Company);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.Medicine);
            this.groupBox1.Location = new System.Drawing.Point(86, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(594, 171);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Product";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Vendor";
            // 
            // Vendor
            // 
            this.Vendor.Location = new System.Drawing.Point(171, 125);
            this.Vendor.Name = "Vendor";
            this.Vendor.Size = new System.Drawing.Size(397, 23);
            this.Vendor.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Company";
            // 
            // Company
            // 
            this.Company.Location = new System.Drawing.Point(171, 80);
            this.Company.Name = "Company";
            this.Company.Size = new System.Drawing.Size(397, 23);
            this.Company.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Medicine";
            // 
            // Medicine
            // 
            this.Medicine.Location = new System.Drawing.Point(171, 30);
            this.Medicine.Name = "Medicine";
            this.Medicine.Size = new System.Drawing.Size(397, 23);
            this.Medicine.TabIndex = 0;
            // 
            // OrderTB
            // 
            this.OrderTB.BackColor = System.Drawing.Color.LightSkyBlue;
            this.OrderTB.Controls.Add(this.clearButton);
            this.OrderTB.Controls.Add(this.orderButton);
            this.OrderTB.Controls.Add(this.editButton);
            this.OrderTB.Controls.Add(this.saveButton);
            this.OrderTB.Controls.Add(this.deleteButton);
            this.OrderTB.Controls.Add(this.label8);
            this.OrderTB.Controls.Add(this.label7);
            this.OrderTB.Controls.Add(this.OrderAmount);
            this.OrderTB.Controls.Add(this.Total);
            this.OrderTB.Controls.Add(this.label6);
            this.OrderTB.Controls.Add(this.OrderItems);
            this.OrderTB.Controls.Add(this.OrderPrice);
            this.OrderTB.Controls.Add(this.Prescriptions);
            this.OrderTB.Location = new System.Drawing.Point(4, 24);
            this.OrderTB.Name = "OrderTB";
            this.OrderTB.Padding = new System.Windows.Forms.Padding(3);
            this.OrderTB.Size = new System.Drawing.Size(792, 422);
            this.OrderTB.TabIndex = 1;
            this.OrderTB.Text = "My Order";
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(41, 321);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 23);
            this.clearButton.TabIndex = 14;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // orderButton
            // 
            this.orderButton.Location = new System.Drawing.Point(173, 321);
            this.orderButton.Name = "orderButton";
            this.orderButton.Size = new System.Drawing.Size(75, 23);
            this.orderButton.TabIndex = 13;
            this.orderButton.Text = "Order";
            this.orderButton.UseVisualStyleBackColor = true;
            this.orderButton.Click += new System.EventHandler(this.orderButton_Click);
            // 
            // editButton
            // 
            this.editButton.Location = new System.Drawing.Point(41, 205);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(75, 23);
            this.editButton.TabIndex = 12;
            this.editButton.Text = "Edit";
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(173, 205);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 11;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(41, 160);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(207, 23);
            this.deleteButton.TabIndex = 10;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(286, 321);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(32, 15);
            this.label8.TabIndex = 9;
            this.label8.Text = "Total";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(285, 205);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 15);
            this.label7.TabIndex = 7;
            this.label7.Text = "Amount";
            // 
            // OrderAmount
            // 
            this.OrderAmount.Enabled = false;
            this.OrderAmount.Location = new System.Drawing.Point(366, 205);
            this.OrderAmount.Name = "OrderAmount";
            this.OrderAmount.Size = new System.Drawing.Size(229, 23);
            this.OrderAmount.TabIndex = 6;
            // 
            // Total
            // 
            this.Total.Enabled = false;
            this.Total.Location = new System.Drawing.Point(366, 321);
            this.Total.Name = "Total";
            this.Total.Size = new System.Drawing.Size(229, 23);
            this.Total.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(285, 160);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 15);
            this.label6.TabIndex = 5;
            this.label6.Text = "Price";
            // 
            // OrderItems
            // 
            this.OrderItems.FormattingEnabled = true;
            this.OrderItems.ItemHeight = 15;
            this.OrderItems.Location = new System.Drawing.Point(41, 34);
            this.OrderItems.Name = "OrderItems";
            this.OrderItems.Size = new System.Drawing.Size(557, 109);
            this.OrderItems.TabIndex = 2;
            this.OrderItems.SelectedIndexChanged += new System.EventHandler(this.OrderItems_SelectedIndexChanged);
            // 
            // OrderPrice
            // 
            this.OrderPrice.Enabled = false;
            this.OrderPrice.Location = new System.Drawing.Point(366, 160);
            this.OrderPrice.Name = "OrderPrice";
            this.OrderPrice.Size = new System.Drawing.Size(229, 23);
            this.OrderPrice.TabIndex = 3;
            // 
            // Prescriptions
            // 
            this.Prescriptions.FormattingEnabled = true;
            this.Prescriptions.Location = new System.Drawing.Point(642, 34);
            this.Prescriptions.Name = "Prescriptions";
            this.Prescriptions.Size = new System.Drawing.Size(120, 310);
            this.Prescriptions.TabIndex = 0;
            // 
            // HistoryTB
            // 
            this.HistoryTB.BackColor = System.Drawing.Color.LightSkyBlue;
            this.HistoryTB.Controls.Add(this.NextOrder);
            this.HistoryTB.Controls.Add(this.PrevOrder);
            this.HistoryTB.Controls.Add(this.Items);
            this.HistoryTB.Controls.Add(this.groupBox3);
            this.HistoryTB.Location = new System.Drawing.Point(4, 24);
            this.HistoryTB.Name = "HistoryTB";
            this.HistoryTB.Size = new System.Drawing.Size(792, 422);
            this.HistoryTB.TabIndex = 2;
            this.HistoryTB.Text = "History";
            // 
            // NextOrder
            // 
            this.NextOrder.Location = new System.Drawing.Point(402, 290);
            this.NextOrder.Name = "NextOrder";
            this.NextOrder.Size = new System.Drawing.Size(75, 23);
            this.NextOrder.TabIndex = 3;
            this.NextOrder.Text = "Next";
            this.NextOrder.UseVisualStyleBackColor = true;
            this.NextOrder.Click += new System.EventHandler(this.NextOrder_Click);
            // 
            // PrevOrder
            // 
            this.PrevOrder.Location = new System.Drawing.Point(45, 290);
            this.PrevOrder.Name = "PrevOrder";
            this.PrevOrder.Size = new System.Drawing.Size(75, 23);
            this.PrevOrder.TabIndex = 2;
            this.PrevOrder.Text = "Prev";
            this.PrevOrder.UseVisualStyleBackColor = true;
            this.PrevOrder.Click += new System.EventHandler(this.PrevOrder_Click);
            // 
            // Items
            // 
            this.Items.FormattingEnabled = true;
            this.Items.ItemHeight = 15;
            this.Items.Location = new System.Drawing.Point(518, 35);
            this.Items.Name = "Items";
            this.Items.Size = new System.Drawing.Size(239, 229);
            this.Items.TabIndex = 1;
            this.Items.Visible = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.ListProducts);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.TotalOrder);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.StatusOrder);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.OrderDate);
            this.groupBox3.Location = new System.Drawing.Point(45, 23);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(432, 246);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Order";
            // 
            // ListProducts
            // 
            this.ListProducts.Location = new System.Drawing.Point(36, 198);
            this.ListProducts.Name = "ListProducts";
            this.ListProducts.Size = new System.Drawing.Size(371, 23);
            this.ListProducts.TabIndex = 6;
            this.ListProducts.Text = "List Products";
            this.ListProducts.UseVisualStyleBackColor = true;
            this.ListProducts.Click += new System.EventHandler(this.ListProducts_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(36, 140);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(32, 15);
            this.label11.TabIndex = 5;
            this.label11.Text = "Total";
            // 
            // TotalOrder
            // 
            this.TotalOrder.Enabled = false;
            this.TotalOrder.Location = new System.Drawing.Point(161, 140);
            this.TotalOrder.Name = "TotalOrder";
            this.TotalOrder.Size = new System.Drawing.Size(246, 23);
            this.TotalOrder.TabIndex = 4;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(36, 85);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(39, 15);
            this.label10.TabIndex = 3;
            this.label10.Text = "Status";
            // 
            // StatusOrder
            // 
            this.StatusOrder.Enabled = false;
            this.StatusOrder.Location = new System.Drawing.Point(161, 85);
            this.StatusOrder.Name = "StatusOrder";
            this.StatusOrder.Size = new System.Drawing.Size(246, 23);
            this.StatusOrder.TabIndex = 2;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(36, 38);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(31, 15);
            this.label9.TabIndex = 1;
            this.label9.Text = "Date";
            // 
            // OrderDate
            // 
            this.OrderDate.Enabled = false;
            this.OrderDate.Location = new System.Drawing.Point(161, 38);
            this.OrderDate.Name = "OrderDate";
            this.OrderDate.Size = new System.Drawing.Size(246, 23);
            this.OrderDate.TabIndex = 0;
            // 
            // PatientPharmacyReload
            // 
            this.PatientPharmacyReload.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reloadToolStripMenuItem});
            this.PatientPharmacyReload.Name = "contextMenuStrip1";
            this.PatientPharmacyReload.Size = new System.Drawing.Size(111, 26);
            // 
            // reloadToolStripMenuItem
            // 
            this.reloadToolStripMenuItem.Name = "reloadToolStripMenuItem";
            this.reloadToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.reloadToolStripMenuItem.Text = "Reload";
            this.reloadToolStripMenuItem.Click += new System.EventHandler(this.reloadToolStripMenuItem_Click);
            // 
            // PharmacyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "PharmacyForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pharmacy";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PharmacyForm_FormClosing);
            this.Load += new System.EventHandler(this.PharmacyForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.ProductsTB.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Amount)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.OrderTB.ResumeLayout(false);
            this.OrderTB.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OrderAmount)).EndInit();
            this.HistoryTB.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.PatientPharmacyReload.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl tabControl1;
        private TabPage ProductsTB;
        private TabPage OrderTB;
        private TabPage HistoryTB;
        private GroupBox groupBox2;
        private NumericUpDown Amount;
        private Label label5;
        private TextBox Price;
        private Label label4;
        private Button addButton;
        private Button nextButton;
        private Button prevButton;
        private GroupBox groupBox1;
        private Label label3;
        private TextBox Vendor;
        private Label label2;
        private TextBox Company;
        private Label label1;
        private TextBox Medicine;
        private Button clearButton;
        private Button orderButton;
        private Button editButton;
        private Button saveButton;
        private Button deleteButton;
        private Label label8;
        private Label label7;
        private NumericUpDown OrderAmount;
        private TextBox Total;
        private Label label6;
        private ListBox OrderItems;
        private TextBox OrderPrice;
        private CheckedListBox Prescriptions;
        private ContextMenuStrip PatientPharmacyReload;
        private ToolStripMenuItem reloadToolStripMenuItem;
        private Button NextOrder;
        private Button PrevOrder;
        private ListBox Items;
        private GroupBox groupBox3;
        private Button ListProducts;
        private Label label11;
        private TextBox TotalOrder;
        private Label label10;
        private TextBox StatusOrder;
        private Label label9;
        private TextBox OrderDate;
    }
}