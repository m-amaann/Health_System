using Health_Care_Plus_System.Classes;
using System;
using System.Data;
using System.Windows.Forms;

namespace Health_Care_Plus_System.Screen_Forms.Appointment
{
    public partial class UpdateAppointment : Form
    {
        private string connectionString = Properties.Settings.Default.DBConnectionString;
        private int appointmentID;
        private AppointmentClass appointmentClass;
        private DataTable doctorsTable;
        private DataTable patientsTable;

        public UpdateAppointment(int appointmentID)
        {
            InitializeComponent();
            this.appointmentID = appointmentID;
            appointmentClass = new AppointmentClass();
        }

        private void LoadAppointmentRecord()
        {
            AppointmentClass appointment = AppointmentClass.GetAppointmentByID(appointmentID);

            if (appointment != null)
            {
                SpecializationComboBox2.SelectedItem = appointment.Specialization;
                DoctorNameText.Text = appointment.DoctorName;
                PatientTextBox1.Text = appointment.PatientName;
                AppointmentDateTimePicker.Value = appointment.Appoint_Date;
                AvalableTimeComboBox.Text = appointment.Appoint_Time;
                NoteTextbox.Text = appointment.Note;
                SenderNameComboBox.Text = appointment.Sender_Name;
                hospitalChargeTextBox.Text = appointment.HospitalCharge;
                DoctorChargeTextBox.Text = appointment.DoctorCharge;
                TotalTextBox.Text = appointment.TotalFee;
            }
            else
            {
                MessageBox.Show("Appointment not found or an error occurred.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        private void Updatebutton_Click(object sender, EventArgs e)
        {
            AppointmentClass updatedAppointment = new AppointmentClass()
            {
                Appointment_ID = appointmentID,
                Specialization = SpecializationComboBox2.Text,
                DoctorName = DoctorNameText.Text,
                PatientName = PatientTextBox1.Text,
                Appoint_Date = AppointmentDateTimePicker.Value,
                Appoint_Time = AvalableTimeComboBox.Text,
                Note = NoteTextbox.Text,
                HospitalCharge = hospitalChargeTextBox.Text,
                Sender_Name = SenderNameComboBox.Text,
                DoctorCharge = DoctorChargeTextBox.Text,
                TotalFee = TotalTextBox.Text
            };

            if (updatedAppointment.UpdateAppointmentRecord())
            {
                MessageBox.Show("Appointment Record Updated Successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Error occurred while updating appointment record.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateAppointment_Load(object sender, EventArgs e)
        {
            LoadAppointmentRecord();
            LoadDoctors();
            LoadPatients();
            LoadSpecializationComboBox();
        }

        private void LoadDoctors()
        {
            doctorsTable = appointmentClass.GetDoctors();
            DisplayDoctorsInDataGridView();
        }

        private void LoadPatients()
        {
            patientsTable = appointmentClass.GetPatients();
            DisplayPatientsInDataGridView();
        }

        private void LoadSpecializationComboBox()
        {
            SpecializationComboBox2.Items.Clear();

            foreach (DataRow row in doctorsTable.Rows)
            {
                string specialization = row["Specialization"].ToString();
                if (!SpecializationComboBox2.Items.Contains(specialization))
                {
                    SpecializationComboBox2.Items.Add(specialization);
                }
            }

            SpecializationComboBox2.SelectedIndex = 0;
        }

        private void DisplayDoctorsInDataGridView()
        {
            DoctorDataGrideView.DataSource = doctorsTable;
        }

        private void DisplayPatientsInDataGridView()
        {
            PatientDataGrideView.DataSource = patientsTable;
        }

        private void DoctorDataGrideView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < DoctorDataGrideView.Rows.Count)
            {
                DataGridViewRow selectedRow = DoctorDataGrideView.Rows[e.RowIndex];
                string doctorspecialization = selectedRow.Cells["Specialization"].Value.ToString();
                string doctorName = selectedRow.Cells["FullName"].Value.ToString();

                DoctorNameText.Text = doctorName;

                int specializationIndex = SpecializationComboBox2.FindStringExact(doctorspecialization);
                if (specializationIndex >= 0)
                {
                    SpecializationComboBox2.SelectedIndex = specializationIndex;
                }
            }
        }

        private void PatientDataGrideView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < PatientDataGrideView.Rows.Count - 1)
            {
                DataGridViewRow selectedRow = PatientDataGrideView.Rows[e.RowIndex];
                string patientName = selectedRow.Cells["FullName"].Value.ToString();
                PatientTextBox1.Text = patientName;
            }
        }

        private void SpecializationComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedSpecialization = SpecializationComboBox2.Text;
            if (selectedSpecialization == "All")
            {
                DoctorDataGrideView.DataSource = doctorsTable;
            }
            else
            {
                DataView dv = new DataView(doctorsTable);
                dv.RowFilter = $"Specialization = '{selectedSpecialization}'";
                DoctorDataGrideView.DataSource = dv;
            }
        }
    }
}
