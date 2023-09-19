using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Health_Care_Plus_System.Classes
{
    public class ResourceClass
    {
        // Database connection string
        private string connectionString = Properties.Settings.Default.DBConnectionString;

        public int ResourceID { get; set; }
        public string Name { get; set; }
        public string ResourceType { get; set; }
        public string Location { get; set; }
        public string Availability { get; set; }
        public string SerialNo { get; set; }
        public string Model { get; set; }
        public DateTime PurchasedDate { get; set; }
        public string ContactNo { get; set; }


        // Constructor
        public ResourceClass()
        {
        }




        // Method to get a resource by its ID from the DB
        public ResourceClass GetResourceByID(int ResourceID)
        {
            ResourceClass resource = null;
            SqlConnection con = new SqlConnection(connectionString);

            try
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandText = "SELECT * FROM Resources WHERE ResourceID = @ResourceID";
                cmd.Parameters.AddWithValue("@ResourceID", ResourceID);

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        resource = new ResourceClass
                        {
                            ResourceID = Convert.ToInt32(reader["ResourceID"]),
                            Name = reader["Name"].ToString(),
                            ResourceType = reader["ResourceType"].ToString(),
                            Location = reader["Location"].ToString(),
                            Availability = reader["Availability"].ToString(),
                            SerialNo = reader["SerialNo"].ToString(),
                            Model = reader["Model"].ToString(),
                            PurchasedDate = Convert.ToDateTime(reader["PurchasedDate"]),
                            ContactNo = reader["ContactNo"].ToString(),
                        };
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while retrieving a resource record: " + ex.Message);
            }
            finally
            {
                con.Close();
            }

            return resource;
        }







        // Add Resource Record Method
        public bool AddResourceRecord()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string INSERTQUERY = "INSERT INTO Resources (Name, ResourceType, Location, Availability, SerialNo, Model, PurchasedDate, ContactNo) " +
                                      "VALUES (@Name, @ResourceType, @Location, @Availability, @SerialNo, @Model, @PurchasedDate, @ContactNo)";

                    using (SqlCommand cmd = new SqlCommand(INSERTQUERY, connection))
                    {
                        cmd.Parameters.AddWithValue("@Name", Name);
                        cmd.Parameters.AddWithValue("@ResourceType", ResourceType);
                        cmd.Parameters.AddWithValue("@Location", Location);
                        cmd.Parameters.AddWithValue("@Availability", Availability);
                        cmd.Parameters.AddWithValue("@SerialNo", SerialNo);
                        cmd.Parameters.AddWithValue("@Model", Model);
                        cmd.Parameters.AddWithValue("@PurchasedDate", PurchasedDate);
                        cmd.Parameters.AddWithValue("@ContactNo", ContactNo);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        return rowsAffected > 0;
                    }
                }
                catch (Exception)
                {
                    return false;
                }
            }
        }








        // Update Resource Method
        public bool UpdateResourceRecord()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string UPDATEQUERY = "UPDATE Resources SET Name = @Name, ResourceType = @ResourceType, Location = @Location, " +
                                      "Availability = @Availability, SerialNo = @SerialNo, Model = @Model, " +
                                      "PurchasedDate = @PurchasedDate, ContactNo = @ContactNo WHERE ResourceID = @ResourceID";

                    using (SqlCommand cmd = new SqlCommand(UPDATEQUERY, connection))
                    {
                        cmd.Parameters.AddWithValue("@ResourceID", ResourceID);
                        cmd.Parameters.AddWithValue("@Name", Name);
                        cmd.Parameters.AddWithValue("@ResourceType", ResourceType);
                        cmd.Parameters.AddWithValue("@Location", Location);
                        cmd.Parameters.AddWithValue("@Availability", Availability);
                        cmd.Parameters.AddWithValue("@SerialNo", SerialNo);
                        cmd.Parameters.AddWithValue("@Model", Model);
                        cmd.Parameters.AddWithValue("@PurchasedDate", PurchasedDate);
                        cmd.Parameters.AddWithValue("@ContactNo", ContactNo);


                        int rowsAffected = cmd.ExecuteNonQuery();

                        return rowsAffected > 0;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("An error occurred while updating a resource record: " + ex.Message);
                    return false;
                }
                finally
                {
                    connection.Close();
                }
            }
        }






        // DELETE RESOURCES METHODS
        public static bool DeleteResourceRecord(int resourceID)
        {
            using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.DBConnectionString))
            {
                try
                {
                    connection.Open();

                    string DELETEQuery = "DELETE FROM Resources WHERE ResourceID = @ResourceID";

                    using (SqlCommand command = new SqlCommand(DELETEQuery, connection))
                    {
                        command.Parameters.AddWithValue("@ResourceID", resourceID);

                        int rowsAffected = command.ExecuteNonQuery();

                        return rowsAffected > 0;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while deleting resource record: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
        }




        // Search method to get all active resources
        public List<ResourceClass> SearchResourceRecord(string searchQuery)
        {
            List<ResourceClass> searchResults = new List<ResourceClass>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string query = "SELECT * FROM Resources WHERE Name LIKE @SearchQuery OR ResourceType LIKE @SearchQuery OR SerialNo LIKE @SearchQuery";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@SearchQuery", "%" + searchQuery + "%");

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                ResourceClass resourceClass = new ResourceClass
                                {
                                    ResourceID = Convert.ToInt32(reader["ResourceID"]),
                                    Name = reader["Name"].ToString(),
                                    ResourceType = reader["ResourceType"].ToString(),
                                    Location = reader["Location"].ToString(),
                                    Availability = reader["Availability"].ToString(),
                                    SerialNo = reader["SerialNo"].ToString(),
                                    Model = reader["Model"].ToString(),
                                    PurchasedDate = Convert.ToDateTime(reader["PurchasedDate"]),
                                    ContactNo = reader["ContactNo"].ToString(),
                                };

                                searchResults.Add(resourceClass);
                            }
                        }
                    }
                    Console.WriteLine("Resource search completed.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("An error occurred while searching for resources records: " + ex.Message);
                }
            }

            return searchResults;
        }








        // This method to display retrieve the resource record in Table
        public bool LoadResourcesRecord()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string query = "SELECT * FROM Resources WHERE ResourceID = @ResourceID";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@ResourceID", ResourceID);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                ResourceID = Convert.ToInt32(reader["ResourceID"]);
                                Name = reader["Name"].ToString();
                                ResourceType = reader["ResourceType"].ToString();
                                Location = reader["Location"].ToString();
                                Availability = reader["Availability"].ToString();
                                SerialNo = reader["SerialNo"].ToString();
                                Model = reader["Model"].ToString();
                                PurchasedDate = Convert.ToDateTime(reader["PurchasedDate"]);
                                ContactNo = reader["ContactNo"].ToString();

                                Console.WriteLine("Resource data loaded successfully.");
                                return true;
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("An error occurred while loading resource data: " + ex.Message);
                }
            }
            return false;
        }


    }
}
