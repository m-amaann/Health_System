using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Health_Care_Plus_System.Classes
{
    public class PrescriptionClass
    {
        private string connectionString = Properties.Settings.Default.DBConnectionString; // connecting DB string statement



        public int MedicationID { get; set; }
        public int PatID { get; set; }
        public string MedicationName { get; set; }
        public string Dosage { get; set; }
        public string Frequently { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Instruction { get; set; }
        public string Prescriped_Doctor { get; set; }
        public DateTime CreatedAt { get; set; }




        //GET MEDICATION ALL RECORD BY ID 
        public PrescriptionClass GetPrescriptionByID(int MedicationID)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT * FROM Prescription WHERE MedicationID = @MedicationID";
                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@MedicationID", MedicationID);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new PrescriptionClass
                            {
                                MedicationID = (int)reader["MedicationID"],
                                PatID = (int)reader["PatID"],
                                MedicationName = reader["MedicationName"].ToString(),
                                Dosage = reader["Dosage"].ToString(),
                                Frequently = reader["Frequently"].ToString(),
                                StartDate = (DateTime)reader["StartDate"],
                                EndDate = (DateTime)reader["EndDate"],
                                Instruction = reader["Instruction"].ToString(),
                                Prescriped_Doctor = reader["Prescriped_Doctor"].ToString(),
                            };
                        }
                        else
                        {
                            return null; // No prescription found with the given ID.
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while retrieving a prescription by ID: " + ex.Message);
                return null;
            }
        }


        //  Get Patient Record Method for in AddAppointment form
        public DataTable GetPatientAndDoctor()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT PatID, PatientName, DoctorName FROM Appointment";

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










        // MEDICATION ADD RECCORD METHOD
        public bool AddPrescription()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "INSERT INTO Prescription (PatID, MedicationName, Dosage, Frequently, StartDate, EndDate, Instruction, Prescriped_Doctor) " +
                                   "VALUES (@PatID, @MedicationName, @Dosage, @Frequently, @StartDate, @EndDate, @Instruction, @Prescriped_Doctor)";

                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@PatID", PatID);
                    cmd.Parameters.AddWithValue("@MedicationName", MedicationName);
                    cmd.Parameters.AddWithValue("@Dosage", Dosage);
                    cmd.Parameters.AddWithValue("@Frequently", Frequently);
                    cmd.Parameters.AddWithValue("@StartDate", StartDate);
                    cmd.Parameters.AddWithValue("@EndDate", EndDate);
                    cmd.Parameters.AddWithValue("@Instruction", Instruction);
                    cmd.Parameters.AddWithValue("@Prescriped_Doctor", Prescriped_Doctor);

                    int rowsAffected = cmd.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
            catch (Exception)
            {
                return false;
            }
           
        }





        // MEDICATION UPDATE RECCORD METHOD
        public bool UpdatePrescription(PrescriptionClass prescription)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "UPDATE Prescription " +
                                   "SET PatID = @PatID, MedicationName = @MedicationName, Dosage = @Dosage, " +
                                   "Frequently = @Frequently, StartDate = @StartDate, EndDate = @EndDate, " +
                                   "Instruction = @Instruction, Prescriped_Doctor = @Prescriped_Doctor, " +
                                 
                                   "WHERE MedicationID = @MedicationID";

                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@MedicationID", prescription.MedicationID);
                    cmd.Parameters.AddWithValue("@PatID", prescription.PatID);
                    cmd.Parameters.AddWithValue("@MedicationName", prescription.MedicationName);
                    cmd.Parameters.AddWithValue("@Dosage", prescription.Dosage);
                    cmd.Parameters.AddWithValue("@Frequently", prescription.Frequently);
                    cmd.Parameters.AddWithValue("@StartDate", prescription.StartDate);
                    cmd.Parameters.AddWithValue("@EndDate", prescription.EndDate);
                    cmd.Parameters.AddWithValue("@Instruction", prescription.Instruction);
                    cmd.Parameters.AddWithValue("@Prescriped_Doctor", prescription.Prescriped_Doctor);

                    int rowsAffected = cmd.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }






        // Search Appointment Method From DB
        public DataTable SearchPrescription(string searchQuery)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT * FROM Prescription WHERE PatID LIKE @SearchQuery " +
                        "OR MedicationName LIKE @SearchQuery " +
                        "OR PatientName LIKE @SearchQuery " +
                        "OR Prescriped_Doctor LIKE @SearchQuery ";

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
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while searching: " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);



                return null;
            }
        }







        //Get Retrieve All Prescription Records From The DB
        public List<PrescriptionClass> LoadPrescriptRecord()
        {
            List<PrescriptionClass> prescriptions = new List<PrescriptionClass>();

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT * FROM Prescription";
                    SqlCommand cmd = new SqlCommand(query, connection);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            prescriptions.Add(new PrescriptionClass
                            {
                                MedicationID = (int)reader["MedicationID"],
                                PatID = (int)reader["PatID"],
                                MedicationName = reader["MedicationName"].ToString(),
                                Dosage = reader["Dosage"].ToString(),
                                Frequently = reader["Frequently"].ToString(),
                                StartDate = (DateTime)reader["StartDate"],
                                EndDate = (DateTime)reader["EndDate"],
                                Instruction = reader["Instruction"].ToString(),
                                Prescriped_Doctor = reader["Prescriped_Doctor"].ToString(),
                            });
                        }
                    }
                }

                return prescriptions;
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}
