namespace Health_Care_Plus_System.Screen_Forms.Appointment
{
    partial class AddAppointment
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddAppointment));
            this.label8 = new System.Windows.Forms.Label();
            this.MedicalTextbox = new Guna.UI2.WinForms.Guna2TextBox();
            this.AvalableTimeComboBox = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.guna2TextBox1 = new Guna.UI2.WinForms.Guna2TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.DobDateTimePicker = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.SearchboxDoctor = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SpecializationComboBox2 = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.guna2DataGridView1 = new Guna.UI2.WinForms.Guna2DataGridView();
            this.AddButton = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.DoctorDataGrideView = new System.Windows.Forms.DataGridView();
            this.PatientDataGrideView = new System.Windows.Forms.DataGridView();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2DataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DoctorDataGrideView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PatientDataGrideView)).BeginInit();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Poppins", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.label8.Location = new System.Drawing.Point(368, 447);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 23);
            this.label8.TabIndex = 218;
            this.label8.Text = "Note";
            // 
            // MedicalTextbox
            // 
            this.MedicalTextbox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.MedicalTextbox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(221)))), ((int)(((byte)(226)))));
            this.MedicalTextbox.BorderRadius = 3;
            this.MedicalTextbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.MedicalTextbox.DefaultText = "";
            this.MedicalTextbox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.MedicalTextbox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.MedicalTextbox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.MedicalTextbox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.MedicalTextbox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.MedicalTextbox.Font = new System.Drawing.Font("Poppins", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MedicalTextbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(104)))), ((int)(((byte)(112)))));
            this.MedicalTextbox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.MedicalTextbox.Location = new System.Drawing.Point(372, 474);
            this.MedicalTextbox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MedicalTextbox.Multiline = true;
            this.MedicalTextbox.Name = "MedicalTextbox";
            this.MedicalTextbox.Padding = new System.Windows.Forms.Padding(1);
            this.MedicalTextbox.PasswordChar = '\0';
            this.MedicalTextbox.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(176)))), ((int)(((byte)(185)))));
            this.MedicalTextbox.PlaceholderText = "What Purpose of appointment";
            this.MedicalTextbox.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.MedicalTextbox.SelectedText = "";
            this.MedicalTextbox.ShadowDecoration.BorderRadius = 5;
            this.MedicalTextbox.Size = new System.Drawing.Size(377, 127);
            this.MedicalTextbox.TabIndex = 217;
            // 
            // AvalableTimeComboBox
            // 
            this.AvalableTimeComboBox.BackColor = System.Drawing.Color.Transparent;
            this.AvalableTimeComboBox.BorderRadius = 3;
            this.AvalableTimeComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.AvalableTimeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AvalableTimeComboBox.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.AvalableTimeComboBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.AvalableTimeComboBox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.AvalableTimeComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.AvalableTimeComboBox.ItemHeight = 30;
            this.AvalableTimeComboBox.Items.AddRange(new object[] {
            "09:00 AM - 2:30 PM",
            "10:00 AM - 4:00 PM",
            "04:00 PM - 9:00 PM",
            "06:00 PM - 10:30 PM",
            "9:00 PM - 1:30 AM"});
            this.AvalableTimeComboBox.Location = new System.Drawing.Point(28, 565);
            this.AvalableTimeComboBox.Name = "AvalableTimeComboBox";
            this.AvalableTimeComboBox.Size = new System.Drawing.Size(295, 36);
            this.AvalableTimeComboBox.TabIndex = 216;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Poppins", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.label7.Location = new System.Drawing.Point(24, 539);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(129, 23);
            this.label7.TabIndex = 215;
            this.label7.Text = "Appointment Time";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Poppins", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.label9.Location = new System.Drawing.Point(24, 447);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(129, 23);
            this.label9.TabIndex = 214;
            this.label9.Text = "Appointment Date";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.PatientDataGrideView);
            this.groupBox2.Controls.Add(this.guna2TextBox1);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(568, 63);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(538, 360);
            this.groupBox2.TabIndex = 212;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Select a Patient";
            // 
            // guna2TextBox1
            // 
            this.guna2TextBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.guna2TextBox1.Animated = true;
            this.guna2TextBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(221)))), ((int)(((byte)(226)))));
            this.guna2TextBox1.BorderRadius = 3;
            this.guna2TextBox1.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.guna2TextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBox1.DefaultText = "";
            this.guna2TextBox1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBox1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBox1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox1.Font = new System.Drawing.Font("Poppins", 7.8F);
            this.guna2TextBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(104)))), ((int)(((byte)(112)))));
            this.guna2TextBox1.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox1.Location = new System.Drawing.Point(33, 74);
            this.guna2TextBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.guna2TextBox1.Name = "guna2TextBox1";
            this.guna2TextBox1.Padding = new System.Windows.Forms.Padding(1);
            this.guna2TextBox1.PasswordChar = '\0';
            this.guna2TextBox1.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(176)))), ((int)(((byte)(185)))));
            this.guna2TextBox1.PlaceholderText = "Patient Name";
            this.guna2TextBox1.SelectedText = "";
            this.guna2TextBox1.ShadowDecoration.BorderRadius = 5;
            this.guna2TextBox1.Size = new System.Drawing.Size(265, 36);
            this.guna2TextBox1.TabIndex = 157;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Poppins", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.label6.Location = new System.Drawing.Point(29, 50);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 23);
            this.label6.TabIndex = 158;
            this.label6.Text = "Search";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Poppins", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.label4.Location = new System.Drawing.Point(29, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 23);
            this.label4.TabIndex = 154;
            // 
            // DobDateTimePicker
            // 
            this.DobDateTimePicker.BackColor = System.Drawing.Color.White;
            this.DobDateTimePicker.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.DobDateTimePicker.BorderRadius = 3;
            this.DobDateTimePicker.Checked = true;
            this.DobDateTimePicker.FillColor = System.Drawing.Color.White;
            this.DobDateTimePicker.FocusedColor = System.Drawing.Color.White;
            this.DobDateTimePicker.Font = new System.Drawing.Font("Poppins", 9F);
            this.DobDateTimePicker.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(104)))), ((int)(((byte)(112)))));
            this.DobDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DobDateTimePicker.Location = new System.Drawing.Point(28, 474);
            this.DobDateTimePicker.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.DobDateTimePicker.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.DobDateTimePicker.Name = "DobDateTimePicker";
            this.DobDateTimePicker.Size = new System.Drawing.Size(295, 36);
            this.DobDateTimePicker.TabIndex = 213;
            this.DobDateTimePicker.Value = new System.DateTime(2023, 8, 22, 22, 8, 20, 402);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.DoctorDataGrideView);
            this.groupBox1.Controls.Add(this.SearchboxDoctor);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.SpecializationComboBox2);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.guna2DataGridView1);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(28, 63);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(508, 360);
            this.groupBox1.TabIndex = 211;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select a Doctor";
            // 
            // SearchboxDoctor
            // 
            this.SearchboxDoctor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SearchboxDoctor.Animated = true;
            this.SearchboxDoctor.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(221)))), ((int)(((byte)(226)))));
            this.SearchboxDoctor.BorderRadius = 3;
            this.SearchboxDoctor.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.SearchboxDoctor.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.SearchboxDoctor.DefaultText = "";
            this.SearchboxDoctor.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.SearchboxDoctor.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.SearchboxDoctor.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.SearchboxDoctor.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.SearchboxDoctor.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.SearchboxDoctor.Font = new System.Drawing.Font("Poppins", 7.8F);
            this.SearchboxDoctor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(104)))), ((int)(((byte)(112)))));
            this.SearchboxDoctor.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.SearchboxDoctor.Location = new System.Drawing.Point(266, 74);
            this.SearchboxDoctor.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SearchboxDoctor.Name = "SearchboxDoctor";
            this.SearchboxDoctor.Padding = new System.Windows.Forms.Padding(1);
            this.SearchboxDoctor.PasswordChar = '\0';
            this.SearchboxDoctor.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(176)))), ((int)(((byte)(185)))));
            this.SearchboxDoctor.PlaceholderText = "Enter Doctor Name";
            this.SearchboxDoctor.SelectedText = "";
            this.SearchboxDoctor.ShadowDecoration.BorderRadius = 5;
            this.SearchboxDoctor.Size = new System.Drawing.Size(225, 36);
            this.SearchboxDoctor.TabIndex = 158;
            this.SearchboxDoctor.TextChanged += new System.EventHandler(this.SearchboxDoctor_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Poppins", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.label3.Location = new System.Drawing.Point(7, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 23);
            this.label3.TabIndex = 159;
            this.label3.Text = "Specialization";
            // 
            // SpecializationComboBox2
            // 
            this.SpecializationComboBox2.BackColor = System.Drawing.Color.Transparent;
            this.SpecializationComboBox2.BorderRadius = 3;
            this.SpecializationComboBox2.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.SpecializationComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SpecializationComboBox2.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.SpecializationComboBox2.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.SpecializationComboBox2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.SpecializationComboBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.SpecializationComboBox2.ItemHeight = 30;
            this.SpecializationComboBox2.Items.AddRange(new object[] {
            "All",
            "Cardiology: Heart",
            "Dermatology: Skin",
            "Gastroenterology: Digestive",
            "Neurology: Nervous",
            "Orthopedics: Bone",
            "Ophthalmology: Eye",
            "Otolaryngology: Ear/Nose/Throat (ENT)",
            "Pediatrics: Children",
            "Psychiatry: Mental",
            "Pulmonology: Lung",
            "Radiology: Imaging",
            "Urology: Urinary",
            "Oncology: Cancer",
            "Endocrinology: Hormone",
            "Rheumatology: Joint",
            "Nephrology: Kidney",
            "Hematology: Blood",
            "Gynecology: Female",
            "Obstetrics: Pregnancy",
            "Anesthesiology: Anesthesia",
            "Infectious Disease: Infection",
            "Allergy & Immunology: Allergies",
            "Physical Medicine: Rehabilitation",
            "Emergency Medicine: Emergency"});
            this.SpecializationComboBox2.Location = new System.Drawing.Point(10, 74);
            this.SpecializationComboBox2.Name = "SpecializationComboBox2";
            this.SpecializationComboBox2.Size = new System.Drawing.Size(224, 36);
            this.SpecializationComboBox2.TabIndex = 160;
            this.SpecializationComboBox2.SelectedIndexChanged += new System.EventHandler(this.SpecializationComboBox2_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Poppins", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.label2.Location = new System.Drawing.Point(262, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 23);
            this.label2.TabIndex = 161;
            this.label2.Text = "Search";
            // 
            // guna2DataGridView1
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.guna2DataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.guna2DataGridView1.ColumnHeadersHeight = 4;
            this.guna2DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.guna2DataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.guna2DataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.guna2DataGridView1.Location = new System.Drawing.Point(287, 234);
            this.guna2DataGridView1.Name = "guna2DataGridView1";
            this.guna2DataGridView1.RowHeadersVisible = false;
            this.guna2DataGridView1.RowHeadersWidth = 51;
            this.guna2DataGridView1.RowTemplate.Height = 24;
            this.guna2DataGridView1.Size = new System.Drawing.Size(8, 8);
            this.guna2DataGridView1.TabIndex = 157;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.guna2DataGridView1.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView1.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.Height = 4;
            this.guna2DataGridView1.ThemeStyle.ReadOnly = false;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2DataGridView1.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.guna2DataGridView1.ThemeStyle.RowsStyle.Height = 24;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.guna2DataGridView1.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // AddButton
            // 
            this.AddButton.Animated = true;
            this.AddButton.BackColor = System.Drawing.Color.Transparent;
            this.AddButton.BorderRadius = 5;
            this.AddButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.AddButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.AddButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.AddButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.AddButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(206)))), ((int)(((byte)(107)))));
            this.AddButton.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddButton.ForeColor = System.Drawing.Color.White;
            this.AddButton.Image = ((System.Drawing.Image)(resources.GetObject("AddButton.Image")));
            this.AddButton.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.AddButton.Location = new System.Drawing.Point(983, 562);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(123, 39);
            this.AddButton.TabIndex = 209;
            this.AddButton.Text = "   ADD";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(419, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(297, 29);
            this.label1.TabIndex = 208;
            this.label1.Text = "MAKE AN APPOINTMENT";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.label5.Location = new System.Drawing.Point(89, 257);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 26);
            this.label5.TabIndex = 210;
            this.label5.Text = "Gender";
            // 
            // DoctorDataGrideView
            // 
            this.DoctorDataGrideView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.DoctorDataGrideView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DoctorDataGrideView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DoctorDataGrideView.Location = new System.Drawing.Point(11, 133);
            this.DoctorDataGrideView.Name = "DoctorDataGrideView";
            this.DoctorDataGrideView.RowHeadersWidth = 51;
            this.DoctorDataGrideView.RowTemplate.Height = 24;
            this.DoctorDataGrideView.Size = new System.Drawing.Size(480, 197);
            this.DoctorDataGrideView.TabIndex = 219;
            // 
            // PatientDataGrideView
            // 
            this.PatientDataGrideView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.PatientDataGrideView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PatientDataGrideView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PatientDataGrideView.Location = new System.Drawing.Point(33, 133);
            this.PatientDataGrideView.Name = "PatientDataGrideView";
            this.PatientDataGrideView.RowHeadersWidth = 51;
            this.PatientDataGrideView.RowTemplate.Height = 24;
            this.PatientDataGrideView.Size = new System.Drawing.Size(480, 197);
            this.PatientDataGrideView.TabIndex = 220;
            // 
            // AddAppointment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1133, 664);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.MedicalTextbox);
            this.Controls.Add(this.AvalableTimeComboBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.DobDateTimePicker);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Name = "AddAppointment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.AddAppointment_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2DataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DoctorDataGrideView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PatientDataGrideView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label8;
        private Guna.UI2.WinForms.Guna2TextBox MedicalTextbox;
        private Guna.UI2.WinForms.Guna2ComboBox AvalableTimeComboBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox2;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2DateTimePicker DobDateTimePicker;
        private System.Windows.Forms.GroupBox groupBox1;
        private Guna.UI2.WinForms.Guna2TextBox SearchboxDoctor;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2ComboBox SpecializationComboBox2;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2DataGridView guna2DataGridView1;
        private Guna.UI2.WinForms.Guna2Button AddButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView PatientDataGrideView;
        private System.Windows.Forms.DataGridView DoctorDataGrideView;
    }
}