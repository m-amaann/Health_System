using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Web.Security;
using System.Windows.Forms;
using Health_Care_Plus_System.Properties;
using System.Security.AccessControl;
using System.Xml.Linq;

namespace Health_Care_Plus_System.Classes
{
    public class AppointmentClass
    {
        private string connectionString = Properties.Settings.Default.DBConnectionString; // connecting DB string statement

        public int Appointment_ID { get; set; }
        public string Specialization { get; set; }
        public string DoctorName { get; set; }
        public string PatientName { get; set; }
        public DateTime Appoint_Date { get; set; }
        public string Appoint_Time { get; set; }
        public string Note { get; set; }
        public string Sender_Name { get; set; }



        //  Get Doctors Record Method from DB for AddAppointment form
        public DataTable GetDoctors()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT Specialization, FullName, AvailabilityDay, AvailabilityTime FROM Doctors";

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



        //  Get Patient Record Method for in AddAppointment form
        public DataTable GetPatients()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT FullName, ContactNo FROM Patient";

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






        // Appointment Add Record Method
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






        // Update Appointment Method
        public bool UpdateAppointmentRecord()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {

                    {
                        connection.Open();

                        string updateQuery = @"
                    UPDATE Appointment SET 
                        Specialization = @Specialization, 
                        DoctorName = @DoctorName, 
                        PatientName = @PatientName, 
                        Appoint_Date = @Appoint_Date, 
                        Appoint_Time = @Appoint_Time, 
                        Note = @Note, 
                        Sender_Name = @Sender_Name WHERE Appointment_ID = @Appointment_ID";

                        using (SqlCommand cmd = new SqlCommand(updateQuery, connection))
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
                catch (Exception ex)
                {
                    Console.WriteLine("An error occurred while updating a appointment record: " + ex.Message);
                    return false;
                }
                finally
                {
                    connection.Close();
                }
            }                 
        }






        // DELETE APPOINTMENT METHOD
        public bool DeleteAppointmentRecord()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string deleteQuery = "DELETE FROM Appointment WHERE Appointment_ID = @Appointment_ID";

                    using (SqlCommand command = new SqlCommand(deleteQuery, connection))
                    {
                        command.Parameters.AddWithValue("@Appointment_ID", Appointment_ID);

                        int rowsAffected = command.ExecuteNonQuery();

                        return rowsAffected > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
                return false;
            }
        }





        // Search Appointment Method From DB
        public DataTable SearchAppointment(string searchQuery)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
   

                    string query = "SELECT * Appointment FROM " +
                        "WHERE Specialization LIKE @SearchQuery " +
                            "OR DoctorName LIKE @SearchQuery " +
                            "OR PatientName LIKE @SearchQuery " +
                            "OR Appoint_Time LIKE @SearchQuery " +
                            "OR Note LIKE @SearchQuery " +
                            "OR Sender_Name LIKE @SearchQuery";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@SearchQuery", "%" + searchQuery + "%");

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








        // This method to display retrieve the resource record in Table
        public bool LoadAppointmentRecord()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string query = "SELECT * FROM Appointment WHERE Appointment_ID = @Appointment_ID";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Appointment_ID", Appointment_ID);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                Appointment_ID = Convert.ToInt32(reader["Appointment_ID"]);
                                Specialization = reader["Specialization"].ToString();
                                DoctorName = reader["DoctorName"].ToString();
                                PatientName = reader["PatientName"].ToString();
                                Appoint_Date = Convert.ToDateTime(reader["Appoint_Date"].ToString());
                                Appoint_Time = reader["Appoint_Time"].ToString();
                                Note = reader["Note"].ToString();
                                Sender_Name = reader["Sender_Name"].ToString();

                                Console.WriteLine("Appointment Record has been Loaded Successful.");
                                return true;
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("An error occurred while loading appointment data: " + ex.Message);
                }
            }
            return false;
        }

    }
}
