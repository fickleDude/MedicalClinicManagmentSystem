using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Text;
using Microsoft.Data.SqlClient;
using XSystem.Security.Cryptography;
using System.Data;
using System;
using XAct;
using Medical_Clinic.General;

namespace Medical_Clinic
{
    public partial class Form1 : Form
    {
        private  Connection connection;
        private object userId;
        private object role;
        private object tableEmail;
        private object tablePassword;
        public Form1()
        {
            InitializeComponent();

            connection = new Connection();
            userId = 0;
            role = 0;
            tableEmail = "";
            tablePassword = "";

            //connection.OpenConnection();
        }

        private void LogInButton_Click(object sender, EventArgs e)
        {
            var formEmail = Email.Text;
            var formPassword = Password.Text;
            Email.Text = "";
            Password.Text = "";

            string passHash = ConvertPassword(formPassword);
            FillCredential(formEmail);

            if ((tableEmail.Equals(formEmail)) && (passHash.Equals(tablePassword)) && (formEmail != ""))
            {

                GetRole(formEmail);
                GetUserId(formEmail);

                if (role.Equals("Admin"))
                {
                    AdminForm form = new AdminForm((int)userId, connection);
                    form.ShowDialog();
                    this.Show();
                }
                else
                {
                    if (role.Equals("Doctor"))
                    {
                        DoctorForm form = new DoctorForm((int)userId, connection);
                        this.Hide();
                        form.ShowDialog();
                        this.Show();
                    }
                    else if (role.Equals("Patient"))
                    {
                        PatientForm form = new PatientForm(userId, connection);
                        this.Hide();
                        form.ShowDialog();
                        this.Show();
                    }
                    else
                    {
                        //anonumous form
                        AnonimousForm form = new AnonimousForm(connection);
                        this.Hide();
                        form.ShowDialog();
                        this.Show();
                    }
                }
            }
            else
            {
                if (tableEmail != "")
                {
                    MessageBox.Show("Wrong Password!", "Password is incorrect!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Account not found!", "Account has not existed yet!",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
     
        private void RegisterButton_Click(object sender, EventArgs e)
        {
            RegisterForm form = new RegisterForm();
            this.Hide();
            form.ShowDialog();
            this.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Email.MaxLength = 30;
        }

        private void GetRole(string email)
        {
            connection.OpenConnection();

            String strSQL = "sp_ShowRole";
            SqlCommand cmdIC = new SqlCommand(strSQL, connection.GetConnection());
            cmdIC.CommandType = CommandType.StoredProcedure;

            cmdIC.Parameters.Add(new SqlParameter
            {
                ParameterName = "@Email",
                SqlDbType = SqlDbType.VarChar,
                Size = 30,
                Value = email
            });
            cmdIC.Parameters.Add(new SqlParameter
            {
                ParameterName = "@RoleName",
                SqlDbType = SqlDbType.VarChar,
                Size = 20,
                Direction = ParameterDirection.Output
            });

            cmdIC.ExecuteNonQuery();
            this.role = cmdIC.Parameters["@RoleName"].Value;
        }     
        
        private void GetUserId(string email)
        {
            connection.OpenConnection();

            String strSQL = "sp_ShowId";
            SqlCommand cmdIC = new SqlCommand(strSQL, connection.GetConnection());
            cmdIC.CommandType = CommandType.StoredProcedure;

            cmdIC.Parameters.Add(new SqlParameter
            {
                ParameterName = "@Email",
                SqlDbType = SqlDbType.VarChar,
                Size = 30,
                Value = email
            });
            cmdIC.Parameters.Add(new SqlParameter
            {
                ParameterName = "@Id",
                SqlDbType = SqlDbType.Int,
                Direction = ParameterDirection.Output
            });

            cmdIC.ExecuteNonQuery();
            this.userId = cmdIC.Parameters["@Id"].Value;
        }
        private string ConvertPassword(string password)
        {
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
            return passHash;
        }

        private void FillCredential(string email)
        {
            connection.OpenConnection();

            String strSQL = "sp_GetCredentials";
            SqlCommand cmdIC = new SqlCommand(strSQL, connection.GetConnection());
            cmdIC.CommandType = CommandType.StoredProcedure;

            cmdIC.Parameters.Add(new SqlParameter
            {
                ParameterName = "@Email",
                SqlDbType = SqlDbType.VarChar,
                Size = 30,
                Value = email
            });
            SqlParameter emailOut = new SqlParameter
            {
                ParameterName = "@EmailOut",
                SqlDbType = SqlDbType.VarChar,
                Size = 30,
                Direction = ParameterDirection.Output
            };
            cmdIC.Parameters.Add(emailOut);
            SqlParameter passwordOut = new SqlParameter
            {
                ParameterName = "@PasswordOut",
                SqlDbType = SqlDbType.VarChar,
                Size = 255,
                Direction = ParameterDirection.Output
            };
            cmdIC.Parameters.Add(passwordOut);

            cmdIC.ExecuteNonQuery();

            this.tableEmail = emailOut.Value;
            this.tablePassword = passwordOut.Value;
        }
    }
}