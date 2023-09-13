using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Health_Care_Plus_System.Classes
{
    public class PatientProfileClass
    {
        private string connectionString = (Properties.Settings.Default.DBConnectionString);

        public int PatID { get; set; }
        public string FullName { get; set; }
        public string Gender { get; set; }
        public string Email { get; set; }
        public DateTime DOB { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string NIC { get; set; }
        public string BloodGroup { get; set; }
        public string ContactNo { get; set; }
        public string MedicalHistory { get; set; }
        public string CreateAt { get; set; }




        // Get the Patient ID to retrieve data's
        public PatientProfileClass GetPatientByID(int patientID)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.DBConnectionString))
                {
                    connection.Open();

                    string query = "SELECT * FROM Patient WHERE PatID = @PatID";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@PatID", patientID);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                PatientProfileClass patient = new PatientProfileClass()
                                {

                                };
                                return patient;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
            }

            return null;
        }
    }
}
