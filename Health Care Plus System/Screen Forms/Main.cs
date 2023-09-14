using Health_Care_Plus_System.Screen_Forms;
using Health_Care_Plus_System.Screen_Forms.AdminAcceess;
using Health_Care_Plus_System.Screen_Forms.Appointment;
using Health_Care_Plus_System.Screen_Forms.Doctor;
using Health_Care_Plus_System.Screen_Forms.Employee;
using Health_Care_Plus_System.Screen_Forms.Medication;
using Health_Care_Plus_System.Screen_Forms.Payment;
using Health_Care_Plus_System.Screen_Forms.Resources;
using Health_Care_Plus_System.Screen_Forms.Room;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Health_Care_Plus_System
{
    public partial class Main : Form
    {

        private string username;
        private string role;


        public Main(string username, string role)
        {
            InitializeComponent();

            //this is to display current digital time in label
            DigitalClock.Text = DateTime.Now.ToLongTimeString();
            timer1.Start();



            /*Set Font Family*/
            label1.Font = new Font("Montserrat", 14, FontStyle.Bold);

            this.username = username;
            this.role = role.ToLower();


            // Set username in the header bar
            UsernameLabel.Text =  role;


            if (userRole.IsAdmin(role))
            {
                ShowAllMenus();
            }
            else if (userRole.IsReceptionist(role))
            {
                ShowReceptionistMenus();
            }

            SetupSidebar();
        }

        public Main()
        {
        }

        private void ShowAllMenus()
        {
            PatButton1.Visible = true;
            StaffBtn.Visible = true;
            DoctorButton.Visible = true;
            AppointmentButton.Visible = true;
            RoomScheduleButton.Visible = true;
            PaymentButton.Visible = true;
            AdminButton.Visible = true;
            ResourcesMenuBtn.Visible = true;
            ReportGenerateBtn.Visible = true;
        }

        private void ShowReceptionistMenus()
        {
            // Show menu
            PatButton1.Visible = true;
            AppointmentButton.Visible = true;



            // Hide menus     
            StaffBtn.Visible = false;
            DoctorButton.Visible = false;
            RoomScheduleButton.Visible = false;
            PaymentButton.Visible = false;
            AdminButton.Visible = false;
            ResourcesMenuBtn.Visible = false;
            ReportGenerateBtn.Visible = false;
            MedicationBtn.Visible = false;

        }


        private void SetupSidebar()
        {

        }


        public void loadform(object Form)
        {
            if (this.MainPanel.Controls.Count > 0)
                this.MainPanel.Controls.RemoveAt(0);
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.MainPanel.Controls.Add(f);
            this.MainPanel.Tag = f;
            f.Show();
        }



        private void Main_Load(object sender, EventArgs e)
        {
            loadform(new DashboardForm());


        }


        private void PatButton1_Click(object sender, EventArgs e)
        {
            loadform(new PatientForm());
        }


        private void guna2Button5_Click(object sender, EventArgs e)
        {
            loadform(new DashboardForm());
        }


        private void LoggoutBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            Login login = new Login();
            login.Show();
        }



        private void LoggoutBtn_Click_1(object sender, EventArgs e)
        {
           
        }




        private void DoctorButton_Click(object sender, EventArgs e)
        {
            loadform(new Doctor());

        }

        private void label1_Click(object sender, EventArgs e)
        {
            label1.Font = new Font("Montserrat", 14, FontStyle.Bold);

        }

        private void StaffBtn_Click(object sender, EventArgs e)
        {

            loadform(new Staff());
        }

        private void SidebarPanel_Paint(object sender, PaintEventArgs e)
        {

        }



        private void AdminButton_Click(object sender, EventArgs e)
        {
            loadform(new AddUsers());
        }

        private void AppointmentButton_Click(object sender, EventArgs e)
        {
            loadform(new Appointment());
        }



        private void ResourcesMenuBtn_Click(object sender, EventArgs e)
        {
            loadform(new ResourcesForm());
        }



        private void MenuItemPanel_Paint(object sender, PaintEventArgs e)
        {
           
        }


        // Logout Button Application
        private void LogoutBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void guna2Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DigitalClock.Text = DateTime.Now.ToLongTimeString();

        }

        private void RoomScheduleButton_Click(object sender, EventArgs e)
        {
            loadform(new RoomForm());
        }

        private void PaymentButton_Click(object sender, EventArgs e)
        {
            loadform(new PaymentForm());

        }

        private void MedicationBtn_Click(object sender, EventArgs e)
        {
            loadform(new PrescriptionForm());
        }
    }
}
