using Medical_Clinic.General;
using Microsoft.Data.SqlClient;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using XAct;
using XSystem.Security.Cryptography;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Medical_Clinic.Patient
{
    public partial class MyProfileForm : Form
    {
        private Connection connection;
        private object userId;
        public MyProfileForm(object userId, Connection connection)
        {
            InitializeComponent();

            this.userId = userId;
            this.connection = connection;
        }

        private void MyProfileForm_Load(object sender, EventArgs e)
        {
            FillProfile();
            FillGender();
        }

        private void FillProfile()
        {
            String strSQL = $"select FIO, Gender, DateOfBirth from Patients where Patients.LoginID = '{userId}'";
            SqlCommand cmdIC = new SqlCommand(strSQL, connection.GetConnection());

            this.connection.OpenConnection();
            SqlDataReader profileReader = cmdIC.ExecuteReader();
            if (profileReader.Read())
            {
                FIO.Text = profileReader["FIO"].ToString();
                Gender.Text = profileReader["Gender"].ToString();
                DateOfBirth.Format = DateTimePickerFormat.Custom;
                DateOfBirth.CustomFormat = "dd-MM-yyyy";
                DateOfBirth.Value = Convert.ToDateTime(profileReader["DateOfBirth"]);
            }
            profileReader.Close();
        }

        private void FillGender()
        {
            Gender.Items.Add("Female");
            Gender.Items.Add("Male");
            Gender.Items.Add("-");
        }

        //private void editButton_Click(object sender, EventArgs e)
        //{
        //    String strSQL = "sp_UpdateMyProfile";
        //    SqlCommand cmdIC = new SqlCommand(strSQL, connection.GetConnection());
        //    cmdIC.CommandType = CommandType.StoredProcedure;

        //    cmdIC.Parameters.Add(new SqlParameter
        //    {
        //        ParameterName = "@FIO",
        //        SqlDbType = SqlDbType.VarChar,
        //        Size = 100,
        //        Value = FIO.Text
        //    });
        //    cmdIC.Parameters.Add(new SqlParameter
        //    {
        //        ParameterName = "@DateOfBirth",
        //        SqlDbType = SqlDbType.Date,
        //        Size = 30,
        //        Value = DateOfBirth.Value
        //    });
        //    cmdIC.Parameters.Add(new SqlParameter
        //    {
        //        ParameterName = "@Gender",
        //        SqlDbType = SqlDbType.VarChar,
        //        Size = 30,
        //        Value = Gender.Text
        //    });
        //    cmdIC.Parameters.Add(new SqlParameter
        //    {
        //        ParameterName = "@Id",
        //        SqlDbType = SqlDbType.Int,
        //        Value = userId
        //    });

        //    this.connection.OpenConnection();
        //    cmdIC.ExecuteNonQuery();

        //    MessageBox.Show("Account data updated!", "My profile updated!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //}      
        
        private void editButton_Click(object sender, EventArgs e)
        {
            FIO.Enabled = true;
            DateOfBirth.Enabled = true;
            Gender.Enabled = true;
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

            string sql = $"SELECT Password FROM [Logins] WHERE ID = '{userId}' and Password = '{passHash_old}';";

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

                    string sql1 = $"UPDATE [Logins] SET [Password] = '{passHash}' WHERE ID = '{userId}';";

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

        private void MyProfileForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            connection.CloseConnection();
        }

        private void SaveProfile_Click(object sender, EventArgs e)
        {
            //insert if dont 
            String strSQL = "sp_UpdateMyProfile";
            SqlCommand cmdIC = new SqlCommand(strSQL, connection.GetConnection());
            cmdIC.CommandType = CommandType.StoredProcedure;

            cmdIC.Parameters.Add(new SqlParameter
            {
                ParameterName = "@FIO",
                SqlDbType = SqlDbType.VarChar,
                Size = 100,
                Value = FIO.Text
            });
            cmdIC.Parameters.Add(new SqlParameter
            {
                ParameterName = "@DateOfBirth",
                SqlDbType = SqlDbType.Date,
                Size = 30,
                Value = DateOfBirth.Value
            });
            cmdIC.Parameters.Add(new SqlParameter
            {
                ParameterName = "@Gender",
                SqlDbType = SqlDbType.VarChar,
                Size = 30,
                Value = Gender.Text
            });
            cmdIC.Parameters.Add(new SqlParameter
            {
                ParameterName = "@Id",
                SqlDbType = SqlDbType.Int,
                Value = userId
            });

            this.connection.OpenConnection();
            cmdIC.ExecuteNonQuery();

            MessageBox.Show("Account data updated!", "My profile updated!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            FillProfile();
            FIO.Enabled = false;
            DateOfBirth.Enabled = false;
            Gender.Enabled = false;
        }

        private void CancelProfile_Click(object sender, EventArgs e)
        {
            //restore data in fields
            FillProfile();
            //disable fields
            FIO.Enabled = false;
            DateOfBirth.Enabled = false;
            Gender.Enabled = false;
        }
    }
}
