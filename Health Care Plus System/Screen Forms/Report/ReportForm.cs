using CrystalDecisions.ReportAppServer.DataDefModel;
using Health_Care_Plus_System.Screen_Forms.Room;
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

namespace Health_Care_Plus_System.Screen_Forms.Report
{
    public partial class ReportForm : Form
    {
        private string connectionString = Properties.Settings.Default.DBConnectionString; // connecting DB string statement
        private DataTable dataTable;


        public ReportForm()
        {
            InitializeComponent();

            CategoryComboBox.Items.AddRange(new object[] { "Patient", "Staff", "Doctors", "Payments", "RoomBooking", "Appointment", "Resources", "Users", "Rooms", "Prescription" });
        }

        private void ReportForm_Load(object sender, EventArgs e)
        {

        }

        private void CategoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }

        private void FilterBtn_Click(object sender, EventArgs e)
        {
            string selectedTable = CategoryComboBox.SelectedItem.ToString();
            DateTime fromDate = FromDate.Value;
            DateTime toDate = ToDate.Value;

            string query = $"SELECT * FROM {selectedTable} WHERE created_at >=  '{fromDate:yyyy-MM-dd}' AND created_at < '{toDate:yyyy-MM-dd}'";

            Console.WriteLine("SQL Query: " + query);

            // Execute the query and populate the DataGridView
            DataTable dataTable = ExecuteQuery(query);
            ReportDatGridTable.DataSource = dataTable;
        }




        private DataTable ExecuteQuery(string query)
        {
            // database connection
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        return dataTable;
                    }
                }
            }
        }

        private void GenerateBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (ReportDatGridTable != null && ReportDatGridTable.Rows.Count > 0)
                {
                    Microsoft.Office.Interop.Excel.ApplicationClass MExcel = new Microsoft.Office.Interop.Excel.ApplicationClass();
                    MExcel.Application.Workbooks.Add(Type.Missing);

                    // Adding headers
                    for (int i = 1; i < ReportDatGridTable.Columns.Count + 1; i++)
                    {
                        MExcel.Cells[1, i] = ReportDatGridTable.Columns[i - 1].HeaderText;
                    }

                    // Adding data
                    for (int i = 0; i < ReportDatGridTable.Rows.Count; i++)
                    {
                        for (int j = 0; j < ReportDatGridTable.Columns.Count; j++)
                        {
                            MExcel.Cells[i + 2, j + 1] = ReportDatGridTable.Rows[i].Cells[j].Value?.ToString() ?? "";
                        }
                    }

                    MExcel.Columns.AutoFit();
                    MExcel.Rows.AutoFit();
                    MExcel.Columns.Font.Size = 12;
                    MExcel.Visible = true;
                }
                else
                {
                    MessageBox.Show("No records found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

