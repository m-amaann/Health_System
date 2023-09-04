using Health_Care_Plus_System.Screen_Forms.Employee;
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

            LoadDoctorsRecords();
        }

        private void Addbutton_Click(object sender, EventArgs e)
        {
            this.Close();
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
            if (DoctorDataGridview.SelectedRows.Count > 0)
            {
                int rowIndex = DoctorDataGridview.SelectedRows[0].Index;
                int DoctorID = Convert.ToInt32(DoctorDataGridview.Rows[rowIndex].Cells["DoctorID"].Value);

                this.Hide();
               UpdateDoctor updateDoctor = new UpdateDoctor(DoctorID);
                updateDoctor.Show();
            }
            else
            {
                MessageBox.Show("Please select a row to update.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }




        // ---------- Delete the Doctors record method
        private bool DeleteDoctorRecord(int DoctorID)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string DELETEQuery = "DELETE FROM Doctors WHERE DoctorID = @DoctorID";

                using (SqlCommand command = new SqlCommand(DELETEQuery, connection))
                {
                    command.Parameters.AddWithValue("@DoctorID", DoctorID);

                    int rowsAffected = command.ExecuteNonQuery();

                    return rowsAffected > 0;
                }
            }
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

                    if (DeleteDoctorRecord(DoctorID))
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
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string searchQuery = SearchTextBox.Text.Trim();

                string query = "SELECT * FROM Doctors " +
                               "WHERE FullName LIKE @SearchQuery OR ContactNo LIKE @SearchQuery OR Specialization LIKE @SearchQuery";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@SearchQuery", "%" + searchQuery + "%");

                    SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);

                    DoctorDataGridview.DataSource = dataTable;
                }
            }
        }
    }
}
