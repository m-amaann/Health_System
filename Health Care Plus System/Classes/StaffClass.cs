using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Health_Care_Plus_System.Screen_Forms.Employee
{
    public class StaffClass
    {
        private string connectionString = Properties.Settings.Default.DBConnectionString;

        public int StaffID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DOB { get; set; }
        public string BloodGroup { get; set; }
        public string Gender { get; set; }
        public string Occupation { get; set; }
        public string Salary { get; set; }
        public DateTime JoiningDate { get; set; }
        public string Shift { get; set; }
        public string ContactNo { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string ProfileImg { get; set; }

        public StaffClass()
        {

        }

        public bool LoadStaffRecord()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string query = "SELECT * FROM Staff WHERE StaffID = @StaffID";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@StaffID", StaffID);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                FirstName = reader["FirstName"].ToString();
                                LastName = reader["LastName"].ToString();
                                DOB = Convert.ToDateTime(reader["DOB"]);
                                BloodGroup = reader["BloodGroup"].ToString();
                                Gender = reader["Gender"].ToString();
                                Occupation = reader["Occupation"].ToString();
                                Salary = reader["Salary"].ToString();
                                JoiningDate = Convert.ToDateTime(reader["JoiningDate"]);
                                Shift = reader["Shift"].ToString();
                                ContactNo = reader["ContactNo"].ToString();
                                Email = reader["Email"].ToString();
                                Address = reader["Address"].ToString();
                                ProfileImg = reader["ProfileImg"].ToString();


                                return true;
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while loading staff data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            return false;
        }




        // Add Staff Method
        public bool AddStaffRecord()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string INSERTQUERY = @"INSERT INTO Staff (FirstName, LastName, DOB, BloodGroup, Gender, Occupation, Salary, JoiningDate, Shift, ContactNo, Email, Address, ProfileImg)
                                     VALUES (@FirstName, @LastName, @DOB, @BloodGroup, @Gender, @Occupation, @Salary, @JoiningDate, @Shift, @ContactNo, @Email, @Address, @ProfileImg)";

                    using (SqlCommand command = new SqlCommand(INSERTQUERY, connection))
                    {
                        command.Parameters.AddWithValue("@FirstName", FirstName);
                        command.Parameters.AddWithValue("@LastName", LastName);
                        command.Parameters.AddWithValue("@DOB", DOB);
                        command.Parameters.AddWithValue("@BloodGroup", BloodGroup);
                        command.Parameters.AddWithValue("@Gender", Gender);
                        command.Parameters.AddWithValue("@Occupation", Occupation);
                        command.Parameters.AddWithValue("@Salary", Salary);
                        command.Parameters.AddWithValue("@JoiningDate", JoiningDate);
                        command.Parameters.AddWithValue("@Shift", Shift);
                        command.Parameters.AddWithValue("@ContactNo", ContactNo);
                        command.Parameters.AddWithValue("@Email", Email);
                        command.Parameters.AddWithValue("@Address", Address);
                        command.Parameters.AddWithValue("@ProfileImg", ProfileImg);


                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Staff Record Saved Successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return true;
                        }
                        else
                        {
                            MessageBox.Show("Error occurred while saving staff record.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return false;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                    return false;
                }
            }
        }

        public bool UpdateStaffRecord()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string UPDATEQUERY = @"UPDATE Staff SET FirstName = @FirstName, LastName = @LastName, DOB = @DOB, 
                                         BloodGroup = @BloodGroup, Gender = @Gender, Occupation = @Occupation, 
                                         Salary = @Salary, JoiningDate = @JoiningDate, Shift = @Shift, 
                                         ContactNo = @ContactNo, Email = @Email, Address = @Address,
                                         ProfileImg = @ProfileImg WHERE StaffID = @StaffID";

                    using (SqlCommand command = new SqlCommand(UPDATEQUERY, connection))
                    {
                        command.Parameters.AddWithValue("@FirstName", FirstName);
                        command.Parameters.AddWithValue("@LastName", LastName);
                        command.Parameters.AddWithValue("@DOB", DOB);
                        command.Parameters.AddWithValue("@BloodGroup", BloodGroup);
                        command.Parameters.AddWithValue("@Gender", Gender);
                        command.Parameters.AddWithValue("@Occupation", Occupation);
                        command.Parameters.AddWithValue("@Salary", Salary);
                        command.Parameters.AddWithValue("@JoiningDate", JoiningDate);
                        command.Parameters.AddWithValue("@Shift", Shift);
                        command.Parameters.AddWithValue("@ContactNo", ContactNo);
                        command.Parameters.AddWithValue("@Email", Email);
                        command.Parameters.AddWithValue("@Address", Address);
                        command.Parameters.AddWithValue("@StaffID", StaffID);
                        command.Parameters.AddWithValue("@ProfileImg", ProfileImg);




                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Staff Record Updated Successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return true;
                        }
                        else
                        {
                            MessageBox.Show("An error occurred while updating staff record.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return false;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("A database error occurred while processing your request. Please contact support.", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
        }

        public static bool DeleteStaffRecord(int staffID)
        {
            using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.DBConnectionString))
            {
                try
                {
                    connection.Open();

                    string DELETEQuery = "DELETE FROM Staff WHERE StaffID = @StaffID";

                    using (SqlCommand command = new SqlCommand(DELETEQuery, connection))
                    {
                        command.Parameters.AddWithValue("@StaffID", staffID);

                        int rowsAffected = command.ExecuteNonQuery();

                        return rowsAffected > 0;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while deleting staff record: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
        }




        //SEARCH Method
        public List<StaffClass> SearchStaffRecord(string searchQuery)
        {
            List<StaffClass> searchResults = new List<StaffClass>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string query = "SELECT * FROM Staff WHERE FirstName LIKE @SearchQuery OR LastName LIKE @SearchQuery OR ContactNo LIKE @SearchQuery OR Email LIKE @SearchQuery";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@SearchQuery", "%" + searchQuery + "%");

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                StaffClass staff = new StaffClass
                                {
                                    StaffID = Convert.ToInt32(reader["StaffID"]),
                                    FirstName = reader["FirstName"].ToString(),
                                    LastName = reader["LastName"].ToString(),
                                    DOB = Convert.ToDateTime(reader["DOB"]),
                                    BloodGroup = reader["BloodGroup"].ToString(),
                                    Gender = reader["Gender"].ToString(),
                                    Occupation = reader["Occupation"].ToString(),
                                    Salary = reader["Salary"].ToString(),
                                    JoiningDate = Convert.ToDateTime(reader["JoiningDate"]),
                                    Shift = reader["Shift"].ToString(),
                                    ContactNo = reader["ContactNo"].ToString(),
                                    Email = reader["Email"].ToString(),
                                    Address = reader["Address"].ToString(),
                                    ProfileImg = reader["ProfileImg"].ToString()
                                };                        

                                searchResults.Add(staff);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while searching for staff records: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            return searchResults;
        }

    }
}
