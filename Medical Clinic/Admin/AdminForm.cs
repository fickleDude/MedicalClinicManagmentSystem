using Medical_Clinic.Admin;
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
using Medical_Clinic.General;
using XAct.Library.Settings;

namespace Medical_Clinic
{
    public partial class AdminForm : Form
    {
        private int loginId;
        private Connection connection;
        public AdminForm(int loginId, Connection connection)
        {
            InitializeComponent();
            this.connection = connection;
            this.loginId = loginId;
        }

        private void myProfileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WelcomeGB.Visible = false;
            STATISTICSGB.Visible = false;
            TODOGB.Visible = false;

            this.WindowState = FormWindowState.Maximized;

            Medical_Clinic.Admin.MyProfileForm myProfileForm = new Medical_Clinic.Admin.MyProfileForm(this.loginId, this.connection);
            myProfileForm.MdiParent = this;
            myProfileForm.Show();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            connection.CloseConnection();
            this.Close();
        }

        private void clinicToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WelcomeGB.Visible = false;
            STATISTICSGB.Visible = false;
            TODOGB.Visible = false;

            this.WindowState = FormWindowState.Maximized;

            Medical_Clinic.Admin.ClinicForm ClinicForm = new Medical_Clinic.Admin.ClinicForm(this.loginId, this.connection);
            ClinicForm.MdiParent = this;
            ClinicForm.Show();
        }

        private void pharmacyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WelcomeGB.Visible = false;
            STATISTICSGB.Visible = false;
            TODOGB.Visible = false;

            this.WindowState = FormWindowState.Maximized;

            PharmacyAdminForm pharmacyAdminForm = new PharmacyAdminForm(connection);
            pharmacyAdminForm.MdiParent = this;
            pharmacyAdminForm.Show();
        }

        private void loginsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WelcomeGB.Visible = false;
            STATISTICSGB.Visible = false;
            TODOGB.Visible = false;

            this.WindowState = FormWindowState.Maximized;

            LoginProfileForm LoginProfile = new LoginProfileForm(this.loginId, this.connection);
            LoginProfile.MdiParent = this;
            LoginProfile.Show();
        }

        private void AdminForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            connection.CloseConnection();
            System.Windows.Forms.Application.Exit();
        }


        private void AdminForm_Load(object sender, EventArgs e)
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
            sqlQuery = $"select COUNT(ID) as Appointments from Journal where StatusID = 1";
            command.CommandText = sqlQuery;
            connection.OpenConnection();

            SqlDataReader appointmentReader = command.ExecuteReader();
            if (appointmentReader.Read())
            {
                AdminAppointments.Text = appointmentReader["Appointments"].ToString();
            }
            appointmentReader.Close();
            //ORDERS
            sqlQuery = $"select COUNT(ID) as Orders from Orders where StatusID = 1";
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
