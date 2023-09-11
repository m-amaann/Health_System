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

namespace Health_Care_Plus_System.Screen_Forms.Appointment
{
    public partial class Appointment : Form
    {
        private string connectionString = Properties.Settings.Default.DBConnectionString; // connecting DB string statement


        private AppointmentClass appointmentClass = new AppointmentClass();

        public Appointment()
        {
            InitializeComponent();
        }

        private void Addbutton_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddAppointment addAppointment = new AddAppointment();
            addAppointment.ShowDialog();
        }

        private void Appointment_Load(object sender, EventArgs e)
        {
            LoadAppointmentRecord();
        }


        private void LoadAppointmentRecord()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT * FROM Appointment"; // Appointment name is DB table

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);

                    AppointmentDataGridView1.DataSource = dataTable; // AppointmentDataGridView1 is name of Table 
                }
            }
        }



        private void Updatebutton_Click(object sender, EventArgs e)
        {
            if (AppointmentDataGridView1.SelectedRows.Count > 0)
            {
                int rowIndex = AppointmentDataGridView1.SelectedRows[0].Index;
                int Appointment_ID = Convert.ToInt32(AppointmentDataGridView1.Rows[rowIndex].Cells["Appointment_ID"].Value);

                // Pass the appointmentID to the UpdateAppointment form
                this.Hide();
                UpdateAppointment updateAppointment = new UpdateAppointment(Appointment_ID);
                updateAppointment.ShowDialog();
            }
            else
            {
                MessageBox.Show("Please select a row to update.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }






        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (AppointmentDataGridView1.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show("Are you sure you want to delete this appointment record?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    int rowIndex = AppointmentDataGridView1.SelectedRows[0].Index;
                    int appointmentID = Convert.ToInt32(AppointmentDataGridView1.Rows[rowIndex].Cells["Appointment_ID"].Value);

                    AppointmentClass appointmentClassToDelete = new AppointmentClass { Appointment_ID = appointmentID };

                    if (appointmentClassToDelete.DeleteAppointmentRecord())
                    {
                        MessageBox.Show("Appointment record deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadAppointmentRecord(); // Refresh the appointment records after deletion
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




        private void SearchTextBox_TextChanged(object sender, EventArgs e)
        {
            string searchQuery = SearchTextBox.Text.Trim(); 
            DataTable dataTable = appointmentClass.SearchAppointment(searchQuery);

            if (dataTable != null)
            {
                AppointmentDataGridView1.DataSource = dataTable;
            }
        }

        private void AppointmentDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
