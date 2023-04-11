using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Medical_Clinic.General
{
    public class Connection
    {
        private string connectionString;
        private SqlConnection sqlConnection;

        public Connection()
        {
            connectionString = "Data Source=ANYAPC;Database=Medical clinic;Persist Security Info=True;" +
            "User ID=test;Password=sa;TrustServerCertificate=True;";
            sqlConnection = new SqlConnection();
            sqlConnection.ConnectionString = connectionString;
        }

        public void OpenConnection()
        {
            if (sqlConnection.State == System.Data.ConnectionState.Closed)
            {
                try
                {
                    sqlConnection.Open();
                }
                catch (Exception)
                {
                    MessageBox.Show("Connection failed!!", "Connection", MessageBoxButtons.OK);
                }
            }
        }

        public void CloseConnection()
        {
            if (sqlConnection.State == System.Data.ConnectionState.Open)
            {
                sqlConnection.Close();
            }
        }

        public SqlConnection GetConnection()
        {
            return sqlConnection;
        }
    }
}
