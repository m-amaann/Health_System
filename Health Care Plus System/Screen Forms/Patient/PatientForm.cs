using Guna.UI2.WinForms;
using Health_Care_Plus_System.Classes;
using Health_Care_Plus_System.Screen_Forms.EMR;
using Health_Care_Plus_System.Screen_Forms.Patient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Security;
using System.Windows.Forms;

namespace Health_Care_Plus_System.Screen_Forms
{

    public partial class PatientForm : Form
    {
        private string connectionString = (Properties.Settings.Default.DBConnectionString);
        private PatientClass patientManager;



        public PatientForm()
        {
            InitializeComponent();

            patientManager = new PatientClass(connectionString);

            LoadPatientRecords();
        }


        private void PatientForm_Load(object sender, EventArgs e)
        {

        }




        private void LoadPatientRecords()
        {
            DataTable dataTable = patientManager.GetPatients();
            DataGridView1.DataSource = dataTable;
        }




        private void Addbutton_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddPatient addPatient = new AddPatient();
            addPatient.ShowDialog();

            LoadPatientRecords();


        }

        private void Updatebutton_Click_1(object sender, EventArgs e)
        {
            if (DataGridView1.SelectedRows.Count > 0)
            {
                try
                {
                    int rowIndex = DataGridView1.SelectedRows[0].Index;
                    int patID = Convert.ToInt32(DataGridView1.Rows[rowIndex].Cells["PatID"].Value);

                    this.Hide();
                    UpdatePatient updatePatient = new UpdatePatient(patID);
                    updatePatient.ShowDialog();
                    LoadPatientRecords();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while updating patient record: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please select a row to update.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void UpdatePatient_FormClosed(object sender, FormClosedEventArgs e)
        {
            LoadPatientRecords();
            this.Show();
        }


        private void SearchTextBox_TextChanged(object sender, EventArgs e)
        {
            string searchQuery = SearchTextBox.Text.Trim();
            DataTable dataTable = patientManager.SearchPatients(searchQuery);
            DataGridView1.DataSource = dataTable;

        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }



        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (DataGridView1.SelectedRows.Count > 0)
            {
                try
                {
                    int rowIndex = DataGridView1.SelectedRows[0].Index;
                    int patID = Convert.ToInt32(DataGridView1.Rows[rowIndex].Cells["PatID"].Value);

                    DialogResult result = MessageBox.Show("Are you sure you want to delete this record?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (result == DialogResult.Yes)
                    {
                        if (patientManager.DeletePatient(patID))
                        {
                            MessageBox.Show("Record deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadPatientRecords();
                        }
                        else
                        {
                            MessageBox.Show("Failed to delete record.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while deleting patient record: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please select a row to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PatientProfileBtn_Click(object sender, EventArgs e)
        {
            if (DataGridView1.SelectedRows.Count > 0)
            {
                try
                {
                    int rowIndex = DataGridView1.SelectedRows[0].Index;
                    int patID = Convert.ToInt32(DataGridView1.Rows[rowIndex].Cells["PatID"].Value);


                    PatientProfile patientProfile = new PatientProfile(patID);
                    patientProfile.ShowDialog();
                    LoadPatientRecords();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while updating patient record: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please select a row to update.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (DataGridView1.SelectedRows.Count > 0)
            {
                try
                {
                    int rowIndex = DataGridView1.SelectedRows[0].Index;
                    int patID = Convert.ToInt32(DataGridView1.Rows[rowIndex].Cells["PatID"].Value);

                    AddEMR addEMR = new AddEMR(patID);
                    addEMR.ShowDialog();

                    LoadPatientRecords();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while updating patient record: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please select a row to update.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
