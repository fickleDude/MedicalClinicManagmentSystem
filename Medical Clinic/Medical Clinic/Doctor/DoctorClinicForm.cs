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

namespace Medical_Clinic.Doctor
{
    public partial class DoctorClinicForm : Form
    {
        private long doctorId;
        private Connection connection;

        //JOURNAL TAB
        private SqlDataAdapter dJournalAdapter;
        private DataSet dJournalSet;
        private DataTable dJournalTable;
        private DataRow dJournalRow;
        private int iJournalRowID;
        private long currentAppointmentId;  
        
        //NOTE TAB
        private SqlDataAdapter dNoteAdapter;
        private DataSet dNoteSet;
        private DataTable dNoteTable;
        private DataRow dNoteRow;
        private int iNoteRowID;
        private long currentNoteId;
        private long currentNoteAppointment;

        //Presc TAB
        private SqlDataAdapter dPrescriptionAdapter;
        private DataSet dPrescriptionSet;
        private DataTable dPrescriptionTable;
        private DataRow dPrescriptionRow;
        private int iPrescriptionRowID;
        private long currentPrescriptionAppointment;
        public DoctorClinicForm(long doctorId, Connection connection)
        {
            InitializeComponent();

            this.connection = connection;
            this.doctorId = doctorId;

            dJournalSet = new DataSet();
            dNoteSet = new DataSet();
            dPrescriptionSet = new DataSet();

            this.ContextMenuStrip = contextMenuStrip1;
        }

        private void DoctorClinicForm_Load(object sender, EventArgs e)
        {
            FillAppointments();

            FillNotes(null);
            FillSelectPatient();

            FillPatientPresc();
            FillPrescMedicine();
        }

        private void FillPatientPresc()
        {
            SelectPatientPresc.Items.Clear();
            string sqlQuery = $"select distinct Patient from AdminJournalView " +
                    $"join Doctors on AdminJournalView.Doctor = Doctors.FIO " +
                    $"where Doctors.ID = '{doctorId}'";
            SqlCommand command = new SqlCommand(sqlQuery, connection.GetConnection());
            connection.OpenConnection();

            SqlDataReader patientReader = command.ExecuteReader();
            while (patientReader.Read())
                SelectPatientPresc.Items.Add(patientReader["Patient"]);

            patientReader.Close();

        } 
        
        private void FillPrescMedicine()
        {
            PrescMedicine.Items.Clear();
            string sqlQuery = $"select Medicines.Name as Name from PharmacyProducts " +
                $"join Medicines on Medicines.ID = PharmacyProducts.MedicineID";
            SqlCommand command = new SqlCommand(sqlQuery, connection.GetConnection());
            connection.OpenConnection();

            SqlDataReader patientReader = command.ExecuteReader();
            while (patientReader.Read())
                PrescMedicine.Items.Add(patientReader["Name"]);

            patientReader.Close();

        }
        private void FillAppointments()
        {
            string sqlQuery = $"SELECT Patient, Service, Status, Doctor, Date, AdminJournalView.ID FROM AdminJournalView join Doctors on Doctors.FIO = Doctor " +
                $"where Doctors.ID = '{doctorId}'";
            dJournalAdapter = new SqlDataAdapter(sqlQuery, connection.GetConnection());
            dJournalSet.Clear();
            dJournalAdapter.Fill(dJournalSet, "DoctorJournalView");
            dJournalTable = dJournalSet.Tables["DoctorJournalView"];

            if (dJournalTable.Rows.Count > 0)
            {
                ShowJournalRow();
            }
        }

        private void ShowJournalRow()
        {
            dJournalRow = dJournalTable.Rows[iJournalRowID];

            DateAppointment.Text = dJournalRow["Date"].ToString();
            PatientAppointment.Text = dJournalRow["Patient"].ToString();
            StatusAppointment.Text = dJournalRow["Status"].ToString();
            ServiceAppointment.Text = dJournalRow["Service"].ToString();
            currentAppointmentId = (long)dJournalRow["ID"];
        }

        private void Journal_DateSelected(object sender, DateRangeEventArgs e)
        {
            //PatientAppointment.Enabled = true;
            //FillPatents(date);
        }

        private void PrevAppointment_Click(object sender, EventArgs e)
        {
            if (iJournalRowID > 0)
            {
                iJournalRowID--;
                ShowJournalRow();
            }
        }

