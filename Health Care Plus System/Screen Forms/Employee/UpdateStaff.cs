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

        private string connectionString = (Properties.Settings.Default.DBConnectionString); //connection string line
        private int staffIDUpdate;


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

                    string UpdateQuery = "SELECT * FROM Staff WHERE StaffID = @StaffID";

                    using (SqlCommand command = new SqlCommand(UpdateQuery, connection))
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

                                if (reader["ProfileImg"] != DBNull.Value)
                                {
                                    byte[] imageData = (byte[])reader["ProfileImg"];
                                    using (MemoryStream ms = new MemoryStream(imageData))
                                    {
                                        BrowsPictureBox1.Image = Image.FromStream(ms);
                                    }
                                }
                                else
                                {
                                    BrowsPictureBox1.Image = null;
                                }
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
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string UPDATEQUERY = @"UPDATE Staff SET FirstName = @FirstName, LastName = @LastName, DOB = @DOB, 
                                         BloodGroup = @BloodGroup, Gender = @Gender, Occupation = @Occupation, 
                                         Salary = @Salary, JoiningDate = @JoiningDate, Shift = @Shift, 
                                         ContactNo = @ContactNo, Email = @Email, Address = @Address,
                                         ProfileImg = @ProfileImg WHERE StaffID = @StaffID";

                    using (SqlCommand command = new SqlCommand(UPDATEQUERY, connection))
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

                        command.Parameters.AddWithValue("@StaffID", staffIDUpdate);


                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Staff Record Updated Successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("An error occurred while processing your request. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("A database error occurred while processing your request. Please contact support.", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void UpdateStaff_Load(object sender, EventArgs e)
        {

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
