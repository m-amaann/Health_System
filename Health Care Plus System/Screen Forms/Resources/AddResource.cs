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
    public partial class AddResource : Form
    {
        private ResourcesForm resourcesForm;

        public AddResource()
        {
            InitializeComponent();

        }

        private void JoiningDateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
           
        }
    }
}
