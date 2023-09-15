using Health_Care_Plus_System.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Health_Care_Plus_System.Screen_Forms.Payment
{
    public partial class AddPayment : Form
    {
        private string connectionString = Properties.Settings.Default.DBConnectionString; // connecting DB string statement

        //initialize instance reference class
        PaymentClass paymentClass = new PaymentClass();


        private int currentInvoiceNumber; // Initialize with the starting invoice number



        public AddPayment()
        {
            InitializeComponent();


    }



    private void AddPayment_Load(object sender, EventArgs e)
        {
            // Generate and display a new invoice number in ascending order when the form loads
            GenerateInvoiceNumber();


            LoadPatientAndAppointment(); //call the method to show data's in Datagridtable
        }


        private void GenerateInvoiceNumber()
        {
            currentInvoiceNumber++;

            // Format the invoice number with leading zeros and "INV" prefix
            string invoiceNumber = $"INV{currentInvoiceNumber:000}";
            InvoiceNumberTextBox.Text = invoiceNumber;
        }


        private void InvoiceNumberTextBox_TextChanged(object sender, EventArgs e)
        {
     
        }


        private void LoadPatientAndAppointment()
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

                // Bind the DataTable to DataGridView
                PatAndAppointDataTable.DataSource = dataTable;
            }

        }

        private void PatAndAppointDataTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
