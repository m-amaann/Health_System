using Health_Care_Plus_System.Classes;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
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
        // connecting DB string statement
        private string connectionString = Properties.Settings.Default.DBConnectionString;

        //initialize instance reference class
        private PaymentClass paymentClass = new PaymentClass();


        // Initialize with the starting invoice number
        private int currentInvoiceNumber; 


        //initialize and declare table
        private DataTable patientappointmentTable;


        public AddPayment()
        {
            InitializeComponent();


    }



    private void AddPayment_Load(object sender, EventArgs e)
        {
            // Generate and display a new invoice number in ascending order when the form loads
            GenerateInvoiceNumber();


            //called the method for display in DatagridTable
            LoadPatientAndAppointment();


        }

        //This method for generate invoice Numbers
        private void GenerateInvoiceNumber()
        {
            currentInvoiceNumber++;

            // Format the invoice number with leading zeros and "INV" prefix
            string invoiceNumber = $"INV{currentInvoiceNumber:000}";
            InvoiceNumberTextBox.Text = invoiceNumber;
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






        private void InvoiceNumberTextBox_TextChanged(object sender, EventArgs e)
        {
     
        }


       
        //Data Gride Table
        private void PatAndAppointDataTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Check if a row is selected 
            if (e.RowIndex >= 0 && e.RowIndex < PatAndAppointDataTable.Rows.Count - 1)
            {
                DataGridViewRow selectedRow = PatAndAppointDataTable.Rows[e.RowIndex];

                // Get the patient name, patient ID, appointment ID, and appointment fees from the selected row
                string PatientName = selectedRow.Cells["FullName"].Value.ToString();
                string PatientID = selectedRow.Cells["PatID"].Value.ToString();
                string AppointmentTotalCharge = selectedRow.Cells["TotalFee"].Value.ToString();


                //Called the Text boxes
                PatientNameTextbox.Text = PatientName;
                PatientIDTextBox.Text = PatientID;
                AppointmentchargeTextBox.Text = AppointmentTotalCharge;
            }
        }


        private void CalculateAndDisplayTotal()
        {
            try
            {
                double appointmentCharge = double.Parse(AppointmentchargeTextBox.Text);
                double roomCharge = double.Parse(RoomTextBox.Text);
                double resourceCharge = double.Parse(ResourceTextBox.Text);

                double totalCharge = appointmentCharge + roomCharge + resourceCharge;

                // Display the total charge with "Rs."
                TotalBillingText.Text = "Rs." + totalCharge.ToString("0.00");
                ToalTextBox1.Text = "Rs." + totalCharge;
            }
            catch (FormatException ex)
            {
                // Handle invalid input gracefully and print the exception message for debugging
                TotalBillingText.Text = "Rs.0.00";
                Console.WriteLine("Exception: " + ex.Message);
            }
        }

        private void AppointmentchargeTextBox_TextChanged(object sender, EventArgs e)
        {
            CalculateAndDisplayTotal();
        }

        private void RoomTextBox_TextChanged(object sender, EventArgs e)
        {
            CalculateAndDisplayTotal();

        }

        private void AddButton_Click(object sender, EventArgs e)
        {

        }

        private void ResourceTextBox_TextChanged(object sender, EventArgs e)
        {
            CalculateAndDisplayTotal();
        }

        private void DiscountTextBox_TextChanged(object sender, EventArgs e)
        {
            CalculateDiscountedTotal();
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

                    // Calculate the discounted total amount based on the percentage
                    double discountAmount = (totalFee * discountPercentage) / 100;
                    double discountedTotalAmount = totalFee - discountAmount;

                    // Display the discounted total amount with "Rs."
                    TotalBillingText.Text = "Rs." + discountedTotalAmount.ToString("0.00");
                }
               
            }
            catch (FormatException ex)
            {
                // Handle invalid input gracefully and print the exception message for debugging
                TotalBillingText.Text = "Invalid input";
                Console.WriteLine("Exception: " + ex.Message);
            }
        }
    }
}
