using Health_Care_Plus_System.Classes;
using iTextSharp.text.pdf;
using iTextSharp.text;
using Newtonsoft.Json.Linq;
using RestSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Policy;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Health_Care_Plus_System.Screen_Forms.Payment
{

    public partial class AddPayment : Form
    {
        private string connectionString = Properties.Settings.Default.DBConnectionString; // connecting DB string statement

        //initialize instance reference class
        private PaymentClass paymentClass = new PaymentClass();


        //initialize and declare table
        private DataTable patientappointmentTable;



        public AddPayment()
        {
            InitializeComponent();


        }



        private void AddPayment_Load(object sender, EventArgs e)
        {
           

            //called the method for display in DatagridTable
            LoadPatientAndAppointment();

        }





        //This method for displaying and align in Data grid table show
        private void LoadPatientAndAppointment()
        {
            patientappointmentTable = paymentClass.GetPatientAndAppointment();

            //DataTable to display patient and appointment column

            DataTable filteredPatientsTable = new DataTable();
            filteredPatientsTable.Columns.Add("PatID", typeof(int));
            filteredPatientsTable.Columns.Add("FullName", typeof(string));
            filteredPatientsTable.Columns.Add("Appointment_ID", typeof(int));
            filteredPatientsTable.Columns.Add("TotalFee", typeof(string));


            foreach (DataRow row in patientappointmentTable.Rows)
            {
                filteredPatientsTable.Rows.Add(row["PatID"], row["FullName"], row["Appointment_ID"], row["TotalFee"]);


                PatAndAppointDataTable.DataSource = filteredPatientsTable;
            }
        }




        //Data Gride Table
        private void PatAndAppointDataTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Check if a row is selected 
            if (e.RowIndex >= 0 && e.RowIndex < PatAndAppointDataTable.Rows.Count - 1)
            {
                DataGridViewRow selectedRow = PatAndAppointDataTable.Rows[e.RowIndex];

                // Get the patient name, patient ID, appointment ID, and appointment fees from the selected row
                string PatientID = selectedRow.Cells["PatID"].Value.ToString();
                string PatientName = selectedRow.Cells["FullName"].Value.ToString();


                //Called the Text boxes
                PatientNameTxtBox.Text = PatientName;
                PatIDTextBox1.Text = PatientID;

                LoadAppointmentIDsIntoComboBox(AppointmentIDComboBox);
            }
        }



        //Add button click Even handler 
        private void AddButton_Click(object sender, EventArgs e)
        {
            try
            {

                PaymentClass payment = new PaymentClass()
                {
                    PatientName = PatientNameTxtBox.Text,
                    PatID = int.Parse(PatIDTextBox1.Text),
                    Appointment_ID = int.Parse(AppointmentIDComboBox.Text),
                    Method = MethodComboBox.Text,
                    INV_Date = InvoiceNumberDatePicker.Value,
                    INV_No = InvoiceNumberTextBox.Text,
                    ServiceNote = ServiceTextbox.Text,
                    Appoinement_Fee = AppointmentchargeTextBox.Text,
                    RoomCharge = RoomTextBox.Text,
                    ResourceCharge = ResourceTextBox.Text,
                    TotalFee = ToalTextBox1.Text,
                    Discount = DiscountTextBox.Text,
                    TotalAmount = TotalBillingText.Text
                };

                // Call the AddPaymentInvoice method to insert the payment record
                bool success = payment.AddPaymentInvoice();

                if (success)
                {
                    MessageBox.Show("Add Payment Invoice Record Successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Failed to add an invoice.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }



        //This method for random generate invoice Numbers
        private string GenerateRandomInvoiceNumber()
        {

            Random rand = new Random();
            int randomNumber = rand.Next(1, 1000); 
            string invoiceNumber = $"INV{randomNumber:D3}";
            return invoiceNumber;
        }



        private void GenerateBtn_Click(object sender, EventArgs e)
        {
            // Generate a random invoice number and display it in the TextBox
            string invoiceNumber = GenerateRandomInvoiceNumber();
            InvoiceNumberTextBox.Text = invoiceNumber;
        }



        //this method for selecting a appointment id by patient name and ids
        public void LoadAppointmentIDsIntoComboBox(ComboBox comboBox)
        {
            try
            {
                // Clear the ComboBox before adding new items
                comboBox.Items.Clear();

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT Appointment_ID FROM Appointment WHERE PatID = @PatID";
                    Console.WriteLine("SQL Query: " + query); // Log the query

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@PatID", PatIDTextBox1.Text); // actual patient ID

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                AppointmentIDComboBox.Items.Add(reader["Appointment_ID"].ToString());
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
            }
        }


        //display and calculte method 
        private void CalculateAndDisplayTotal()
        {
            try
            {
                if (double.TryParse(AppointmentchargeTextBox.Text, out double appointmentCharge) &&
                    double.TryParse(RoomTextBox.Text, out double roomCharge) &&
                    double.TryParse(ResourceTextBox.Text, out double resourceCharge))
                {
                    double totalCharge = appointmentCharge + roomCharge + resourceCharge;

                    TotalBillingText.Text =  totalCharge.ToString("0.00");
                    ToalTextBox1.Text = totalCharge.ToString("0.00");
                }
                else
                {
                    TotalBillingText.Text = "0.00";
                }
            }
            catch (FormatException ex)
            {
                TotalBillingText.Text = "0.00";
                Console.WriteLine("Exception: " + ex.Message);
            }
        }




        //This calculates the discount method
        private void CalculateDiscountedTotal()
        {
            try
            {
                double totalFee = double.Parse(ToalTextBox1.Text);

                // Extract the percentage value from the DiscountTextBox using regular expressions
                Match match = Regex.Match(DiscountTextBox.Text, @"\d+(\.\d+)?%");

                if (match.Success)
                {
                    string percentageStr = match.Value.TrimEnd('%');
                    double discountPercentage = double.Parse(percentageStr);

                    double discountAmount = (totalFee * discountPercentage) / 100;
                    double discountedTotalAmount = totalFee - discountAmount;

                    TotalBillingText.Text = "Rs." + discountedTotalAmount.ToString("0.00");
                }
                else
                {
                    TotalBillingText.Text = "Invalid input";
                }
            }
            catch (FormatException ex)
            {
                TotalBillingText.Text = "Invalid input";
                Console.WriteLine("Exception: " + ex.Message);
            }
        }





        private void ToalTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void DiscountTextBox_TextChanged(object sender, EventArgs e)
        {
            CalculateDiscountedTotal();
        }

        private void TotalBillingText_Click(object sender, EventArgs e)
        {

        }

        private void AppointmentchargeTextBox_TextChanged(object sender, EventArgs e)
        {
            CalculateAndDisplayTotal();
        }

        private void RoomTextBox_TextChanged(object sender, EventArgs e)
        {
            CalculateAndDisplayTotal();

        }

        private void ResourceTextBox_TextChanged(object sender, EventArgs e)
        {
            CalculateAndDisplayTotal();

        }





        private void GeneratePDFInvoice(string invoiceNumber, string patientName, string totalAmount)
        {
            Document doc = new Document();

            // Set the file path for the PDF invoice
            string filePath = "Invoice_" + invoiceNumber + ".pdf";

            PdfWriter.GetInstance(doc, new FileStream(filePath, FileMode.Create));
            doc.Open();

            // Create the PDF content
            doc.Add(new Paragraph("Payment Invoice Details"));
            doc.Add(new Paragraph("Invoice Number: " + invoiceNumber));
            doc.Add(new Paragraph("Patient Name: " + patientName));

            // Add the rest of the payment details here as needed
            doc.Add(new Paragraph("Total Amount: " + totalAmount));

            doc.Close();

            MessageBox.Show("Invoice PDF generated and saved as " + filePath, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Open the generated PDF invoice
            System.Diagnostics.Process.Start(filePath);
        }




        private void PrintInvoiceBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string invoiceNumber = InvoiceNumberTextBox.Text;
                string patientName = PatientNameTxtBox.Text;
                string totalAmount = TotalBillingText.Text;

                // Generate the PDF invoice
                GeneratePDFInvoice(invoiceNumber, patientName, totalAmount);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }
    }







     
}
