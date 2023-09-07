using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Health_Care_Plus_System.Classes
{
    public class DoctorClass
    {

        private string connectionString = Properties.Settings.Default.DBConnectionString; // this connecting DB string statement


        public int DoctorID { get; set; }
        public string FullName { get; set; }
        public string Gender { get; set; }
        public DateTime DOB { get; set; }
        public string MedicalLicense { get; set; }
        public string Specialization { get; set; }
        public string Qualification { get; set; }
        public string ContactNo { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string WorkPlace { get; set; }
        public string AvailabilityDay { get; set; }
        public string AvailabilityTime { get; set; }
        public string PreferredMethod { get; set; }
        public string ProfilePicture { get; set; }



        // Doctor Profile Input Field to Get
        public int Age { get; set; } 
        public string Experience { get; private set; } 
        public DateTime RegisteredDate { get; set; } 



        public DoctorClass()
        {
            
        }



        // This CalculateExperience() method is for Doctor Profile
        public void CalculateExperience()
        {
            // Calculate experience in years and months
            TimeSpan experienceSpan = DateTime.Today - RegisteredDate;
            int totalMonths = (int)(experienceSpan.TotalDays / 30.44); // Average number of days in a month

            int years = totalMonths / 12;
            int months = totalMonths % 12;

            Experience = $"{years} years, {months} months";
        }




        // Get the Doctor ID to retrieve datas
        public static DoctorClass GetDoctorByID(int doctorID)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.DBConnectionString))
                {
                    connection.Open();

                    string query = "SELECT * FROM Doctors WHERE DoctorID = @DoctorID";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@DoctorID", doctorID);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                DoctorClass doctor = new DoctorClass
                                {
                                    DoctorID = Convert.ToInt32(reader["DoctorID"]),
                                    FullName = reader["FullName"].ToString(),
                                    Gender = reader["Gender"].ToString(),
                                    DOB = Convert.ToDateTime(reader["DOB"]),
                                    MedicalLicense = reader["MedicalLicense"].ToString(),
                                    Specialization = reader["Specialization"].ToString(),
                                    Qualification = reader["Qualification"].ToString(),
                                    ContactNo = reader["ContactNo"].ToString(),
                                    Email = reader["Email"].ToString(),
                                    Address = reader["Address"].ToString(),
                                    WorkPlace = reader["WorkPlace"].ToString(),
                                    AvailabilityDay = reader["AvailabilityDay"].ToString(),
                                    AvailabilityTime = reader["AvailabilityTime"].ToString(),
                                    PreferredMethod = reader["PreferredMethod"].ToString(),
                                    ProfilePicture = reader["ProfilePicture"].ToString()
                                };

                                return doctor;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }

            return null;
        }





        //Add Method for Doctor
        public bool AddDoctor()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string insertQuery = @"
                        INSERT INTO Doctors (
                            FullName, Gender, DOB, MedicalLicense, Specialization, Qualification,
                            ContactNo, Email, Address, WorkPlace, AvailabilityDay, AvailabilityTime,
                            PreferredMethod, ProfilePicture)
                        VALUES (
                            @FullName, @Gender, @DOB, @MedicalLicense, @Specialization, @Qualification,
                            @ContactNo, @Email, @Address, @WorkPlace, @AvailabilityDay, @AvailabilityTime,
                            @PreferredMethod, @ProfilePicture
                        )";


                    using (SqlCommand command = new SqlCommand(insertQuery, connection))
                    {
                        // Set command parameters here
                        command.Parameters.AddWithValue("@FullName", FullName);
                        command.Parameters.AddWithValue("@Gender", Gender);
                        command.Parameters.AddWithValue("@DOB", DOB);
                        command.Parameters.AddWithValue("@MedicalLicense", MedicalLicense);
                        command.Parameters.AddWithValue("@Specialization", Specialization);
                        command.Parameters.AddWithValue("@Qualification", Qualification);
                        command.Parameters.AddWithValue("@ContactNo", ContactNo);
                        command.Parameters.AddWithValue("@Email", Email);
                        command.Parameters.AddWithValue("@Address", Address);
                        command.Parameters.AddWithValue("@WorkPlace", WorkPlace);
                        command.Parameters.AddWithValue("@AvailabilityDay", AvailabilityDay);
                        command.Parameters.AddWithValue("@AvailabilityTime", AvailabilityTime);
                        command.Parameters.AddWithValue("@PreferredMethod", PreferredMethod);
                        command.Parameters.AddWithValue("@ProfilePicture", ProfilePicture);

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



        public bool UpdateDoctor()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string updateQuery = @"
                        UPDATE Doctors SET
                            FullName = @FullName, Gender = @Gender, DOB = @DOB, 
                            MedicalLicense = @MedicalLicense, Specialization = @Specialization,
                            Qualification = @Qualification, ContactNo = @ContactNo, 
                            Email = @Email, Address = @Address, WorkPlace = @WorkPlace, 
                            AvailabilityDay = @AvailabilityDay, AvailabilityTime = @AvailabilityTime,
                            PreferredMethod = @PreferredMethod, ProfilePicture = @ProfilePicture
                        WHERE DoctorID = @DoctorID";

                    using (SqlCommand command = new SqlCommand(updateQuery, connection))
                    {
                        // Set command parameters here
                        command.Parameters.AddWithValue("@DoctorID", DoctorID);
                        command.Parameters.AddWithValue("@FullName", FullName);
                        command.Parameters.AddWithValue("@Gender", Gender);
                        command.Parameters.AddWithValue("@DOB", DOB);
                        command.Parameters.AddWithValue("@MedicalLicense", MedicalLicense);
                        command.Parameters.AddWithValue("@Specialization", Specialization);
                        command.Parameters.AddWithValue("@Qualification", Qualification);
                        command.Parameters.AddWithValue("@ContactNo", ContactNo);
                        command.Parameters.AddWithValue("@Email", Email);
                        command.Parameters.AddWithValue("@Address", Address);
                        command.Parameters.AddWithValue("@WorkPlace", WorkPlace);
                        command.Parameters.AddWithValue("@AvailabilityDay", AvailabilityDay);
                        command.Parameters.AddWithValue("@AvailabilityTime", AvailabilityTime);
                        command.Parameters.AddWithValue("@PreferredMethod", PreferredMethod);
                        command.Parameters.AddWithValue("@ProfilePicture", ProfilePicture);

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





        public bool DeleteDoctor()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string deleteQuery = "DELETE FROM Doctors WHERE DoctorID = @DoctorID";

                    using (SqlCommand command = new SqlCommand(deleteQuery, connection))
                    {
                        command.Parameters.AddWithValue("@DoctorID", DoctorID);

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




        public static DataTable SearchDoctors(string searchQuery)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.DBConnectionString))
                {
                    connection.Open();

                    string query = "SELECT * FROM Doctors " +
                         "WHERE FullName LIKE @SearchQuery OR ContactNo LIKE @SearchQuery OR Specialization LIKE @SearchQuery";

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
                MessageBox.Show("An error occurred while searching: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null; 
            }
        }
    }
}
