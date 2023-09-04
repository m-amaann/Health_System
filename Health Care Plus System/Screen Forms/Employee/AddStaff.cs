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

namespace Health_Care_Plus_System.Screen_Forms.Employee
{
    public partial class AddStaff : Form
    {
        private string connectionString = (Properties.Settings.Default.DBConnectionString);


        public AddStaff()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void BloodgroupComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }


        //this is browse profile image browse import
        private void BrowseBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                BrowsPictureBox1.Image = new Bitmap(openFileDialog.FileName);
                BrowsPictureBox1.Text = openFileDialog.FileName;
            }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string INSERTQUERY = @"INSERT INTO Staff ( FirstName, LastName, DOB, BloodGroup, Gender, Occupation, Salary, JoiningDate, Shift,ContactNo,Email,Address,ProfileImg)
                                     VALUES ( @FirstName, @LastName, @DOB,  @BloodGroup, @Gender, @Occupation, @Salary, @JoiningDate, @Shift, @ContactNo, @Email, @Address, @ProfileImg)";

                    using (SqlCommand command = new SqlCommand(INSERTQUERY, connection))
                    {

                        command.Parameters.AddWithValue("@FirstName", FirstTextBox.Text);
                        command.Parameters.AddWithValue("@LastName", LastTextBox.Text);
                        command.Parameters.AddWithValue("@DOB", DobDateTimePicker.Value);
                        command.Parameters.AddWithValue("@BloodGroup", BloodgroupComboBox.Text);
                        command.Parameters.AddWithValue("@Gender", genderComboBox.Text);

                        command.Parameters.AddWithValue("@Occupation", OccupationComboBox1.Text);
                        command.Parameters.AddWithValue("@Salary", SalaryTextbox.Text);
                        command.Parameters.AddWithValue("@JoiningDate", JoiningDateTimePicker1.Value);
                        command.Parameters.AddWithValue("@Shift", ShiftComboBox2.Text);
                        command.Parameters.AddWithValue("@ContactNo", ContactTextBox.Text);

                        command.Parameters.AddWithValue("@Email", EmailTextbox.Text);
                        command.Parameters.AddWithValue("@Address", AddressTextBox1.Text);


                        if (!string.IsNullOrWhiteSpace(BrowsPictureBox1.Text))
                        {
                            string ProfileImage = Path.GetFileName(BrowsPictureBox1.Text);
                            command.Parameters.AddWithValue("@ProfileImg", ProfileImage);
                        }
                        else
                        {
                            command.Parameters.AddWithValue("@ProfileImg", DBNull.Value);
                        }


                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Staff Record Saved Successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Error occurred while saving staff record.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
        }

        private void AddStaff_Load(object sender, EventArgs e)
        {

        }
    }
}
