using Health_Care_Plus_System.Classes;
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

namespace Health_Care_Plus_System.Screen_Forms.Doctor
{
    public partial class AddDoctor : Form
    {
        private string connectionString = (Properties.Settings.Default.DBConnectionString);


        public AddDoctor()
        {
            InitializeComponent();
        }

        private void AddDoctor_Load(object sender, EventArgs e)
        {
           
        }




        private void AddButton_Click(object sender, EventArgs e)
        {
            DoctorClass doctor = new DoctorClass()
            {
                FullName = FullNameTextBox.Text,
                Gender = genderComboBox.Text,
                DOB = DobDateTimePicker.Value,
                MedicalLicense = MedicalLicenceTextBox.Text,
                Specialization = SpecificationComboBox1.Text,
                Qualification = QualificationComboBox1.Text,
                ContactNo = ContactNoTextbox.Text,
                Email = EmailTextBox.Text,
                Address = AddressTextBox.Text,
                WorkPlace = WorkPlaceComboBox.Text,
                AvailabilityDay = GetSelectedDays(),
                AvailabilityTime = AvalableTimeComboBox.Text,
                PreferredMethod = PreferredMethodComboBox.Text,
                ProfilePicture = BrowsPictureBox1.Text
            };


            if (doctor.AddDoctor())
            {
                MessageBox.Show("Doctor Record Saved Successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close(); // form close after successfull save record

            }
            else
            {
                MessageBox.Show("Error occurred while saving doctor record.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }



        //This method for  select field for doctor available days
        private string GetSelectedDays()
        {
            string selectedDays = string.Empty;

            foreach (var item in AvailableDayscheckedListBox.CheckedItems)
            {
                if (!string.IsNullOrEmpty(selectedDays))
                {
                    selectedDays += ",";
                }
                selectedDays += item.ToString();
            }

            return selectedDays;
        }



        // Upload Profile Picture in DB
        private void BrowseBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                BrowsPictureBox1.Image = new Bitmap(openFileDialog.FileName);
                BrowsPictureBox1.Text = openFileDialog.FileName;
            }
        }
    }
}
