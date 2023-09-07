using Health_Care_Plus_System.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Health_Care_Plus_System.Screen_Forms.Doctor
{
    public partial class DoctorProfile : Form
    {
        private DoctorClass selectedDoctor;

        public DoctorProfile(DoctorClass selectedDoctor)
        {
            InitializeComponent();

            this.selectedDoctor = selectedDoctor;



            // Form controls with the selected doctor's data


            // Display the profile picture
            if (!string.IsNullOrEmpty(selectedDoctor.ProfilePicture))
            {
                try
                {
                    DoctorProfilePictureBox.Image = Image.FromFile(selectedDoctor.ProfilePicture);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading profile picture: " + ex.Message);
                }
            }



            FullNameTextBox.Text = selectedDoctor.FullName;
            SpecificationTextBox1.Text = selectedDoctor.Qualification;
            ContactNoTextbox.Text = selectedDoctor.ContactNo;
            MedicalLicenceTextBox.Text = selectedDoctor.MedicalLicense;
            WorkPlaceTextBox.Text = selectedDoctor.WorkPlace;

            // Calculate and display age (only years)
            DateTime currentDate = DateTime.Today;
            int ageInYears = currentDate.Year - selectedDoctor.DOB.Year;

            // Check if the birth date has occurred this year
            if (currentDate.Month < selectedDoctor.DOB.Month || (currentDate.Month == selectedDoctor.DOB.Month && currentDate.Day < selectedDoctor.DOB.Day))
            {
                ageInYears--;
            }

            AgeTextBox.Text = ageInYears.ToString(); // Display age 

            genderTextBox.Text = selectedDoctor.Gender;
            QualificationTextBox1.Text = selectedDoctor.Qualification;
            EmailTextBox.Text = selectedDoctor.Email;
            PreferredMethodTextBox.Text = selectedDoctor.PreferredMethod;
            AddressTextBox.Text = selectedDoctor.Address;
            AvailableDaysTextBox.Text = selectedDoctor.AvailabilityDay;
            AvalableTimeTextBox.Text = selectedDoctor.AvailabilityTime;
            RegisterDateTextBox.Text = selectedDoctor.RegisteredDate.ToShortDateString();


          
        }

        private void DoctorProfile_Load(object sender, EventArgs e)
        {

        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
