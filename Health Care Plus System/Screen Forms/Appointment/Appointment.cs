using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Health_Care_Plus_System.Screen_Forms.Appointment
{
    public partial class Appointment : Form
    {
        private string connectionString = Properties.Settings.Default.DBConnectionString; // this connecting DB string statement

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

        }

        private void Updatebutton_Click(object sender, EventArgs e)
        {

        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {

        }
    }
}
