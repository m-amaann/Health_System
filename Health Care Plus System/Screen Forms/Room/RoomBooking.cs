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

namespace Health_Care_Plus_System.Screen_Forms.Room
{
    public partial class RoomBooking : Form
    {
        private string connectionString = Properties.Settings.Default.DBConnectionString; // connecting DB string statement


        //initialize instance class
        private BookingRoomClass bookingRoomClass = new BookingRoomClass();
        private DataTable CombinedTable;

        //initialize instance variable
        private DataTable PatientTable;



        public RoomBooking()
        {
            InitializeComponent();
        }

        private void RoomBooking_Load(object sender, EventArgs e)
        {
            LoadPatients();
        }


        // Patient's Load Record Method
        private void LoadPatients()
        {
            // Modify SQL query to combine data from both tables
            string query = "SELECT P.PatID, P.FullName AS PatientName, ISNULL(A.Appointment_ID, 0) AS Appointment_ID " +
               "FROM Patient P " +
               "LEFT JOIN Appointment A ON P.PatID = A.PatientName";

            PatientTable = bookingRoomClass.GetPatients();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                    CombinedTable = new DataTable();
                    dataAdapter.Fill(CombinedTable);

                    // Bind the combinedTable to the DataGridView
                    PatientDataGrideView.DataSource = CombinedTable;
                }
            }
        }




        private void PatientDataGrideView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Check if a patient row is selected 
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = PatientDataGrideView.Rows[e.RowIndex];
                string patientID = selectedRow.Cells["PatID"].Value.ToString();
                string patientName = selectedRow.Cells["FullName"].Value.ToString();
                string appointmentID = selectedRow.Cells["Appointment_ID"].Value.ToString();


                // Display patient and appointment information as needed
                PatientIDTextBox.Text = patientID;
                PatientNameTextBox.Text = patientName;

                AppoinmentIDTextBox1.Text = appointmentID;
                // You can add more code to display other patient and appointment details.
            }
        }

        private void PatientNameTextBox_TextChanged(object sender, EventArgs e)
        {
            //In this function searching patient names record list
            string searchPatient = PatientNameTextBox.Text.Trim();

            DataView dv = new DataView(PatientTable);
            dv.RowFilter = $"FullName LIKE '%{searchPatient}%'";

            PatientDataGrideView.DataSource = dv;
        }
    }
}
