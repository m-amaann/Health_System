using Health_Care_Plus_System.Classes;
using Health_Care_Plus_System.Properties;
using Health_Care_Plus_System.Screen_Forms.Employee;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Health_Care_Plus_System.Screen_Forms.Resources
{
    public partial class ResourcesForm : Form
    {
        //Connection link
        private string connectionString = (Properties.Settings.Default.DBConnectionString);


        private ResourceClass resourceClass = new ResourceClass();


        public ResourcesForm()
        {
            InitializeComponent();
        }

        private void ResourcesForm_Load(object sender, EventArgs e)
        {
            LoadResourcesRecord();
        }


        private void LoadResourcesRecord()
        {
            string searchQuery = SearchTextBox.Text.Trim();
            List<ResourceClass> searchResults = resourceClass.SearchResourceRecord(searchQuery);

            //searhc reult to the DatagridTable
            ResourceDataGridview.DataSource = searchResults;
        }






        private void Addbutton_Click(object sender, EventArgs e)
        {
            AddResource addResource = new AddResource();
            addResource.ShowDialog();
            LoadResourcesRecord();

        }



        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (ResourceDataGridview.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show("Are you sure you want to delete this record?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    int rowIndex = ResourceDataGridview.SelectedRows[0].Index;
                    int resourceID = Convert.ToInt32(ResourceDataGridview.Rows[rowIndex].Cells["ResourceID"].Value);

                    if (ResourceClass.DeleteResourceRecord(resourceID))
                    {
                        MessageBox.Show("Record has been deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadResourcesRecord();
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
            List<ResourceClass> searchResult = resourceClass.SearchResourceRecord(searchQuery);

            ResourceDataGridview.DataSource = searchResult; // This is search result in display Datagridview


        }



        private void Updatebutton_Click(object sender, EventArgs e)
        {
            if (ResourceDataGridview.SelectedRows.Count > 0)
            {
                int rowIndex = ResourceDataGridview.SelectedRows[0].Index;
                int ResourceID = Convert.ToInt32(ResourceDataGridview.Rows[rowIndex].Cells["ResourceID"].Value);

                this.Hide();
                UpdateResource updateResource = new UpdateResource(ResourceID);
                updateResource.ShowDialog();
            }
            else
            {
                MessageBox.Show("Please select a row to update.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ResourceDataGridview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
