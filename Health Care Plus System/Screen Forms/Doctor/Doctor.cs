using Health_Care_Plus_System.Classes;
using Health_Care_Plus_System.Screen_Forms.Doctor;
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

namespace Health_Care_Plus_System.Screen_Forms.Doctor
{
    public partial class Doctor : Form
    {
        private string connectionString = (Properties.Settings.Default.DBConnectionString);


        public Doctor()
        {
            InitializeComponent();

            LoadDoctorsRecords(); // Load the doctor data to display in datagridview table
        }

        private void Addbutton_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddDoctor addDoctor = new AddDoctor();
            addDoctor.ShowDialog();
        }

        private void Doctor_Load(object sender, EventArgs e)
        {

        }


        private void LoadDoctorsRecords()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT * FROM Doctors"; // Dcotor name is DB table

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);

                    DoctorDataGridview.DataSource = dataTable; // DoctorDataGridview is the name of table DataGridView 
                }
            }
        }

        private void Updatebutton_Click(object sender, EventArgs e)
        {

        }


        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (DoctorDataGridview.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show("Are you sure you want to delete this record?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    int rowIndex = DoctorDataGridview.SelectedRows[0].Index;
                    int DoctorID = Convert.ToInt32(DoctorDataGridview.Rows[rowIndex].Cells["DoctorID"].Value);

                    DoctorClass doctorClass = new DoctorClass { DoctorID = DoctorID };


                    if (doctorClass.DeleteDoctor())
                    {
                        MessageBox.Show("Record deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadDoctorsRecords();
                    }
                    else
                    {
                        MessageBox.Show("Failed to delete record.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a row to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void SearchTextBox_TextChanged(object sender, EventArgs e)
        {
         
        }

        private void DoctorProfileBtn_Click(object sender, EventArgs e)
        {
            if (DoctorDataGridview.SelectedRows.Count > 0)
            {
                int DoctorID = Convert.ToInt32(DoctorDataGridview.SelectedRows[0].Cells["DoctorID"].Value);
                DoctorClass selectedDoctor = DoctorClass.GetDoctorByID(DoctorID);

                if (selectedDoctor != null)
                {
                    DoctorProfile doctorProfile = new DoctorProfile(selectedDoctor);
                    doctorProfile.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Doctor not found.");
                }
            }
            else
            {
                MessageBox.Show("Please select a doctor to view the profile.");
            }
        }





        private void Updatebutton_Click_1(object sender, EventArgs e)
        {
            if (DoctorDataGridview.SelectedRows.Count > 0)
            {
                int rowIndex = DoctorDataGridview.SelectedRows[0].Index;
                int DoctorID = Convert.ToInt32(DoctorDataGridview.Rows[rowIndex].Cells["DoctorID"].Value);

                this.Hide();
                UpdateDoctor updateDoctor = new UpdateDoctor(DoctorID);
                updateDoctor.ShowDialog();
            }
            else
            {
                MessageBox.Show("Please select a row to update.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SearchTextBox_TextChanged_1(object sender, EventArgs e)
        {
            string searchQuery = SearchTextBox.Text.Trim();
            DataTable dataTable = DoctorClass.SearchDoctors(searchQuery);

            if (dataTable != null)
            {
                DoctorDataGridview.DataSource = dataTable;
            }
        }
    }
}
