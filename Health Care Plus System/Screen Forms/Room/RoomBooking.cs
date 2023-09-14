using Health_Care_Plus_System.Classes;
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
using System.Windows.Forms;

namespace Health_Care_Plus_System.Screen_Forms.Room
{
    public partial class RoomBooking : Form
    {
        private string connectionString = Properties.Settings.Default.DBConnectionString; // connecting DB string statement


        private BookingRoomClass bookingRoomClass = new BookingRoomClass();

        //initialize instance variable
        private DataTable PatientTable;



        public RoomBooking()
        {
            InitializeComponent();

            LoadRoomTheaterNumbers(); //call the method here
        }

        private void RoomBooking_Load(object sender, EventArgs e)
        {
            LoadPatientsAndAppoinment();
        }



        // Patient and Appoimnet Load Record Method
        private void LoadPatientsAndAppoinment()
        {
            PatientTable = bookingRoomClass.GetPatients();

            //DataTable to display patient column names
            DataTable filteredPatientsTable = new DataTable();
            filteredPatientsTable.Columns.Add("PatID", typeof(int));
            filteredPatientsTable.Columns.Add("PatientName", typeof(string));
            filteredPatientsTable.Columns.Add("Appointment_ID", typeof(int));



            foreach (DataRow row in PatientTable.Rows)
            {
                filteredPatientsTable.Rows.Add(row["PatID"], row["PatientName"], row["Appointment_ID"]);
            }

            PatientDataGrideView.DataSource = filteredPatientsTable;
        }



        // Room Theater No Load Record Method()
        private void LoadRoomTheaterNumbers()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string QUERY = "SELECT RoomTheaterID, RoomTheater_No FROM Rooms WHERE Status = 'Available'";

                using (SqlCommand command = new SqlCommand(QUERY, connection))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        DataTable roomTheaterTable = new DataTable();
                        adapter.Fill(roomTheaterTable);

                        // you have a ComboBox named 'roomTheaterComboBox'
                        RoomTheaterNoComboBox.DataSource = roomTheaterTable;
                        RoomTheaterNoComboBox.DisplayMember = "RoomTheater_No";
                        RoomTheaterNoComboBox.ValueMember = "RoomTheaterID";
                    }
                }
            }
        }





        private void PatientDataGrideView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Check if a patient row is selected 
            if (e.RowIndex >= 0 && e.RowIndex < PatientDataGrideView.Rows.Count - 1)
            {
                DataGridViewRow selectedRow = PatientDataGrideView.Rows[e.RowIndex];

                //  the patient name from the selected row
                string PatientName = selectedRow.Cells["PatientName"].Value.ToString();



                PatientNameTextBox.Text = PatientName;

            }
        }

        private void PatientNameTextBox_TextChanged(object sender, EventArgs e)
        {
            //In this function searching patient names record list
            string searchPatient = PatientNameTextBox.Text.Trim();

            DataView dv = new DataView(PatientTable);
            dv.RowFilter = $"PatientName LIKE '%{searchPatient}%'";

            PatientDataGrideView.DataSource = dv;
        }




        // Add Click Button For Room Booking 
        private void BookRoomAddBtn_Click(object sender, EventArgs e)
        {
            // Check if a patient is selected
            if (PatientDataGrideView.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a patient.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Get selected patient ID and name
            int selectedPatientID = Convert.ToInt32(PatientDataGrideView.SelectedRows[0].Cells["PatID"].Value);
            string selectedPatientName = PatientDataGrideView.SelectedRows[0].Cells["PatientName"].Value.ToString();

            // Check if a room/theater is selected
            if (RoomTheaterNoComboBox.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a room/theater number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Get selected room/theater ID
            int selectedRoomTheaterID = Convert.ToInt32(RoomTheaterNoComboBox.SelectedValue);

            // Get booking dates
            DateTime bookingFromDate = FromDateDatePicker.Value;
            DateTime bookingEndDate = EndDateDatePicker.Value;

            // Call the RecordRoomBooking method to add the booking record
            bookingRoomClass.RecordRoomBooking(selectedRoomTheaterID, selectedPatientID, 0, bookingFromDate, bookingEndDate);

         

            MessageBox.Show($"Room booked successfully for {selectedPatientName}.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void RoomTheaterNoComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
