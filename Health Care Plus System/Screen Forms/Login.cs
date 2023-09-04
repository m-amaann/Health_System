using System;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Health_Care_Plus_System
{
    public partial class Login : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DELL-5050\\SQLEXPRESS;Initial Catalog=HealthCareDB;Integrated Security=True");
        SqlCommand cmd;

        private bool isPasswordVisible = false;


        public Login()
        {
            InitializeComponent();
        }


        private void PasstxtBox_TextChanged(object sender, EventArgs e)
        {

        }


        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void Login_Load(object sender, EventArgs e)
        {
            PasstxtBox.UseSystemPasswordChar = true; //initially hide password char
            eyePictureBox.Image = Properties.Resources.eye_icon;

            eyePictureBox.Click += new EventHandler(eyePictureBox_Click);  // in here, click event handler to your image button
        }

        private void LoginBtn1_Click(object sender, EventArgs e)
        {
            string username = Usertxtbox.Text;
            string password = PasstxtBox.Text;

            con.Open();

            cmd = new SqlCommand("SELECT * FROM Users WHERE Username = @username", con);
            cmd.Parameters.AddWithValue("@username", username);
            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                //Role based on
                string role = dr["Role"].ToString();

                string storedPasswordHash = dr["Password"].ToString();

                // Hash the entered password
                string enteredPasswordHash = HashPassword(password);

                if (enteredPasswordHash == storedPasswordHash)
                {
                    con.Close();
                    this.Hide();
                    Main main = new Main(username, role);
                    main.Show();
                }
                else
                {
                    MessageBox.Show("Invalid username or password", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Invalid username or password", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            con.Close();


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

        private void guna2ImageButton1_Click_1(object sender, EventArgs e)
        {

        }


        //Toggle hide and visible eye icons
        private void eyePictureBox_Click(object sender, EventArgs e)
        {
            isPasswordVisible = !isPasswordVisible;
            PasstxtBox.UseSystemPasswordChar = !isPasswordVisible;

            eyePictureBox.Image = isPasswordVisible ? Properties.Resources.eye_open_icon : Properties.Resources.eye_icon;
        }
    }
}

