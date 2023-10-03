using Health_Care_Plus_System.Classes;
using Health_Care_Plus_System.Screen_Forms.Patient;
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

namespace Health_Care_Plus_System.Screen_Forms.EMR
{
    public partial class AddEMR : Form
    {
        private string connectionString = (Properties.Settings.Default.DBConnectionString);
        private PatientClass patientManager;
        private int selectedPatID;




        public AddEMR(int patID)
        {
            InitializeComponent();

            patientManager = new PatientClass(connectionString);
            selectedPatID = patID;

            LoadPatientRecord();
            LoadPatientAppointmentRecords();
            LoadPatientMedicationsRecords();
            LoadPaymentInvoiceRecords();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void PatientDataGrideView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
            PatientProfile patientProfile = new PatientProfile();
            patientProfile.ShowDialog();
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();

        }



        private void LoadPatientRecord()
        {
            try
            {
                DataTable patientTable = patientManager.GetPatients();
                foreach (DataRow row in patientTable.Rows)
                {
                    if ((int)row["PatID"] == selectedPatID)
                    {
                        FullnameTextbox.Text = row["FullName"].ToString();
                        GenderComboBox.Text = row["Gender"].ToString();
                        EmailTextbox.Text = row["Email"].ToString();
                        DOBDateTimePicker.Value = (DateTime)row["DOB"];
                        AddressTextbox.Text = row["Address"].ToString();
                        CityTextbox.Text = row["City"].ToString();
                        NICTextbox.Text = row["NIC"].ToString();
                        BloodgroupComboBox.Text = row["BloodGroup"].ToString();
                        ContactTextbox.Text = row["ContactNo"].ToString();
                        VisitedTextBox1.Text = row["CreateAt"].ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while loading patient record: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }





        private void PatientDataGrideView_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void AddEMR_Load(object sender, EventArgs e)
        {
           
        }


        private void LoadPatientAppointmentRecords()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT * FROM Appointment where PatID = @PatID"; 

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@PatID", selectedPatID);

                    SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);

                    PatientDataGrideView.DataSource = dataTable; //  dataGridView1 is the name of your DataGridView control
                }
            }
        }

        private void LoadPatientMedicationsRecords()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT * FROM Prescription where PatID = @PatID"; 

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@PatID", selectedPatID);

                    SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);

                    MedicationGridTable.DataSource = dataTable; 
                }
            }
        }


        private void LoadPaymentInvoiceRecords()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT * FROM Payments where PatID = @PatID";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@PatID", selectedPatID);

                    SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);

                    PaymentInvoiceDataGridView1.DataSource = dataTable; 
                }
            }
        }

    }
}
