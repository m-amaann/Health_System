using System;
using System.Windows.Forms;
using Health_Care_Plus_System.Classes;

namespace Health_Care_Plus_System.Screen_Forms.Resources
{
    public partial class AddResource : Form
    {
        private ResourceClass resourceClass;

        public AddResource()
        {
            InitializeComponent();
            resourceClass = new ResourceClass();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void AddResource_Load(object sender, EventArgs e)
        {
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Validate input fields before adding.
                if (ValidateInput())
                {
                    ResourceClass newResource = new ResourceClass
                    {
                        Name = NameTextBox.Text,
                        ResourceType = ResourceTypeBox.Text,
                        Location = LocationComboBox1.Text,
                        Availability = AvailabilityComboBox.Text,
                        SerialNo = SerialNoTextbox.Text,
                        Model = ModelTextBox.Text,
                        PurchasedDate = PurchaseDateTimePicker1.Value,
                        ContactNo = ContactNoTextBox.Text
                    };

                    bool success = newResource.AddResourceRecord();

                    if (success)
                    {
                        MessageBox.Show("Resource Record added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Failed to add resource.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }


        // This input field validation method 
        private bool ValidateInput()
        {
            if (string.IsNullOrWhiteSpace(NameTextBox.Text) ||
                string.IsNullOrWhiteSpace(ResourceTypeBox.Text) ||
                string.IsNullOrWhiteSpace(SerialNoTextbox.Text) ||
                string.IsNullOrWhiteSpace(LocationComboBox1.Text) ||
                string.IsNullOrWhiteSpace(AvailabilityComboBox.Text) ||
                string.IsNullOrWhiteSpace(ModelTextBox.Text) ||
                string.IsNullOrWhiteSpace(ContactNoTextBox.Text))
            {
                MessageBox.Show("Please fill in all required fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            

            return true; // If all validations passed
        }
    }
}
