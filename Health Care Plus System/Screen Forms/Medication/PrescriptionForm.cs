using Health_Care_Plus_System.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Health_Care_Plus_System.Screen_Forms.Medication
{
    public partial class PrescriptionForm : Form
    {
        private string connectionString = Properties.Settings.Default.DBConnectionString; // connecting DB string statement



        PrescriptionClass prescriptionClass = new PrescriptionClass();
        public PrescriptionForm()
        {
            InitializeComponent();
        }


        private void Addbutton_Click(object sender, EventArgs e)
        {
            AddPrescription addPrescription = new AddPrescription();
            addPrescription.ShowDialog();
            LoadPrescriptionRecord();


        }

        private void SearchTextBox_TextChanged(object sender, EventArgs e)
        {
            string searchQuery = SearchTextBox.Text.Trim();
            DataTable dataTable = prescriptionClass.SearchPrescription(searchQuery);

            if (dataTable != null)
            {
                PrescriptionDataGridview.DataSource = dataTable;
            }
        }




        private void PrescriptionForm_Load(object sender, EventArgs e)
        {
            LoadPrescriptionRecord();
        }


        private void LoadPrescriptionRecord()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT * FROM Prescription"; // Prescription name is DB table


                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);

                    PrescriptionDataGridview.DataSource = dataTable; // PrescriptionDataGridview is name of Table 
                }
            }
        }

        private void Updatebutton_Click(object sender, EventArgs e)
        {
            // Check if a prescription is selected
            if (PrescriptionDataGridview.SelectedRows.Count > 0)
            {
                // Get the selected MedicationID from the Table
                int medicationID = Convert.ToInt32(PrescriptionDataGridview.SelectedRows[0].Cells["MedicationID"].Value);

                UpdatePrescription updatePrescription = new UpdatePrescription(medicationID);
                updatePrescription.ShowDialog();
            }
            else
            {
                MessageBox.Show("Please select a prescription to update.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (PrescriptionDataGridview.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show("Are you sure you want to delete this medication record?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    int rowIndex = PrescriptionDataGridview.SelectedRows[0].Index;
                    int prescriptionID = Convert.ToInt32(PrescriptionDataGridview.Rows[rowIndex].Cells["MedicationID"].Value);

                    PrescriptionClass prescriptionClass = new PrescriptionClass { MedicationID = prescriptionID };

                    if (prescriptionClass.DeletePrescriptionecord())
                    {
                        MessageBox.Show("Appointment record deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadPrescriptionRecord(); // Refresh the appointment records after deletion
                    }
                    else
                    {
                        MessageBox.Show("Failed to delete appointment record.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select an appointment record to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}




