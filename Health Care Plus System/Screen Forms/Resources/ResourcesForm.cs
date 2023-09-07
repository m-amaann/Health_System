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
        public ResourcesForm()
        {
            InitializeComponent();
        }

        private void ResourcesForm_Load(object sender, EventArgs e)
        {
            
        }

        private void Addbutton_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddResource addResource = new AddResource();
            addResource.ShowDialog();
        }
    }
}
