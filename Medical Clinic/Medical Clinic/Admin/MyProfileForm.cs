using Medical_Clinic.General;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using XSystem.Security.Cryptography;

namespace Medical_Clinic.Admin
{
    public partial class MyProfileForm : Form
    {
        private long adminId;
        private Connection connection;
        public MyProfileForm(long adminId, Connection connection)
        {
            InitializeComponent();

            this.adminId = adminId;
            this.connection = connection;
        }

        private void MyProfileForm_Load(object sender, EventArgs e)
        {
            //fill email
            string sqlQuery = $"select Email from Logins where ID = '{adminId}'";
            SqlCommand command = new SqlCommand(sqlQuery, connection.GetConnection());
            connection.OpenConnection();

            SqlDataReader emailReader = command.ExecuteReader();
            if (emailReader.Read())
            {
                MyProfileEmail.Text = emailReader["Email"].ToString();

            }
            emailReader.Close();
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            MyProfileEmail.Enabled = true;
        }

        private void myProfileSavebutton_Click(object sender, EventArgs e)
        {
            string sqlQuery = $"UPDATE Logins SET Email = '{MyProfileEmail.Text}' WHERE ID = '{adminId}';";
            SqlCommand command = new SqlCommand(sqlQuery, connection.GetConnection());
            connection.OpenConnection();
            command.ExecuteNonQuery();
            MyProfileEmail.Enabled = false;
            MessageBox.Show("Email Updated!");
        }
        static string ByteArrayToString(byte[] arrInput)
        {
            int i;
            StringBuilder sOutput = new StringBuilder(arrInput.Length);
            for (i = 0; i < arrInput.Length; i++)
            {
                sOutput.Append(arrInput[i].ToString("X2"));
            }
            return sOutput.ToString();
        }
        private void createButton_Click(object sender, EventArgs e)
        {
            var oldPassword = Password.Text;
            var newPassword = NewPassword.Text;
            var confirmPassword = ConfirmPassword.Text;

            byte[] tmpSource_old;
            byte[] tmpHash_old;
            tmpSource_old = ASCIIEncoding.ASCII.GetBytes(oldPassword);
            tmpHash_old = new MD5CryptoServiceProvider().ComputeHash(tmpSource_old);

            string passHash_old = ByteArrayToString(tmpHash_old);

            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();

            string sql = $"SELECT Password FROM [Logins] WHERE ID = '{adminId}' and Password = '{passHash_old}';";

            SqlCommand command = new SqlCommand(sql, connection.GetConnection());

            adapter.SelectCommand = command;
            this.connection.OpenConnection();
            adapter.Fill(table);

            if (table.Rows.Count != 1)
            {
                MessageBox.Show("Incorrect old password!", "Incorrect password!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (newPassword == confirmPassword)
                {
                    byte[] tmpSource;
                    byte[] tmpHash;
                    tmpSource = ASCIIEncoding.ASCII.GetBytes(newPassword);
                    tmpHash = new MD5CryptoServiceProvider().ComputeHash(tmpSource);

                    string passHash = ByteArrayToString(tmpHash);

                    SqlDataAdapter adapter1 = new SqlDataAdapter();
                    DataTable table1 = new DataTable();

                    string sql1 = $"UPDATE [Logins] SET [Password] = '{passHash}' WHERE ID = '{adminId}';";

                    SqlCommand command1 = new SqlCommand(sql1, connection.GetConnection());

                    adapter1.SelectCommand = command1;
                    connection.OpenConnection();
                    adapter1.Fill(table1);
                    MessageBox.Show("Password Updated!");
                }
                else
                {
                    MessageBox.Show("Doesn't match!", "Password doesn't match!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
         }
    }
}