        private void NextAppointment_Click(object sender, EventArgs e)
        {
            if (iJournalRowID < dJournalSet.Tables["DoctorJournalView"].Rows.Count - 1)
            {
                iJournalRowID++;
                ShowJournalRow();
            }
        }      
        
        private void FillNotes(string patientFIO)
        {
            iNoteRowID = 0;
            string sqlQuery = "";
            if(patientFIO != null)
            {
                sqlQuery = $"select distinct Diagnosis, Symptoms, AdminJournalView.Date as Date, AdminJournalView.Service as Service, AdminJournalView.Patient as Patient, AdminJournalView.ID as AppointmentID from DoctorNotes " +
                    $"join AdminJournalView on AdminJournalView.ID = DoctorNotes.AppointmentID " +
                    $"join Doctors on AdminJournalView.Doctor = Doctors.FIO where Doctors.ID = '{doctorId}' and Patient = '{patientFIO}'";
            }
            else
            { 
                sqlQuery = $"select distinct DoctorNotes.ID as Note, Diagnosis, Symptoms, AdminJournalView.Date as Date, AdminJournalView.Service as Service, AdminJournalView.Patient as Patient, AdminJournalView.ID as AppointmentID from DoctorNotes " +
                    $"join AdminJournalView on AdminJournalView.ID = DoctorNotes.AppointmentID " +
                    $"join Doctors on AdminJournalView.Doctor = Doctors.FIO where Doctors.ID = '{doctorId}'";
        
            }
            dNoteAdapter = new SqlDataAdapter(sqlQuery, connection.GetConnection());
            dNoteSet.Clear();
            dNoteAdapter.Fill(dNoteSet, "DoctorNoteView");
            dNoteTable = dNoteSet.Tables["DoctorNoteView"];    

            if (dNoteTable.Rows.Count > 0)
            {
                ShowNoteRow();
            }
        }
        private void FillSelectPatient()
        {
            
            string sqlQuery = $"select distinct Patient from AdminJournalView " +
                $"join Doctors on AdminJournalView.Doctor = Doctors.FIO " +
                $"where Doctors.ID = '{doctorId}'";
            SqlCommand command = new SqlCommand(sqlQuery, connection.GetConnection());
            connection.OpenConnection();

            SqlDataReader patientReader = command.ExecuteReader();
            SelectPatient.Items.Clear();
            while (patientReader.Read())
                SelectPatient.Items.Add(patientReader["Patient"]);

            patientReader.Close();
        }
        private void ShowNoteRow()
        {
            dNoteRow = dNoteTable.Rows[iNoteRowID];

            NoteDate.Text = dNoteRow["Date"].ToString();
            SimptomsNote.Text = dNoteRow["Symptoms"].ToString();
            DiagnosisNote.Text = dNoteRow["Diagnosis"].ToString();
            NoteService.Text = dNoteRow["Service"].ToString();
            SelectPatient.SelectedValue = dNoteRow["Patient"].ToString();
            currentNoteAppointment = (long)dNoteRow["AppointmentID"];
            if (dNoteRow.IsNull("Note"))
            {
                currentNoteId = -1;
            }
            else
            {
                currentNoteId = (long)dNoteRow["Note"];
            }
            
        }

        private void prevButton_Click(object sender, EventArgs e)
        {
            if (iNoteRowID > 0)
            {
                iNoteRowID--;
                ShowNoteRow();
            }
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            if (iNoteRowID < dNoteSet.Tables["DoctorNoteView"].Rows.Count - 1)
            {
                iNoteRowID++;
                ShowNoteRow();
            }
        }

        private void SelectPatient_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillNotes(SelectPatient.SelectedItem.ToString());
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            DiagnosisNote.Enabled = true;
            SimptomsNote.Enabled = true;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            
            string sqlQuery = $"update DoctorNotes set Diagnosis = '{DiagnosisNote.Text}', Symptoms = '{SimptomsNote.Text}' where AppointmentID = '{currentNoteAppointment}'";
            SqlCommand command = new SqlCommand(sqlQuery, connection.GetConnection());
            connection.OpenConnection();
            command.ExecuteNonQuery();
            DiagnosisNote.Enabled = false;
            SimptomsNote.Enabled = false;
            MessageBox.Show("Doctor Note Updated!", "Notes", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void SelectPatientPresc_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillSelectDate();
        }

