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
        public Appointment()
        {
            InitializeComponent();
        }

        private void Addbutton_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddAppointment addAppointment = new AddAppointment();
            addAppointment.Show();
        }

        private void Appointment_Load(object sender, EventArgs e)
        {

        }
    }
}
