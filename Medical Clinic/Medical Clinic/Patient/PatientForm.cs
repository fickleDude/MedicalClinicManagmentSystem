using Medical_Clinic.General;
using Medical_Clinic.Patient;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Medical_Clinic
{
    public partial class PatientForm : Form
    {
        private Connection connection;
        private object loginId;
        public PatientForm(object loginId, Connection connection)
        {
            InitializeComponent();
            this.connection = connection;
            this.loginId = loginId;
        }

        private long GetPatientId()
        {
            string sqlQuery = "sp_ShowPatientId";
            SqlCommand command = new SqlCommand(sqlQuery, connection.GetConnection());
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.Add(new SqlParameter
            {
                ParameterName = "@LoginId",
                SqlDbType = SqlDbType.BigInt,
                Value = loginId
            });
            command.Parameters.Add(new SqlParameter
            {
                ParameterName = "@PatientId",
                SqlDbType = SqlDbType.BigInt,
                Direction = ParameterDirection.Output
            });
            this.connection.OpenConnection();
            command.ExecuteNonQuery();

            return (long)command.Parameters["@PatientId"].Value;
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            connection.CloseConnection();
            this.Close();
        }

        private void myProfileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WelcomeGB.Visible = false;
            STATISTICSGB.Visible = false;
            TODOGB.Visible = false;
            this.WindowState = FormWindowState.Maximized; 

            MyProfileForm MyProfile = new MyProfileForm(this.loginId, this.connection);
            MyProfile.MdiParent = this;
            MyProfile.Show();
        }

        private void clinicToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WelcomeGB.Visible = false;
            STATISTICSGB.Visible = false;
            TODOGB.Visible = false;
            this.WindowState = FormWindowState.Maximized;

            long patientId = GetPatientId();
            ClinicForm clinic = new ClinicForm(patientId, this.connection);
            clinic.MdiParent = this;
            clinic.Show();
        }

        private void PatientForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            connection.CloseConnection();
            System.Windows.Forms.Application.Exit();
        }

        private void pharmacyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WelcomeGB.Visible = false;
            STATISTICSGB.Visible = false;
            TODOGB.Visible = false;
            this.WindowState = FormWindowState.Maximized;

            long patientId = GetPatientId();
            PharmacyForm pharmacy = new PharmacyForm(patientId, this.connection);
            pharmacy.MdiParent = this;
            pharmacy.Show();
        }

        private void PatientForm_Load(object sender, EventArgs e)
        {
            //OUR USERS
            String sqlQuery = $"select COUNT(ID) as Users from Patients";
            SqlCommand command = new SqlCommand(sqlQuery, connection.GetConnection());
            connection.OpenConnection();

            SqlDataReader userReader = command.ExecuteReader();
            if (userReader.Read())
            {
                AdminUsers.Text = userReader["Users"].ToString();
            }
            userReader.Close();
            //OUR DOCTORS
            sqlQuery = $"select COUNT(ID) as Doctors from Doctors";
            command.CommandText = sqlQuery;
            connection.OpenConnection();

            SqlDataReader doctorReader = command.ExecuteReader();
            if (doctorReader.Read())
            {
                AdminDoctors.Text = doctorReader["Doctors"].ToString();
            }
            doctorReader.Close();
            //OUR SERVICES
            sqlQuery = $"select COUNT(ID) as Services from Services";
            command.CommandText = sqlQuery;
            connection.OpenConnection();

            SqlDataReader serviceReader = command.ExecuteReader();
            if (serviceReader.Read())
            {
                AdminServices.Text = serviceReader["Services"].ToString();
            }
            serviceReader.Close();

            long patientID = GetPatientId();

            //APPOINTMENTS
            sqlQuery = $"select COUNT(Appointments.ID) as Appointments from Appointments " +
                $"join Doctor_Patient on Appointments.Doctor_PatientID = Doctor_Patient.ID where  PatientID = '{patientID}'";
            command.CommandText = sqlQuery;
            connection.OpenConnection();

            SqlDataReader appointmentReader = command.ExecuteReader();
            if (appointmentReader.Read())
            {
                AdminAppointments.Text = appointmentReader["Appointments"].ToString();
            }
            appointmentReader.Close();
            //ORDERS
            sqlQuery = $"select COUNT(ID) as Orders from Orders where PatientID = '{patientID}'";
            command.CommandText = sqlQuery;
            connection.OpenConnection();

            SqlDataReader orderReader = command.ExecuteReader();
            if (orderReader.Read())
            {
                AdminOrders.Text = orderReader["Orders"].ToString();
            }
            orderReader.Close();
        }
    }
}
