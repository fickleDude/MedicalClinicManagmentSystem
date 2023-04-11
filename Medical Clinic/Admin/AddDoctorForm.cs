using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Medical_Clinic.General;
using Microsoft.Data.SqlClient;

namespace Medical_Clinic.Admin
{
    public partial class AddDoctorForm : Form
    {
        private Connection connection;
        public AddDoctorForm(Connection connection)
        {
            InitializeComponent();

            this.connection = connection;
        }

        private void AddDoctorForm_Load(object sender, EventArgs e)
        {
            FillSpecializations();
            FillEmails();
        }

        private void FillSpecializations()
        {
            string sqlQuery = "select Name from Specializations";
            SqlCommand command = new SqlCommand(sqlQuery, connection.GetConnection());
            connection.OpenConnection();

            SqlDataReader specializationReader = command.ExecuteReader();
            Specialization.Items.Clear();
            while (specializationReader.Read())
                Specialization.Items.Add(specializationReader["Name"]);

            specializationReader.Close();
        }  
        
        private void FillEmails()
        {
            string sqlQuery = "select Email from Logins where ID in " +
                "(select ID from Logins " +
                "where RoleID = 2 except select LoginID from Doctors)";
            SqlCommand command = new SqlCommand(sqlQuery, connection.GetConnection());
            connection.OpenConnection();

            SqlDataReader emailReader = command.ExecuteReader();
            Email.Items.Clear();
            while (emailReader.Read())
                Email.Items.Add(emailReader["Email"]);

            emailReader.Close();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            //find Login Id
            string sqlQuery = $"select ID from Logins where Email = '{Email.SelectedItem}'";
            SqlCommand command = new SqlCommand(sqlQuery, connection.GetConnection());
            connection.OpenConnection();

            SqlDataReader loginReader = command.ExecuteReader();
            long loginId = -1;
            if (loginReader.Read())
                loginId = (long)loginReader["ID"];

            loginReader.Close();

            //insert doctor
            sqlQuery = $"insert into Doctors (LoginID, FIO, Description) values ('{loginId}','{FIO.Text}','{Description.Text}'); SELECT @id=SCOPE_IDENTITY();";
            command.CommandText = sqlQuery;
            SqlParameter id = new SqlParameter
            {
                ParameterName = "@id",
                SqlDbType = SqlDbType.BigInt,
                Direction = ParameterDirection.Output
            };
            command.Parameters.Add(id);
            connection.OpenConnection();
            command.ExecuteNonQuery();
            long newDoctorId = (long)id.Value;

            //bind specializations
            foreach (var specialization in Specialization.CheckedItems)
            {
                //search specialization id
                sqlQuery = $"select ID from Specializations where Name = '{specialization.ToString()}'";
                command.CommandText = sqlQuery;
                connection.OpenConnection();

                SqlDataReader specializationReader = command.ExecuteReader();
                long specializationId = -1;
                if (specializationReader.Read())
                    specializationId = (int)specializationReader["ID"];

                specializationReader.Close();

                //insert int doctor_specialization
                sqlQuery = $"insert into Doctor_Specialization (DoctorID, SpecializationID) values ('{newDoctorId}','{specializationId}')";
                command.CommandText = sqlQuery;
                connection.OpenConnection();
                command.ExecuteNonQuery();
            }

            this.Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
