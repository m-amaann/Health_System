using Health_Care_Plus_System.Screen_Forms.Patient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Health_Care_Plus_System.Screen_Forms.EMR
{
    public partial class AddEMR : Form
    {
        public AddEMR()
        {
            InitializeComponent();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void PatientDataGrideView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
            PatientProfile patientProfile = new PatientProfile();
            patientProfile.ShowDialog();
        }
    }
}
