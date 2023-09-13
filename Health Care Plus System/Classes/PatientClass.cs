using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Health_Care_Plus_System.Classes
{
    public class PatientClass
    {
        private string connectionString;

        public PatientClass(string connectionString)
        {
            this.connectionString = connectionString;
        }



        // GET ALL PATIENTS METHODS
        public DataTable GetPatients()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT * FROM Patient";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                        DataTable dataTable = new DataTable();
                        dataAdapter.Fill(dataTable);

                        return dataTable;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
                return null;
            }
        }





        //SEARCHING METHODS
        public DataTable SearchPatients(string searchQuery)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT * FROM Patient " +
                                   "WHERE NIC LIKE @SearchQuery OR ContactNo LIKE @SearchQuery OR FullName LIKE @SearchQuery";

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
                Console.WriteLine("An error occurred: " + ex.Message);
                return null;
            }
        }



        // ADD PATIENTS METHODS
        public bool AddPatient(string fullName, string gender, string email, DateTime dob, string address, string city, string nic, string bloodGroup, string contactNo, string medicalHistory)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string insertQuery = @"INSERT INTO Patient ( FullName, Gender, Email, DOB, Address, City, NIC, BloodGroup, ContactNo, MedicalHistory)
                                     VALUES ( @FullName, @Gender, @Email, @DOB, @Address, @City, @NIC, @BloodGroup, @ContactNo, @MedicalHistory)";

                    using (SqlCommand command = new SqlCommand(insertQuery, connection))
                    {
                        command.Parameters.AddWithValue("@FullName", fullName);
                        command.Parameters.AddWithValue("@Gender", gender);
                        command.Parameters.AddWithValue("@Email", email);
                        command.Parameters.AddWithValue("@DOB", dob);
                        command.Parameters.AddWithValue("@Address", address);
                        command.Parameters.AddWithValue("@City", city);
                        command.Parameters.AddWithValue("@NIC", nic);
                        command.Parameters.AddWithValue("@BloodGroup", bloodGroup);
                        command.Parameters.AddWithValue("@ContactNo", contactNo);
                        command.Parameters.AddWithValue("@MedicalHistory", medicalHistory);

                        int rowsAffected = command.ExecuteNonQuery();

                        return rowsAffected > 0;


                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
                return false;
            }
        }



        // UPDATE PATIENTS METHODS
        public bool UpdatePatient(int patID, string fullName, string gender, string email, DateTime dob, string address, string city, string nic, string bloodGroup, string contactNo, string medicalHistory)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string updateQuery = "UPDATE Patient SET " +
                                        "FullName = @FullName, Gender = @Gender, Email = @Email, " +
                                        "DOB = @DOB, Address = @Address, City = @City, NIC = @NIC, " +
                                        "BloodGroup = @BloodGroup, ContactNo = @ContactNo, " +
                                        "MedicalHistory = @MedicalHistory " +
                                        "WHERE PatID = @PatID";

                    using (SqlCommand command = new SqlCommand(updateQuery, connection))
                    {
                        command.Parameters.AddWithValue("@FullName", fullName);
                        command.Parameters.AddWithValue("@Gender", gender);
                        command.Parameters.AddWithValue("@Email", email);
                        command.Parameters.AddWithValue("@DOB", dob);
                        command.Parameters.AddWithValue("@Address", address);
                        command.Parameters.AddWithValue("@City", city);
                        command.Parameters.AddWithValue("@NIC", nic);
                        command.Parameters.AddWithValue("@BloodGroup", bloodGroup);
                        command.Parameters.AddWithValue("@ContactNo", contactNo);
                        command.Parameters.AddWithValue("@MedicalHistory", medicalHistory);
                        command.Parameters.AddWithValue("@PatID", patID);

                        int rowsAffected = command.ExecuteNonQuery();

                        return rowsAffected > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
                return false;
            }
        }




        // DELETE PATIENTS METHODS
        public bool DeletePatient(int patID)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string deleteQuery = "DELETE FROM Patient WHERE PatID = @PatID";

                    using (SqlCommand command = new SqlCommand(deleteQuery, connection))
                    {
                        command.Parameters.AddWithValue("@PatID", patID);

                        int rowsAffected = command.ExecuteNonQuery();

                        return rowsAffected > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
                return false;
            }
        }
    }
}
