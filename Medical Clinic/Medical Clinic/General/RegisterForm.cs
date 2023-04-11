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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using XSystem.Security.Cryptography;
using Medical_Clinic.General;

namespace Medical_Clinic
{
    public partial class RegisterForm : Form
    {
        Connection connection;
        public RegisterForm()
        {
            InitializeComponent();

            connection = new Connection();
            connection.OpenConnection();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var email= Email.Text;
            var password = Password.Text;
            var password2 = ConfirmPassword.Text;

            if (password == password2)
            {
                SqlCommand emails = new SqlCommand($"SELECT Email FROM Logins;", connection.GetConnection());
                SqlDataReader reader = emails.ExecuteReader();
                while (reader.Read())
                {
                    var emailDB = reader.GetValue(0);
                    if (email == (string)emailDB)
                    {
                        MessageBox.Show("Email is used!", "Choose new Email!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        reader.Close();
                        return;
                    }
                }
                reader.Close();
                byte[] tmpSource;
                byte[] tmpHash;
                tmpSource = ASCIIEncoding.ASCII.GetBytes(password);
                tmpHash = new MD5CryptoServiceProvider().ComputeHash(tmpSource);

                string passHash = ByteArrayToString(tmpHash);
                string ByteArrayToString(byte[] arrInput)
                {
                    int i;
                    StringBuilder sOutput = new StringBuilder(arrInput.Length);
                    for (i = 0; i < arrInput.Length; i++)
                    {
                        sOutput.Append(arrInput[i].ToString("X2"));
                    }
                    return sOutput.ToString();
                }
                //search for equal password
                long id = GetPasswordID(passHash);
                if(id != -1)
                {
                    MessageBox.Show("Password is used!", "Fail!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                    //insert if everything is ok
                    SqlCommand IDS = new SqlCommand($"INSERT INTO Logins (Email, Password) VALUES ('{email}','{passHash}');", connection.GetConnection());
                    SqlDataReader rdr = IDS.ExecuteReader();
                    rdr.Close();
                    MessageBox.Show("Account created!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Doesn't match!", "Password doesn't match!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private long GetPasswordID(string passHash)
        {
            string sqlQuery = $"select ID from Logins where Password = '{passHash}'";
            SqlCommand command = new SqlCommand(sqlQuery, connection.GetConnection());
            connection.OpenConnection();

            SqlDataReader idReader = command.ExecuteReader();
            long id = -1;
            if (idReader.Read())
            {
                id = (long)idReader["ID"];

            }
            idReader.Close();

            return id;
        }
    }
}
