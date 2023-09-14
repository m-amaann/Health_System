using Health_Care_Plus_System.Classes;
using Health_Care_Plus_System.Screen_Forms.EMR;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Health_Care_Plus_System.Screen_Forms.Patient
{
    public partial class PatientProfile : Form
    {
        private string connectionString = (Properties.Settings.Default.DBConnectionString);
        private PatientClass patientManager;
        private int selectedPatID;

        public PatientProfile(int patID)
        {
            InitializeComponent();
            patientManager = new PatientClass(connectionString);
            selectedPatID = patID;

            LoadPatientRecord();
         
        }

        public PatientProfile()
        {
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
                        DOBTextBox.Text = row["DOB"].ToString();
                        AddressTextBox.Text = row["Address"].ToString();
                        CityTextbox.Text = row["City"].ToString();
                        NICTextbox.Text = row["NIC"].ToString();
                        BloodgroupBox.Text = row["BloodGroup"].ToString();
                        ContactTextbox.Text = row["ContactNo"].ToString();
                        MedicalTextbox.Text = row["MedicalHistory"].ToString();
                        RegisterDateTextBox.Text = row["CreateAt"].ToString() ;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while loading patient record: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void PatientProfile_Load(object sender, EventArgs e)
        {

        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EMRecordBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddEMR addEMR = new AddEMR();
            addEMR.ShowDialog();
        }

        private void AppointmentBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
