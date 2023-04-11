using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Medical_Clinic.General;
using Microsoft.Data.SqlClient;

namespace Medical_Clinic.Patient
{
    public partial class PharmacyForm : Form
    {
        private long patientId;
        private Connection connection;

        //PRODUCTS TAB
        private SqlDataAdapter dProductsAdapter;
        private DataSet dProductsSet;
        private DataTable dProductsTable;
        private DataRow dProductsRow;
        private int iProductsRowID;
        private long currentProductId;

        //HISTORY TAB
        private SqlDataAdapter dHistoryAdapter;
        private DataSet dHistorySet;
        private DataTable dHistoryTable;
        private DataRow dHistoryRow;
        private int iHistoryRowID;
        private long currentHistoryId;

        //MY ORDER TAB
        private long currentOrderId;
        private long currentOrderItemId;
        public PharmacyForm(long patientId, Connection connection)
        {
            InitializeComponent();

            this.patientId = patientId;
            this.connection = connection;

            tabControl1.SelectTab(1);

            this.ContextMenuStrip = PatientPharmacyReload;

            dHistorySet = new DataSet();
            iHistoryRowID = 0;
        }

        private void PharmacyForm_Load(object sender, EventArgs e)
        {
            FillProducts();
            FillMyOrder();

            FillPrescriptions();

            FillHistory();
        }

        //PRODUCTS TAB
        private void FillProducts()
        {
            String strSQL = $"select Medicine, Company, Vendor, Price, Amount, ID from ProductsView where Amount > 0;";
            dProductsAdapter = new SqlDataAdapter(strSQL, connection.GetConnection());
            dProductsSet = new DataSet();
            dProductsAdapter.Fill(dProductsSet, "ProductsView");
            dProductsTable = dProductsSet.Tables["ProductsView"];

            if (dProductsTable.Rows.Count > 0)
            {
                iProductsRowID = 0;
                ShowProductsRow();
            }
        }

        private void ShowProductsRow()
        {
            dProductsRow = dProductsTable.Rows[iProductsRowID];

            Price.Text = Convert.ToDouble(dProductsRow["Price"]).ToString("#.##");
            Medicine.Text = dProductsRow["Medicine"].ToString();
            Vendor.Text = dProductsRow["Vendor"].ToString();
            Company.Text = dProductsRow["Company"].ToString();

            Amount.Maximum = (int)dProductsRow["Amount"];

            currentProductId = (long)dProductsRow["ID"];
        }

        private void FillHistory()
        {
            String strSQL = $"select Date, Total, OrderStatuses.Name as Status, Orders.ID as ID from Orders join OrderStatuses on StatusID = OrderStatuses.ID";
            dHistoryAdapter = new SqlDataAdapter(strSQL, connection.GetConnection());
            dHistorySet = new DataSet();
            dHistoryAdapter.Fill(dHistorySet, "HistoryView");
            dHistoryTable = dHistorySet.Tables["HistoryView"];

            if (dHistoryTable.Rows.Count > 0)
            {
                iHistoryRowID = 0;
                ShowHistoryRow();
            }
        }

        private void ShowHistoryRow()
        {
            dHistoryRow = dHistoryTable.Rows[iHistoryRowID];

            OrderDate.Text = dHistoryRow["Date"].ToString();
            TotalOrder.Text = dHistoryRow["Total"].ToString();
            StatusOrder.Text = dHistoryRow["Status"].ToString();

            currentHistoryId = (long)dHistoryRow["ID"];
        }

        private void prevButton_Click(object sender, EventArgs e)
        {
            if (iProductsRowID > 0)
            {
                iProductsRowID--;
                ShowProductsRow();
            }
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            if (iProductsRowID < dProductsSet.Tables["ProductsView"].Rows.Count - 1)
            {
                iProductsRowID++;
                ShowProductsRow();
            }
        }

