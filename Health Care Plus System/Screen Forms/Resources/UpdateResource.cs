using Health_Care_Plus_System.Classes;
using Health_Care_Plus_System.Screen_Forms.Doctor;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Health_Care_Plus_System.Screen_Forms.Resources
{
    public partial class UpdateResource : Form
    {
        private string connectionString = Properties.Settings.Default.DBConnectionString; // Connection string

        private int resourceIDUpdate;
        private ResourceClass resourceClass;


        public UpdateResource(int resourceID)
        {
            InitializeComponent();

            resourceIDUpdate = resourceID;
            resourceClass = new ResourceClass();

        }


        private void LoadResourcesRecord()
        {          
            ResourceClass resource = resourceClass.GetResourceByID(resourceIDUpdate);

            if (resource != null)
            {
                // Load resource data into form controls
                NameTextBox.Text = resource.Name;
                ResourceTypeBox.Text = resource.ResourceType;
                LocationComboBox1.Text = resource.Location;
                AvailabilityComboBox.Text = resource.Availability;
                SerialNoTextbox.Text = resource.SerialNo;
                ModelTextBox.Text = resource.Model;
                PurchaseDateTimePicker1.Value = resource.PurchasedDate;
                ContactNoTextBox.Text = resource.ContactNo;

            }
            else
            {
                MessageBox.Show("Resource not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close(); // Close the form if resource not found
            }    
        }




        private void Updatebutton_Click(object sender, EventArgs e)
        {
            ResourceClass resourceClass = new ResourceClass()
            {
                ResourceID = resourceIDUpdate,
                Name = NameTextBox.Text,
                ResourceType = ResourceTypeBox.Text,
                Location = LocationComboBox1.Text,
                Availability = AvailabilityComboBox.Text,
                SerialNo = SerialNoTextbox.Text,
                Model = ModelTextBox.Text,
                PurchasedDate = PurchaseDateTimePicker1.Value,
                ContactNo = ContactNoTextBox.Text
            };

            if (resourceClass.UpdateResourceRecord())
            {
                MessageBox.Show("Resource Record Updated Successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
            else
            {
                MessageBox.Show("Error occurred while updating resource record.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateResource_Load(object sender, EventArgs e)
        {
            LoadResourcesRecord();
        }
    }
}
