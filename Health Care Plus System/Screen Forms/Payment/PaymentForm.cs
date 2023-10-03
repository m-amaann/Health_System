using Health_Care_Plus_System.Classes;
using Health_Care_Plus_System.Screen_Forms.Doctor;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Health_Care_Plus_System.Screen_Forms.Payment
{
    public partial class PaymentForm : Form
    {
        private string connectionString = Properties.Settings.Default.DBConnectionString; // connecting DB string statement

        PaymentClass paymentClass = new PaymentClass();

        public PaymentForm()
        {
            InitializeComponent();
        }

        private void PaymentForm_Load(object sender, EventArgs e)
        {
            LoadPaymentInvoiceRecord(); //called the method to display in data table
        }

        private void Addbutton_Click(object sender, EventArgs e)
        {
            AddPayment addPayment = new AddPayment();
            addPayment.Show();
        }

        private void Updatebutton_Click(object sender, EventArgs e)
        {
            if (PaymentDataGridview.SelectedRows.Count > 0)
            {
                int rowIndex = PaymentDataGridview.SelectedRows[0].Index;
                int BillingID = Convert.ToInt32(PaymentDataGridview.Rows[rowIndex].Cells["BillingID"].Value);

                this.Hide();
                UpdatePayment updatePayment = new UpdatePayment();
                updatePayment.Show();
               
            }
            else
            {
                MessageBox.Show("Please select a row to update.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void LoadPaymentInvoiceRecord()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT * FROM Payments";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);

                    PaymentDataGridview.DataSource = dataTable;
                }
            }
        }


      
        private void PaymentDataGridview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void SearchTextBox_TextChanged(object sender, EventArgs e)
        {
            string searchQuery = SearchTextBox.Text.Trim();
            DataTable dataTable = paymentClass.SearchPaymentInvoice(searchQuery);

            if (dataTable != null)
            {
                PaymentDataGridview.DataSource = dataTable;
            }
        }




        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (PaymentDataGridview.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show("Are you sure you want to delete this payment invoice record?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    int rowIndex = PaymentDataGridview.SelectedRows[0].Index;
                    int BillingID = Convert.ToInt32(PaymentDataGridview.Rows[rowIndex].Cells["BillingID"].Value);

                    PaymentClass paymentClass = new PaymentClass { BillingID = BillingID };

                    if (paymentClass.DeletePaymentInvoiceRecord())
                    {
                        MessageBox.Show("Payment Invoice record deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadPaymentInvoiceRecord();
                    }
                    else
                    {
                        MessageBox.Show("Failed to delete payment record.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a payment record to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
