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
using System.Windows.Controls;
using System.Windows.Forms;

namespace Health_Care_Plus_System.Screen_Forms.Patient
{
    public partial class AddPatient : Form
    {
        private string connectionString = (Properties.Settings.Default.DBConnectionString);
        private PatientClass patientManager;


        public AddPatient()
        {
            InitializeComponent();

            patientManager = new PatientClass(connectionString);

        }


        private void AddPatient_Load(object sender, EventArgs e)
        {
            
        }

        private void BackPictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (patientManager.AddPatient(FullnameTextbox.Text, GenderComboBox.Text, EmailTextbox.Text,
                    DOBDateTimePicker.Value, AddressTextbox.Text, CityTextbox.Text, NICTextbox.Text,
                    BloodgroupComboBox.Text, ContactTextbox.Text, MedicalTextbox.Text))
                {
                    MessageBox.Show("Patient Record Saved Successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearForm();
                    this.Close();


                }
                else
                {
                    MessageBox.Show("Error occurred while saving patient data.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        

        private void ClearForm()
        {
            FullnameTextbox.Clear();
            GenderComboBox.SelectedIndex = -1;
            EmailTextbox.Clear();
            DOBDateTimePicker.Value = DateTime.Now;
            AddressTextbox.Clear();
            CityTextbox.Clear();
            NICTextbox.Clear();
            BloodgroupComboBox.SelectedIndex = -1;
            ContactTextbox.Clear();
            MedicalTextbox.Clear();
        }





        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }
    }
}
