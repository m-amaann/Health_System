using Health_Care_Plus_System.Classes;
using System;
using System.Windows.Forms;

namespace Health_Care_Plus_System.Screen_Forms.Room
{
    public partial class UpdateRoom : Form
    {
        private string connectionString = Properties.Settings.Default.DBConnectionString;
        private int roomIDUpdate;
        private RoomClass roomClass;

        public UpdateRoom(int roomIDUpdate)
        {
            InitializeComponent();
            this.roomIDUpdate = roomIDUpdate;
            roomClass = new RoomClass();
        }

        private void UpdateRoom_Load(object sender, EventArgs e)
        {
            LoadRoomRecord();
        }

        private void LoadRoomRecord()
        {
            RoomClass room = RoomClass.GetRoomByID(roomIDUpdate);

            if (room != null)
            {
                RoomTheaterNoTextBox.Text = room.RoomTheater_No;
                RoomTypeComboBox.Text = room.Type;
                ScheduleProcedureComboBox.Text = room.Scheduled_Procedure;
                StatusComboBox.Text = room.Status;
            }
            else
            {
                MessageBox.Show("Room not found or an error occurred.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        private void Updatebutton_Click(object sender, EventArgs e)
        {
            RoomClass roomToUpdate = new RoomClass()
            {
                RoomTheaterID = roomIDUpdate,
                RoomTheater_No = RoomTheaterNoTextBox.Text,
                Type = RoomTypeComboBox.Text,
                Scheduled_Procedure = ScheduleProcedureComboBox.Text,
                Status = StatusComboBox.Text,
            };

            if (roomToUpdate.UpdateRoomsRecord())
            {
                MessageBox.Show("Room Record Updated Successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Error occurred while updating room record.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
