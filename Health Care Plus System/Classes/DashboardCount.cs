﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Health_Care_Plus_System.Classes
{
    public class DashboardCount
    {
        private string connectionString = Properties.Settings.Default.DBConnectionString;



        //  Get Staff's Total Save Count Display Method
        public int GetStaffTotalCount()
        {
            try
            {
                // Connect to the database.
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // SQL query to count staff.
                    string query = "SELECT COUNT(*) FROM Staff";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Execute the query and get the count.
                        int staffCount = (int)command.ExecuteScalar();
                        return staffCount;
                    }
                }
            }
            catch (Exception ex)
            {         
                MessageBox.Show("An error occurred while fetching staff count: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return -1; // Return -1 to indicate an error.
            }
        }




        // Get Doctor's Total Save Count Display Method
        public int GetDoctorsTotalCount()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT COUNT(*) FROM Doctors";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        int doctorCount = (int)command.ExecuteScalar();
                        return doctorCount;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while fetching doctors count: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return -1; // Return -1 to indicate an error.
            }

        }




        // Get Patient's Total Save Count Display Method

        public int GetPatientsCount()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT COUNT(*) FROM Patient";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        int patientsCount = (int)command.ExecuteScalar();
                        return patientsCount;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while fetching patients count: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return -1; // Return -1 to indicate an error.
            }
        }


        public int GetResourceTotalCount()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT COUNT(*) FROM Resources";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        int resourceCount = (int)command.ExecuteScalar();
                        return resourceCount;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while fetching resource count: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return -1; // Return -1 to indicate an error.
            }
        }




        //  Get Staff's Total Save Count Display Method
        public int GetAppointmentotalCount()
        {
            try
            {
                // Connect to the database.
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // SQL query to count appointment.
                    string query = "SELECT COUNT(*) FROM Appointment";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Execute the query and get the count.
                        int appointmentCount = (int)command.ExecuteScalar();
                        return appointmentCount;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while fetching appointment count: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return -1; // Return -1 to indicate an error.
            }
        }



        // Method to get appointments created on a specific date (e.g., today)
        public DataTable GetAppointmentsForDate(DateTime date)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Customize the query to select only specific columns
                string query = "SELECT Appointment_ID, DoctorName, PatientName FROM Appointment WHERE CONVERT(DATE, created_at) = @CreationDate";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Add the parameter for the creation date
                    command.Parameters.AddWithValue("@CreationDate", date.Date);

                    SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);

                    return dataTable;
                }
            }
        }






    }
}
