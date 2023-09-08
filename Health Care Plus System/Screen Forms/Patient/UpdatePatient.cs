using Health_Care_Plus_System.Classes;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Health_Care_Plus_System.Screen_Forms.Patient
{
    public partial class UpdatePatient : Form
    {

        private string connectionString = (Properties.Settings.Default.DBConnectionString);
        private PatientClass patientManager;
        private int selectedPatID;


        public UpdatePatient(int patID)
        {
            InitializeComponent();

            patientManager = new PatientClass(connectionString);
            selectedPatID = patID;

            LoadPatientRecord();
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
                        MedicalTextbox.Text = row["MedicalHistory"].ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while loading patient record: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void Updatebutton_Click(object sender, EventArgs e)
        {
            try
            {
                // Get the updated values from the form 
                string fullName = FullnameTextbox.Text;
                string gender = GenderComboBox.Text;
                string email = EmailTextbox.Text;
                DateTime dob = DOBDateTimePicker.Value;
                string address = AddressTextbox.Text;
                string city = CityTextbox.Text;
                string nic = NICTextbox.Text;
                string bloodGroup = BloodgroupComboBox.Text;
                string contactNo = ContactTextbox.Text;
                string medicalHistory = MedicalTextbox.Text;

                // Call the UpdatePatient method to update the patient record 
                if (patientManager.UpdatePatient(selectedPatID, fullName, gender, email, dob, address, city, nic, bloodGroup, contactNo, medicalHistory))
                {
                    MessageBox.Show("Patient Record updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);


                    Close();               

                }
                else
                {
                    MessageBox.Show("Failed to update patient record.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while updating patient record: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }

        private void UpdatePatient_Load(object sender, EventArgs e)
        {

        }
    }
}
