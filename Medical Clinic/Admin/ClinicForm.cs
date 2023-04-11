using Medical_Clinic.General;
using Microsoft.Data.SqlClient;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Medical_Clinic.Admin
{
    public partial class ClinicForm : Form
    {
        private long adminId;
        private Connection connection;
        //JOURNAL TAB
        private SqlDataAdapter dJournalAdapter;
        private DataSet dJournalSet;
        private long currentAppointment;

        //SERVICE TAB
        private SqlDataAdapter dServiceAdapter;
        private DataSet dServiceSet;
        private int currentService;  
        
        //SPECIALIZATION TAB
        private SqlDataAdapter dSpecializationAdapter;
        private DataSet dSpecializationSet;
        private int currentSpecialization;

        //DOCTOR TAB
        private SqlDataAdapter dDoctorsAdapter;
        private DataSet dDoctorsSet;
        private DataTable dDoctorsTable;
        private DataRow dDoctorsRow;
        private int iDoctorsRowID;
        private long currentDoctorId;
        private long currentLoginId;
        public ClinicForm(long adminId, Connection connection)
        {
            InitializeComponent();

            this.adminId = adminId;
            this.connection = connection;

            dJournalSet = new DataSet();
            dServiceSet = new DataSet();
            dSpecializationSet = new DataSet();

            iDoctorsRowID = 0;

            this.ContextMenuStrip = ClinicReload;
        }

        private void ClinicForm_Load(object sender, EventArgs e)
        {
            //Journal TAB
            FillAppointments(null,null);
            FillDoctors();

            //Service TAB
            FillService();    
            
            //Specialization TAB
            FillSpecialization();

            //Doctor TAB
            FillDoctorsProfile();
        }

        private void FillAppointments(string date, string doctor)
        {
            string sqlQuery = "";
            if(date==null && doctor==null)
            {
                sqlQuery = "SELECT Patient, Service, Status, Price, Doctor, Date FROM AdminJournalView";
            }
            else if(doctor == null)
            {
                sqlQuery = $"SELECT Patient, Service, Status, Price, Doctor, Date FROM AdminJournalView where Date = '{date}'";
            }
            else
            {
                sqlQuery = $"SELECT Patient, Service, Status, Price, Doctor, Date FROM AdminJournalView where Date = '{date}' and Doctor = '{doctor}'";
            }
            dJournalAdapter = new SqlDataAdapter(sqlQuery, connection.GetConnection());
            dJournalSet.Clear();
            dJournalAdapter.Fill(dJournalSet, "AdminJournalView");
           // dJournalAdapter.Update(dJournalSet, "AdminJournalView");

            AppointmentDG.DataSource = dJournalSet.Tables["AdminJournalView"];
        }  
        
        private void FillService()
        {
            string sqlQuery = $"SELECT Name, Price from Services";

            dServiceAdapter = new SqlDataAdapter(sqlQuery, connection.GetConnection());
            dServiceSet.Clear();
            dServiceAdapter.Fill(dServiceSet, "Services");

            ServiceDG.DataSource = dServiceSet.Tables["Services"];
        }   
        
        private void FillSpecialization()
        {
            string sqlQuery = $"SELECT Name from Specializations";

            dSpecializationAdapter = new SqlDataAdapter(sqlQuery, connection.GetConnection());
            dSpecializationSet.Clear();
            dSpecializationAdapter.Fill(dSpecializationSet, "Specializations");

            SpecializationGD.DataSource = dSpecializationSet.Tables["Specializations"];
        }   
        
        public void FillDoctors()
        {
            string sqlQuery = "select FIO from Doctors";
            SqlCommand command = new SqlCommand(sqlQuery, connection.GetConnection());
            connection.OpenConnection();

            SqlDataReader fioReader = command.ExecuteReader();
            JournalDoctor.Items.Clear();
            while (fioReader.Read())
                JournalDoctor.Items.Add(fioReader["FIO"]);

            fioReader.Close();
        }

        private void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {
            string date = JournalCalendar.SelectionStart.ToShortDateString();
            string selectedDoctor = (string)JournalDoctor.SelectedItem;
            FillAppointments(date, selectedDoctor);
        }

        private void JournalDoctor_SelectedIndexChanged(object sender, EventArgs e)
        {
            string date = JournalCalendar.SelectionStart.ToShortDateString();
            string selectedDoctor = (string)JournalDoctor.SelectedItem;
            FillAppointments(date, selectedDoctor);

        }

        private void AppointmentDG_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.AppointmentDG.Rows[e.RowIndex];
                string patient = row.Cells["Patient"].Value.ToString();
                string service = row.Cells["Service"].Value.ToString();
                string status = row.Cells["Status"].Value.ToString();
                string price = row.Cells["Price"].Value.ToString();
                string doctor = row.Cells["Doctor"].Value.ToString();
                DateTime date = Convert.ToDateTime(row.Cells["Date"].Value);

                string sqlQuery = $"select ID from AdminJournalView where Patient = '{patient}' and Doctor = '{doctor}' " +
                    $"and Service = '{service}' and Status = '{status}' and Date = '{date}' and Price = '{price}'";
                SqlCommand command = new SqlCommand(sqlQuery, connection.GetConnection());
                connection.OpenConnection();

                SqlDataReader idReader = command.ExecuteReader();
                //JournalDoctor.Items.Clear();
                if (idReader.Read())
                    currentAppointment = (long)idReader["ID"];
                idReader.Close();
            }
            ActionGB.Visible = true;
        }

        private void addJournalButton_Click(object sender, EventArgs e)
        {
            AppointmentAdminForm appointmentAdminForm = new AppointmentAdminForm(connection);
            appointmentAdminForm.ShowDialog();

            dJournalAdapter.Update(dJournalSet, "AdminJournalView");

            FillDoctors();
            ActionGB.Visible = false;
        }

        private void cancelJournalbutton_Click(object sender, EventArgs e)
        {
            string date = JournalCalendar.SelectionStart.ToShortDateString();
            string selectedDoctor = (string)JournalDoctor.SelectedItem;
            //set caancel status
            string sqlQuery = $"update Journal set StatusID = 2 where AppoitmentID = '{currentAppointment}'";
            SqlCommand command = new SqlCommand(sqlQuery, connection.GetConnection());
            connection.OpenConnection();
            command.ExecuteNonQuery();

            //delete associated with appointment notes
            DeleteNotes(currentAppointment);

            //update grid
            dJournalAdapter.Update(dJournalSet, "AdminJournalView");

            FillDoctors();
            ActionGB.Visible = false;
        }

        private void DeleteNotes(long appointmentId)
        {
            string sqlQuery = $"DELETE FROM PatientNotes WHERE AppointmentId = '{appointmentId}';";
            SqlCommand command = new SqlCommand(sqlQuery, connection.GetConnection());
            connection.OpenConnection();
            command.ExecuteNonQuery();

            sqlQuery = $"DELETE FROM DoctorNotes WHERE AppointmentId = '{appointmentId}';";
            command.CommandText = sqlQuery;
            command.ExecuteNonQuery();
        }

        private void ServiceDG_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.ServiceDG.Rows[e.RowIndex];
                ServiceName.Text = row.Cells["Name"].Value.ToString();
                ServicePrice.Value = (decimal)row.Cells["Price"].Value;

                string sqlQuery = $"select ID FROM Services WHERE Name = '{ServiceName.Text}' and Price = '{ServicePrice.Value}';";
                SqlCommand command = new SqlCommand(sqlQuery, connection.GetConnection());
                connection.OpenConnection();

                SqlDataReader idReader = command.ExecuteReader();
                if (idReader.Read())
                    currentService = (int)idReader["ID"];
                idReader.Close();
            }
            Service.Visible = true;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            ServicePrice.Enabled = false;
            ServiceName.Enabled = false;
            Service.Visible = false;
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            ServicePrice.Enabled = true;
            ServiceName.Enabled = true;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if(currentService != -1) //modify
            {
                string sqlQuery = $"update Services set Name = '{ServiceName.Text}', Price = '{ServicePrice.Value}' where ID = '{currentService}'";
                SqlCommand command = new SqlCommand(sqlQuery, connection.GetConnection());
                connection.OpenConnection();
                command.ExecuteNonQuery();
                MessageBox.Show("Service Modified!", "Service",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else //add new
            {
                string sqlQuery = $"insert into Services (Name, Price) values ('{ServiceName.Text}','{ServicePrice.Value}')";
                SqlCommand command = new SqlCommand(sqlQuery, connection.GetConnection());
                connection.OpenConnection();
                try
                {
                    command.ExecuteNonQuery();
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Service already existis!", "Service",
                         MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                MessageBox.Show("New Service Added!", "Service",
                     MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            dServiceSet.Clear();
            dServiceAdapter.Fill(dServiceSet, "Services");

            ServicePrice.Enabled = false;
            ServiceName.Enabled = false;
            Service.Visible = false;
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            editButton.Enabled = false;
            currentService = -1;
            ServiceName.Enabled = true;
            ServiceName.Text = "";
            ServicePrice.Enabled = true;
            ServicePrice.Value = 0;

            Service.Visible = true;
        }

        private void saveSpecializationbutton_Click(object sender, EventArgs e)
        {
            if (currentSpecialization != -1) //modify
            {
                string sqlQuery = $"update Specializations set Name = '{SpecializationName.Text}' where ID = '{currentSpecialization}'";
                SqlCommand command = new SqlCommand(sqlQuery, connection.GetConnection());
                connection.OpenConnection();
                command.ExecuteNonQuery();
                MessageBox.Show("Specialization Modified!", "Specialization",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else //add new
            {
                string sqlQuery = $"insert into Specializations (Name) values ('{SpecializationName.Text}')";
                SqlCommand command = new SqlCommand(sqlQuery, connection.GetConnection());
                connection.OpenConnection();
                command.ExecuteNonQuery();
                MessageBox.Show("New Specialization Added!", "Specialization",
                     MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            dSpecializationSet.Clear();
            dSpecializationAdapter.Fill(dSpecializationSet, "Specializations");

            SpecializationName.Enabled = false;
            Specialization.Visible = false;
        }

        private void editSpecializationbutton_Click(object sender, EventArgs e)
        {
            SpecializationName.Enabled = true;
        }

        private void cancelSpecializationbutton_Click(object sender, EventArgs e)
        {
            SpecializationName.Enabled = false;
            Specialization.Visible = false;
        }

        private void addSpecializationbutton_Click(object sender, EventArgs e)
        {
            editSpecializationbutton.Enabled = false;
            currentSpecialization = -1;

            SpecializationName.Enabled = true;
            SpecializationName.Text = "";

            Specialization.Visible = true;
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            string sqlQuery = $"DELETE FROM Services WHERE ID = '{currentService}';";
            SqlCommand command = new SqlCommand(sqlQuery, connection.GetConnection());
            connection.OpenConnection();
            command.ExecuteNonQuery();
            MessageBox.Show("Deleted Service!", "Service",
                 MessageBoxButtons.OK, MessageBoxIcon.Information);

            Service.Visible = false;
            dServiceSet.Clear();
            dServiceAdapter.Fill(dServiceSet, "Services");
        }

        private void deleteSpecializationbutton_Click_1(object sender, EventArgs e)
        {
            //delete doctor_specialization bind
            string sqlQuery = $"DELETE FROM Doctor_Specialization WHERE SpecializationID = '{currentSpecialization}';";
            SqlCommand command = new SqlCommand(sqlQuery, connection.GetConnection());
            connection.OpenConnection();
            command.ExecuteNonQuery();

            //delete specialization
            sqlQuery = $"DELETE FROM Specializations WHERE ID = '{currentSpecialization}';";
            command.CommandText = sqlQuery;
            connection.OpenConnection();
            command.ExecuteNonQuery();
            MessageBox.Show("Deleted Specialization!", "Specialization",
                 MessageBoxButtons.OK, MessageBoxIcon.Information);

            Specialization.Visible = false;
            dSpecializationSet.Clear();
            dSpecializationAdapter.Fill(dSpecializationSet, "Specializations");
        }

        private void SpecializationGD_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.SpecializationGD.Rows[e.RowIndex];
                SpecializationName.Text = row.Cells["Name"].Value.ToString();

                string sqlQuery = $"select ID FROM Specializations WHERE Name = '{SpecializationName.Text}';";
                SqlCommand command = new SqlCommand(sqlQuery, connection.GetConnection());
                connection.OpenConnection();

                SqlDataReader idReader = command.ExecuteReader();
                if (idReader.Read())
                    currentSpecialization = (int)idReader["ID"];
                idReader.Close();
            }
            editSpecializationbutton.Enabled = true;
            Specialization.Visible = true;
        }

        //DOCTOR TAB
        private void FillDoctorsProfile()
        {
            String strSQL = $"select FIO, Description, LoginID as Login, Doctors.ID as ID from Doctors";
            dDoctorsAdapter = new SqlDataAdapter(strSQL, connection.GetConnection());
            dDoctorsSet = new DataSet();
            dDoctorsAdapter.Fill(dDoctorsSet, "DoctorsTable");
            dDoctorsTable = dDoctorsSet.Tables["DoctorsTable"];

            if (dDoctorsTable.Rows.Count > 0)
            {
                ShowDoctorRow();
            }
            //else
            //{
            //    MessageBox.Show("No Doctors in Clinic!", "No doctors", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }

        private void ShowDoctorRow()
        {
            dDoctorsRow = dDoctorsTable.Rows[iDoctorsRowID];
            //fill text fields
            FIO.Text = dDoctorsRow["FIO"].ToString();
            Description.Text = dDoctorsRow["Description"].ToString();
            currentLoginId = (long)dDoctorsRow["Login"];
            currentDoctorId = (long)dDoctorsRow["ID"];

            string sqlQuery = $"select Email from Logins where ID = '{currentLoginId}'";
            SqlCommand command = new SqlCommand(sqlQuery, connection.GetConnection());
            connection.OpenConnection();

            SqlDataReader emailReader = command.ExecuteReader();
            if (emailReader.Read())
                Email.Text = emailReader["Email"].ToString();

            emailReader.Close();

            //fill check bor
            FillSpecializations();
        }

        private void FillSpecializations()
        {
            //fill list box
            string sqlQuery = "select Name from Specializations";
            SqlCommand command = new SqlCommand(sqlQuery, connection.GetConnection());
            connection.OpenConnection();

            SqlDataReader specializationReader = command.ExecuteReader();
            Specializations.Items.Clear();
            while (specializationReader.Read())
                Specializations.Items.Add(specializationReader["Name"]);

            specializationReader.Close();

            //check current specialization
            sqlQuery = $"select Name from Specializations join Doctor_Specialization on Specializations.ID = Doctor_Specialization.SpecializationID where DoctorID = '{currentDoctorId}'";
            command.CommandText = sqlQuery;
            connection.OpenConnection();

            SqlDataReader specializationsReader = command.ExecuteReader();
            while (specializationsReader.Read())
            {
                for (int i = 0; i < Specializations.Items.Count; i++)
                {
                    if (Specializations.Items[i].ToString().Equals(specializationsReader["Name"].ToString()))
                    {
                        Specializations.SetItemChecked(i, true);
                    }
                }
            }
            specializationsReader.Close();
        }

        private void prevButton_Click(object sender, EventArgs e)
        {
            if (iDoctorsRowID > 0)
            {
                iDoctorsRowID--;
                ShowDoctorRow();
            }
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            if (iDoctorsRowID < dDoctorsSet.Tables["DoctorsTable"].Rows.Count - 1)
            {
                iDoctorsRowID++;
                ShowDoctorRow();
            }
        }

        private void EditDoctor_Click(object sender, EventArgs e)
        {
            FIO.Enabled = true;
            Description.Enabled = true;
            Email.Enabled = true;
            Specializations.SelectionMode = SelectionMode.One;
        }

        private void SaveDoctor_Click(object sender, EventArgs e)
        {
            String sqlQuery = $"UPDATE Doctors SET FIO = '{FIO.Text}', Description = '{Description.Text}' WHERE ID = '{currentDoctorId}';";
            SqlCommand command = new SqlCommand(sqlQuery, connection.GetConnection());
            connection.OpenConnection();

            command.ExecuteNonQuery();

            FIO.Enabled = false;
            Description.Enabled = false;

            sqlQuery = $"UPDATE Logins SET Email = '{Email.Text}' WHERE ID = '{currentLoginId}';";
            command.CommandText = sqlQuery;
            connection.OpenConnection();

            command.ExecuteNonQuery();
            Email.Enabled = false;

            //update specializations
            for (int i = 0; i < Specializations.Items.Count; i++)
            {
                //search for doctor_specialization connection
                sqlQuery = $"select Doctor_specialization.ID as ID from Doctor_Specialization " +
                    $"join Specializations on SpecializationID = Specializations.ID " +
                    $"where DoctorID = '{currentDoctorId}' and Specializations.Name = '{Specializations.Items[i]}'";
                command.CommandText = sqlQuery;
                connection.OpenConnection();

                SqlDataReader idReader = command.ExecuteReader();
                int id = -1;
                if (idReader.Read())
                    id = (int)idReader["ID"];
                idReader.Close();
                //if connection exists, but item unchecked
                if(id != -1 && Specializations.GetItemCheckState(i) != CheckState.Checked)
                {
                    sqlQuery = $"DELETE FROM Doctor_specialization WHERE ID = '{id}';";
                    command.CommandText = sqlQuery;
                    connection.OpenConnection();

                    command.ExecuteNonQuery();
                }
                //if connection does not exists, but item checked
                else if(id == -1 && Specializations.GetItemCheckState(i) == CheckState.Checked)
                {
                    //get specialization id
                    sqlQuery = $"select ID from Specializations where Name = '{Specializations.Items[i]}'";
                    command.CommandText = sqlQuery;
                    connection.OpenConnection();

                    SqlDataReader idSpecializationReader = command.ExecuteReader();
                    int idSpecialization = -1;
                    if (idSpecializationReader.Read())
                        idSpecialization = (int)idSpecializationReader["ID"];
                    idSpecializationReader.Close();

                    sqlQuery = $"insert into Doctor_Specialization (DoctorID, SpecializationID) values ('{currentDoctorId}','{idSpecialization}')";
                    command.CommandText = sqlQuery;
                    connection.OpenConnection();

                    command.ExecuteNonQuery();
                }
            }
            Specializations.SelectionMode = SelectionMode.None;
            
            FillDoctorsProfile();
        }

        private void CancelDoctor_Click(object sender, EventArgs e)
        {
            //fio and description
            String sqlQuery = $"select FIO, Description from Doctors where ID = '{currentDoctorId}'";
            SqlCommand command = new SqlCommand(sqlQuery, connection.GetConnection());
            connection.OpenConnection();

            SqlDataReader cancelReader = command.ExecuteReader();
            if (cancelReader.Read())
            {
                Description.Text = cancelReader["Description"].ToString();
                FIO.Text = cancelReader["FIO"].ToString();
            }
            cancelReader.Close();

            FIO.Enabled = false;
            Description.Enabled = false;

            //email
            sqlQuery = $"select Email from Logins where ID = '{currentLoginId}'";
            command.CommandText = sqlQuery;
            connection.OpenConnection();

            SqlDataReader emailReader = command.ExecuteReader();
            if (emailReader.Read())
            {
                Email.Text = emailReader["Email"].ToString();
            }
            emailReader.Close();
            Email.Enabled = false;

            //specializations
            FillSpecializations();
            Specializations.SelectionMode = SelectionMode.None;
        }

        private void AddDoctor_Click(object sender, EventArgs e)
        {
            AddDoctorForm addDoctorForm = new AddDoctorForm(connection);
            addDoctorForm.ShowDialog();
            //FillDoctors();
        }

        private void DeleteDoctor_Click(object sender, EventArgs e)
        {
            //delete from doctor_specialization
            String sqlQuery = $"DELETE FROM Doctor_Specialization WHERE DoctorID = '{currentDoctorId}';";
            SqlCommand command = new SqlCommand(sqlQuery, connection.GetConnection());
            connection.OpenConnection();

            command.ExecuteNonQuery();
            //delete doctor
            sqlQuery = $"DELETE FROM Doctors WHERE ID = '{currentDoctorId}';";
            command.CommandText = sqlQuery;
            connection.OpenConnection();

            command.ExecuteNonQuery();

            MessageBox.Show("Doctor Deleted!", "Doctors", MessageBoxButtons.OK, MessageBoxIcon.Information);
            FillDoctors();
        }

        private void reloadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Journal TAB
            FillAppointments(null, null);
            FillDoctors();

            //Service TAB
            FillService();

            //Specialization TAB
            FillSpecialization();

            //Doctor TAB
            FillDoctorsProfile();
        }
    }
}
