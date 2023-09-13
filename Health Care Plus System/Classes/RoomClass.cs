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
    public class RoomClass
    {
        private string connectionString = Properties.Settings.Default.DBConnectionString; // connecting DB string statement


        public int RoomTheaterID { get; set; }
        public string RoomTheater_No { get; set; }
        public string Type { get; set; }
        public string Scheduled_Procedure { get; set; }
        public int Current_Patient { get; set; }
        public string Status { get; set; }






        // Get Room by ID Method
        public static RoomClass GetRoomByID(int RoomTheaterID)
        {
            RoomClass roomClass = null;
            SqlConnection con = new SqlConnection(Properties.Settings.Default.DBConnectionString);

            try
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandText = "SELECT * FROM Rooms WHERE RoomTheaterID = @RoomTheaterID";
                cmd.Parameters.AddWithValue("@RoomTheaterID", RoomTheaterID);

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        roomClass = new RoomClass
                        {
                            RoomTheaterID = Convert.ToInt32(reader["RoomTheaterID"]),
                            RoomTheater_No = reader["RoomTheater_No"].ToString(),
                            Type = reader["Type"].ToString(),
                            Scheduled_Procedure = reader["Scheduled_Procedure"].ToString(),             
                            Current_Patient = Convert.ToInt32(reader["Current_Patient"]),
                            Status = reader["Status"].ToString(),
                        };
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while retrieving an add room record: " + ex.Message);
            }
            finally
            {
                con.Close();
            }

            return roomClass;
        }








        // Appointment Add Record Method
        public bool AddRoomRecord()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string insertQuery = @"
                INSERT INTO Rooms (RoomTheater_No, Type, Scheduled_Procedure, Status)
                VALUES (@RoomTheater_No, @Type, @Scheduled_Procedure, @Status)";

                    using (SqlCommand cmd = new SqlCommand(insertQuery, connection))
                    {
                        cmd.Parameters.AddWithValue("@RoomTheater_No", RoomTheater_No);
                        cmd.Parameters.AddWithValue("@Type", Type);
                        cmd.Parameters.AddWithValue("@Scheduled_Procedure", Scheduled_Procedure);
                        cmd.Parameters.AddWithValue("@Status", Status);
                      

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








        // Room Update Record Method
        // Room Update Record Method
        public bool UpdateRoomsRecord()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string updateQuery = @"
                UPDATE Rooms SET 
                    RoomTheater_No = @RoomTheater_No, 
                    Type = @Type, 
                    Scheduled_Procedure = @Scheduled_Procedure, 
                    Status = @Status
                WHERE RoomTheaterID = @RoomTheaterID";

                    using (SqlCommand cmd = new SqlCommand(updateQuery, connection))
                    {
                        cmd.Parameters.AddWithValue("@RoomTheaterID", RoomTheaterID);
                        cmd.Parameters.AddWithValue("@RoomTheater_No", RoomTheater_No);
                        cmd.Parameters.AddWithValue("@Type", Type);
                        cmd.Parameters.AddWithValue("@Scheduled_Procedure", Scheduled_Procedure);
                        cmd.Parameters.AddWithValue("@Status", Status);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        return rowsAffected > 0;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("An error occurred while updating a room record: " + ex.Message);
                    return false;
                }
                finally
                {
                    connection.Close();
                }
            }
        }








        // DELETE ROOMS RECORD METHOD
        public bool DeleteRoomRecord()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string deleteQuery = "DELETE FROM Rooms WHERE RoomTheaterID = @RoomTheaterID";

                    using (SqlCommand command = new SqlCommand(deleteQuery, connection))
                    {
                        command.Parameters.AddWithValue("@RoomTheaterID", RoomTheaterID);

                        int rowsAffected = command.ExecuteNonQuery();

                        return rowsAffected > 0;
                    }
                }
            }
            catch (Exception)
            {
                return false;
            }

        }







        // Search Appointment Method From DB
        public DataTable SearchRoomRecord(string searchQuery)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT * FROM Rooms WHERE RoomTheater_No LIKE @SearchQuery " +
                        "OR Type LIKE @SearchQuery " +
                        "OR Scheduled_Procedure LIKE @SearchQuery " +
                        "OR Current_Patient LIKE @SearchQuery " +
                        "OR Status LIKE @SearchQuery";

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








        // This method to display retrieve the update rooms form record in Table
        public bool LoadRoomsRecord()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string query = "SELECT * FROM Rooms WHERE RoomTheaterID = @RoomTheaterID";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@RoomTheaterID", RoomTheaterID);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                RoomTheaterID = Convert.ToInt32(reader["RoomTheaterID"]);
                                RoomTheater_No = reader["RoomTheater_No"].ToString();
                                Type = reader["Type"].ToString();
                                Scheduled_Procedure = reader["Scheduled_Procedure"].ToString();
                                Current_Patient = Convert.ToInt32(reader["Current_Patient"]);
                                Status = reader["Status"].ToString();

                                Console.WriteLine("Room Record Loaded Successful.");
                                return true;
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("An error occurred while loading room data: " + ex.Message);
                }
            }
            return false;
        }






    }
}
