using Health_Care_Plus_System.Screen_Forms.Patient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Health_Care_Plus_System.Screen_Forms.Employee
{
    public partial class Staff : Form
    {
        //Connection link
        private string connectionString = (Properties.Settings.Default.DBConnectionString);

        private StaffClass staff = new StaffClass();

        public Staff()
        {
            InitializeComponent();       
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }



        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (StaffDataGridview.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show("Are you sure you want to delete this record?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    int rowIndex = StaffDataGridview.SelectedRows[0].Index;
                    int staffID = Convert.ToInt32(StaffDataGridview.Rows[rowIndex].Cells["StaffID"].Value);

                    if (StaffClass.DeleteStaffRecord(staffID))
                    {
                        MessageBox.Show("Record deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadStaffRecords();
                    }
                    else
                    {
                        MessageBox.Show("Failed to delete record.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a row to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

       



        private void SearchTextBox_TextChanged(object sender, EventArgs e)
        {
            string searchQuery = SearchTextBox.Text.Trim();
            List<StaffClass> searchResults = staff.SearchStaffRecord(searchQuery);

            StaffDataGridview.DataSource = searchResults; // This is search result in display Datagridview
        }

        

        private void Addbutton_Click(object sender, EventArgs e)
        {
            AddStaff addStaffForm = new AddStaff();
            addStaffForm.ShowDialog();
            LoadStaffRecords();
        }

        private void Updatebutton_Click(object sender, EventArgs e)
        {
            if (StaffDataGridview.SelectedRows.Count > 0)
            {
                int rowIndex = StaffDataGridview.SelectedRows[0].Index;
                int staffID = Convert.ToInt32(StaffDataGridview.Rows[rowIndex].Cells["StaffID"].Value);

                UpdateStaff updateStaffForm = new UpdateStaff(staffID);
                updateStaffForm.ShowDialog();
                LoadStaffRecords();
            }
            else
            {
                MessageBox.Show("Please select a row to update.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void UpdateStaff_FormClosed(object sender, FormClosedEventArgs e)
        {

            LoadStaffRecords();
            this.Show(); // Show the main Staff form again
        }

        private void Staff_Load(object sender, EventArgs e)
        {
            LoadStaffRecords();
        }

        private void LoadStaffRecords()
        {
            string searchQuery = SearchTextBox.Text.Trim();
            List<StaffClass> searchResults = staff.SearchStaffRecord(searchQuery);

            //  search results to the DataGridView
            StaffDataGridview.DataSource = searchResults;

        }


    }
}
