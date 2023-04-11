using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Medical_Clinic.General;
using Microsoft.Data.SqlClient;
using XAct.Constants;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Medical_Clinic.Admin
{
    public partial class PharmacyAdminForm : Form
    {
        private Connection connection;

        //PRODUCT TAB
        private SqlDataAdapter dProductAdapter;
        private DataSet dProductSet;
        private long currentProduct;

        //MEDICINE TAB
        private SqlDataAdapter dMedicineAdapter;
        private DataSet dMedicineSet;
        private long currentMedicine;

        //VENDOR TAB
        private SqlDataAdapter dVendorAdapter;
        private DataSet dVendorSet;
        private long currentVendor;     
        
        //ORDER TAB
        private SqlDataAdapter dOrderAdapter;
        private DataSet dOrderSet;
        private long currentOrder;

        public PharmacyAdminForm(Connection connection)
        {
            InitializeComponent();

            this.connection = connection;

            dProductSet = new DataSet();
            dMedicineSet = new DataSet();
            dVendorSet = new DataSet();
            dOrderSet = new DataSet();

            this.ContextMenuStrip = contextMenuStrip1;
        }

        private void PharmacyAdminForm_Load(object sender, EventArgs e)
        {
            //PRODUCT TAB
            FillProductsDG();
            FillMedicineCB();
            FillVendorCB();

            //MEDICINE TAB
            FillMedicineDG();
            FillCompanyCB();

            //VENDOR TAB
            FillVendorDG();

            //ORDER TAB
            FillOrders(null, null);
            FillPatients();
            FillDates();
        }

        //PRODUCT TAB
        private void ProductDG_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.ProductDG.Rows[e.RowIndex];
                
                //Vendor.SelectedIndex = Vendor.FindStringExact(row.Cells["Vendor"].Value.ToString());
                //Medicine.SelectedIndex = Medicine.FindStringExact(row.Cells["Medicine"].Value.ToString());

                Medicine.Text = row.Cells["Medicine"].Value.ToString();
                Vendor.Text = row.Cells["Vendor"].Value.ToString();
                ProductPrice.Value = (decimal)row.Cells["Price"].Value;
                ProductAmount.Value = (int)row.Cells["Amount"].Value;

                string sqlQuery = $"select ID from AdminProductView where Medicine = '{Medicine.Text}' and Vendor = '{Vendor.Text}' " +
                       $"and Price = '{ProductPrice.Value}' and Amount = '{ProductAmount.Value}'";
                SqlCommand command = new SqlCommand(sqlQuery, connection.GetConnection());
                connection.OpenConnection();

                SqlDataReader idReader = command.ExecuteReader();
                if (idReader.Read())
                    currentProduct = (long)idReader["ID"];
                idReader.Close();
            }
            editButton.Enabled = true;
            ProductProduct.Visible = true;
        }
        private void FillProductsDG()
        {
            string sqlQuery = $"select Medicine, Amount, Price, Vendor from AdminProductView";

            dProductAdapter = new SqlDataAdapter(sqlQuery, connection.GetConnection());
            dProductSet.Clear();
            dProductAdapter.Fill(dProductSet, "AdminProductView");

            ProductDG.DataSource = dProductSet.Tables["AdminProductView"];
        }

        private void FillMedicineCB()
        {
            string sqlQuery = "select Name, Company from Medicines";
            SqlCommand command = new SqlCommand(sqlQuery, connection.GetConnection());
            connection.OpenConnection();

            SqlDataReader medicineReader = command.ExecuteReader();
            Medicine.Items.Clear();
            while (medicineReader.Read())
                Medicine.Items.Add(medicineReader["Name"] + " "+ medicineReader["Company"]);

            medicineReader.Close();
        }    
        
        private void FillVendorCB()
        {
            string sqlQuery = "select Name from Vendors";
            SqlCommand command = new SqlCommand(sqlQuery, connection.GetConnection());
            connection.OpenConnection();

            SqlDataReader vendorReader = command.ExecuteReader();
            Vendor.Items.Clear();
            while (vendorReader.Read())
                Vendor.Items.Add(vendorReader["Name"]);

            vendorReader.Close();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            editButton.Enabled = false;
            currentProduct = -1;

            Vendor.Enabled = true;
            Vendor.Text = "";    
            
            Medicine.Enabled = true;
            Medicine.Text = "";

            ProductPrice.Enabled = true;
            ProductPrice.Value = 0;    
            
            ProductAmount.Enabled = true;
            ProductAmount.Value = 0;

            ProductProduct.Visible = true;
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            //delete product
            string sqlQuery = $"DELETE FROM PharmacyProducts WHERE ID = '{currentProduct}';";
            SqlCommand command = new SqlCommand(sqlQuery, connection.GetConnection());
            connection.OpenConnection();
            command.ExecuteNonQuery();

            ProductProduct.Visible = false;
            dProductSet.Clear();
            dProductAdapter.Fill(dProductSet, "AdminProductView");
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            long medicineId = GetMedicineId();
            int vendorId = GetVendorId();
            if (currentProduct != -1) //modify
            {
                string sqlQuery = $"update PharmacyProducts set MedicineID = '{medicineId}', VendorID = '{vendorId}', Price = '{ProductPrice.Value}', Amount = '{ProductAmount.Value}' where ID = '{currentProduct}'";
                SqlCommand command = new SqlCommand(sqlQuery, connection.GetConnection());
                connection.OpenConnection();
                command.ExecuteNonQuery();
                MessageBox.Show("Product Modified!", "Product",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else //add new
            {
                //search for medicine in DB
                string sqlQuery = $"select ID from PharmacyProducts where MedicineID = '{medicineId}' and VendorId = '{vendorId}'";
                SqlCommand command = new SqlCommand(sqlQuery, connection.GetConnection());
                connection.OpenConnection();

                SqlDataReader medicineReader = command.ExecuteReader();
                long id = -1;
                if (medicineReader.Read())
                    id = (long)medicineReader["ID"];

                medicineReader.Close();
                if(id == -1)
                {
                    sqlQuery = $"insert into PharmacyProducts (MedicineID, VendorID, Price, Amount) values ('{medicineId}','{vendorId}','{ProductPrice.Value}','{ProductAmount.Value}')";
                    command.CommandText = sqlQuery;
                    connection.OpenConnection();
                    command.ExecuteNonQuery();
                }
                else
                {
                    sqlQuery = $"update PharmacyProducts set Amount = Amount + '{ProductAmount.Value}' where ID = '{id}'";
                    command.CommandText = sqlQuery;
                    connection.OpenConnection();
                    command.ExecuteNonQuery();
                }
                MessageBox.Show("New Product Added!", "Product",
                     MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            dProductSet.Clear();
            dProductAdapter.Fill(dProductSet, "AdminProductView");

            Medicine.Enabled = false;
            Vendor.Enabled = false;
            ProductPrice.Enabled = false;
            ProductAmount.Enabled = false;

            ProductProduct.Visible = false;
        }
        private int GetVendorId()
        {
            string vendorName = "";
            if (Vendor.SelectedItem == null)
            {
                vendorName = Vendor.Text;
            }
            else
            {
                vendorName = Vendor.SelectedItem.ToString();
            }

            string sqlQuery = $"select ID from Vendors where Name = '{vendorName}'";
            SqlCommand command = new SqlCommand(sqlQuery, connection.GetConnection());
            connection.OpenConnection();

            SqlDataReader vendorReader = command.ExecuteReader();
            int vendorId = -1;
            if (vendorReader.Read())
                vendorId = (int)vendorReader["ID"];

            vendorReader.Close();

            return vendorId;
        }    
        
        private long GetMedicineId()
        {
            string medicineName = "";
            if (Medicine.SelectedItem == null)
            {
                medicineName = Medicine.Text;
            }
            else
            {
                medicineName = Medicine.SelectedItem.ToString().Split(' ')[0];
            }

            string sqlQuery = $"select ID from Medicines where Name = '{medicineName}'";
            SqlCommand command = new SqlCommand(sqlQuery, connection.GetConnection());
            connection.OpenConnection();

            SqlDataReader medicineReader = command.ExecuteReader();
            long medicineId = -1;
            if (medicineReader.Read())
                medicineId = (long)medicineReader["ID"];

            medicineReader.Close();

            return medicineId;
        }
        private void editButton_Click(object sender, EventArgs e)
        {
            //Medicine.Enabled = true;
            Vendor.Enabled = true;
            ProductPrice.Enabled = true;
            ProductAmount.Enabled = true;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Medicine.Enabled = false;
            Vendor.Enabled = false;
            ProductPrice.Enabled = false;
            ProductAmount.Enabled = false;

            ProductProduct.Visible = false;
        }

        //MEDICINE TAB
        private void FillMedicineDG()
        {
            string sqlQuery = $"select Name, Company from Medicines";

            dMedicineAdapter = new SqlDataAdapter(sqlQuery, connection.GetConnection());
            dMedicineSet.Clear();
            dMedicineAdapter.Fill(dMedicineSet, "Medicines");

            MedicineDG.DataSource = dMedicineSet.Tables["Medicines"];
        }

        private void FillCompanyCB()
        {
            string sqlQuery = "select distinct Company from Medicines";
            SqlCommand command = new SqlCommand(sqlQuery, connection.GetConnection());
            connection.OpenConnection();

            SqlDataReader companyReader = command.ExecuteReader();
            MedicineCompany.Items.Clear();
            while (companyReader.Read())
                MedicineCompany.Items.Add(companyReader["Company"]);

            companyReader.Close();
        }

        private void MedicineDG_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.MedicineDG.Rows[e.RowIndex];

                MedicineName.Text = row.Cells["Name"].Value.ToString();
                MedicineCompany.Text = row.Cells["Company"].Value.ToString();

                string sqlQuery = $"select ID from Medicines where Name = '{MedicineName.Text}' and Company = '{MedicineCompany.Text}'";
                SqlCommand command = new SqlCommand(sqlQuery, connection.GetConnection());
                connection.OpenConnection();

                SqlDataReader idReader = command.ExecuteReader();
                if (idReader.Read())
                    currentMedicine = (long)idReader["ID"];
                idReader.Close();
            }
            EditMedicine.Enabled = true;
            MedicineMedicine.Visible = true;
        }

        private void SaveMedicine_Click(object sender, EventArgs e)
        {
            if (currentMedicine != -1) //modify
            {
                string sqlQuery = $"update Medicines set Name = '{MedicineName.Text}', Company = '{MedicineCompany.Text}' where ID = '{currentMedicine}'";
                SqlCommand command = new SqlCommand(sqlQuery, connection.GetConnection());
                connection.OpenConnection();
                command.ExecuteNonQuery();
                MessageBox.Show("Medicines Modified!", "Medicine",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else //add new
            {
                string sqlQuery = $"insert into Medicines (Name, Company) values ('{MedicineName.Text}','{MedicineCompany.Text}')";
                SqlCommand command = new SqlCommand(sqlQuery, connection.GetConnection());
                connection.OpenConnection();
                command.ExecuteNonQuery();
                MessageBox.Show("New Medicine Added!", "Medicine",
                     MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            dMedicineSet.Clear();
            dMedicineAdapter.Fill(dMedicineSet, "Medicines");

            MedicineName.Enabled = false;
            MedicineCompany.Enabled = false;
            FillCompanyCB();

            MedicineMedicine.Visible = false;
        }

        private void EditMedicine_Click(object sender, EventArgs e)
        {
            MedicineName.Enabled = true;
            MedicineCompany.Enabled = true;
        }

        private void CancelMedicine_Click(object sender, EventArgs e)
        {
            MedicineName.Enabled = false;
            MedicineCompany.Enabled = false;

            MedicineMedicine.Visible = false;
        }

        private void addMedicinebutton_Click(object sender, EventArgs e)
        {
            EditMedicine.Enabled = false;
            currentMedicine = -1;

            MedicineName.Enabled = true;
            MedicineName.Text = "";

            MedicineCompany.Enabled = true;
            MedicineCompany.Text = "";

            MedicineMedicine.Visible = true;
        }

        private void deleteMedicinebutton_Click(object sender, EventArgs e)
        {
            //delete from order items
            string sqlQuery = $"UPDATE OrderItems SET PharmacyProductID = null WHERE PharmacyProductID in (SELECT ID FROM PharmacyProducts where MedicineID = '{currentMedicine}')";
            SqlCommand command = new SqlCommand(sqlQuery, connection.GetConnection());
            connection.OpenConnection();
            command.ExecuteNonQuery();

            //delete from products
            sqlQuery = $"DELETE FROM PharmacyProducts WHERE MedicineID = '{currentMedicine}';";
            command.CommandText = sqlQuery;
            connection.OpenConnection();
            command.ExecuteNonQuery();

            //delete from medicine table
            sqlQuery = $"DELETE FROM Medicines WHERE ID = '{currentMedicine}';";
            command.CommandText = sqlQuery;
            //SqlCommand command = new SqlCommand(sqlQuery, connection.GetConnection());
            connection.OpenConnection();
            command.ExecuteNonQuery();

            MedicineMedicine.Visible = false;
            dMedicineSet.Clear();
            dMedicineAdapter.Fill(dMedicineSet, "Medicines");

            MessageBox.Show("Medicine Deleted!", "Medicine",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        //VENDOR TAB
        private void FillVendorDG()
        {
            string sqlQuery = $"select Name, Number, Location from Vendors";

            dVendorAdapter = new SqlDataAdapter(sqlQuery, connection.GetConnection());
            dVendorSet.Clear();
            dVendorAdapter.Fill(dVendorSet, "Vendors");

            VendorDG.DataSource = dVendorSet.Tables["Vendors"];
        }

        private void VendorDG_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.VendorDG.Rows[e.RowIndex];

                VendorName.Text = row.Cells["Name"].Value.ToString();
                VendorNumber.Text = row.Cells["Number"].Value.ToString();
                VendorLocation.Text = row.Cells["Location"].Value.ToString();

                string sqlQuery = $"select ID from Vendors where Name = '{VendorName.Text}' and Number = '{VendorNumber.Text}' and Location = '{VendorLocation.Text}'";
                SqlCommand command = new SqlCommand(sqlQuery, connection.GetConnection());
                connection.OpenConnection();

                SqlDataReader idReader = command.ExecuteReader();
                if (idReader.Read())
                    currentVendor = (int)idReader["ID"];
                idReader.Close();
            }
            VendorGB.Visible = true;
        }

        private void AddVendor_Click(object sender, EventArgs e)
        {
            EditVendor.Enabled = false;
            currentVendor = -1;

            VendorName.Enabled = true;
            VendorName.Text = "";

            VendorNumber.Enabled = true;
            VendorNumber.Text = "";   
            
            VendorLocation.Enabled = true;
            VendorLocation.Text = "";

            VendorGB.Visible = true;
        }

        private void DeleteVendor_Click(object sender, EventArgs e)
        {
            //delete from order items
            string sqlQuery = $"UPDATE OrderItems SET PharmacyProductID = null WHERE PharmacyProductID in (SELECT ID FROM PharmacyProducts where VendorID = '{currentVendor}')";
            SqlCommand command = new SqlCommand(sqlQuery, connection.GetConnection());
            connection.OpenConnection();
            command.ExecuteNonQuery();

            //delete from products
            sqlQuery = $"DELETE FROM PharmacyProducts WHERE VendorID = '{currentVendor}';";
            command.CommandText = sqlQuery;
            connection.OpenConnection();
            command.ExecuteNonQuery();

            //delete from medicine table
            sqlQuery = $"DELETE FROM Vendors WHERE ID = '{currentVendor}';";
            command.CommandText = sqlQuery;
            //SqlCommand command = new SqlCommand(sqlQuery, connection.GetConnection());
            connection.OpenConnection();
            command.ExecuteNonQuery();

            VendorGB.Visible = false;
            dVendorSet.Clear();
            dVendorAdapter.Fill(dVendorSet, "Vendors");

            MessageBox.Show("Vendor Deleted!", "Vendor",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void SaveVendor_Click(object sender, EventArgs e)
        {
            if (currentVendor != -1) //modify
            {
                string sqlQuery = $"update Vendors set Name = '{VendorName.Text}', Number = '{VendorNumber.Text}', Location = '{VendorLocation.Text}' where ID = '{currentVendor}'";
                SqlCommand command = new SqlCommand(sqlQuery, connection.GetConnection());
                connection.OpenConnection();
                command.ExecuteNonQuery();
                MessageBox.Show("Vendor Modified!", "Vendor",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else //add new
            {
                string sqlQuery = $"insert into Vendors (Name, Number, Location) values ('{VendorName.Text}','{VendorNumber.Text}', '{VendorLocation.Text}')";
                SqlCommand command = new SqlCommand(sqlQuery, connection.GetConnection());
                connection.OpenConnection();
                command.ExecuteNonQuery();
                MessageBox.Show("New Vendor Added!", "Vendor",
                     MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            dVendorSet.Clear();
            dVendorAdapter.Fill(dVendorSet, "Vendors");

            VendorName.Enabled = false;
            VendorNumber.Enabled = false;
            VendorLocation.Enabled = false;

            VendorGB.Visible = false;
        }

        private void EditVendor_Click(object sender, EventArgs e)
        {
            VendorName.Enabled = true;
            VendorNumber.Enabled = true;
            VendorLocation.Enabled = true;
        }

        private void CancelVendor_Click(object sender, EventArgs e)
        {
            VendorName.Enabled = false;
            VendorNumber.Enabled = false;
            VendorLocation.Enabled = false;

            VendorGB.Visible = false;
        }

        //ORDER TAB
        private void FillOrders(string patient, string date)
        {
            string sqlQuery = "";
            if(patient == null && date == null){
                sqlQuery = "select Date, Patient, Status, Total from AdminOrderView";
            }
            else if(patient == null)
            {
                sqlQuery = $"select Date, Patient, Status, Total from AdminOrderView where Date = '{date}'";
            }
            else
            {
                sqlQuery = $"select Date, Patient, Status, Total from AdminOrderView where Date = '{date}' and Patient = '{patient}'";
            }
            dOrderAdapter = new SqlDataAdapter(sqlQuery, connection.GetConnection());
            dOrderSet.Clear();
            dOrderAdapter.Fill(dOrderSet, "Orders");

            OrderDG.DataSource = dOrderSet.Tables["Orders"];
        }
        
        private void FillPatients()
        {
            string sqlQuery = "select distinct Patient from AdminOrderView";
            SqlCommand command = new SqlCommand(sqlQuery, connection.GetConnection());
            connection.OpenConnection();

            SqlDataReader patientReader = command.ExecuteReader();
            PatientOrder.Items.Clear();
            while (patientReader.Read())
                PatientOrder.Items.Add(patientReader["Patient"]);

            patientReader.Close();
        }

        private void FillDates()
        {
            string sqlQuery = "select distinct Date from AdminOrderView";
            SqlCommand command = new SqlCommand(sqlQuery, connection.GetConnection());
            connection.OpenConnection();

            SqlDataReader dateReader = command.ExecuteReader();
            DateOrder.Items.Clear();
            while (dateReader.Read())
                DateOrder.Items.Add(dateReader["Date"]);

            dateReader.Close();
        }

        private void OrederDG_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.OrderDG.Rows[e.RowIndex];

                string date = Convert.ToDateTime(row.Cells["Date"].Value).ToString("yyyy-MM-dd HH:mm:ss.fff");
                double total = Convert.ToDouble(row.Cells["Total"].Value);
                string patient = row.Cells["Patient"].Value.ToString();
                string status = row.Cells["Status"].Value.ToString();

                string sqlQuery = $"select ID from AdminOrderView where Patient = '{patient}' and Date = '{date}' and Status = '{status}' and Total = '{total}'";
                SqlCommand command = new SqlCommand(sqlQuery, connection.GetConnection());
                connection.OpenConnection();

                SqlDataReader idReader = command.ExecuteReader();
                if (idReader.Read())
                    currentOrder = (long)idReader["ID"];
                idReader.Close();
            }
            OrderAction.Visible = true;
        }

        private void DateOrder_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(PatientOrder.SelectedItem == null && DateOrder.SelectedItem == null)
            {
                FillOrders(null, null);
            }
            else if(PatientOrder.SelectedItem == null)
            {
                FillOrders(null, DateOrder.SelectedItem.ToString());
            }
            else if (DateOrder.SelectedItem == null)
            {
                FillOrders(PatientOrder.SelectedItem.ToString(), null);
            }
            else
            {
                FillOrders(PatientOrder.SelectedItem.ToString(), DateOrder.SelectedItem.ToString());
            }
            
        }

        private void PatientOrder_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (PatientOrder.SelectedItem == null && DateOrder.SelectedItem == null)
            {
                FillOrders(null, null);
            }
            else if (DateOrder.SelectedItem == null)
            {
                FillOrders(PatientOrder.SelectedItem.ToString(), null);
            }
            else if (PatientOrder.SelectedItem == null)
            {
                FillOrders(null, DateOrder.SelectedItem.ToString());
            }
            else
            {
                FillOrders(PatientOrder.SelectedItem.ToString(), DateOrder.SelectedItem.ToString());
            }
        }

        private void ClearOrderFilters_Click(object sender, EventArgs e)
        {
            PatientOrder.SelectedItem = null;
            DateOrder.SelectedItem = null;
        }

        private void CompleteOrder_Click(object sender, EventArgs e)
        {
            string sqlQuery = $"UPDATE Orders SET Orders.StatusID = 3 WHERE ID = '{currentOrder}'";
            SqlCommand command = new SqlCommand(sqlQuery, connection.GetConnection());
            connection.OpenConnection();
            command.ExecuteNonQuery();
            dOrderAdapter.Update(dOrderSet, "Orders");
            MessageBox.Show("Order Completed!", "Order",
                 MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void CancelOrder_Click(object sender, EventArgs e)
        {
            string sqlQuery = $"UPDATE Orders SET Orders.StatusID = 2 WHERE ID = '{currentOrder}'";
            SqlCommand command = new SqlCommand(sqlQuery, connection.GetConnection());
            connection.OpenConnection();
            command.ExecuteNonQuery();
            dOrderAdapter.Update(dOrderSet, "Orders");
            MessageBox.Show("Order Canceled!", "Order",
                 MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void SortByDate_Click(object sender, EventArgs e)
        {
            OrderDG.Sort(OrderDG.Columns["Date"], ListSortDirection.Ascending);
        }

        private void SortByTotal_Click(object sender, EventArgs e)
        {
            OrderDG.Sort(OrderDG.Columns["Total"], ListSortDirection.Ascending);
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //PRODUCT TAB
            FillProductsDG();
            FillMedicineCB();
            FillVendorCB();

            //MEDICINE TAB
            FillMedicineDG();
            FillCompanyCB();

            //VENDOR TAB
            FillVendorDG();

            //ORDER TAB
            FillOrders(null, null);
            FillPatients();
            FillDates();
        }
    }
}
