using Medical_Clinic.Admin;
using Medical_Clinic.Doctor;
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

namespace Medical_Clinic
{
    public partial class DoctorForm : Form
    {
        private int loginId;
        private Connection connection;
        public DoctorForm(int loginId, Connection connection)
        {
            InitializeComponent();

            this.connection = connection;
            this.loginId = loginId;
        }

        private void DoctorForm_Load(object sender, EventArgs e)
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
            //APPOINTMENTS
            long id = GetDoctorId();
            sqlQuery = $"select COUNT(Appointments.ID) as Appointments from Appointments join Doctor_Patient on Appointments.Doctor_PatientID = Doctor_Patient.ID " +
                $"where DoctorID = '{id}'";
            command.CommandText = sqlQuery;
            connection.OpenConnection();

            SqlDataReader appointmentReader = command.ExecuteReader();
            if (appointmentReader.Read())
            {
                AdminAppointments.Text = appointmentReader["Appointments"].ToString();
            }
            appointmentReader.Close();
        }

        private void DoctorForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            connection.CloseConnection();
            System.Windows.Forms.Application.Exit();
        }

        private void myProfileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void myProfileToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            WelcomeGB.Visible = false;
            STATISTICSGB.Visible = false;
            TODOGB.Visible = false;

            this.WindowState = FormWindowState.Maximized;
            long doctorId = GetDoctorId();
            MyProfileDoctorForm LoginProfile = new MyProfileDoctorForm(doctorId, this.connection);
            LoginProfile.MdiParent = this;
            LoginProfile.Show();
        }
        private long GetDoctorId()
        {
            string sqlQuery = $"select ID from Doctors where LoginID = '{loginId}'";
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
        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            connection.CloseConnection();
            this.Close();
        }

        private void clinicToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            long doctorId = GetDoctorId();
            DoctorClinicForm clinicForm = new DoctorClinicForm(doctorId, this.connection);
            clinicForm.MdiParent = this;
            clinicForm.Show();
        }
    }
}
