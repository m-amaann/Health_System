using Health_Care_Plus_System;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;

namespace Health_Care_Plus_System.Screen_Forms.AdminAcceess
{
    public partial class AddUsers : Form
    {
        private string connectionString = (Properties.Settings.Default.DBConnectionString); // connection string line 


        public AddUsers()
        {
            InitializeComponent();

           
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
            Main main = new Main();
            main.Show();
        }



        private void AddButton_Click(object sender, EventArgs e)
        {
            // Check if any of the required fields are empty
            if (string.IsNullOrWhiteSpace(FirstTextBox.Text) ||
                string.IsNullOrWhiteSpace(LastTextBox.Text) ||
                string.IsNullOrWhiteSpace(EmailTextbox.Text) ||
                string.IsNullOrWhiteSpace(RoleComboBox.Text) ||
                string.IsNullOrWhiteSpace(Usertxtbox.Text) ||
                string.IsNullOrWhiteSpace(PasstxtBox.Text))
             
            {
                MessageBox.Show("Please fill in all required fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string INSERTQUERY = @"INSERT INTO Users ( FirstName, LastName, Email, Role, Username, Password)
                                     VALUES ( @FirstName, @LastName, @Email, @Role, @username, @Password)";

                    using (SqlCommand command = new SqlCommand(INSERTQUERY, connection))
                    {

                        command.Parameters.AddWithValue("@FirstName", FirstTextBox.Text);
                        command.Parameters.AddWithValue("@LastName", LastTextBox.Text);
                        command.Parameters.AddWithValue("@Email", EmailTextbox.Text);

                        command.Parameters.AddWithValue("@Role", RoleComboBox.SelectedItem.ToString());
                        command.Parameters.AddWithValue("@username", Usertxtbox.Text);

                        // Encrypt the password using SHA-256 hash
                        string hashedPassword = HashPassword(PasstxtBox.Text);
                        command.Parameters.AddWithValue("@Password", hashedPassword);

                       



                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("New User Accessor Saved Successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                         


                            Close();

                        }
                        else
                        {
                            MessageBox.Show("Error occurred while saving patient data.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }

            }
        }

        private string HashPassword(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] hashBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                StringBuilder builder = new StringBuilder();

                foreach (byte b in hashBytes)
                {
                    builder.Append(b.ToString("x2")); // Convert to hexadecimal format
                }

                return builder.ToString();
            }

        }

        private void AddUsers_Load(object sender, EventArgs e)
        {
            
        }
    }
}