        private void Amount_ValueChanged(object sender, EventArgs e)
        {
            int amount = (int)Amount.Value;
            double price = Convert.ToDouble(dProductsRow["Price"]) * amount;
            Price.Text = price.ToString("#.##");
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            //search for existing order
            string sqlQuery = $"select ID from Orders where Orders.PatientID = '{patientId}' and Orders.StatusID = 1";
            SqlCommand command = new SqlCommand(sqlQuery, connection.GetConnection());
            connection.OpenConnection();

            SqlDataReader orderReader = command.ExecuteReader();
            long orderId = -1;
            if (orderReader.Read())
            {
                orderId = (long)orderReader["ID"];
                orderReader.Close();
            }
            else
            {
                orderReader.Close();
                sqlQuery = $"insert into Orders (PatientID, StatusID, Date) values ('{patientId}', 1, GETDATE());" +
                    $"SET @id=SCOPE_IDENTITY()";
                command.CommandText = sqlQuery;
                SqlParameter orderIdParameter = new SqlParameter
                {
                    ParameterName = "@id",
                    SqlDbType = SqlDbType.BigInt,
                    Direction = ParameterDirection.Output
                };
                command.Parameters.Add(orderIdParameter);
                command.ExecuteNonQuery();
                orderId = (long)orderIdParameter.Value;
            }
            AddToOrder(orderId);
            MessageBox.Show("Added to Order!", "Added", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //update list of order items
            FillMyOrder();
        }

        private void AddToOrder(long orderId)
        {
            int amount = (int)Amount.Value;

            //check for existing order item
            string sqlQuery = $"select ID from OrderItems where PharmacyProductID = '{currentProductId}' and OrderID = '{orderId}'";
            SqlCommand command = new SqlCommand(sqlQuery, connection.GetConnection());
            connection.OpenConnection();

            SqlDataReader orderItemReader = command.ExecuteReader();
            long orderItemId = -1;
            if (orderItemReader.Read())
            {
                orderItemId = (long)orderItemReader["ID"];
                orderItemReader.Close();

                //alter quantity value
                sqlQuery = $"UPDATE OrderItems SET Quantity = Quantity + '{amount}' WHERE OrderItems.ID = '{orderItemId}';";
                command.CommandText = sqlQuery;
                command.ExecuteNonQuery();
                //reduce amount in pharmacy products
                sqlQuery = $"UPDATE PharmacyProducts SET Amount = Amount - '{amount}' WHERE ID = '{currentProductId}';";
                command.CommandText = sqlQuery;
                connection.OpenConnection();
                command.ExecuteNonQuery();
            }
            else
            {
                orderItemReader.Close();
                //create new order item 
                sqlQuery = $"insert into OrderItems (PharmacyProductID, OrderID, Quantity) values ('{currentProductId}', '{orderId}', '{amount}')";
                command.CommandText = sqlQuery;
                connection.OpenConnection();
                command.ExecuteNonQuery();
            }

            //make amount equals 1 again
            Amount.Value = 1;
            FillMyOrder();
        }

        //MY ORDER TAB
        private void FillMyOrder()
        {
            string sqlQuery = "sp_ShowOrderId";
            SqlCommand command = new SqlCommand(sqlQuery, connection.GetConnection());
            command.CommandType = CommandType.StoredProcedure;
            SqlParameter id = new SqlParameter
            {
                ParameterName = "@PatientId",
                SqlDbType = SqlDbType.BigInt,
                Value = patientId
            };
            command.Parameters.Add(id);
            connection.OpenConnection();

            SqlDataReader orderIdReader = command.ExecuteReader();
            if (orderIdReader.Read())
            {
                currentOrderId = (long)orderIdReader["ID"];
                orderIdReader.Close();

                FillOrderItemsList();
                FillTotal();
            }
            else
            {
                orderIdReader.Close();
            }
        }

        private void FillTotal()
        {
            string sqlQuery = $"select Total from Orders where ID = '{currentOrderId}'";
            SqlCommand command = new SqlCommand(sqlQuery, connection.GetConnection());
            connection.OpenConnection();

            SqlDataReader totalReader = command.ExecuteReader();
            if (totalReader.Read())
            {
                Total.Text = totalReader["Total"].ToString();
            }
            totalReader.Close();
        }

        private void FillOrderItemsList()
        {
            OrderItems.Items.Clear();

            string sqlQuery = "sp_ShowOrderItems";
            SqlCommand command = new SqlCommand(sqlQuery, connection.GetConnection());
            command.CommandType = CommandType.StoredProcedure;
            SqlParameter patientIdParameter = new SqlParameter
            {
                ParameterName = "@PatientId",
                SqlDbType = SqlDbType.BigInt,
                Value = patientId
            };
            command.Parameters.Add(patientIdParameter);     
            SqlParameter orderIdParameter = new SqlParameter
            {
                ParameterName = "@OrderId",
                SqlDbType = SqlDbType.BigInt,
                Value = currentOrderId
            };
            command.Parameters.Add(orderIdParameter);
            connection.OpenConnection();

            SqlDataReader orderItemsReader = command.ExecuteReader();
            while (orderItemsReader.Read())
            {
                OrderItems.Items.Add(orderItemsReader["Name"].ToString());

            }
            orderItemsReader.Close();
        }
        private void OrderItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            //see selected item
            string medicineName = OrderItems.SelectedItem.ToString();

            //fill textboxes
            FillCurrentOrderItem(medicineName);
            FillOrderAmount(medicineName);
            FillOrderPrice((int) OrderAmount.Value, medicineName);
        }

