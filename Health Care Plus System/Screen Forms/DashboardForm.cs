using Health_Care_Plus_System.Classes;
using Health_Care_Plus_System.Screen_Forms.Employee;
using LiveCharts;
using LiveCharts.Wpf;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace Health_Care_Plus_System.Screen_Forms
{
    public partial class DashboardForm : Form
    {
        private DashboardCount dashboardCount; // This instance of DashboardCount.

        public DashboardForm()
        {
            InitializeComponent();

            dashboardCount = new DashboardCount();   
         
            UpdateTotalCounts();    // Call the method to update the total counts.


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

                // Update the labels to display the counts.
                Patientlabel.Text = patientCount.ToString();
                Stafflabel.Text = staffCount.ToString();
                Doctorlabel.Text = doctorCount.ToString();
                ResourceLabel.Text = resourceCount.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while fetching total counts: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DashboardForm_Load(object sender, EventArgs e)
        {

        }

        private void RefreshBtn_Click(object sender, EventArgs e)
        {
          
            
        }
    }
}
