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

namespace Health_Care_Plus_System.Screen_Forms.Medication
{
    public partial class AddPrescription : Form
    {
        //initialize class
        PrescriptionClass prescriptionClass = new PrescriptionClass();


        private DataTable patientsTable;

        // Store the selected patient's ID
        private int selectedPatID = -1;

        public AddPrescription()
        {
            InitializeComponent();
        }

        private void MedicalTextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddPrescription_Load(object sender, EventArgs e)
        {
            GetPatientAndDoctor(); //Called the method
        }


        // Patient and Doctor Load Record Method
        private void GetPatientAndDoctor()
        {
            patientsTable = prescriptionClass.GetPatientAndDoctor();

            //DataTable to display patient column names
            DataTable filteredPatientsTable = new DataTable();
            filteredPatientsTable.Columns.Add("PatID", typeof(int));
            filteredPatientsTable.Columns.Add("PatientName", typeof(string));
            filteredPatientsTable.Columns.Add("DoctorName", typeof(string));

            foreach (DataRow row in patientsTable.Rows)
            {
                filteredPatientsTable.Rows.Add(row["PatID"], row["PatientName"], row["DoctorName"]);
            }

            PatientDataTable.DataSource = filteredPatientsTable;
        }






        private void SearchTextBox_TextChanged(object sender, EventArgs e)
        {
            // In this function, search for patient names and IDs in the record list
            string searchPatient = PatientSearchTextBox.Text.Trim();

            DataView dv = new DataView(patientsTable);
            dv.RowFilter = $"PatientName LIKE '%{searchPatient}%'";

            PatientDataTable.DataSource = dv;
        }






        private void PatientDataTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Check if a medication row is selected
            if (e.RowIndex >= 0 && e.RowIndex < PatientDataTable.Rows.Count - 1)
            {
                DataGridViewRow selectedRow = PatientDataTable.Rows[e.RowIndex];

                // Get the patient ID from the selected row
                selectedPatID = Convert.ToInt32(selectedRow.Cells["PatID"].Value);
                string PatientName = selectedRow.Cells["PatientName"].Value.ToString();
                string DoctorName = selectedRow.Cells["DoctorName"].Value.ToString();


                DoctorNameTextBox1.Text = DoctorName;
                PatientNameTextBox.Text = PatientName;
            }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidateInput())
                {
                    PrescriptionClass prescriptionClass = new PrescriptionClass()
                    {
                        PatID = selectedPatID,
                        MedicationName = MedicationNameTextBox.Text.Trim(),
                        Dosage = DosageTextBox.Text.Trim(),
                        Frequently = FrequentlyComboBox.Text.Trim(),
                        StartDate = StartDatePicker.Value,
                        EndDate = EndDatePicker.Value, 
                        Instruction = InstructionComboBox1.Text.Trim(),
                        Prescriped_Doctor = DoctorNameTextBox1.Text.Trim(),
                    };

                    // Call the AddPrescription method to add the prescription record to the database
                    bool success = prescriptionClass.AddPrescription();

                    if (success)
                    {
                        MessageBox.Show("Prescription added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Clear the input fields after successful addition
                        ClearInputFields();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Failed to add prescription. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }



                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred in Add Medication Record: " + ex.Message);
            }
        }

        private void ClearInputFields()
        {
            MedicationNameTextBox.Clear();
            DosageTextBox.Clear();
            FrequentlyComboBox.SelectedIndex = -1;
            StartDatePicker.Value = DateTime.Now;
            EndDatePicker.Value = DateTime.Now;
            InstructionComboBox1.SelectedIndex = -1;
            DoctorNameTextBox1.Clear();
        }





        // Validate user input fields in form method
        private bool ValidateInput()
        {
            if (
                string.IsNullOrWhiteSpace(PatientNameTextBox.Text) ||
                string.IsNullOrWhiteSpace(MedicationNameTextBox.Text) ||
                string.IsNullOrWhiteSpace(DosageTextBox.Text) ||
                string.IsNullOrWhiteSpace(FrequentlyComboBox.Text) ||
                string.IsNullOrWhiteSpace(StartDatePicker.Text) ||
                string.IsNullOrWhiteSpace(InstructionComboBox1.Text) ||
                string.IsNullOrWhiteSpace(DoctorNameTextBox1.Text) 
                )
            {
                MessageBox.Show("Please fill in all required fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true; // If all validations passed
        }

    }
}