        private void FillOrderPrice(int amount, string medicineName)
        {
            string sqlQuery = $"select Price from PharmacyProducts join Medicines on Medicines.ID = PharmacyProducts.MedicineID where Medicines.Name = '{medicineName}'";
            SqlCommand command = new SqlCommand(sqlQuery, connection.GetConnection());
            connection.OpenConnection();

            SqlDataReader priceReader = command.ExecuteReader();
            decimal price = 0;
            if (priceReader.Read())
            {
                price = (decimal)priceReader["Price"];
            }
            priceReader.Close();

            OrderPrice.Text = (price * amount).ToString("#.##");
        }

        private void FillOrderAmount(string medicineName)
        {
            string sqlQuery = $"select Quantity from OrderItems where PharmacyProductID in (select PharmacyProducts.ID from PharmacyProducts " +
                $"join Medicines on Medicines.ID = PharmacyProducts.MedicineID where Medicines.Name = '{medicineName}') and OrderID = '{currentOrderId}'";
            SqlCommand command = new SqlCommand(sqlQuery, connection.GetConnection());
            connection.OpenConnection();

            SqlDataReader amountReader = command.ExecuteReader();
            if (amountReader.Read())
            {
                OrderAmount.Value = (int)amountReader["Quantity"];
            }
            amountReader.Close();
        }   
        private void FillCurrentOrderItem(string medicineName)
        {
            string sqlQuery = $"select ID from OrderItems where PharmacyProductID in (select PharmacyProducts.ID from PharmacyProducts " +
                $"join Medicines on Medicines.ID = PharmacyProducts.MedicineID where Medicines.Name = '{medicineName}') and OrderID = '{currentOrderId}'";
            SqlCommand command = new SqlCommand(sqlQuery, connection.GetConnection());
            connection.OpenConnection();

            SqlDataReader amountReader = command.ExecuteReader();
            if (amountReader.Read())
            {
                currentOrderItemId = (long)amountReader["ID"];
            }
            amountReader.Close();
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            if (currentOrderItemId == -1)
            {
                MessageBox.Show("No Items Choosen!", "No Items", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            OrderAmount.Enabled = true;

            //set maximum value
            string medicineName = OrderItems.SelectedItem.ToString();
            string sqlQuery = $"select Amount from PharmacyProducts where PharmacyProducts.ID in " +
                $"(select PharmacyProductID from OrderItems " +
                $"join PharmacyProducts on PharmacyProducts.ID = PharmacyProductID " +
                $"join Medicines on Medicines.ID = MedicineID " +
                $"where OrderItems.OrderID = '{currentOrderId}' and Medicines.Name = '{medicineName}')";
            SqlCommand command = new SqlCommand(sqlQuery, connection.GetConnection());
            connection.OpenConnection();

            SqlDataReader amountReader = command.ExecuteReader();
            if (amountReader.Read())
            {
                OrderAmount.Maximum  = (int)amountReader["Amount"];
            }
            amountReader.Close();

            //set minimum value
            OrderAmount.Minimum = 1;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (currentOrderItemId == -1)
            {
                MessageBox.Show("No Items Choosen!", "No Items", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int amount = (int)OrderAmount.Value;
            //update quantity in order item
            string sqlQuery = $"UPDATE OrderItems SET Quantity = '{amount}' WHERE OrderItems.ID = '{currentOrderItemId}';";
            SqlCommand command = new SqlCommand(sqlQuery, connection.GetConnection());
            command.ExecuteNonQuery();

            //update price
            FillOrderPrice(amount, OrderItems.SelectedItem.ToString());
            //update total
            FillTotal();

            OrderAmount.Enabled = false;
        }

        private void orderButton_Click(object sender, EventArgs e)
        {
            if (OrderItems.Items.Count <= 0)
            {
                MessageBox.Show("No New Items Added!", "No Items", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //complete order; trigger on add in order items
            string sqlQuery = $"UPDATE Orders SET StatusID = 3 WHERE Orders.ID = '{currentOrderId}';";
            SqlCommand command = new SqlCommand(sqlQuery, connection.GetConnection());
            command.ExecuteNonQuery();

            OrderItems.Items.Clear();
            Total.Text = "0";
            Price.Text = "0";

            FillProducts();

            //info
            MessageBox.Show("Thank you for the Order!", "Order created", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if(currentOrderItemId == -1)
            {
                MessageBox.Show("No Items Choosen!", "No Items", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string sqlQuery = $"DELETE FROM OrderItems WHERE OrderItems.ID = '{currentOrderItemId}';";
                SqlCommand command = new SqlCommand(sqlQuery, connection.GetConnection());
                command.ExecuteNonQuery();

                FillMyOrder();
                FillProducts(); 
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            if (OrderItems.Items.Count <= 0)
            {
                MessageBox.Show("No New Items Added!", "No Items", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                //trigger on delete from order items to update amount of items
                string sqlQuery = $"select ID from OrderItems where OrderID = '{currentOrderId}'";
                SqlCommand command = new SqlCommand(sqlQuery, connection.GetConnection());
                SqlDataReader prescriptionReader = command.ExecuteReader();
                List<long> itemsToDelete = new List<long>();
                while (prescriptionReader.Read())
                {

                    long id = (long)prescriptionReader["ID"];
                    itemsToDelete.Add(id);
                }
                prescriptionReader.Close();
                foreach(long item in itemsToDelete)
                {
                    sqlQuery = $"DELETE FROM OrderItems WHERE ID = '{item}';";
                    command.CommandText = sqlQuery;
                    command.ExecuteNonQuery();
                }

                ////cancel order
                //sqlQuery = $"UPDATE Orders SET StatusID = 2 WHERE Orders.ID = '{currentOrderId}';";
                //command.CommandText = sqlQuery;
                //command.ExecuteNonQuery();

                OrderItems.Items.Clear();
                Total.Text = "0";
                Price.Text = "0";
            }
        }

        private void reloadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FillProducts();
            FillMyOrder();

            FillPrescriptions();

            FillHistory();
        }

        private void FillPrescriptions()
        {
            Prescriptions.Items.Clear();
            string sqlQuery = $"select Medicine from PrescriptionsView where Patient = '{patientId}'";
            SqlCommand command = new SqlCommand(sqlQuery, connection.GetConnection());
            connection.OpenConnection();

            SqlDataReader prescriptionReader = command.ExecuteReader();
            while (prescriptionReader.Read())
            {
                Prescriptions.Items.Add(prescriptionReader["Medicine"]);
            }
            prescriptionReader.Close();

            for(int i = 0; i < Prescriptions.Items.Count; i++)
            {
                sqlQuery = $"select Medicines.Name as Medicine from OrderItems " +
                    $"join PharmacyProducts on PharmacyProductID = PharmacyProducts.ID " +
                    $"join Medicines on MedicineID = Medicines.ID where OrderID = '{currentOrderId}'";
                command.CommandText = sqlQuery;
                connection.OpenConnection();

                SqlDataReader orderReader = command.ExecuteReader();
                while (orderReader.Read())
                {
                    if (Prescriptions.Items[i].Equals(orderReader["Medicine"]))
                    {
                        Prescriptions.SetItemChecked(i, true);
                    }
                }
                orderReader.Close();
            }
        }

        private void PrevOrder_Click(object sender, EventArgs e)
        {
            Items.Visible = false;
            if (iHistoryRowID > 0)
            {
                iHistoryRowID--;
                ShowHistoryRow();
            }
        }

        private void NextOrder_Click(object sender, EventArgs e)
        {
            Items.Visible = false;
            if (iHistoryRowID < dHistorySet.Tables["HistoryView"].Rows.Count - 1)
            {
                iHistoryRowID++;
                ShowHistoryRow();
            }
        }

        private void ListProducts_Click(object sender, EventArgs e)
        {
            Items.Visible = true;

            Items.Items.Clear();
            string sqlQuery = $"select Medicines.Name as Medicine, Quantity from OrderItems " +
                $"join PharmacyProducts on OrderItems.PharmacyProductID = PharmacyProducts.ID " +
                $"join Medicines on MedicineID = Medicines.ID where OrderID = '{currentHistoryId}'";
            SqlCommand command = new SqlCommand(sqlQuery, connection.GetConnection());
            connection.OpenConnection();

            SqlDataReader historyReader = command.ExecuteReader();
            while (historyReader.Read())
            {
                Items.Items.Add(historyReader["Medicine"]+" - "+ historyReader["Quantity"]);
            }
            historyReader.Close();
        }

        private void PharmacyForm_FormClosing(object sender, FormClosingEventArgs e)
        {
        }
    }
}
