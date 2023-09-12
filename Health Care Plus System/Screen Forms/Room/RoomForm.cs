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
    public partial class RoomForm : Form
    {

        public RoomForm()
        {
            InitializeComponent();

        }

        private void Addbutton_Click(object sender, EventArgs e)
        {
            AddRoom addRoom = new AddRoom();
            addRoom.Show();
        }

        private void RoomBookingBtn_Click(object sender, EventArgs e)
        {
            RoomBooking roomBooking = new RoomBooking();
            roomBooking.Show();
        }

        private void RoomForm_Load(object sender, EventArgs e)
        {

        }
    }
}
