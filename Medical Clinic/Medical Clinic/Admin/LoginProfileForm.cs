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
using XAct.Library.Settings;
using XSystem.Security.Cryptography;

namespace Medical_Clinic.Admin
{
    public partial class LoginProfileForm : Form
    {
        private long adminId;
        private Connection connection;

        private SqlDataAdapter dLoginAdapter;
        private DataSet dLoginSet;
        private DataTable dLoginTable;
        private DataRow dLoginRow;
        private int iLoginRowID;
        private long currentLoginId;
        public LoginProfileForm(long adminId, Connection connection)
        {
            InitializeComponent();
            this.adminId = adminId;
            this.connection = connection;

            iLoginRowID = 0;
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            if (iLoginRowID < dLoginSet.Tables["LoginsTable"].Rows.Count - 1)
            {
                iLoginRowID++;
                ShowLoginRow();
            }
        }

        private void prevButton_Click(object sender, EventArgs e)
        {
            if (iLoginRowID > 0)
            {
                iLoginRowID--;
                ShowLoginRow();
            }
        }
        //private void ShowLoginRow()
        //{
        //    dLoginRow = dLoginTable.Rows[iLoginRowID];
        //    //fill text fields
        //    Email.Text = dLoginRow["Email"].ToString();
        //    Role.Text = dLoginRow["Role"].ToString();
        //    currentLoginId = (long)dLoginRow["ID"];
        //}

        //private void FillLoginProfile()
        //{
        //    String strSQL = $"select Email, Logins.ID as ID, Roles.Name as Role from Logins join Roles on Roles.ID = RoleID where RoleID != '{3}'";
        //    dLoginAdapter = new SqlDataAdapter(strSQL, connection.GetConnection());
        //    dLoginSet = new DataSet();
        //    dLoginAdapter.Fill(dLoginSet, "LoginsTable");
        //    dLoginTable = dLoginSet.Tables["LoginsTable"];

        //    if (dLoginTable.Rows.Count > 0)
        //    {
        //        ShowLoginRow();
        //    }
        //    else
        //    {
        //        MessageBox.Show("No Doctors in Clinic!", "No doctors", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //}  
        
        private void ShowLoginRow()
        {
            dLoginRow = dLoginTable.Rows[iLoginRowID];
            //fill text fields
            
            if(dLoginRow.IsNull("Role"))
            {
                Role.Text = "Anonimous";
            }
            else
            {
                int roleId = (int)dLoginRow["Role"];
                if (roleId == 3)
                {
                    this.nextButton_Click(new object(), new EventArgs());
                    return;
                }
                else if(roleId == 1)
                {
                    Role.Text = "Patient";
                }
                else
                {
                    Role.Text = "Doctor";
                }

            }
            Email.Text = dLoginRow["Email"].ToString();
            currentLoginId = (long)dLoginRow["ID"];
            
        }

        private void FillLoginProfile()
        {
            String strSQL = $"select Email, Logins.ID as ID, RoleID as Role from Logins";
            dLoginAdapter = new SqlDataAdapter(strSQL, connection.GetConnection());
            dLoginSet = new DataSet();
            dLoginAdapter.Fill(dLoginSet, "LoginsTable");
            dLoginTable = dLoginSet.Tables["LoginsTable"];

            if (dLoginTable.Rows.Count > 0)
            {
                ShowLoginRow();
            }
            else
            {
                MessageBox.Show("No Users in Clinic!", "No Users", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void LoginProfileForm_Load(object sender, EventArgs e)
        {
            FillLoginProfile();

            FillRoles();
        }

        private void FillRoles()
        {
            Role.Items.Clear();
            Role.Items.Add("Doctor");
            Role.Items.Add("Patient");
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            Email.Enabled = true;
            Role.Enabled = true;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            //update email
            string sqlQuery = $"UPDATE Logins SET Email = '{Email.Text}' WHERE ID = '{currentLoginId}';";
            SqlCommand command = new SqlCommand(sqlQuery, connection.GetConnection());

            command.ExecuteNonQuery();

            //update role
            if (!Role.Text.Equals("Anonimous"))
            {
                sqlQuery = $"update Logins set RoleID = (select ID from Roles where Name = '{Role.Text}') where ID = '{currentLoginId}'";
                command.CommandText = sqlQuery;

                command.ExecuteNonQuery();
            }

            Email.Enabled = false;
            Role.Enabled = false;

            FillLoginProfile();
        }

        private void resetPasswordbutton_Click(object sender, EventArgs e)
        {
            PasswordGB.Visible = true;
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            //var oldPassword = Password.Text;
            var newPassword = NewPassword.Text;
            var confirmPassword = ConfirmPassword.Text;
            if (newPassword == confirmPassword)
            {
                byte[] tmpSource;
                byte[] tmpHash;
                tmpSource = ASCIIEncoding.ASCII.GetBytes(newPassword);
                tmpHash = new MD5CryptoServiceProvider().ComputeHash(tmpSource);

                string passHash = ByteArrayToString(tmpHash);

                SqlDataAdapter adapter1 = new SqlDataAdapter();
                DataTable table1 = new DataTable();

                string sql1 = $"UPDATE [Logins] SET [Password] = '{passHash}' WHERE ID = '{currentLoginId}';";

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
            PasswordGB.Visible = false;
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
     }


}

