using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Web.Security;

namespace Health_Care_Plus_System.Classes
{
    public class AppointmentClass
    {
        private string connectionString = Properties.Settings.Default.DBConnectionString; // this connecting DB string statement

        public string Specialization { get; set; }
        public string DoctorName { get; set; }
        public string PatientName { get; set; }
        public DateTime Appoint_Date { get; set; }
        public string Appoint_Time { get; set; }
        public string Note { get; set; }
        public string Sender_Name { get; set; }




        public DataTable GetDoctors()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT DoctorID, Specialization, FullName FROM Doctors";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                        DataTable dataTable = new DataTable();
                        dataAdapter.Fill(dataTable);

                        return dataTable;
                    }
                }
            }
            catch (Exception)
            {
                throw; 
            }
        }




        public DataTable GetPatients()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT PatID, FullName, ContactNo FROM Patient";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                        DataTable dataTable = new DataTable();
                        dataAdapter.Fill(dataTable);

                        return dataTable;
                    }
                }
            }
            catch(Exception)
            {
                throw;
            }
        }






        // Appointment Add Record Methods
        public bool AddAppointment()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string insertQuery = @"
                INSERT INTO Appointment (Specialization, DoctorName, PatientName, Appoint_Date, Appoint_Time, Note, Sender_Name)
                VALUES (@Specialization, @DoctorName, @PatientName, @Appoint_Date, @Appoint_Time, @Note, @Sender_Name)";

                    using (SqlCommand cmd = new SqlCommand(insertQuery, connection))
                    {
                        cmd.Parameters.AddWithValue("@Specialization", Specialization);
                        cmd.Parameters.AddWithValue("@DoctorName", DoctorName);
                        cmd.Parameters.AddWithValue("@PatientName", PatientName);
                        cmd.Parameters.AddWithValue("@Appoint_Date", Appoint_Date);
                        cmd.Parameters.AddWithValue("@Appoint_Time", Appoint_Time);
                        cmd.Parameters.AddWithValue("@Note", Note);
                        cmd.Parameters.AddWithValue("@Sender_Name", Sender_Name);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        return rowsAffected > 0;
                    }

                }
            }
            catch (Exception) 
            { 
                return false;
            }
        }

    }
}
