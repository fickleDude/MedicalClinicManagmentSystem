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
using XAct.Services;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Medical_Clinic.Patient
{
    public partial class AppointmentForm : Form
    {
        private string date;
        private Connection connection;
        private long patientId;
        public AppointmentForm(string date, Connection connection, long patientId)
        {
            InitializeComponent();

            this.date = date;
            this.connection = connection;
            this.patientId = patientId;
        }

        private void AppointmentForm_Load(object sender, EventArgs e)
        {
            Date.Text = this.date;
            FillDoctorCombobox();
            FillServiceCombobox();
            Price.Text = "0.00";
        }

        private void FillDoctorCombobox()
        {
            string sqlQuery = "sp_ShowFreeDoctorFIO";
            SqlCommand command = new SqlCommand(sqlQuery, connection.GetConnection());
            command.CommandType = CommandType.StoredProcedure;
            SqlParameter date = new SqlParameter
            {
                ParameterName = "@Date",
                SqlDbType = SqlDbType.Date,
                Value = this.date
            };
            command.Parameters.Add(date);
            connection.OpenConnection();

            SqlDataReader fioReader = command.ExecuteReader();
            while (fioReader.Read())
                Doctor.Items.Add(fioReader["FIO"]);

            fioReader.Close();
        }   
        
        private void FillServiceCombobox()
        {
            string sqlQuery = "select Name from Services";
            SqlCommand command = new SqlCommand(sqlQuery, connection.GetConnection());
            connection.OpenConnection();

            SqlDataReader serviceReader = command.ExecuteReader();
            while (serviceReader.Read())
                Service.Items.Add(serviceReader["Name"]);

            serviceReader.Close();
        }

        private void Service_SelectedIndexChanged(object sender, EventArgs e)
        {
            string serviceName = (string)Service.SelectedItem;
            FillPriceTextbox(serviceName);
        }

        private void FillPriceTextbox(string serviceName)
        {
            string sqlQuery = $"select Price from Services where Name = '{serviceName}'";
            SqlCommand command = new SqlCommand(sqlQuery, connection.GetConnection());
            connection.OpenConnection();

            SqlDataReader serviceReader = command.ExecuteReader();
            if (serviceReader.Read())
                Price.Text = Convert.ToDouble(serviceReader["Price"]).ToString("#.##");

            serviceReader.Close();
        }

        private void makeButton_Click(object sender, EventArgs e)
        {
            string doctorFIO = (string)Doctor.SelectedItem;

            string sqlQuery = $"select ID from Doctors where FIO = '{doctorFIO}'";
            SqlCommand command = new SqlCommand(sqlQuery, connection.GetConnection());
            connection.OpenConnection();

            SqlDataReader doctorReader = command.ExecuteReader();
            long doctorId = -1;
            if (doctorReader.Read())
                doctorId = (long)doctorReader["ID"];

            doctorReader.Close();

            long doctorPatientId = GetDoctorPatientID(doctorId);
            long appointmentId = AddAppointment(doctorPatientId);
            //AddToNotes(appointmentId);
            AddToJournal(appointmentId);
            MessageBox.Show("Thank you! Appointment made!", "See you soon!",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        //private void AddToNotes(long appointmentId)
        //{
        //    string sqlQuery = "sp_InsertPatientNote";
        //    SqlCommand command = new SqlCommand(sqlQuery, connection.GetConnection());
        //    command.CommandType = CommandType.StoredProcedure;
        //    SqlParameter appointmetId = new SqlParameter
        //    {
        //        ParameterName = "@AppointmentId",
        //        SqlDbType = SqlDbType.BigInt,
        //        Value = appointmentId
        //    };
        //    command.Parameters.Add(appointmetId);
        //    connection.OpenConnection();
        //    command.ExecuteNonQuery();

        //    sqlQuery = "sp_InsertDoctorNote";
        //    command.CommandText = sqlQuery;
        //    connection.OpenConnection();
        //    command.ExecuteNonQuery();
        //}

        private void AddToJournal(long appointmentId)
        {
            string serviceName = (string)Service.SelectedItem;
            string sqlQuery = $"select ID from Services where Name = '{serviceName}'";
            SqlCommand command = new SqlCommand(sqlQuery, connection.GetConnection());
            connection.OpenConnection();

            SqlDataReader serviceReader = command.ExecuteReader();
            long serviceId = -1;
            if (serviceReader.Read())
                serviceId = (int)serviceReader["ID"];

            serviceReader.Close();

            int statusId = 1;

            sqlQuery = $"insert into Journal (AppoitmentID, ServiceID, StatusID) values ('{appointmentId}', '{serviceId}', '{statusId}')";
            command.CommandText = sqlQuery;
            command.ExecuteNonQuery();
        }

        private long GetDoctorPatientID(long doctorId)
        {

            string sqlQuery = $"select ID from Doctor_Patient where PatientID = '{this.patientId}' " +
                $"and DoctorID = '{doctorId}'";
            SqlCommand command = new SqlCommand(sqlQuery, connection.GetConnection());
            SqlDataReader doctorPatientReader = command.ExecuteReader();
            long doctorPatientId = -1;
            if (doctorPatientReader.Read())
            {
                doctorPatientId = (long)doctorPatientReader["ID"];
                doctorPatientReader.Close();
            }
            else
            {
                doctorPatientReader.Close();
                sqlQuery = $"insert into Doctor_patient (DoctorID, PatientID) values ('{doctorId}', '{patientId}'); " +
                    $"SET @id=SCOPE_IDENTITY()";
                command.CommandText = sqlQuery;
                SqlParameter doctorPatientParam = new SqlParameter
                {
                    ParameterName = "@id",
                    SqlDbType = SqlDbType.BigInt,
                    Direction = ParameterDirection.Output
                };
                command.Parameters.Add(doctorPatientParam);
                command.ExecuteNonQuery();
                doctorPatientId = (long)doctorPatientParam.Value;
            }
            
            return doctorPatientId;
        }

        private int AddAppointment(long doctorPatientId)
        {
            string sqlQuery = $"insert into Appointments (Doctor_PatientID, Date) values ('{doctorPatientId}', '{this.date}'); SET @id=SCOPE_IDENTITY()";
            SqlCommand command = new SqlCommand(sqlQuery, connection.GetConnection());
            SqlParameter appointmetId = new SqlParameter
            {
                ParameterName = "@id",
                SqlDbType = SqlDbType.Int,
                Direction = ParameterDirection.Output
            };
            command.Parameters.Add(appointmetId);
            command.ExecuteNonQuery();
            return (int)appointmetId.Value;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            connection.CloseConnection();
            this.Close();
        }
    }
}
