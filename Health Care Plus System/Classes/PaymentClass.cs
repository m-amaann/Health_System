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
    public class PaymentClass
    {
        private string connectionString = Properties.Settings.Default.DBConnectionString; // connecting DB string statement


        // fields in the Payment table
        public int BillingID { get; set; }
        public string PatientName { get; set; }
        public int PatID { get; set; }
        public int Appointment_ID { get; set; }
        public string Method { get; set; }
        public DateTime INV_Date { get; set; }
        public string INV_No { get; set; }
        public string ServiceNote { get; set; }
        public string Appoinement_Fee { get; set; }
        public string RoomCharge { get; set; }
        public string ResourceCharge { get; set; }
        public string TotalFee { get; set; }
        public string Discount { get; set; }
        public string TotalAmount { get; set; }



        // Constructor
        public PaymentClass()
        {

        }



        // Method to get a payment by its ID from the DB
        public PaymentClass GetPaymentByID(int BillingID)
        {
            PaymentClass payment = null;
            SqlConnection con = new SqlConnection(connectionString);

            try
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandText = "SELECT * FROM Payments WHERE BillingID = @BillingID";
                cmd.Parameters.AddWithValue("@BillingID", BillingID);

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        payment = new PaymentClass
                        {
                            BillingID = Convert.ToInt32(reader["BillingID"]),
                            PatientName = reader["PatientName"].ToString(),
                            PatID = Convert.ToInt32(reader["PatID"]),
                            Appointment_ID = Convert.ToInt32(reader["Appointment_ID"]),
                            Method = reader["Method"].ToString(),
                            INV_Date = Convert.ToDateTime(reader["INV_Date"]),
                            INV_No = reader["INV_No"].ToString(),
                            ServiceNote = reader["ServiceNote"].ToString(),
                            Appoinement_Fee = reader["Appoinement_Fee"].ToString(),
                            RoomCharge = reader["RoomCharge"].ToString(),
                            ResourceCharge = reader["ResourceCharge"].ToString(),
                            TotalFee = reader["TotalFee"].ToString(),
                            Discount = reader["Discount"].ToString(),
                            TotalAmount = reader["TotalAmount"].ToString()
                        };
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while retrieving a payment invoice record: " + ex.Message);
            }
            finally
            {
                con.Close();
            }

            return payment;
        }




        //This method for Get and displayed patient Rectd in Data Grid Table in Addpayment Form 
        public DataTable GetPatientRecord()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = @"SELECT PatID, FullName, ContactNo FROM Patient";

                    

                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);


                    return dataTable;
                   
                }
            }
            catch (Exception)
            {
                throw;
            }        
        }






        // Payment Invoice Add Record Method
        public bool AddPaymentInvoice()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string insertQuery = @"
                        INSERT INTO Payments (PatientName, PatID, Appointment_ID, Method, INV_Date, INV_No, ServiceNote, Appoinement_Fee, RoomCharge, ResourceCharge, TotalFee, Discount, TotalAmount)
                        VALUES (@PatientName, @PatID, @Appointment_ID, @Method, @INV_Date, @INV_No, @ServiceNote, @Appoinement_Fee, @RoomCharge, @ResourceCharge, @TotalFee, @Discount, @TotalAmount)";

                    using (SqlCommand cmd = new SqlCommand(insertQuery, connection))
                    {
                        cmd.Parameters.AddWithValue("@PatientName", PatientName);
                        cmd.Parameters.AddWithValue("@PatID", PatID);
                        cmd.Parameters.AddWithValue("@Appointment_ID", Appointment_ID);
                        cmd.Parameters.AddWithValue("@Method", Method);
                        cmd.Parameters.AddWithValue("@INV_Date", INV_Date);
                        cmd.Parameters.AddWithValue("@INV_No", INV_No);
                        cmd.Parameters.AddWithValue("@ServiceNote", ServiceNote);
                        cmd.Parameters.AddWithValue("@Appoinement_Fee", Appoinement_Fee);
                        cmd.Parameters.AddWithValue("@RoomCharge", RoomCharge);
                        cmd.Parameters.AddWithValue("@ResourceCharge", ResourceCharge);
                        cmd.Parameters.AddWithValue("@TotalFee", TotalFee);
                        cmd.Parameters.AddWithValue("@Discount", Discount);
                        cmd.Parameters.AddWithValue("@TotalAmount", TotalAmount);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            return true; // Record added successfully
                        }
                        else
                        {
                            MessageBox.Show("Failed to add a payment invoice. No rows affected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return false;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }







        // Search Payment Method From DB
        public DataTable SearchPaymentInvoice(string searchQuery)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT * FROM Payments WHERE BillingID LIKE @SearchQuery " +
                        "OR PatientName LIKE @SearchQuery " +
                        "OR PatID LIKE @SearchQuery " +
                        "OR Appointment_ID LIKE @SearchQuery " +
                        "OR INV_No LIKE @SearchQuery";

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






        // DELETE PAYMENT INVOICE RECORD METHOD
        public bool DeletePaymentInvoiceRecord()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string deleteQuery = "DELETE FROM Payments WHERE BillingID = @BillingID";

                    using (SqlCommand command = new SqlCommand(deleteQuery, connection))
                    {
                        command.Parameters.AddWithValue("@BillingID", BillingID);

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






        // This method to display retrieve the update billing form record in Table
        public bool LoadPaymentRecord()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string query = "SELECT * FROM Payment WHERE BillingID = @BillingID";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@BillingID", BillingID);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                PatientName = reader["PatientName"].ToString();
                                PatID = Convert.ToInt32(reader["PatID"]);
                                Appointment_ID = Convert.ToInt32(reader["Appointment_ID"]);
                                Method = reader["Method"].ToString();
                                INV_Date = Convert.ToDateTime(reader["INV_Date"].ToString());
                                INV_No = reader["INV_No"].ToString();
                                ServiceNote = reader["ServiceNote"].ToString();
                                Appoinement_Fee = reader["Appoinement_Fee"].ToString();
                                RoomCharge = reader["RoomCharge"].ToString();
                                ResourceCharge = reader["ResourceCharge"].ToString();
                                TotalFee = reader["TotalFee"].ToString();
                                Discount = reader["Discount"].ToString();
                                TotalAmount = reader["TotalAmount"].ToString();

                                Console.WriteLine("Payment Invoice Record Has Been Loaded Successful.");
                                return true;
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("An error occurred while loading payment invoce record: " + ex.Message);
                }
            }
            return false;
        }

        public DataTable GetPatientAndAppointment()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = @"
                    SELECT A.Appointment_ID, P.PatID, P.FullName, A.TotalFee
                    FROM Appointment A
                    LEFT JOIN Patient P ON A.PatID = P.PatID";

                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);


                    return dataTable;

                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}