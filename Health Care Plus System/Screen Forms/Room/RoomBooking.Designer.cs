namespace Health_Care_Plus_System.Screen_Forms.Room
{
    partial class RoomBooking
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RoomBooking));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.FromDateDatePicker = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.AddButton = new Guna.UI2.WinForms.Guna2Button();
            this.label9 = new System.Windows.Forms.Label();
            this.guna2ComboBox1 = new Guna.UI2.WinForms.Guna2ComboBox();
            this.EndDateDatePicker = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.PatientDataGrideView = new Guna.UI2.WinForms.Guna2DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.PatientIDTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.PatientNameTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.AppoinmentIDTextBox1 = new Guna.UI2.WinForms.Guna2TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PatientDataGrideView)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(23, 61);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(28, 28);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 228;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(386, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(243, 29);
            this.label1.TabIndex = 227;
            this.label1.Text = "BOOKING A ROOM";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.label2.Location = new System.Drawing.Point(536, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 26);
            this.label2.TabIndex = 234;
            this.label2.Text = "Appointment ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.label3.Location = new System.Drawing.Point(134, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 26);
            this.label3.TabIndex = 231;
            this.label3.Text = "Room Theater No";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.label6.Location = new System.Drawing.Point(133, 221);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 26);
            this.label6.TabIndex = 232;
            this.label6.Text = "Patient ID";
            // 
            // FromDateDatePicker
            // 
            this.FromDateDatePicker.BackColor = System.Drawing.Color.White;
            this.FromDateDatePicker.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.FromDateDatePicker.BorderRadius = 3;
            this.FromDateDatePicker.Checked = true;
            this.FromDateDatePicker.FillColor = System.Drawing.Color.Azure;
            this.FromDateDatePicker.FocusedColor = System.Drawing.Color.White;
            this.FromDateDatePicker.Font = new System.Drawing.Font("Poppins", 9F);
            this.FromDateDatePicker.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(104)))), ((int)(((byte)(112)))));
            this.FromDateDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.FromDateDatePicker.Location = new System.Drawing.Point(538, 354);
            this.FromDateDatePicker.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.FromDateDatePicker.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.FromDateDatePicker.Name = "FromDateDatePicker";
            this.FromDateDatePicker.Size = new System.Drawing.Size(301, 36);
            this.FromDateDatePicker.TabIndex = 238;
            this.FromDateDatePicker.Value = new System.DateTime(2023, 8, 22, 22, 8, 20, 402);
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
            this.AddButton.Location = new System.Drawing.Point(372, 561);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(175, 42);
            this.AddButton.TabIndex = 237;
            this.AddButton.Text = "    BOOK ROOM";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.label9.Location = new System.Drawing.Point(533, 326);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(131, 26);
            this.label9.TabIndex = 239;
            this.label9.Text = "From Book Date";
            // 
            // guna2ComboBox1
            // 
            this.guna2ComboBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ComboBox1.BorderRadius = 3;
            this.guna2ComboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.guna2ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.guna2ComboBox1.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2ComboBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2ComboBox1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.guna2ComboBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.guna2ComboBox1.ItemHeight = 30;
            this.guna2ComboBox1.Location = new System.Drawing.Point(135, 141);
            this.guna2ComboBox1.Name = "guna2ComboBox1";
            this.guna2ComboBox1.Size = new System.Drawing.Size(303, 36);
            this.guna2ComboBox1.TabIndex = 242;
            // 
            // EndDateDatePicker
            // 
            this.EndDateDatePicker.BackColor = System.Drawing.Color.White;
            this.EndDateDatePicker.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.EndDateDatePicker.BorderRadius = 3;
            this.EndDateDatePicker.Checked = true;
            this.EndDateDatePicker.FillColor = System.Drawing.Color.Azure;
            this.EndDateDatePicker.FocusedColor = System.Drawing.Color.White;
            this.EndDateDatePicker.Font = new System.Drawing.Font("Poppins", 9F);
            this.EndDateDatePicker.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(104)))), ((int)(((byte)(112)))));
            this.EndDateDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.EndDateDatePicker.Location = new System.Drawing.Point(538, 469);
            this.EndDateDatePicker.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.EndDateDatePicker.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.EndDateDatePicker.Name = "EndDateDatePicker";
            this.EndDateDatePicker.Size = new System.Drawing.Size(301, 36);
            this.EndDateDatePicker.TabIndex = 243;
            this.EndDateDatePicker.Value = new System.DateTime(2023, 8, 22, 22, 8, 20, 402);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.label4.Location = new System.Drawing.Point(533, 439);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 26);
            this.label4.TabIndex = 244;
            this.label4.Text = "End Book Date";
            // 
            // PatientDataGrideView
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.PatientDataGrideView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.PatientDataGrideView.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.PatientDataGrideView.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.PatientDataGrideView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.PatientDataGrideView.ColumnHeadersHeight = 22;
            this.PatientDataGrideView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.PatientDataGrideView.DefaultCellStyle = dataGridViewCellStyle3;
            this.PatientDataGrideView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.PatientDataGrideView.Location = new System.Drawing.Point(98, 326);
            this.PatientDataGrideView.Name = "PatientDataGrideView";
            this.PatientDataGrideView.RowHeadersVisible = false;
            this.PatientDataGrideView.RowHeadersWidth = 51;
            this.PatientDataGrideView.RowTemplate.Height = 24;
            this.PatientDataGrideView.Size = new System.Drawing.Size(392, 197);
            this.PatientDataGrideView.TabIndex = 247;
            this.PatientDataGrideView.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.PatientDataGrideView.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.PatientDataGrideView.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.PatientDataGrideView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.PatientDataGrideView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.PatientDataGrideView.ThemeStyle.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.PatientDataGrideView.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.PatientDataGrideView.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.PatientDataGrideView.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.PatientDataGrideView.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PatientDataGrideView.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.PatientDataGrideView.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.PatientDataGrideView.ThemeStyle.HeaderStyle.Height = 22;
            this.PatientDataGrideView.ThemeStyle.ReadOnly = false;
            this.PatientDataGrideView.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.PatientDataGrideView.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.PatientDataGrideView.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PatientDataGrideView.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.PatientDataGrideView.ThemeStyle.RowsStyle.Height = 24;
            this.PatientDataGrideView.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.PatientDataGrideView.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.PatientDataGrideView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.PatientDataGrideView_CellContentClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.label5.Location = new System.Drawing.Point(536, 221);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 26);
            this.label5.TabIndex = 246;
            this.label5.Text = "Patient Name";
            // 
            // PatientIDTextBox
            // 
            this.PatientIDTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PatientIDTextBox.Animated = true;
            this.PatientIDTextBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(221)))), ((int)(((byte)(226)))));
            this.PatientIDTextBox.BorderRadius = 3;
            this.PatientIDTextBox.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.PatientIDTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PatientIDTextBox.DefaultText = "";
            this.PatientIDTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.PatientIDTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.PatientIDTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.PatientIDTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.PatientIDTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PatientIDTextBox.Font = new System.Drawing.Font("Poppins", 9F);
            this.PatientIDTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(104)))), ((int)(((byte)(112)))));
            this.PatientIDTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PatientIDTextBox.Location = new System.Drawing.Point(135, 249);
            this.PatientIDTextBox.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.PatientIDTextBox.Name = "PatientIDTextBox";
            this.PatientIDTextBox.Padding = new System.Windows.Forms.Padding(1);
            this.PatientIDTextBox.PasswordChar = '\0';
            this.PatientIDTextBox.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(176)))), ((int)(((byte)(185)))));
            this.PatientIDTextBox.PlaceholderText = "Patient ID";
            this.PatientIDTextBox.SelectedText = "";
            this.PatientIDTextBox.ShadowDecoration.BorderRadius = 5;
            this.PatientIDTextBox.Size = new System.Drawing.Size(303, 36);
            this.PatientIDTextBox.TabIndex = 248;
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
            this.PatientNameTextBox.Location = new System.Drawing.Point(538, 249);
            this.PatientNameTextBox.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.PatientNameTextBox.Name = "PatientNameTextBox";
            this.PatientNameTextBox.Padding = new System.Windows.Forms.Padding(1);
            this.PatientNameTextBox.PasswordChar = '\0';
            this.PatientNameTextBox.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(176)))), ((int)(((byte)(185)))));
            this.PatientNameTextBox.PlaceholderText = "Patient Name";
            this.PatientNameTextBox.SelectedText = "";
            this.PatientNameTextBox.ShadowDecoration.BorderRadius = 5;
            this.PatientNameTextBox.Size = new System.Drawing.Size(303, 36);
            this.PatientNameTextBox.TabIndex = 249;
            this.PatientNameTextBox.TextChanged += new System.EventHandler(this.PatientNameTextBox_TextChanged);
            // 
            // AppoinmentIDTextBox1
            // 
            this.AppoinmentIDTextBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AppoinmentIDTextBox1.Animated = true;
            this.AppoinmentIDTextBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(221)))), ((int)(((byte)(226)))));
            this.AppoinmentIDTextBox1.BorderRadius = 3;
            this.AppoinmentIDTextBox1.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.AppoinmentIDTextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.AppoinmentIDTextBox1.DefaultText = "";
            this.AppoinmentIDTextBox1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.AppoinmentIDTextBox1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.AppoinmentIDTextBox1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.AppoinmentIDTextBox1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.AppoinmentIDTextBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.AppoinmentIDTextBox1.Font = new System.Drawing.Font("Poppins", 9F);
            this.AppoinmentIDTextBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(104)))), ((int)(((byte)(112)))));
            this.AppoinmentIDTextBox1.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.AppoinmentIDTextBox1.Location = new System.Drawing.Point(536, 141);
            this.AppoinmentIDTextBox1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.AppoinmentIDTextBox1.Name = "AppoinmentIDTextBox1";
            this.AppoinmentIDTextBox1.Padding = new System.Windows.Forms.Padding(1);
            this.AppoinmentIDTextBox1.PasswordChar = '\0';
            this.AppoinmentIDTextBox1.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(176)))), ((int)(((byte)(185)))));
            this.AppoinmentIDTextBox1.PlaceholderText = "Appoinment ID";
            this.AppoinmentIDTextBox1.SelectedText = "";
            this.AppoinmentIDTextBox1.ShadowDecoration.BorderRadius = 5;
            this.AppoinmentIDTextBox1.Size = new System.Drawing.Size(303, 36);
            this.AppoinmentIDTextBox1.TabIndex = 250;
            // 
            // RoomBooking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(975, 640);
            this.Controls.Add(this.AppoinmentIDTextBox1);
            this.Controls.Add(this.PatientNameTextBox);
            this.Controls.Add(this.PatientIDTextBox);
            this.Controls.Add(this.PatientDataGrideView);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.EndDateDatePicker);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.guna2ComboBox1);
            this.Controls.Add(this.FromDateDatePicker);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Name = "RoomBooking";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.RoomBooking_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PatientDataGrideView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        protected internal System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2DateTimePicker FromDateDatePicker;
        private Guna.UI2.WinForms.Guna2Button AddButton;
        private System.Windows.Forms.Label label9;
        private Guna.UI2.WinForms.Guna2ComboBox guna2ComboBox1;
        private Guna.UI2.WinForms.Guna2DateTimePicker EndDateDatePicker;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2DataGridView PatientDataGrideView;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2TextBox PatientIDTextBox;
        private Guna.UI2.WinForms.Guna2TextBox PatientNameTextBox;
        private Guna.UI2.WinForms.Guna2TextBox AppoinmentIDTextBox1;
    }
}