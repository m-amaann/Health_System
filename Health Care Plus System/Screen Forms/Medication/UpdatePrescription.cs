using Health_Care_Plus_System.Classes;
using Health_Care_Plus_System.Screen_Forms.Appointment;
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
    public partial class UpdatePrescription : Form
    {
        private string connectionString = Properties.Settings.Default.DBConnectionString;


        //initialize class
        PrescriptionClass prescriptionClass = new PrescriptionClass();

        private int prescriptionID;

        private DataTable patientsTable;

        // Store the selected patient's ID
        private int selectedPatID = -1;



        public UpdatePrescription(int prescriptionID)
        {
            InitializeComponent();
            this.prescriptionID = prescriptionID;
            prescriptionClass = new PrescriptionClass();
        }

        private void UpdatePrescription_Load(object sender, EventArgs e)
        {
            GetPatientAndDoctor();   //Called the method

            LoadPrescriptionRecord();
        }



        private void LoadPrescriptionRecord()
        {
            PrescriptionClass prescription = prescriptionClass.GetPrescriptionByID(prescriptionID);

            if (prescription != null)
            {
                // Set the text of the PatientNameTextBox to the patient's name
                PatientNameTextBox.Text = GetPatientNameById(prescription.PatID);

                MedicationNameTextBox.Text = prescription.MedicationName;
                DosageTextBox.Text = prescription.Dosage;
                FrequentlyComboBox.Text = prescription.Frequently;
                StartDatePicker.Value = prescription.StartDate;
                EndDatePicker.Value = prescription.EndDate;
                InstructionComboBox1.Text = prescription.Instruction;
                DoctorNameTextBox1.Text = prescription.Prescriped_Doctor;
            }
            else
            {
                MessageBox.Show("Medication not found or an error occurred.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }


        // Helper method to get patient name by ID
        private string GetPatientNameById(int PatID)
        {
            foreach (DataRow row in patientsTable.Rows)
            {
                int id = Convert.ToInt32(row["PatID"]);
                if (id == PatID)
                {
                    return row["PatID"].ToString();
                }
            }
            return string.Empty; // Return an empty string if no match found
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






        private void PatientSearchTextBox_TextChanged(object sender, EventArgs e)
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

        private void Updatebutton_Click(object sender, EventArgs e)
        {
            try
            {
                int selectedPatientID = selectedPatID;
                PrescriptionClass prescriptionToUpdate = new PrescriptionClass()
                {
                    PatID = selectedPatientID, // Include the PatID here
                    MedicationID = prescriptionID,
                    MedicationName = MedicationNameTextBox.Text,
                    Dosage = DosageTextBox.Text,
                    Frequently = FrequentlyComboBox.Text,
                    StartDate = StartDatePicker.Value,
                    EndDate = EndDatePicker.Value,
                    Instruction = InstructionComboBox1.Text,
                    Prescriped_Doctor = DoctorNameTextBox1.Text
                };

                if (prescriptionToUpdate.UpdatePrescription())
                {
                    MessageBox.Show("Prescription Record Updated Successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Failed to update prescription record. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while updating prescription record: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
