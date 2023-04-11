using Medical_Clinic.General;
using Microsoft.Data.SqlClient;
using System.Collections.Generic;
using System;
using System.Data;
using System.Runtime.Intrinsics.Arm;
using System.Security.Policy;
using XAct.Library.Settings;
using XAct;

namespace Medical_Clinic.Patient
{
    public partial class ClinicForm : Form
    {
        private long patientId;
        private Connection connection;
        
        //Note Tab
        private SqlDataAdapter dNoteAdapter;
        private DataSet dNoteSet;
        private DataTable dNoteTable;
        private DataRow dNoteRow;
        private int iNoteRowID;
        private long noteAppointmentId;
        
        //Prescriptions Tab
        private SqlDataAdapter dPrescAdapter;
        private DataSet dPrescSet;
        private DataTable dPrescTable;
        private DataRow dPrescRow;
        private int iPrescRowID;
        private long prescAppointmentId;
        public ClinicForm(long patientId, Connection connection)
        {
            iNoteRowID = 0;
            InitializeComponent();

            this.connection = connection;
            this.patientId = patientId;

            this.noteAppointmentId = -1;

            this.ContextMenuStrip = PatientClinicReload;
        }
        private void ClinicForm_Load(object sender, EventArgs e)
        {
            FillPrescripton();

            FillNote();
        }
        private void ClinicForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            connection.CloseConnection();
        }

