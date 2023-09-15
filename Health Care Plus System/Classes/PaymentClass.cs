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


        //  fields in the Payment table
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


        // Constructor
        public PaymentClass()
        {
        }



        //This method for Get and displayed patient and appointment in Data Grid Table
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






     /*   // Appointment Add Record Method
        public bool AddPayment()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string insertQuery = @"
                INSERT INTO Appointment (Specialization, DoctorName, PatID, PatientName, Appoint_Date, Appoint_Time, Note, Sender_Name, HospitalCharge, DoctorCharge, TotalFee)
                VALUES (@Specialization, @DoctorName, @PatID, @PatientName, @Appoint_Date, @Appoint_Time, @Note, @Sender_Name, @HospitalCharge, @DoctorCharge, @TotalFee)";

                    using (SqlCommand cmd = new SqlCommand(insertQuery, connection))
                    {
                        cmd.Parameters.AddWithValue("@Specialization", Specialization);
                        cmd.Parameters.AddWithValue("@DoctorName", DoctorName);
                        cmd.Parameters.AddWithValue("@PatID", PatID);
                        cmd.Parameters.AddWithValue("@PatientName", PatientName);
                        cmd.Parameters.AddWithValue("@Appoint_Date", Appoint_Date);
                        cmd.Parameters.AddWithValue("@Appoint_Time", Appoint_Time);
                        cmd.Parameters.AddWithValue("@Note", Note);
                        cmd.Parameters.AddWithValue("@Sender_Name", Sender_Name);
                        cmd.Parameters.AddWithValue("@HospitalCharge", HospitalCharge);
                        cmd.Parameters.AddWithValue("@DoctorCharge", DoctorCharge);
                        cmd.Parameters.AddWithValue("@TotalFee", TotalFee);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            return true; // Record added successfully
                        }
                        else
                        {
                            MessageBox.Show("Failed to add a appointment. No rows affected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return false;
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("SQL Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }*/
    }
}
