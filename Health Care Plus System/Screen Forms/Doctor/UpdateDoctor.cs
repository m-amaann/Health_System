using Health_Care_Plus_System.Screen_Forms.Employee;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Health_Care_Plus_System.Screen_Forms.Doctor
{
    public partial class UpdateDoctor : Form
    {
        private string connectionString = (Properties.Settings.Default.DBConnectionString);
        private int doctorIDUpdate;

        public UpdateDoctor(int DoctorID)
        {
            InitializeComponent();


            doctorIDUpdate = DoctorID;
            LoadDoctorRecord(); //display the doctor's info
        }

        private void Updatebutton_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string updateQuery = @"
                        UPDATE Doctors SET
                            FullName = @FullName, Gender = @Gender, DOB = @DOB, 
                            MedicalLicense = @MedicalLicense, Specialization = @Specialization,
                            Qualification = @Qualification, ContactNo = @ContactNo, 
                            Email = @Email, Address = @Address, WorkPlace = @WorkPlace, 
                            AvailabilityDay = @AvailabilityDay, AvailabilityTime = @AvailabilityTime,
                            PreferredMethod = @PreferredMethod, ProfilePicture = @ProfilePicture
                        WHERE DoctorID = @DoctorID";

                    using (SqlCommand command = new SqlCommand(updateQuery, connection))
                    {
                        command.Parameters.AddWithValue("@FullName", FullNameTextBox.Text);
                        command.Parameters.AddWithValue("@Gender", genderComboBox.Text);
                        command.Parameters.AddWithValue("@DOB", DobDateTimePicker.Value);
                        command.Parameters.AddWithValue("@MedicalLicense", MedicalLicenceTextBox.Text);
                        command.Parameters.AddWithValue("@Specialization", SpecificationComboBox1.Text);
                        command.Parameters.AddWithValue("@Qualification", QualificationComboBox1.Text);
                        command.Parameters.AddWithValue("@ContactNo", ContactNoTextbox.Text);
                        command.Parameters.AddWithValue("@Email", EmailTextBox.Text);
                        command.Parameters.AddWithValue("@Address", AddressTextBox.Text);
                        command.Parameters.AddWithValue("@WorkPlace", WorkPlaceComboBox.Text);

                        string[] selectedDaysArray = AvailableDayscheckedListBox.CheckedItems
                                                   .Cast<string>()
                                                   .ToArray();
                        string selectedDays = string.Join(",", selectedDaysArray);
                        command.Parameters.AddWithValue("@AvailabilityDay", selectedDays);

                        command.Parameters.AddWithValue("@AvailabilityTime", AvalableTimeComboBox.Text);
                        command.Parameters.AddWithValue("@PreferredMethod", PreferredMethodComboBox.Text);

                        if (!string.IsNullOrWhiteSpace(BrowsPictureBox1.Text))
                        {
                            string ProfileImage = Path.GetFileName(BrowsPictureBox1.Text);
                            command.Parameters.AddWithValue("@ProfilePicture", ProfileImage);
                        }
                        else
                        {
                            command.Parameters.AddWithValue("@ProfilePicture", DBNull.Value);
                        }

                        command.Parameters.AddWithValue("@DoctorID", doctorIDUpdate);


                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Doctor Record Updated Successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Error occurred while updating doctor record.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
        }

        private void BrowseBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                BrowsPictureBox1.Image = new Bitmap(openFileDialog.FileName);
                BrowsPictureBox1.Text = openFileDialog.FileName;
            }
        }

        private void UpdateDoctor_Load(object sender, EventArgs e)
        {

        }


        private void LoadDoctorRecord()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string updateQuery = "SELECT * FROM Doctors WHERE DoctorID = @DoctorID";

                    using (SqlCommand command = new SqlCommand(updateQuery, connection))
                    {
                        command.Parameters.AddWithValue("@DoctorID", doctorIDUpdate);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                FullNameTextBox.Text = reader["FullName"].ToString();
                                genderComboBox.Text = reader["Gender"].ToString();
                                DobDateTimePicker.Value = Convert.ToDateTime(reader["DOB"]);
                                MedicalLicenceTextBox.Text = reader["MedicalLicense"].ToString();
                                SpecificationComboBox1.Text = reader["Specialization"].ToString();
                                QualificationComboBox1.Text = reader["Qualification"].ToString();
                                ContactNoTextbox.Text = reader["ContactNo"].ToString();
                                EmailTextBox.Text = reader["Email"].ToString();
                                AddressTextBox.Text = reader["Address"].ToString();
                                WorkPlaceComboBox.Text = reader["WorkPlace"].ToString();

                                //SELECTED DAYS
                                string availabilityDays = reader["AvailabilityDay"].ToString();
                                string[] selectedDaysArray = availabilityDays.Split(',');
                                foreach (string day in selectedDaysArray)
                                {
                                    int index = AvailableDayscheckedListBox.Items.IndexOf(day);
                                    if (index >= 0)
                                    {
                                        AvailableDayscheckedListBox.SetItemChecked(index, true);
                                    }
                                }

                                AvalableTimeComboBox.Text = reader["AvailabilityTime"].ToString();
                                PreferredMethodComboBox.Text = reader["PreferredMethod"].ToString();

                                //PROFILE PICTURE UPLOAD
                                string profilePicture = reader["ProfilePicture"].ToString();
                                try
                                {
                                    if (!string.IsNullOrWhiteSpace(profilePicture) && File.Exists(profilePicture))
                                    {
                                        BrowsPictureBox1.Image = new Bitmap(profilePicture);
                                        BrowsPictureBox1.Text = profilePicture;
                                    }
                                }
                                catch (Exception ex)
                                {
                                    MessageBox.Show("An error occurred while loading the profile picture: " + ex.Message);
                                }
                            }
                        }                   
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
        }
    }
}
