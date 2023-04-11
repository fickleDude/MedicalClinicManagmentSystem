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

namespace Medical_Clinic.Admin
{
    public partial class AppointmentAdminForm : Form
    {
        private Connection connection;
        public AppointmentAdminForm(Connection connection)
        {
            InitializeComponent();

            this.connection = connection;
        }

        private void Date_ValueChanged(object sender, EventArgs e)
        {
            DateTime date = Convert.ToDateTime(Date.Text);

            FillDoctor(date);
            FillPatient(date);
        }

        private void FillDoctor(DateTime date)
        {
            Doctor.Items.Clear();

            string sqlQuery = $"select distinct Doctor from AdminJournalView where Date != '{date}'";
            SqlCommand command = new SqlCommand(sqlQuery, connection.GetConnection());
            connection.OpenConnection();

            SqlDataReader doctorReader = command.ExecuteReader();
            while (doctorReader.Read())
            {
                Doctor.Items.Add(doctorReader["Doctor"].ToString());

            }
            doctorReader.Close();
        }

        private void FillPatient(DateTime date)
        {
            Patient.Items.Clear();

            string sqlQuery = $"select distinct Patient from AdminJournalView where Date != '{date}'";
            SqlCommand command = new SqlCommand(sqlQuery, connection.GetConnection());
            connection.OpenConnection();

            SqlDataReader patientReader = command.ExecuteReader();
            while (patientReader.Read())
            {
                Patient.Items.Add(patientReader["Patient"].ToString());

            }
            patientReader.Close();
        }

        private void FillService()
        {
            string sqlQuery = $"select Name from Services";
            SqlCommand command = new SqlCommand(sqlQuery, connection.GetConnection());
            connection.OpenConnection();

            SqlDataReader serviceReader = command.ExecuteReader();
            while (serviceReader.Read())
            {
                Service.Items.Add(serviceReader["Name"].ToString());

            }
            serviceReader.Close();
        }

        private void AppointmentAdminForm_Load(object sender, EventArgs e)
        {
            FillService();
        }

        private void makeButton_Click(object sender, EventArgs e)
        {
            //get information
            string doctorFIO = (string)Doctor.SelectedItem;
            string patientFIO = (string)Patient.SelectedItem;
            string service = (string)Service.SelectedItem;
            DateTime date = Convert.ToDateTime(Date.Text);

            //add to Doctor_Patient if not
            long doctorId = GetDoctorID(doctorFIO);
            long patientId = GetPatientID(patientFIO);

            long doctorPatientId = GetDoctorPatientID(doctorId, patientId);
            //add to Appointment
            long appointmentId = AddAppointment(doctorPatientId, date);
            
            //add to Journal
            AddToJournal(appointmentId, service);
            MessageBox.Show("Thank you! Appointment made!", "See you soon!",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void AddToJournal(long appointmentId, string service)
        {
            string sqlQuery = $"select ID from Services where Name = '{service}'";
            SqlCommand command = new SqlCommand(sqlQuery, connection.GetConnection());
            connection.OpenConnection();

            SqlDataReader serviceReader = command.ExecuteReader();
            long serviceId = -1;
            if (serviceReader.Read())
                serviceId = (int)serviceReader["ID"];

            serviceReader.Close();

            int statusId = 1;//New

            sqlQuery = $"insert into Journal (AppoitmentID, ServiceID, StatusID) values ('{appointmentId}', '{serviceId}', '{statusId}')";
            command.CommandText = sqlQuery;
            command.ExecuteNonQuery();
        }
        private long GetDoctorID(string doctorFIO)
        {
            string sqlQuery = $"select ID from Doctors where FIO = '{doctorFIO}'";
            SqlCommand command = new SqlCommand(sqlQuery, connection.GetConnection());
            connection.OpenConnection();

            SqlDataReader doctorReader = command.ExecuteReader();
            long doctorId = -1;
            if (doctorReader.Read())
                doctorId = (long)doctorReader["ID"];

            doctorReader.Close();
            return doctorId;
        } 
        
        private long GetPatientID(string patientFIO)
        {
            string sqlQuery = $"select ID from Patients where FIO = '{patientFIO}'";
            SqlCommand command = new SqlCommand(sqlQuery, connection.GetConnection());
            connection.OpenConnection();

            SqlDataReader patientReader = command.ExecuteReader();
            long doctorId = -1;
            if (patientReader.Read())
                doctorId = (long)patientReader["ID"];

            patientReader.Close();
            return doctorId;
        }

        private long GetDoctorPatientID(long doctorId, long patientId)
        {

            string sqlQuery = $"select ID from Doctor_Patient where PatientID = '{patientId}' " +
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

        private int AddAppointment(long doctorPatientId, DateTime date)
        {
            string sqlQuery = $"insert into Appointments (Doctor_PatientID, Date) values ('{doctorPatientId}', '{date}'); SET @id=SCOPE_IDENTITY()";
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