        //JOURNAL TAB
        //calendar reaction
        private void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {
            Doctor.Items.Clear();

            //store choose date
            string date = Journal.SelectionStart.ToShortDateString();
            Date.Text = date;

            //search if there is appointments on choosen date
            string sqlQuery = $"select Appointments.ID from Appointments join Doctor_Patient on Doctor_Patient.ID = Appointments.Doctor_PatientID " +
                $"where Appointments.Date = '{date}' and Doctor_Patient.PatientID = '{patientId}'";
            SqlCommand command = new SqlCommand(sqlQuery, connection.GetConnection());
            connection.OpenConnection();
            SqlDataReader sqlDataReader = command.ExecuteReader();
 
            if (sqlDataReader.HasRows)
            {
                sqlDataReader.Close();
                Service.Text = "";
                Status.Text = "";
                FillDoctorCombobox(date);
                Appointment.Visible = true;
            }
            else
            {
                sqlDataReader.Close();
                Appointment.Visible = false;
                MessageBox.Show("No appointments on this date", "No appointments!",
                     MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        } 
        //Cancel appointment button
        private void cancelButton_Click(object sender, EventArgs e)
        { 
            string doctorFio = (string)Doctor.SelectedItem; 

            string selectedDate = Journal.SelectionStart.ToShortDateString();
            long appointmentId = GetAppointmentId(selectedDate, doctorFio);

            string sqlQuery = "sp_SetCanceledStatus";
            SqlCommand command = new SqlCommand(sqlQuery, connection.GetConnection());
            command.CommandType = CommandType.StoredProcedure;
            SqlParameter id = new SqlParameter
            {
                ParameterName = "@AppointmentId",
                SqlDbType = SqlDbType.BigInt,
                Value = appointmentId
            };
            command.Parameters.Add(id);
            connection.OpenConnection();
            command.ExecuteNonQuery();

            Status.Text = "Canceled";

            DeleteNotes(appointmentId);

            //DeletePrescriptions(appointmentId);
        }
        //Make appointment button
        //private void MakeAppointment_Click(object sender, EventArgs e)
        //{
        //    string date = Journal.SelectionStart.ToShortDateString();
        //    AppointmentForm appointmentForm = new AppointmentForm(date, connection, patientId);
        //    appointmentForm.ShowDialog();
        //}
        //helpful
        private void FillDoctorCombobox(string selectedDate)
        {
            //search for doctor fio assotiated with certain patient and date in appointments
            string sqlQuery = "sp_ShowDoctorFIO";
            SqlCommand command = new SqlCommand(sqlQuery, connection.GetConnection());
            command.CommandType = CommandType.StoredProcedure;
            SqlParameter id = new SqlParameter
            {
                ParameterName = "@PatientId",
                SqlDbType = SqlDbType.BigInt,
                Value = patientId
            };
            SqlParameter date = new SqlParameter
            {
                ParameterName = "@Date",
                SqlDbType = SqlDbType.Date,
                Value = selectedDate
            };
            command.Parameters.Add(id);
            command.Parameters.Add(date);
            connection.OpenConnection();

            SqlDataReader fioReader = command.ExecuteReader();
            Doctor.Items.Clear();
            while (fioReader.Read())
                Doctor.Items.Add(fioReader["FIO"]);

            fioReader.Close();
        }

        //helpful
        private long GetAppointmentId(string selectedDate, string doctorFio)
        {
            string sqlQuery = "sp_ShowAppointmentId";
            SqlCommand command = new SqlCommand(sqlQuery, connection.GetConnection());
            command.CommandType = CommandType.StoredProcedure;
            SqlParameter id = new SqlParameter
            {
                ParameterName = "@PatientId",
                SqlDbType = SqlDbType.BigInt,
                Value = patientId
            };
            SqlParameter date = new SqlParameter
            {
                ParameterName = "@Date",
                SqlDbType = SqlDbType.Date,
                Value = selectedDate
            };
            SqlParameter fio = new SqlParameter
            {
                ParameterName = "@DoctorFIO",
                SqlDbType = SqlDbType.VarChar,
                Size = 100,
                Value = doctorFio
            };
            command.Parameters.Add(id);
            command.Parameters.Add(date);
            command.Parameters.Add(fio);
            connection.OpenConnection();

            SqlDataReader appointmentIdReader = command.ExecuteReader();
           
            long appointmentId = -1;
            if (appointmentIdReader.Read())
            {
                appointmentId = Convert.ToInt64(appointmentIdReader["ID"]);

            }
            appointmentIdReader.Close();
            return appointmentId;
        }


        //helpful; to delete doctor and patient notes for canceled appointment
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
        //private void DeletePrescriptions(long appointmentId)
        //{
        //    string sqlQuery = $"DELETE FROM Prescriptions WHERE AppointmentId = '{appointmentId}';";
        //    SqlCommand command = new SqlCommand(sqlQuery, connection.GetConnection());
        //    connection.OpenConnection();
        //    command.ExecuteNonQuery();
        //}
        //helpful;to change info in appointment due to doctor
        private void Doctor_SelectedIndexChanged(object sender, EventArgs e)
        {
            //set value to combobox
            string selectedDoctor = (string)Doctor.SelectedItem;
   
            string selectedDate = Journal.SelectionStart.ToShortDateString();
            long appointmentId = GetAppointmentId(selectedDate, selectedDoctor);

            string sqlQuery = "sp_ShowAppointmentServiceInfo";
            SqlCommand command = new SqlCommand(sqlQuery, connection.GetConnection());
            command.CommandType = CommandType.StoredProcedure;
            SqlParameter id = new SqlParameter
            {
                ParameterName = "@AppointmentId",
                SqlDbType = SqlDbType.BigInt,
                Value = appointmentId
            };
            command.Parameters.Add(id);
            connection.OpenConnection();

            SqlDataReader appointmentInfoReader = command.ExecuteReader();
            if (appointmentInfoReader.Read())
            {
                Service.Text = appointmentInfoReader["ServiceName"].ToString();

            }
            appointmentInfoReader.Close();

            command.CommandText = "sp_ShowAppointmentStatusInfo";
            appointmentInfoReader = command.ExecuteReader();
            if (appointmentInfoReader.Read())
            {
                Status.Text = appointmentInfoReader["StatusName"].ToString();

            }

            appointmentInfoReader.Close();
        }
        //NOTE TAB
        //Previous button
        private void prevButton_Click(object sender, EventArgs e)
        {
            if (iNoteRowID > 0)
            {
                iNoteRowID--;
                ShowNoteRow();
            }
        }
        //Next button
        private void nextButton_Click(object sender, EventArgs e)
        {
            if (iNoteRowID < dNoteSet.Tables["NoteView"].Rows.Count - 1)
            {
                iNoteRowID++;
                ShowNoteRow();
            }
        } 
        private void editButton_Click(object sender, EventArgs e)
        {
            Note.Enabled = true;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            string slqQuery = $"UPDATE PatientNotes SET Note = '{Note.Text}' WHERE AppointmentID = '{noteAppointmentId}'";
            SqlCommand command = new SqlCommand(slqQuery, connection.GetConnection());
            connection.OpenConnection();
            command.ExecuteNonQuery();
            Note.Enabled = false;
        }
        //helpful; to fill textfields of note
        private void ShowNoteRow()
        {
            dNoteRow = dNoteTable.Rows[iNoteRowID];

            Note.Text = dNoteRow["Note"].ToString();
            NoteDate.Text = dNoteRow["Date"].ToString();
            long doctorId = (long)dNoteRow["DoctorID"];
            long appointmentId = (long)dNoteRow["AppointmentID"];
            this.noteAppointmentId = appointmentId;
            SetDoctorFIO(doctorId);
            SetServiceName(appointmentId);
        }
        //helpful;
        private void SetDoctorFIO(long doctorId)
        {
            string sqlQuery = $"select FIO from Doctors where ID = '{doctorId}'";
            SqlCommand command = new SqlCommand(sqlQuery, connection.GetConnection());
            connection.OpenConnection();

            SqlDataReader doctorReader = command.ExecuteReader();
            if (doctorReader.Read())
                NoteDoctor.Text = doctorReader["FIO"].ToString();

            doctorReader.Close();
        }
        //helpful;
        private void SetServiceName(long appointmentId)
        {
            string sqlQuery = $"select Name from Services where Services.ID in (select ServiceID from Journal where Journal.AppoitmentID = '{appointmentId}')";
            SqlCommand command = new SqlCommand(sqlQuery, connection.GetConnection());
            connection.OpenConnection();

            SqlDataReader serviceReader = command.ExecuteReader();
            if (serviceReader.Read())
                NoteService.Text = serviceReader["Name"].ToString();

            serviceReader.Close();
        }

        private void FillNote()
        {
            String strSQL = $"select PatientId, Date, DoctorID, AppointmentID, Note from NoteView where PatientId = '{patientId}';";
            dNoteAdapter = new SqlDataAdapter(strSQL, connection.GetConnection());
            dNoteSet = new DataSet();
            dNoteAdapter.Fill(dNoteSet, "NoteView");
            dNoteTable = dNoteSet.Tables["NoteView"];

            if (dNoteTable.Rows.Count > 0)
            {
                ShowNoteRow();
            }
        }

        //PRESCRIPTION TAB
        private void FillPrescripton()
        {
            String strSQL = $"select AppointmentID from AppointmentsView where PatientId = '{patientId}';";
            dPrescAdapter = new SqlDataAdapter(strSQL, connection.GetConnection());
            dPrescSet = new DataSet();
            dPrescAdapter.Fill(dPrescSet, "AppointmentsView");
            dPrescTable = dPrescSet.Tables["AppointmentsView"];

            if (dPrescTable.Rows.Count > 0)
            {
                ShowPrescRow();
            }
        }
        private void ShowPrescRow()
        {
            dPrescRow = dPrescTable.Rows[iPrescRowID];
            prescAppointmentId = (long)dPrescRow["AppointmentID"];

            //see if prescription existis
            string sqlQuery = $"select ID from Prescriptions where AppointmentID = '{prescAppointmentId}'";
            SqlCommand command = new SqlCommand(sqlQuery, connection.GetConnection());
            connection.OpenConnection();

            SqlDataReader idReader = command.ExecuteReader();
            if (!idReader.Read())
            {
                idReader.Close();
                return;
            }
            idReader.Close();
            sqlQuery = $"select Price, Amount, Medicines.Name as Name, Vendors.Name as Vendor from PharmacyProducts " +
                $"join Prescriptions on Prescriptions.PharmacyProductID = PharmacyProducts.ID " +
                $"join Medicines on Medicines.ID = MedicineID join Vendors on Vendors.ID = VendorID where AppointmentID = '{prescAppointmentId}'";
            command.CommandText = sqlQuery;
            connection.OpenConnection();

            SqlDataReader prescriptionReader = command.ExecuteReader();
            if (prescriptionReader.Read())
            {
                Medicine.Text = prescriptionReader["Name"].ToString();
                Price.Text = Convert.ToDouble(prescriptionReader["Price"]).ToString("#.##");
                Left.Text = prescriptionReader["Amount"].ToString();
                Vendor.Text = prescriptionReader["Vendor"].ToString();
            }
            prescriptionReader.Close();

            sqlQuery = $"select Date from Appointments where Appointments.ID = '{prescAppointmentId}'";
            command.CommandText = sqlQuery;
            connection.OpenConnection();

            SqlDataReader dateReader = command.ExecuteReader();
            if (dateReader.Read())
            {
                PrescriptionDate.Text = dateReader["Date"].ToString();
            }
            dateReader.Close();


            sqlQuery = $"select Diagnosis from DoctorNotes where AppointmentID = '{prescAppointmentId}'";
            command.CommandText = sqlQuery;
            connection.OpenConnection();

            SqlDataReader diagnosisReader = command.ExecuteReader();
            if (diagnosisReader.Read())
            {
                Diagnosis.Text = diagnosisReader["Diagnosis"].ToString();
            }
            diagnosisReader.Close(); 
            
            sqlQuery = $"select FIO from Doctors where Doctors.ID in (select Doctor_Patient.DoctorID from Appointments join Doctor_Patient on Doctor_Patient.ID = Doctor_PatientID where Appointments.ID = '{prescAppointmentId}')";
            command.CommandText = sqlQuery;
            connection.OpenConnection();

            SqlDataReader doctorReader = command.ExecuteReader();
            if (doctorReader.Read())
            {
                PrescriptionDoctor.Text = doctorReader["FIO"].ToString();
            }
            doctorReader.Close();
        }

        private void nextPrescriptionButton_Click(object sender, EventArgs e)
        {
            if (iPrescRowID < dPrescSet.Tables["AppointmentsView"].Rows.Count - 1)
            {
                iPrescRowID++;
                ShowPrescRow();
            }
        }

        private void prevPrescriptionButton_Click(object sender, EventArgs e)
        {
            if (iPrescRowID > 0)
            {
                iPrescRowID--;
                ShowPrescRow();
            }
        }

        //add to order button
        private void button3_Click(object sender, EventArgs e)
        {
            //search for existing order
            string sqlQuery = $"select ID from Orders where Orders.PatientID = '{patientId}' and Orders.StatusID = 1";
            SqlCommand command = new SqlCommand(sqlQuery, connection.GetConnection());
            connection.OpenConnection();

            SqlDataReader orderReader = command.ExecuteReader();
            long orderId = -1;
            if (orderReader.Read())
            {
                orderId = (long)orderReader["ID"];
                orderReader.Close();
            }
            else
            {
                orderReader.Close();
                sqlQuery = $"insert into Orders (PatientID, StatusID, Date) values ('{patientId}', 1, GETDATE());" +
                    $"SET @id=SCOPE_IDENTITY()";
                command.CommandText = sqlQuery;
                SqlParameter orderIdParameter = new SqlParameter
                {
                    ParameterName = "@id",
                    SqlDbType = SqlDbType.BigInt,
                    Direction = ParameterDirection.Output
                };
                command.Parameters.Add(orderIdParameter);
                command.ExecuteNonQuery();
                orderId = (long)orderIdParameter.Value;
            }

            if(Left.Text.Equals(0))
            {
                MessageBox.Show("No Medicine left!", "No Medicine", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                AddToOrder(orderId);
                MessageBox.Show("Added to Order!", "Added", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void AddToOrder(long orderId)
        {
            //search for pharmacy product
            string sqlQuery = $"select PharmacyProductID from Prescriptions where AppointmentID = '{prescAppointmentId}'";
            SqlCommand command = new SqlCommand(sqlQuery, connection.GetConnection());
            connection.OpenConnection();

            SqlDataReader prescriptionReader = command.ExecuteReader();
            long prescriptionId = -1;
            if (prescriptionReader.Read())
            {
                prescriptionId = (long)prescriptionReader["PharmacyProductID"];
            }
            prescriptionReader.Close();
            //create new order item 
            sqlQuery = $"insert into OrderItems (PharmacyProductID, OrderID, Quantity) values ('{prescriptionId}', '{orderId}', 1)";
            command.CommandText = sqlQuery;
            connection.OpenConnection();
            command.ExecuteNonQuery();

            //reduce amount in pharmacy products
            sqlQuery = $"UPDATE PharmacyProducts SET Amount = Amount - 1 WHERE ID = '{prescriptionId}';";
            command.CommandText = sqlQuery;
            connection.OpenConnection();
            command.ExecuteNonQuery();
        }

        private void MakeAppointmentButton_Click(object sender, EventArgs e)
        {
            string date = Journal.SelectionStart.ToShortDateString();
            AppointmentForm appointmentForm = new AppointmentForm(date, connection, patientId);
            appointmentForm.ShowDialog();
        }

        private void reloadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FillPrescripton();

            FillNote();
        }

        private void toOrderbutton_Click(object sender, EventArgs e)
        {
            PharmacyForm pharmacy = new PharmacyForm(patientId, this.connection);
            pharmacy.ShowDialog();
        }
    }
}
