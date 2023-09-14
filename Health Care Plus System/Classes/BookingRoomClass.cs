using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Health_Care_Plus_System.Classes
{
    public class BookingRoomClass
    {
        private string connectionString = Properties.Settings.Default.DBConnectionString; // connecting DB string statement



        //  Get Room Record Method for in Booking Room Method
        public DataTable GetPatients()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT PatID, PatientName, Appointment_ID FROM Appointment";

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




        //Get Room Booking Data's to retrieve all record table
        public DataTable GetBookingRooms()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT * FROM RoomBooking";

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





        public void RecordRoomBooking(int RoomTheaterID, int PatID, int Appointment_ID, DateTime BookingFromDate, DateTime BookingEndDate)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Begin a transaction to ensure atomic updates
                SqlTransaction transaction = connection.BeginTransaction();

                try
                {
                    // Update RoomTheaterAvailability to mark the room as booked
                    string updateQuery = @"
                                UPDATE Rooms 
                                    SET 
                                        Status = 'Scheduled',
                                        Current_Patient = @PatID 
                                    WHERE RoomTheaterID = @RoomTheaterID";

                    using (SqlCommand updateCommand = new SqlCommand(updateQuery, connection, transaction))
                    {
                        updateCommand.Parameters.AddWithValue("@RoomTheaterID", RoomTheaterID);
                        updateCommand.Parameters.AddWithValue("@PatID", PatID);

                        int updateRowsAffected = updateCommand.ExecuteNonQuery();

                        if(updateRowsAffected <= 0)
                        {
                            // If the update fails, roll back the transaction and show an error message
                            transaction.Rollback();
                            MessageBox.Show("Failed to update room/theater availability.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }




                    // Record the room booking in the RoomBookings table
                    string insertQuery = @"
                                    INSERT INTO RoomBooking (RoomTheaterID, PatID, Appointment_ID, BookingFromDate, BookingEndDate)
                                    VALUES (@RoomTheaterID, @PatID, @Appointment_ID, @BookingFromDate, @BookingEndDate)";


                    using (SqlCommand insertCommand = new SqlCommand(insertQuery, connection, transaction))
                    {
                        insertCommand.Parameters.AddWithValue("@RoomTheaterID", RoomTheaterID);
                        insertCommand.Parameters.AddWithValue("@PatID", PatID);
                        insertCommand.Parameters.AddWithValue("@Appointment_ID", Appointment_ID);
                        insertCommand.Parameters.AddWithValue("@BookingFromDate", BookingFromDate);
                        insertCommand.Parameters.AddWithValue("@BookingEndDate", BookingEndDate);

                        int insertRowsAffected = insertCommand.ExecuteNonQuery();

                        if (insertRowsAffected > 0)
                        {
                            
                            transaction.Commit(); // If everything is successful, commit the transaction
                        }
                        else
                        {
                            // If the insert fails, roll back the transaction and show an error message
                            transaction.Rollback();
                            MessageBox.Show("Failed to record room booking.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    // Handle any exceptions that occur during the transaction
                    transaction.Rollback();
                    MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }



        public bool DeleteBookRoom(int bookingID)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string deleteQuery = "DELETE FROM RoomBooking WHERE BookingID = @BookingID";

                using (SqlCommand command = new SqlCommand(deleteQuery, connection))
                {
                    command.Parameters.AddWithValue("@BookingID", bookingID);

                    int rowsAffected = command.ExecuteNonQuery();

                    return rowsAffected > 0;
                }
            }
        }




    }
}
