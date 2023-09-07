using Health_Care_Plus_System.Classes;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Health_Care_Plus_System.Screen_Forms.Doctor
{
    public partial class UpdateDoctor : Form
    {
        private int doctorIDUpdate;

        public UpdateDoctor(int DoctorID)
        {
            InitializeComponent();
            doctorIDUpdate = DoctorID;
            LoadDoctorRecord();
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
       
        }

        private void LoadDoctorRecord()
        {
            DoctorClass doctor = DoctorClass.GetDoctorByID(doctorIDUpdate);

            if (doctor != null)
            {
                FullNameTextBox.Text = doctor.FullName;
                genderComboBox.Text = doctor.Gender;
                DobDateTimePicker.Value = doctor.DOB;
                MedicalLicenceTextBox.Text = doctor.MedicalLicense;
                SpecificationComboBox1.Text = doctor.Specialization;
                QualificationComboBox1.Text = doctor.Qualification;
                ContactNoTextbox.Text = doctor.ContactNo;
                EmailTextBox.Text = doctor.Email;
                AddressTextBox.Text = doctor.Address;
                WorkPlaceComboBox.Text = doctor.WorkPlace;

                string[] selectedDaysArray = doctor.AvailabilityDay.Split(',');
                foreach (string day in selectedDaysArray)
                {
                    int index = AvailableDayscheckedListBox.Items.IndexOf(day);
                    if (index >= 0)
                    {
                        AvailableDayscheckedListBox.SetItemChecked(index, true);
                    }
                }

                AvalableTimeComboBox.Text = doctor.AvailabilityTime;
                PreferredMethodComboBox.Text = doctor.PreferredMethod;

                if (!string.IsNullOrWhiteSpace(doctor.ProfilePicture) && File.Exists(doctor.ProfilePicture))
                {
                    BrowsPictureBox1.Image = new Bitmap(doctor.ProfilePicture);
                    BrowsPictureBox1.Text = doctor.ProfilePicture;
                }
            }
        }

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

        private void Updatebutton_Click_1(object sender, EventArgs e)
        {
            DoctorClass doctor = new DoctorClass
            {
                DoctorID = doctorIDUpdate,
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

            if (doctor.UpdateDoctor())
            {
                MessageBox.Show("Doctor Record Updated Successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
            else
            {
                MessageBox.Show("Error occurred while updating doctor record.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BrowseBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                BrowsPictureBox1.Text = openFileDialog.FileName; // Update the file path

                try
                {
                    // Attempt to load the image and set it to the PictureBox
                    BrowsPictureBox1.Image = new Bitmap(openFileDialog.FileName);
                }
                catch (Exception ex)
                {
                    // Handle any exceptions that may occur when loading the image
                    MessageBox.Show("Error loading the image: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void UpdateDoctor_Load(object sender, EventArgs e)
        {

        }
    }
}
