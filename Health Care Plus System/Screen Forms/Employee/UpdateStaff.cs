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
using System.Web;
using System.Windows.Controls;
using System.Windows.Forms;
using Image = System.Drawing.Image;

namespace Health_Care_Plus_System.Screen_Forms.Employee
{
    public partial class UpdateStaff : Form
    {

        private string connectionString = Properties.Settings.Default.DBConnectionString; // Connection string
        private int staffIDUpdate;
        private string selectedImageFileName;

        public UpdateStaff(int StaffID)
        {
            InitializeComponent();

            staffIDUpdate = StaffID;
            LoadStaffRecord();
        }

        

        private void LoadStaffRecord()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT * FROM Staff WHERE StaffID = @StaffID";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@StaffID", staffIDUpdate);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                FirstTextBox.Text = reader["FirstName"].ToString();
                                LastTextBox.Text = reader["LastName"].ToString();
                                DobDateTimePicker.Value = Convert.ToDateTime(reader["DOB"]);
                                BloodgroupComboBox.Text = reader["BloodGroup"].ToString();
                                genderComboBox.Text = reader["Gender"].ToString();
                                OccupationComboBox1.Text = reader["Occupation"].ToString();
                                SalaryTextbox.Text = reader["Salary"].ToString();
                                JoiningDateTimePicker1.Value = Convert.ToDateTime(reader["JoiningDate"]);
                                ShiftComboBox2.Text = reader["Shift"].ToString();
                                ContactTextBox.Text = reader["ContactNo"].ToString();
                                EmailTextbox.Text = reader["Email"].ToString();
                                AddressTextBox1.Text = reader["Address"].ToString();
                                selectedImageFileName = reader["ProfileImg"].ToString(); // Store the image file name
                                                                                         // Set the image location for BrowsPictureBox1
                                string imageFilePath = Path.Combine(Application.StartupPath, "Images", selectedImageFileName);
                                BrowsPictureBox1.ImageLocation = imageFilePath;
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while loading staff data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }



        private void Updatebutton_Click(object sender, EventArgs e)
        {
            // Update staff record with new data
            StaffClass updatedStaff = new StaffClass
            {
                StaffID = staffIDUpdate,

                FirstName = FirstTextBox.Text.Trim(),
                LastName = LastTextBox.Text.Trim(),
                DOB = DobDateTimePicker.Value,
                BloodGroup = BloodgroupComboBox.Text.Trim(),
                Gender = genderComboBox.Text,
                Occupation = OccupationComboBox1.Text.Trim(),
                Salary = SalaryTextbox.Text.Trim(),
                JoiningDate = JoiningDateTimePicker1.Value,
                Shift = ShiftComboBox2.Text,
                ContactNo = ContactTextBox.Text.Trim(),
                Email = EmailTextbox.Text.Trim(),
                Address = AddressTextBox1.Text.Trim(),
                ProfileImg = BrowsPictureBox1.ImageLocation
            };

            if (updatedStaff.UpdateStaffRecord())
            {
                this.Close();
            }
            else
            {
                MessageBox.Show("Failed to update staff record.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateStaff_Load(object sender, EventArgs e)
        {

        }

        private void BrowseBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files (*.jpg; *.jpeg; *.png; *.bmp; *.avif)|*.jpg; *.jpeg; *.png; *.bmp; *.avif";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                selectedImageFileName = Path.GetFileName(openFileDialog.FileName); // Store the selected file name
                string selectedImagePath = openFileDialog.FileName;
                BrowsPictureBox1.ImageLocation = selectedImagePath;
            }
        }
    }
}
