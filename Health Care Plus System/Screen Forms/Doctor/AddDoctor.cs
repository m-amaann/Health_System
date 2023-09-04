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
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string insertQuery = @"
                        INSERT INTO Doctors (
                            FullName, Gender, DOB, MedicalLicense, Specialization, Qualification,
                            ContactNo, Email, Address, WorkPlace, AvailabilityDay, AvailabilityTime,
                            PreferredMethod, ProfilePicture)

                       VALUES (
                            @FullName, @Gender, @DOB, @MedicalLicense, @Specialization, @Qualification,
                            @ContactNo, @Email, @Address, @WorkPlace, @AvailabilityDay, @AvailabilityTime,
                            @PreferredMethod, @ProfilePicture
                        )";

                     using (SqlCommand command = new SqlCommand(insertQuery, connection))
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


                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Doctor Record Saved Successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Error occurred while saving doctor record.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
            Close();
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
    }
}
