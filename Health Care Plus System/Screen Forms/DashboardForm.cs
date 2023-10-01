using Health_Care_Plus_System.Classes;
using Health_Care_Plus_System.Screen_Forms.Employee;
using LiveCharts;
using LiveCharts.Wpf;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace Health_Care_Plus_System.Screen_Forms
{
    public partial class DashboardForm : Form
    {
        private string connectionString = Properties.Settings.Default.DBConnectionString;

        private DashboardCount dashboardCount; // This instance of DashboardCount.

        public DashboardForm()
        {
            InitializeComponent();

            dashboardCount = new DashboardCount();   
         
            UpdateTotalCounts();    // Call the method to update the total counts.

            LoadAppointmentsForToday(); // Load today's appointments 
        }

        // Method to update the total counts and display them on the form.
        private void UpdateTotalCounts()
        {
            try
            {
                // Get the total counts using DashboardCount instance.
                int staffCount = dashboardCount.GetStaffTotalCount();
                int doctorCount = dashboardCount.GetDoctorsTotalCount();
                int patientCount = dashboardCount.GetPatientsCount();
                int resourceCount = dashboardCount.GetResourceTotalCount();
                int appointmentCount = dashboardCount.GetAppointmentotalCount();


                // Update the labels to display the counts.
                Patientlabel.Text = patientCount.ToString();
                Stafflabel.Text = staffCount.ToString();
                Doctorlabel.Text = doctorCount.ToString();
                ResourceLabel.Text = resourceCount.ToString();
                AppointmentLabel.Text = appointmentCount.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while fetching total counts: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        // Method to load today's appointments into the DataGridView.
        private void LoadAppointmentsForToday()
        {
            try
            {
                // Get today's date.
                DateTime today = DateTime.Today;

                // Get appointments for today using the GetAppointmentsForDate method.
                DataTable appointmentsToday = dashboardCount.GetAppointmentsForDate(today);

                // Bind the DataTable to the DataGridView.
                TodayAppointmentGrideTable.DataSource = appointmentsToday;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while loading today's appointments: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }




        private void TodayAppointmentGrideTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DashboardForm_Load(object sender, EventArgs e)
        {
            LoadAppointmentsForToday();
        }

        private void cartesianChart1_ChildChanged(object sender, System.Windows.Forms.Integration.ChildChangedEventArgs e)
        {

        }
    }
}
