using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

                    string query = "SELECT PatID, FullName, NIC FROM Patient";

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

    }
}
