namespace Health_Care_Plus_System.Screen_Forms.Medication
{
    partial class AddPrescription
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddPrescription));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label4 = new System.Windows.Forms.Label();
            this.StartDatePicker = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.PatientNameTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.PatientDataTable = new Guna.UI2.WinForms.Guna2DataGridView();
            this.MedicationNameTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.DosageTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.FrequentlyComboBox = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.EndDatePicker = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.PatientSearchTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.InstructionComboBox1 = new Guna.UI2.WinForms.Guna2ComboBox();
            this.AddButton = new Guna.UI2.WinForms.Guna2Button();
            this.DoctorNameTextBox1 = new Guna.UI2.WinForms.Guna2TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PatientDataTable)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.label4.Location = new System.Drawing.Point(58, 472);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 26);
            this.label4.TabIndex = 129;
            this.label4.Text = "Start Date";
            // 
            // StartDatePicker
            // 
            this.StartDatePicker.BackColor = System.Drawing.Color.White;
            this.StartDatePicker.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.StartDatePicker.BorderRadius = 3;
            this.StartDatePicker.Checked = true;
            this.StartDatePicker.FillColor = System.Drawing.Color.MintCream;
            this.StartDatePicker.FocusedColor = System.Drawing.Color.White;
            this.StartDatePicker.Font = new System.Drawing.Font("Poppins", 9F);
            this.StartDatePicker.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(104)))), ((int)(((byte)(112)))));
            this.StartDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.StartDatePicker.Location = new System.Drawing.Point(63, 500);
            this.StartDatePicker.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.StartDatePicker.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.StartDatePicker.Name = "StartDatePicker";
            this.StartDatePicker.Size = new System.Drawing.Size(303, 36);
            this.StartDatePicker.TabIndex = 123;
            this.StartDatePicker.Value = new System.DateTime(2023, 9, 14, 0, 0, 0, 0);
            // 
            // PatientNameTextBox
            // 
            this.PatientNameTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PatientNameTextBox.Animated = true;
            this.PatientNameTextBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(221)))), ((int)(((byte)(226)))));
            this.PatientNameTextBox.BorderRadius = 3;
            this.PatientNameTextBox.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.PatientNameTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PatientNameTextBox.DefaultText = "";
            this.PatientNameTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.PatientNameTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.PatientNameTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.PatientNameTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.PatientNameTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PatientNameTextBox.Font = new System.Drawing.Font("Poppins", 9F);
            this.PatientNameTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(104)))), ((int)(((byte)(112)))));
            this.PatientNameTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PatientNameTextBox.Location = new System.Drawing.Point(63, 134);
            this.PatientNameTextBox.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.PatientNameTextBox.Name = "PatientNameTextBox";
            this.PatientNameTextBox.Padding = new System.Windows.Forms.Padding(1);
            this.PatientNameTextBox.PasswordChar = '\0';
            this.PatientNameTextBox.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(176)))), ((int)(((byte)(185)))));
            this.PatientNameTextBox.PlaceholderText = "Patient Name";
            this.PatientNameTextBox.SelectedText = "";
            this.PatientNameTextBox.ShadowDecoration.BorderRadius = 5;
            this.PatientNameTextBox.Size = new System.Drawing.Size(303, 36);
            this.PatientNameTextBox.TabIndex = 122;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.label3.Location = new System.Drawing.Point(58, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 26);
            this.label3.TabIndex = 127;
            this.label3.Text = "Patient Name";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(15, 35);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(28, 28);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 121;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(340, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(335, 29);
            this.label1.TabIndex = 120;
            this.label1.Text = "ADD MEDICATION RECORD";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.label5.Location = new System.Drawing.Point(58, 291);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 26);
            this.label5.TabIndex = 128;
            this.label5.Text = "Dosage";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.label8.Location = new System.Drawing.Point(63, 379);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(91, 26);
            this.label8.TabIndex = 131;
            this.label8.Text = "Frequently";
            // 
            // PatientDataTable
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.PatientDataTable.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.PatientDataTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.None;
            this.PatientDataTable.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
            this.PatientDataTable.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.PatientDataTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.PatientDataTable.ColumnHeadersHeight = 22;
            this.PatientDataTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.PatientDataTable.DefaultCellStyle = dataGridViewCellStyle3;
            this.PatientDataTable.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.PatientDataTable.Location = new System.Drawing.Point(415, 134);
            this.PatientDataTable.Name = "PatientDataTable";
            this.PatientDataTable.RowHeadersVisible = false;
            this.PatientDataTable.RowHeadersWidth = 51;
            this.PatientDataTable.RowTemplate.Height = 24;
            this.PatientDataTable.Size = new System.Drawing.Size(528, 222);
            this.PatientDataTable.TabIndex = 225;
            this.PatientDataTable.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.PatientDataTable.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.PatientDataTable.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.PatientDataTable.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.PatientDataTable.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.PatientDataTable.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
            this.PatientDataTable.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.PatientDataTable.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.PatientDataTable.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.PatientDataTable.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PatientDataTable.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.PatientDataTable.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.PatientDataTable.ThemeStyle.HeaderStyle.Height = 22;
            this.PatientDataTable.ThemeStyle.ReadOnly = false;
            this.PatientDataTable.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.PatientDataTable.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.PatientDataTable.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PatientDataTable.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.PatientDataTable.ThemeStyle.RowsStyle.Height = 24;
            this.PatientDataTable.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.PatientDataTable.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.PatientDataTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.PatientDataTable_CellContentClick);
            // 
            // MedicationNameTextBox
            // 
            this.MedicationNameTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.MedicationNameTextBox.Animated = true;
            this.MedicationNameTextBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(221)))), ((int)(((byte)(226)))));
            this.MedicationNameTextBox.BorderRadius = 3;
            this.MedicationNameTextBox.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.MedicationNameTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.MedicationNameTextBox.DefaultText = "";
            this.MedicationNameTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.MedicationNameTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.MedicationNameTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.MedicationNameTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.MedicationNameTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.MedicationNameTextBox.Font = new System.Drawing.Font("Poppins", 9F);
            this.MedicationNameTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(104)))), ((int)(((byte)(112)))));
            this.MedicationNameTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.MedicationNameTextBox.Location = new System.Drawing.Point(63, 228);
            this.MedicationNameTextBox.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.MedicationNameTextBox.Name = "MedicationNameTextBox";
            this.MedicationNameTextBox.Padding = new System.Windows.Forms.Padding(1);
            this.MedicationNameTextBox.PasswordChar = '\0';
            this.MedicationNameTextBox.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(176)))), ((int)(((byte)(185)))));
            this.MedicationNameTextBox.PlaceholderText = "";
            this.MedicationNameTextBox.SelectedText = "";
            this.MedicationNameTextBox.ShadowDecoration.BorderRadius = 5;
            this.MedicationNameTextBox.Size = new System.Drawing.Size(303, 36);
            this.MedicationNameTextBox.TabIndex = 226;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.label2.Location = new System.Drawing.Point(58, 200);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 26);
            this.label2.TabIndex = 227;
            this.label2.Text = "Medication Name";
            // 
            // DosageTextBox
            // 
            this.DosageTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DosageTextBox.Animated = true;
            this.DosageTextBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(221)))), ((int)(((byte)(226)))));
            this.DosageTextBox.BorderRadius = 3;
            this.DosageTextBox.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.DosageTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.DosageTextBox.DefaultText = "";
            this.DosageTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.DosageTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.DosageTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.DosageTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.DosageTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.DosageTextBox.Font = new System.Drawing.Font("Poppins", 9F);
            this.DosageTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(104)))), ((int)(((byte)(112)))));
            this.DosageTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.DosageTextBox.Location = new System.Drawing.Point(63, 319);
            this.DosageTextBox.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.DosageTextBox.Name = "DosageTextBox";
            this.DosageTextBox.Padding = new System.Windows.Forms.Padding(1);
            this.DosageTextBox.PasswordChar = '\0';
            this.DosageTextBox.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(176)))), ((int)(((byte)(185)))));
            this.DosageTextBox.PlaceholderText = "Enter medicine (mg, ml, units)";
            this.DosageTextBox.SelectedText = "";
            this.DosageTextBox.ShadowDecoration.BorderRadius = 5;
            this.DosageTextBox.Size = new System.Drawing.Size(303, 36);
            this.DosageTextBox.TabIndex = 228;
            // 
            // FrequentlyComboBox
            // 
            this.FrequentlyComboBox.BackColor = System.Drawing.Color.Transparent;
            this.FrequentlyComboBox.BorderRadius = 3;
            this.FrequentlyComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.FrequentlyComboBox.DropDownHeight = 90;
            this.FrequentlyComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FrequentlyComboBox.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.FrequentlyComboBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.FrequentlyComboBox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.FrequentlyComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.FrequentlyComboBox.IntegralHeight = false;
            this.FrequentlyComboBox.ItemHeight = 29;
            this.FrequentlyComboBox.Items.AddRange(new object[] {
            "Once a day (Morning)",
            "Once a day (Night)",
            "Twice a day (Morning and Night)",
            "Three times a day (Morning, Afternoon, and Night)",
            "Four times a day (Morning, Noon, Afternoon, and Night)",
            "Every 6 hours",
            "Every 8 hours",
            "Every 12 hours (Morning and Night)",
            "Once a week",
            "Once every two weeks",
            "Once a month",
            "As needed (PRN - Pro Re Nata)",
            "Before meals",
            "After meals",
            "With food",
            "Without food",
            "Bedtime",
            "Every other day (Morning)",
            "Every morning",
            "Every night"});
            this.FrequentlyComboBox.Location = new System.Drawing.Point(63, 407);
            this.FrequentlyComboBox.Name = "FrequentlyComboBox";
            this.FrequentlyComboBox.Size = new System.Drawing.Size(303, 35);
            this.FrequentlyComboBox.TabIndex = 229;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.label6.Location = new System.Drawing.Point(58, 570);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 26);
            this.label6.TabIndex = 231;
            this.label6.Text = "End Date";
            // 
            // EndDatePicker
            // 
            this.EndDatePicker.BackColor = System.Drawing.Color.White;
            this.EndDatePicker.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.EndDatePicker.BorderRadius = 3;
            this.EndDatePicker.Checked = true;
            this.EndDatePicker.FillColor = System.Drawing.Color.MintCream;
            this.EndDatePicker.FocusedColor = System.Drawing.Color.White;
            this.EndDatePicker.Font = new System.Drawing.Font("Poppins", 9F);
            this.EndDatePicker.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(104)))), ((int)(((byte)(112)))));
            this.EndDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.EndDatePicker.Location = new System.Drawing.Point(63, 599);
            this.EndDatePicker.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.EndDatePicker.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.EndDatePicker.Name = "EndDatePicker";
            this.EndDatePicker.Size = new System.Drawing.Size(303, 36);
            this.EndDatePicker.TabIndex = 230;
            this.EndDatePicker.Value = new System.DateTime(2023, 9, 14, 0, 0, 0, 0);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.label10.Location = new System.Drawing.Point(434, 378);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(101, 26);
            this.label10.TabIndex = 233;
            this.label10.Text = "Instructions";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.label7.Location = new System.Drawing.Point(439, 472);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(147, 26);
            this.label7.TabIndex = 234;
            this.label7.Text = "Prescriped Doctor";
            // 
            // PatientSearchTextBox
            // 
            this.PatientSearchTextBox.Animated = true;
            this.PatientSearchTextBox.AutoRoundedCorners = true;
            this.PatientSearchTextBox.BorderRadius = 20;
            this.PatientSearchTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PatientSearchTextBox.DefaultText = "";
            this.PatientSearchTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.PatientSearchTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.PatientSearchTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.PatientSearchTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.PatientSearchTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PatientSearchTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.PatientSearchTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PatientSearchTextBox.Location = new System.Drawing.Point(685, 74);
            this.PatientSearchTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.PatientSearchTextBox.Name = "PatientSearchTextBox";
            this.PatientSearchTextBox.PasswordChar = '\0';
            this.PatientSearchTextBox.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(179)))), ((int)(((byte)(184)))));
            this.PatientSearchTextBox.PlaceholderText = "Search a Patient Names";
            this.PatientSearchTextBox.SelectedText = "";
            this.PatientSearchTextBox.Size = new System.Drawing.Size(258, 43);
            this.PatientSearchTextBox.TabIndex = 236;
            this.PatientSearchTextBox.TextChanged += new System.EventHandler(this.SearchTextBox_TextChanged);
            // 
            // InstructionComboBox1
            // 
            this.InstructionComboBox1.BackColor = System.Drawing.Color.Transparent;
            this.InstructionComboBox1.BorderRadius = 3;
            this.InstructionComboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.InstructionComboBox1.DropDownHeight = 90;
            this.InstructionComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.InstructionComboBox1.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.InstructionComboBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.InstructionComboBox1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.InstructionComboBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.InstructionComboBox1.IntegralHeight = false;
            this.InstructionComboBox1.ItemHeight = 29;
            this.InstructionComboBox1.Items.AddRange(new object[] {
            "Take with food.",
            "Do not crush or chew the tablet.",
            "Shake well before use.",
            "Store in a cool, dry place.",
            "Take one hour before bedtime.",
            "Take on an empty stomach.",
            "Take with plenty of water.",
            "Take one tablet with breakfast.",
            "Take two capsules before bedtime.",
            "Take as needed for pain.",
            "Take with food.",
            "Take on an empty stomach.",
            "Take one pill every 4 hours.",
            "Take with a full glass of water.",
            "Do not crush or chew.",
            "Shake well before using.",
            "Use only as directed.",
            "Take with milk.",
            "Take with a meal.",
            "Take one tablet every morning.",
            "Take two tablets every evening.",
            "Take one teaspoon orally.",
            "Take with plenty of water.",
            "Take before bedtime."});
            this.InstructionComboBox1.Location = new System.Drawing.Point(439, 407);
            this.InstructionComboBox1.Name = "InstructionComboBox1";
            this.InstructionComboBox1.Size = new System.Drawing.Size(303, 35);
            this.InstructionComboBox1.TabIndex = 237;
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
            this.AddButton.Location = new System.Drawing.Point(819, 614);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(124, 42);
            this.AddButton.TabIndex = 238;
            this.AddButton.Text = "    SAVE";
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // DoctorNameTextBox1
            // 
            this.DoctorNameTextBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DoctorNameTextBox1.Animated = true;
            this.DoctorNameTextBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(221)))), ((int)(((byte)(226)))));
            this.DoctorNameTextBox1.BorderRadius = 3;
            this.DoctorNameTextBox1.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.DoctorNameTextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.DoctorNameTextBox1.DefaultText = "";
            this.DoctorNameTextBox1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.DoctorNameTextBox1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.DoctorNameTextBox1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.DoctorNameTextBox1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.DoctorNameTextBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.DoctorNameTextBox1.Font = new System.Drawing.Font("Poppins", 9F);
            this.DoctorNameTextBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(104)))), ((int)(((byte)(112)))));
            this.DoctorNameTextBox1.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.DoctorNameTextBox1.Location = new System.Drawing.Point(439, 503);
            this.DoctorNameTextBox1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.DoctorNameTextBox1.Name = "DoctorNameTextBox1";
            this.DoctorNameTextBox1.Padding = new System.Windows.Forms.Padding(1);
            this.DoctorNameTextBox1.PasswordChar = '\0';
            this.DoctorNameTextBox1.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(176)))), ((int)(((byte)(185)))));
            this.DoctorNameTextBox1.PlaceholderText = "";
            this.DoctorNameTextBox1.SelectedText = "";
            this.DoctorNameTextBox1.ShadowDecoration.BorderRadius = 5;
            this.DoctorNameTextBox1.Size = new System.Drawing.Size(303, 36);
            this.DoctorNameTextBox1.TabIndex = 239;
            // 
            // AddPrescription
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(983, 696);
            this.Controls.Add(this.DoctorNameTextBox1);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.InstructionComboBox1);
            this.Controls.Add(this.PatientSearchTextBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.EndDatePicker);
            this.Controls.Add(this.FrequentlyComboBox);
            this.Controls.Add(this.DosageTextBox);
            this.Controls.Add(this.MedicationNameTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.PatientDataTable);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.StartDatePicker);
            this.Controls.Add(this.PatientNameTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Name = "AddPrescription";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.AddPrescription_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PatientDataTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2DateTimePicker StartDatePicker;
        private Guna.UI2.WinForms.Guna2TextBox PatientNameTextBox;
        private System.Windows.Forms.Label label3;
        protected internal System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private Guna.UI2.WinForms.Guna2DataGridView PatientDataTable;
        private Guna.UI2.WinForms.Guna2TextBox MedicationNameTextBox;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox DosageTextBox;
        private Guna.UI2.WinForms.Guna2ComboBox FrequentlyComboBox;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2DateTimePicker EndDatePicker;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2TextBox PatientSearchTextBox;
        private Guna.UI2.WinForms.Guna2ComboBox InstructionComboBox1;
        private Guna.UI2.WinForms.Guna2Button AddButton;
        private Guna.UI2.WinForms.Guna2TextBox DoctorNameTextBox1;
    }
}