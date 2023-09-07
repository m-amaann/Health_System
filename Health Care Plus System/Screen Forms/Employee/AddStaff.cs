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
        private StaffClass staff = new StaffClass();
        private string ProfileImg = "";

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

            openFileDialog.Filter = "Image Files (*.jpg; *.jpeg; *.png; *.bmp; *.avif)|*.jpg; *.jpeg; *.png; *.bmp; *.avif";
            openFileDialog.Title = "Select an Image File";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string selectedProfileImg = openFileDialog.FileName;
                BrowsPictureBox1.Image = System.Drawing.Image.FromFile(selectedProfileImg);

                staff.ProfileImg = Path.GetFileName(selectedProfileImg); // Set the image file name
            }
        }


        private void AddButton_Click(object sender, EventArgs e)
        {
            staff.FirstName = FirstTextBox.Text;
            staff.LastName = LastTextBox.Text;
            staff.DOB = DobDateTimePicker.Value;
            staff.BloodGroup = BloodgroupComboBox.Text;
            staff.Gender = genderComboBox.Text;
            staff.Occupation = OccupationComboBox1.Text;
            staff.Salary = SalaryTextbox.Text;
            staff.JoiningDate = JoiningDateTimePicker1.Value;
            staff.Shift = ShiftComboBox2.Text;
            staff.ContactNo = ContactTextBox.Text;
            staff.Email = EmailTextbox.Text;
            staff.Address = AddressTextBox1.Text;
           



            // Add staff record
            if (staff.AddStaffRecord())
            {
                // Clear form fields after successful insert record
                ClearForm();
            }
        }

        private void ClearForm()
        {
            FirstTextBox.Clear();
            LastTextBox.Clear();
            DobDateTimePicker.Value = DateTime.Today;
            BloodgroupComboBox.SelectedIndex = -1;
            genderComboBox.SelectedIndex = -1;
            OccupationComboBox1.SelectedIndex = -1;
            SalaryTextbox.Clear();
            JoiningDateTimePicker1.Value = DateTime.Today;
            ShiftComboBox2.SelectedIndex = -1;
            ContactTextBox.Clear();
            EmailTextbox.Clear();
            AddressTextBox1.Clear();
            BrowsPictureBox1.Image = null;
        }

        private void AddStaff_Load(object sender, EventArgs e)
        {

        }
    }
}
