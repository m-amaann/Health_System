using Health_Care_Plus_System.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Health_Care_Plus_System.Screen_Forms.Room
{
    public partial class AddRoom : Form
    {
        private string connectionString = Properties.Settings.Default.DBConnectionString; // connection DB string statement


        //initialize instant class
        private RoomClass roomClass = new RoomClass();



        public AddRoom()
        {
            InitializeComponent();
        }

        private void AddRoom_Load(object sender, EventArgs e)
        {
            StatusComboBox.SelectedIndexChanged += StatusComboBox_SelectedIndexChanged;

            StatusComboBox.SelectedItem = "Available";
        }

        private void StatusComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Update the text color of the Status ComboBox based on the selected status.
            string selectedStatus = StatusComboBox.SelectedItem.ToString();
            if (selectedStatus == "Available")
            {
                StatusComboBox.ForeColor = System.Drawing.Color.Green;
            }
            else if (selectedStatus == "Occupancy") 
            {
                StatusComboBox.ForeColor = System.Drawing.Color.Red;
            }
        }

        private void AddRoomBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidateInput())
                {
                    RoomClass roomClass = new RoomClass()
                    {
                        RoomTheater_No = RoomTheaterNoTextBox.Text,
                        Type = RoomTypeComboBox.Text,
                        Scheduled_Procedure = ScheduleProcedureComboBox.Text,
                        Status = StatusComboBox.Text,
                    };

                    // Call the Method in Room Class
                    bool success = roomClass.AddRoomRecord();

                    if (success)
                    {
                        MessageBox.Show("Add A New Room Record Successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Failed to add a room.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private bool ValidateInput()
        {
            if (
              string.IsNullOrWhiteSpace(RoomTheaterNoTextBox.Text) ||
              string.IsNullOrWhiteSpace(RoomTypeComboBox.Text) ||
              string.IsNullOrWhiteSpace(ScheduleProcedureComboBox.Text) ||
              string.IsNullOrWhiteSpace(StatusComboBox.Text)            
              )
            {
                MessageBox.Show("Please fill in all required fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true; // If all validations passed
        }
    }
}
