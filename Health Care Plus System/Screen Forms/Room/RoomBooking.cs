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
            filteredPatientsTable.Columns.Add("FullName", typeof(string));


            foreach (DataRow row in PatientTable.Rows)
            {
                filteredPatientsTable.Rows.Add(row["PatID"], row["FullName"]);
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
                string PatientID = selectedRow.Cells["PatID"].Value.ToString();
                string PatientName = selectedRow.Cells["FullName"].Value.ToString();


                PatientNameTextBox.Text = PatientName;

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

        private void BookRoomAddBtn_Click(object sender, EventArgs e)
        {

        }

        private void RoomTheaterNoComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