        private void FillSelectDate()
        {
            SelectDatePresc.Items.Clear();
            string sqlQuery = $"select distinct Date from AdminJournalView " +
                    $"join Doctors on AdminJournalView.Doctor = Doctors.FIO " +
                    $"where Doctors.ID = '{doctorId}' and AdminJournalView.Patient = '{SelectPatientPresc.SelectedItem}'";
            SqlCommand command = new SqlCommand(sqlQuery, connection.GetConnection());
            connection.OpenConnection();

            SqlDataReader patientReader = command.ExecuteReader();
            while (patientReader.Read())
                SelectDatePresc.Items.Add(patientReader["Date"]);

            patientReader.Close();
        }

        private void SelectDatePresc_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sqlQuery = $"select AdminJournalView.ID as AppointmentID from AdminJournalView " +
                $"join Doctors on Doctors.FIO = Doctor " +
                $"where Date = '{SelectDatePresc.SelectedItem}' and Patient = '{SelectPatientPresc.SelectedItem}' and Doctors.ID = '{doctorId}'";
            SqlCommand command = new SqlCommand(sqlQuery, connection.GetConnection());
            connection.OpenConnection();

            SqlDataReader patientReader = command.ExecuteReader();
            long id = -1;
            if (patientReader.Read())
                id = (long)patientReader["AppointmentID"];

            patientReader.Close();
            currentPrescriptionAppointment = id;
            FillPrescriptionItems();
        }

        private void FillPrescriptionItems()
        {
            string sqlQuery = $"SELECT Medicine, ID, Diagnosis from DoctorPrescriptionsView where ID = '{currentPrescriptionAppointment}'";
            dPrescriptionAdapter = new SqlDataAdapter(sqlQuery, connection.GetConnection());
            dPrescriptionSet.Clear();
            dPrescriptionAdapter.Fill(dPrescriptionSet, "DoctorPrescriptionView");
            dPrescriptionTable = dPrescriptionSet.Tables["DoctorPrescriptionView"];

            if (dPrescriptionTable.Rows.Count > 0)
            {
                ShowPrescriptionRow();
            }
        }
        private void ShowPrescriptionRow()
        {
            dPrescriptionRow = dPrescriptionTable.Rows[iPrescriptionRowID];

            PrescDiagnosis.Text = dPrescriptionRow["Diagnosis"].ToString();
            PrescMedicine.Text = dPrescriptionRow["Medicine"].ToString();
        }

        private void PrevPresc_Click(object sender, EventArgs e)
        {
            if (iPrescriptionRowID > 0)
            {
                iPrescriptionRowID--;
                ShowPrescriptionRow();
            }
        }

        private void NextPresc_Click(object sender, EventArgs e)
        {
            if (iPrescriptionRowID < dPrescriptionSet.Tables["DoctorPrescriptionView"].Rows.Count - 1)
            {
                iPrescriptionRowID++;
                ShowPrescriptionRow();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            PrescMedicine.Enabled = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string sqlQuery = $"select PharmacyProducts.ID as ID from PharmacyProducts " +
                $"join Medicines on Medicines.ID = PharmacyProducts.MedicineID " +
                $"where Medicines.Name = '{PrescMedicine.Text}'";
            SqlCommand command = new SqlCommand(sqlQuery, connection.GetConnection());
            connection.OpenConnection();

            SqlDataReader patientReader = command.ExecuteReader();
            long id = -1;
            if (patientReader.Read())
                id = (long)patientReader["ID"];

            patientReader.Close();

            sqlQuery = $"insert into Prescriptions (PharmacyProductID, AppointmentID) values ('{id}', '{currentPrescriptionAppointment}')";
            command.CommandText = sqlQuery;
            connection.OpenConnection();
            command.ExecuteNonQuery();
            MessageBox.Show("Prescriptions Updated!", "Prescriptions", MessageBoxButtons.OK, MessageBoxIcon.Information);
            PrescMedicine.Enabled = false;
        }

        private void reloadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FillAppointments();

            FillNotes(null);
            FillSelectPatient();

            FillPatientPresc();
            FillPrescMedicine();
        }
    }
}
