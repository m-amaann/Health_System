using Health_Care_Plus_System.Classes;
using System;
using System.Data;
using System.Windows.Forms;

namespace Health_Care_Plus_System.Screen_Forms.Appointment
{
    public partial class UpdateAppointment : Form
    {
        private int appointmentID;
        private int selectedPatientID; // Added
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
            try
            {
                AppointmentClass appointment = AppointmentClass.GetAppointmentByID(appointmentID);

                if (appointment != null)
                {
                    // Populate form fields with appointment data
                    SpecializationComboBox2.Text = appointment.Specialization;
                    DoctorNameText.Text = appointment.DoctorName;
                    selectedPatientID = appointment.PatID;
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
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while loading appointment record: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }


       





        private void Updatebutton_Click(object sender, EventArgs e)
        {
            try
            {
                // Validate input data before updating
                if (ValidateInput())
                {
                    AppointmentClass updatedAppointment = new AppointmentClass()
                    {
                        Appointment_ID = appointmentID,
                        Specialization = SpecializationComboBox2.Text,
                        DoctorName = DoctorNameText.Text,
                        PatID = selectedPatientID, // Use the selectedPatientID as PatID
                        PatientName = PatientTextBox1.Text,
                        Appoint_Date = AppointmentDateTimePicker.Value,
                        Appoint_Time = AvalableTimeComboBox.Text,
                        Note = NoteTextbox.Text,
                        Sender_Name = SenderNameComboBox.Text,
                        HospitalCharge = hospitalChargeTextBox.Text,
                        DoctorCharge = DoctorChargeTextBox.Text,
                        TotalFee = TotalTextBox.Text,
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
                else
                {
                    MessageBox.Show("Invalid input data. Please check your entries.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }





        // Check N validate the input fields
        private bool ValidateInput()
        {
            // Check if Specialization is selected
            if (string.IsNullOrEmpty(SpecializationComboBox2.Text))
            {
                MessageBox.Show("Please select a specialization.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // Check if Doctor Name is entered
            if (string.IsNullOrEmpty(DoctorNameText.Text))
            {
                MessageBox.Show("Please enter the doctor's name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }        

            // Check if Patient Name is entered
            if (string.IsNullOrEmpty(PatientTextBox1.Text))
            {
                MessageBox.Show("Please enter the patient's name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
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

        private void DoctorgroupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
