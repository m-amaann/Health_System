using Health_Care_Plus_System.Screen_Forms.Doctor;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Health_Care_Plus_System.Screen_Forms.Payment
{
    public partial class PaymentForm : Form
    {
        public PaymentForm()
        {
            InitializeComponent();
        }

        private void PaymentForm_Load(object sender, EventArgs e)
        {

        }

        private void Addbutton_Click(object sender, EventArgs e)
        {
            AddPayment addPayment = new AddPayment();
            addPayment.Show();
        }

        private void Updatebutton_Click(object sender, EventArgs e)
        {
            if (PaymentDataGridview.SelectedRows.Count > 0)
            {
                int rowIndex = PaymentDataGridview.SelectedRows[0].Index;
                int BillingID = Convert.ToInt32(PaymentDataGridview.Rows[rowIndex].Cells["BillingID"].Value);

                this.Hide();
                UpdatePayment updatePayment = new UpdatePayment();
                updatePayment.Show();
               
            }
            else
            {
                MessageBox.Show("Please select a row to update.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PaymentDataGridview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
