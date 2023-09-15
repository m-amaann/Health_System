using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Health_Care_Plus_System.Classes
{
    public class PaymentClass
    {
        private string connectionString = Properties.Settings.Default.DBConnectionString; // connecting DB string statement


        //  fields in the Payment table
        public int BillingID { get; set; }
        public string PatientName { get; set; }
        public int PatID { get; set; }
        public int Appointment_ID { get; set; }
        public string Method { get; set; }
        public DateTime INV_Date { get; set; }
        public string INV_No { get; set; }
        public string ServiceNote { get; set; }
        public string Appoinement_Fee { get; set; }
        public string RoomCharge { get; set; }
        public string ResourceCharge { get; set; }
        public string TotalFee { get; set; }


        // Constructor
        public PaymentClass()
        {
        }

    }
}
