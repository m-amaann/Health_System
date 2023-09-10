using Health_Care_Plus_System.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Health_Care_Plus_System.Screen_Forms.Appointment
{
    public partial class AddAppointment : Form
    {
        //initialize instance class
        private AppointmentClass AppointmentClass = new AppointmentClass();

        //initialize instance variable
        private DataTable patientsTable;
        private DataTable doctorsTable;




        public AddAppointment()
        {
            InitializeComponent();
        }



        private void AddAppointment_Load(object sender, EventArgs e)
        {
            LoadDoctors();
            LoadPatients();     
        }




        private void LoadDoctors()
        {
            doctorsTable = AppointmentClass.GetDoctors();
            DataTable filteredDoctorsTable = new DataTable();
            filteredDoctorsTable.Columns.Add("Specialization", typeof(string));
            filteredDoctorsTable.Columns.Add("FullName", typeof(string));
            filteredDoctorsTable.Columns.Add("AvailabilityDay", typeof(string));
            filteredDoctorsTable.Columns.Add("AvailabilityTime", typeof(string));



            foreach (DataRow row in doctorsTable.Rows)
            {
                filteredDoctorsTable.Rows.Add( row["Specialization"], row["FullName"], row["AvailabilityDay"], row["AvailabilityTime"]);
            }

            DoctorDataGrideView.DataSource = filteredDoctorsTable;

            SpecializationComboBox2.Items.Clear();
            SpecializationComboBox2.Items.Add("All"); // Add "All" option
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


        private void LoadPatients()
        {
            patientsTable = AppointmentClass.GetPatients();

            //DataTable to display patient column names
            DataTable filteredPatientsTable = new DataTable();
            filteredPatientsTable.Columns.Add("FullName", typeof(string));
            filteredPatientsTable.Columns.Add("ContactNo", typeof(string));

            foreach (DataRow row in patientsTable.Rows)
            {
                filteredPatientsTable.Rows.Add( row["FullName"], row["ContactNo"]);
            }

            PatientDataGrideView.DataSource = filteredPatientsTable;
        }

 

        // Add Button Click Handle
        private void AddButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidateInput())
                {
                    AppointmentClass AppointmentClass = new AppointmentClass()
                    {
                        Specialization = SpecializationComboBox2.Text,
                        DoctorName = DoctorNameText.Text,
                        PatientName = PatientTextBox1.Text,
                        Appoint_Date = AppointmentDateTimePicker.Value,
                        Appoint_Time = AvalableTimeComboBox.Text,
                        Note = NoteTextbox.Text,
                        Sender_Name = SenderNameComboBox.Text
                    };

                    // Call the Method in Appointment Class
                    bool success = AppointmentClass.AddAppointment();

                    if (success)
                    {
                        MessageBox.Show("Make A Patient Appointment Successful.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Failed to add a appointment.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }




        // Validate user input fields in form
        private bool ValidateInput()
        {
            if (string.IsNullOrWhiteSpace(SpecializationComboBox2.Text) ||
                string.IsNullOrWhiteSpace(DoctorNameText.Text) ||
                string.IsNullOrWhiteSpace(PatientTextBox1.Text) ||
                string.IsNullOrWhiteSpace(AvalableTimeComboBox.Text) ||
                string.IsNullOrWhiteSpace(NoteTextbox.Text) ||
                string.IsNullOrWhiteSpace(SenderNameComboBox.Text))
            {
                MessageBox.Show("Please fill in all required fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true; // If all validations passed
        }



        private void SpecializationComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedSpecialization = SpecializationComboBox2.Text;
            if (selectedSpecialization == "All")
            {
                // Show all doctors
                DoctorDataGrideView.DataSource = doctorsTable;
            }
            else
            {
                // Filter doctors by selected specialization
                DataView dv = new DataView(doctorsTable);
                dv.RowFilter = $"Specialization = '{selectedSpecialization}'";
                DoctorDataGrideView.DataSource = dv;
            }
        }




        private void DoctorNameText_TextChanged(object sender, EventArgs e)
        {
            //In this function searching doctor names record list
            string searchTerm = DoctorNameText.Text.Trim();

            DataView dv = new DataView(doctorsTable);
            dv.RowFilter = $"FullName LIKE '%{searchTerm}%'";

            DoctorDataGrideView.DataSource = dv;
        }



        private void PatientTextBox1_TextChanged(object sender, EventArgs e)
        {
            //In this function searching patient names record list
            string searchPatient = PatientTextBox1.Text.Trim();

            DataView dv = new DataView(patientsTable);
            dv.RowFilter = $"FullName LIKE '%{searchPatient}%'";

            PatientDataGrideView.DataSource = dv;
        }




        private void DoctorDataGrideView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Check if a row is selected 
            if (e.RowIndex >= 0 && e.RowIndex < DoctorDataGrideView.Rows.Count - 1)
            {
                DataGridViewRow selectedRow = DoctorDataGrideView.Rows[e.RowIndex];

                //  the doctor name from the selected row
                string Specialization = selectedRow.Cells["Specialization"].Value.ToString();
                string DoctorName = selectedRow.Cells["FullName"].Value.ToString();

                SpecializationComboBox2.Text = Specialization;
                DoctorNameText.Text = DoctorName;
            }
        }




        private void PatientDataGrideView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Check if a patient row is selected 
            if (e.RowIndex >= 0 && e.RowIndex < PatientDataGrideView.Rows.Count - 1)
            {
                DataGridViewRow selectedRow = PatientDataGrideView.Rows[e.RowIndex];

                //  the patient name from the selected row
                string PatientName = selectedRow.Cells["FullName"].Value.ToString();

                PatientTextBox1.Text = PatientName;
            }
        }
    }
}
