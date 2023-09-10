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

                string query = "SELECT * FROM Appointment"; // Dcotor name is DB table

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);

                    AppointmentDataGridView1.DataSource = dataTable; // AppointmentDataGridView1 is the name of table Table 
                }
            }
        }



        private void Updatebutton_Click(object sender, EventArgs e)
        {

        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {

        }
    }
}
