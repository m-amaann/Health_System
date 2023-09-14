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

namespace Health_Care_Plus_System.Screen_Forms.Medication
{
    public partial class PrescriptionForm : Form
    {
        private string connectionString = Properties.Settings.Default.DBConnectionString; // connecting DB string statement



        PrescriptionClass prescriptionClass = new PrescriptionClass();
        public PrescriptionForm()
        {
            InitializeComponent();
        }

        private void Addbutton_Click(object sender, EventArgs e)
        {
            AddPrescription addPrescription = new AddPrescription();
            addPrescription.ShowDialog();

        }

        private void SearchTextBox_TextChanged(object sender, EventArgs e)
        {
            string searchQuery = SearchTextBox.Text.Trim();
            DataTable dataTable = prescriptionClass.SearchPrescription(searchQuery);

            if (dataTable != null)
            {
                PrescriptionDataGridview.DataSource = dataTable;
            }
        }




        private void PrescriptionForm_Load(object sender, EventArgs e)
        {
            LoadPrescriptionRecord();
        }


        private void LoadPrescriptionRecord()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT * FROM Prescription"; // Prescription name is DB table


                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);

                    PrescriptionDataGridview.DataSource = dataTable; // PrescriptionDataGridview is name of Table 
                }
            }
        }
    }
}




