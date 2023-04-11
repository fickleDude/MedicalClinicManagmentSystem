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

namespace Medical_Clinic.Doctor
{
    public partial class MyProfileDoctorForm : Form
    {
        private long doctorId;
        private Connection connection;
        public MyProfileDoctorForm(long doctorId, Connection connection)
        {
            InitializeComponent();

            this.doctorId = doctorId;
            this.connection = connection;
        }

        private void MyProfileDoctorForm_Load(object sender, EventArgs e)
        {
            string sqlQuery = $"select FIO, Description, Email from Doctors " +
                $"join Logins on LoginID = Logins.ID where Doctors.ID = '{doctorId}'";
            SqlCommand command = new SqlCommand(sqlQuery, connection.GetConnection());
            connection.OpenConnection();

            SqlDataReader doctorReader = command.ExecuteReader();
            if (doctorReader.Read())
            {
                DoctorEmail.Text = doctorReader["Email"].ToString();
                DoctorFIO.Text = doctorReader["FIO"].ToString();
                DoctorDescription.Text = doctorReader["Description"].ToString();

            }
            doctorReader.Close();
        }
    }
}
