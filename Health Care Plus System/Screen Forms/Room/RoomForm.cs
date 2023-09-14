using Health_Care_Plus_System.Classes;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Health_Care_Plus_System.Screen_Forms.Room
{
    public partial class RoomForm : Form
    {
        private string connectionString = Properties.Settings.Default.DBConnectionString;
        RoomClass roomClass = new RoomClass();

        public RoomForm()
        {
            InitializeComponent();
        }

        private void Addbutton_Click(object sender, EventArgs e)
        {
            AddRoom addRoom = new AddRoom();
            addRoom.Show();

            LoadRoomtRecord();
        }

        private void RoomBookingBtn_Click(object sender, EventArgs e)
        {
            RoomBooking roomBooking = new RoomBooking();
            roomBooking.Show();
        }

        private void RoomForm_Load(object sender, EventArgs e)
        {
            LoadRoomtRecord();
        }

        private void LoadRoomtRecord()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT * FROM Rooms";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);

                    RoomDataGridview.DataSource = dataTable;
                }
            }
        }

        private void ResourceDataGridview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Updatebutton_Click(object sender, EventArgs e)
        {
            if (RoomDataGridview.SelectedRows.Count > 0)
            {
                int rowIndex = RoomDataGridview.SelectedRows[0].Index;
                int RoomTheaterID = Convert.ToInt32(RoomDataGridview.Rows[rowIndex].Cells["RoomTheaterID"].Value);

                UpdateRoom updateRoom = new UpdateRoom(RoomTheaterID);
                updateRoom.Show();
            }
            else
            {
                MessageBox.Show("Please select a row to update.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (RoomDataGridview.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show("Are you sure you want to delete this room record?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    int rowIndex = RoomDataGridview.SelectedRows[0].Index;
                    int RoomTheaterID = Convert.ToInt32(RoomDataGridview.Rows[rowIndex].Cells["RoomTheaterID"].Value);

                    RoomClass roomClass = new RoomClass { RoomTheaterID = RoomTheaterID };

                    if (roomClass.DeleteRoomRecord())
                    {
                        MessageBox.Show("Room record deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadRoomtRecord();
                    }
                    else
                    {
                        MessageBox.Show("Failed to delete room record.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a room record to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SearchTextBox_TextChanged(object sender, EventArgs e)
        {
            string searchQuery = SearchTextBox.Text.Trim();
            DataTable dataTable = roomClass.SearchRoomRecord(searchQuery);

            if (dataTable != null)
            {
                RoomDataGridview.DataSource = dataTable;
            }
        }
    }
}
