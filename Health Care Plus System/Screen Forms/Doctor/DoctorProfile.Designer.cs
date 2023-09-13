namespace Health_Care_Plus_System.Screen_Forms.Doctor
{
    partial class DoctorProfile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DoctorProfile));
            this.closeBtn = new Guna.UI2.WinForms.Guna2ImageButton();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.ContactNoTextbox = new Guna.UI2.WinForms.Guna2TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SpecificationTextBox1 = new Guna.UI2.WinForms.Guna2TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.FullNameTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.DoctorProfilePictureBox = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.RegisterDateTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.AddressTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.QualificationTextBox1 = new Guna.UI2.WinForms.Guna2TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.AgeTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.AvalableTimeTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.AvailableDaysTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.EmailTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.genderTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.PreferredMethodTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.MedicalLicenceTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.WorkPlaceTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DoctorProfilePictureBox)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // closeBtn
            // 
            this.closeBtn.BackColor = System.Drawing.Color.Transparent;
            this.closeBtn.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.closeBtn.HoverState.ImageSize = new System.Drawing.Size(38, 38);
            this.closeBtn.Image = ((System.Drawing.Image)(resources.GetObject("closeBtn.Image")));
            this.closeBtn.ImageOffset = new System.Drawing.Point(0, 0);
            this.closeBtn.ImageRotate = 0F;
            this.closeBtn.ImageSize = new System.Drawing.Size(38, 38);
            this.closeBtn.Location = new System.Drawing.Point(972, 1);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.PressedState.ImageSize = new System.Drawing.Size(38, 38);
            this.closeBtn.Size = new System.Drawing.Size(35, 37);
            this.closeBtn.TabIndex = 6;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Pristina", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(399, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(241, 39);
            this.label1.TabIndex = 208;
            this.label1.Text = "View Doctors Profiles";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.White;
            this.guna2Panel1.Controls.Add(this.ContactNoTextbox);
            this.guna2Panel1.Controls.Add(this.label5);
            this.guna2Panel1.Controls.Add(this.SpecificationTextBox1);
            this.guna2Panel1.Controls.Add(this.label4);
            this.guna2Panel1.Controls.Add(this.FullNameTextBox);
            this.guna2Panel1.Controls.Add(this.DoctorProfilePictureBox);
            this.guna2Panel1.Controls.Add(this.label3);
            this.guna2Panel1.Location = new System.Drawing.Point(22, 82);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(328, 579);
            this.guna2Panel1.TabIndex = 209;
            // 
            // ContactNoTextbox
            // 
            this.ContactNoTextbox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ContactNoTextbox.Animated = true;
            this.ContactNoTextbox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(221)))), ((int)(((byte)(226)))));
            this.ContactNoTextbox.BorderRadius = 3;
            this.ContactNoTextbox.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.ContactNoTextbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ContactNoTextbox.DefaultText = "";
            this.ContactNoTextbox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.ContactNoTextbox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.ContactNoTextbox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.ContactNoTextbox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.ContactNoTextbox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ContactNoTextbox.Font = new System.Drawing.Font("Poppins", 7.8F);
            this.ContactNoTextbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(104)))), ((int)(((byte)(112)))));
            this.ContactNoTextbox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ContactNoTextbox.Location = new System.Drawing.Point(26, 491);
            this.ContactNoTextbox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ContactNoTextbox.Name = "ContactNoTextbox";
            this.ContactNoTextbox.Padding = new System.Windows.Forms.Padding(1);
            this.ContactNoTextbox.PasswordChar = '\0';
            this.ContactNoTextbox.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(176)))), ((int)(((byte)(185)))));
            this.ContactNoTextbox.PlaceholderText = "";
            this.ContactNoTextbox.SelectedText = "";
            this.ContactNoTextbox.ShadowDecoration.BorderRadius = 5;
            this.ContactNoTextbox.Size = new System.Drawing.Size(271, 31);
            this.ContactNoTextbox.TabIndex = 216;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Poppins", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.label5.Location = new System.Drawing.Point(22, 467);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 23);
            this.label5.TabIndex = 217;
            this.label5.Text = "Contact No";
            // 
            // SpecificationTextBox1
            // 
            this.SpecificationTextBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SpecificationTextBox1.Animated = true;
            this.SpecificationTextBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(221)))), ((int)(((byte)(226)))));
            this.SpecificationTextBox1.BorderRadius = 3;
            this.SpecificationTextBox1.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.SpecificationTextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.SpecificationTextBox1.DefaultText = "";
            this.SpecificationTextBox1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.SpecificationTextBox1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.SpecificationTextBox1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.SpecificationTextBox1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.SpecificationTextBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.SpecificationTextBox1.Font = new System.Drawing.Font("Poppins", 7.8F);
            this.SpecificationTextBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(104)))), ((int)(((byte)(112)))));
            this.SpecificationTextBox1.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.SpecificationTextBox1.Location = new System.Drawing.Point(26, 407);
            this.SpecificationTextBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SpecificationTextBox1.Name = "SpecificationTextBox1";
            this.SpecificationTextBox1.Padding = new System.Windows.Forms.Padding(1);
            this.SpecificationTextBox1.PasswordChar = '\0';
            this.SpecificationTextBox1.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(176)))), ((int)(((byte)(185)))));
            this.SpecificationTextBox1.PlaceholderText = "";
            this.SpecificationTextBox1.SelectedText = "";
            this.SpecificationTextBox1.ShadowDecoration.BorderRadius = 5;
            this.SpecificationTextBox1.Size = new System.Drawing.Size(271, 31);
            this.SpecificationTextBox1.TabIndex = 214;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Poppins", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.label4.Location = new System.Drawing.Point(22, 383);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 23);
            this.label4.TabIndex = 215;
            this.label4.Text = "Specialization";
            // 
            // FullNameTextBox
            // 
            this.FullNameTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.FullNameTextBox.Animated = true;
            this.FullNameTextBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(221)))), ((int)(((byte)(226)))));
            this.FullNameTextBox.BorderRadius = 3;
            this.FullNameTextBox.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.FullNameTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.FullNameTextBox.DefaultText = "";
            this.FullNameTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.FullNameTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.FullNameTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.FullNameTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.FullNameTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.FullNameTextBox.Font = new System.Drawing.Font("Poppins", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FullNameTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(104)))), ((int)(((byte)(112)))));
            this.FullNameTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.FullNameTextBox.Location = new System.Drawing.Point(26, 319);
            this.FullNameTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.FullNameTextBox.Name = "FullNameTextBox";
            this.FullNameTextBox.Padding = new System.Windows.Forms.Padding(1);
            this.FullNameTextBox.PasswordChar = '\0';
            this.FullNameTextBox.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(176)))), ((int)(((byte)(185)))));
            this.FullNameTextBox.PlaceholderText = "Doctor\'s Full Name";
            this.FullNameTextBox.SelectedText = "";
            this.FullNameTextBox.ShadowDecoration.BorderRadius = 5;
            this.FullNameTextBox.Size = new System.Drawing.Size(271, 31);
            this.FullNameTextBox.TabIndex = 210;
            // 
            // DoctorProfilePictureBox
            // 
            this.DoctorProfilePictureBox.BackColor = System.Drawing.Color.Transparent;
            this.DoctorProfilePictureBox.FillColor = System.Drawing.Color.WhiteSmoke;
            this.DoctorProfilePictureBox.ImageRotate = 0F;
            this.DoctorProfilePictureBox.Location = new System.Drawing.Point(56, 39);
            this.DoctorProfilePictureBox.Name = "DoctorProfilePictureBox";
            this.DoctorProfilePictureBox.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.DoctorProfilePictureBox.Size = new System.Drawing.Size(219, 220);
            this.DoctorProfilePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.DoctorProfilePictureBox.TabIndex = 210;
            this.DoctorProfilePictureBox.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Poppins", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.label3.Location = new System.Drawing.Point(22, 294);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 23);
            this.label3.TabIndex = 211;
            this.label3.Text = "Full Name";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.RegisterDateTextBox);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.AddressTextBox);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.QualificationTextBox1);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.AgeTextBox);
            this.panel1.Controls.Add(this.AvalableTimeTextBox);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.AvailableDaysTextBox);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.EmailTextBox);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.genderTextBox);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.PreferredMethodTextBox);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.MedicalLicenceTextBox);
            this.panel1.Controls.Add(this.WorkPlaceTextBox);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Location = new System.Drawing.Point(368, 82);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(623, 579);
            this.panel1.TabIndex = 210;
            // 
            // RegisterDateTextBox
            // 
            this.RegisterDateTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.RegisterDateTextBox.Animated = true;
            this.RegisterDateTextBox.BackColor = System.Drawing.Color.LightGray;
            this.RegisterDateTextBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(221)))), ((int)(((byte)(226)))));
            this.RegisterDateTextBox.BorderRadius = 3;
            this.RegisterDateTextBox.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.RegisterDateTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.RegisterDateTextBox.DefaultText = "";
            this.RegisterDateTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.RegisterDateTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.RegisterDateTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.RegisterDateTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.RegisterDateTextBox.FillColor = System.Drawing.Color.WhiteSmoke;
            this.RegisterDateTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.RegisterDateTextBox.Font = new System.Drawing.Font("Poppins", 7.8F);
            this.RegisterDateTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(104)))), ((int)(((byte)(112)))));
            this.RegisterDateTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.RegisterDateTextBox.Location = new System.Drawing.Point(327, 410);
            this.RegisterDateTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.RegisterDateTextBox.Name = "RegisterDateTextBox";
            this.RegisterDateTextBox.Padding = new System.Windows.Forms.Padding(1);
            this.RegisterDateTextBox.PasswordChar = '\0';
            this.RegisterDateTextBox.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(176)))), ((int)(((byte)(185)))));
            this.RegisterDateTextBox.PlaceholderText = "";
            this.RegisterDateTextBox.SelectedText = "";
            this.RegisterDateTextBox.ShadowDecoration.BorderRadius = 5;
            this.RegisterDateTextBox.Size = new System.Drawing.Size(271, 31);
            this.RegisterDateTextBox.TabIndex = 260;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Poppins", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.label15.Location = new System.Drawing.Point(323, 386);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(111, 23);
            this.label15.TabIndex = 261;
            this.label15.Text = "RegisteredDate";
            // 
            // AddressTextBox
            // 
            this.AddressTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AddressTextBox.Animated = true;
            this.AddressTextBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.AddressTextBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(221)))), ((int)(((byte)(226)))));
            this.AddressTextBox.BorderRadius = 3;
            this.AddressTextBox.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.AddressTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.AddressTextBox.DefaultText = "";
            this.AddressTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.AddressTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.AddressTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.AddressTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.AddressTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.AddressTextBox.Font = new System.Drawing.Font("Poppins", 7.8F);
            this.AddressTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(104)))), ((int)(((byte)(112)))));
            this.AddressTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.AddressTextBox.Location = new System.Drawing.Point(327, 158);
            this.AddressTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.AddressTextBox.Name = "AddressTextBox";
            this.AddressTextBox.Padding = new System.Windows.Forms.Padding(1);
            this.AddressTextBox.PasswordChar = '\0';
            this.AddressTextBox.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(176)))), ((int)(((byte)(185)))));
            this.AddressTextBox.PlaceholderText = "";
            this.AddressTextBox.SelectedText = "";
            this.AddressTextBox.ShadowDecoration.BorderRadius = 5;
            this.AddressTextBox.Size = new System.Drawing.Size(271, 31);
            this.AddressTextBox.TabIndex = 258;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Poppins", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.label14.Location = new System.Drawing.Point(323, 134);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(105, 23);
            this.label14.TabIndex = 259;
            this.label14.Text = "Home Address";
            // 
            // QualificationTextBox1
            // 
            this.QualificationTextBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.QualificationTextBox1.Animated = true;
            this.QualificationTextBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.QualificationTextBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(221)))), ((int)(((byte)(226)))));
            this.QualificationTextBox1.BorderRadius = 3;
            this.QualificationTextBox1.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.QualificationTextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.QualificationTextBox1.DefaultText = "";
            this.QualificationTextBox1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.QualificationTextBox1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.QualificationTextBox1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.QualificationTextBox1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.QualificationTextBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.QualificationTextBox1.Font = new System.Drawing.Font("Poppins", 7.8F);
            this.QualificationTextBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(104)))), ((int)(((byte)(112)))));
            this.QualificationTextBox1.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.QualificationTextBox1.Location = new System.Drawing.Point(22, 410);
            this.QualificationTextBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.QualificationTextBox1.Name = "QualificationTextBox1";
            this.QualificationTextBox1.Padding = new System.Windows.Forms.Padding(1);
            this.QualificationTextBox1.PasswordChar = '\0';
            this.QualificationTextBox1.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(176)))), ((int)(((byte)(185)))));
            this.QualificationTextBox1.PlaceholderText = "";
            this.QualificationTextBox1.SelectedText = "";
            this.QualificationTextBox1.ShadowDecoration.BorderRadius = 5;
            this.QualificationTextBox1.Size = new System.Drawing.Size(271, 31);
            this.QualificationTextBox1.TabIndex = 256;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Poppins", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.label13.Location = new System.Drawing.Point(18, 386);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(91, 23);
            this.label13.TabIndex = 257;
            this.label13.Text = "Qualification";
            // 
            // AgeTextBox
            // 
            this.AgeTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AgeTextBox.Animated = true;
            this.AgeTextBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.AgeTextBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(221)))), ((int)(((byte)(226)))));
            this.AgeTextBox.BorderRadius = 3;
            this.AgeTextBox.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.AgeTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.AgeTextBox.DefaultText = "";
            this.AgeTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.AgeTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.AgeTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.AgeTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.AgeTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.AgeTextBox.Font = new System.Drawing.Font("Poppins", 7.8F);
            this.AgeTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(104)))), ((int)(((byte)(112)))));
            this.AgeTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.AgeTextBox.Location = new System.Drawing.Point(22, 246);
            this.AgeTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.AgeTextBox.Name = "AgeTextBox";
            this.AgeTextBox.Padding = new System.Windows.Forms.Padding(1);
            this.AgeTextBox.PasswordChar = '\0';
            this.AgeTextBox.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(176)))), ((int)(((byte)(185)))));
            this.AgeTextBox.PlaceholderText = "";
            this.AgeTextBox.SelectedText = "";
            this.AgeTextBox.ShadowDecoration.BorderRadius = 5;
            this.AgeTextBox.Size = new System.Drawing.Size(271, 31);
            this.AgeTextBox.TabIndex = 240;
            // 
            // AvalableTimeTextBox
            // 
            this.AvalableTimeTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AvalableTimeTextBox.Animated = true;
            this.AvalableTimeTextBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.AvalableTimeTextBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(221)))), ((int)(((byte)(226)))));
            this.AvalableTimeTextBox.BorderRadius = 3;
            this.AvalableTimeTextBox.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.AvalableTimeTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.AvalableTimeTextBox.DefaultText = "";
            this.AvalableTimeTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.AvalableTimeTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.AvalableTimeTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.AvalableTimeTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.AvalableTimeTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.AvalableTimeTextBox.Font = new System.Drawing.Font("Poppins", 7.8F);
            this.AvalableTimeTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(104)))), ((int)(((byte)(112)))));
            this.AvalableTimeTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.AvalableTimeTextBox.Location = new System.Drawing.Point(327, 322);
            this.AvalableTimeTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.AvalableTimeTextBox.Name = "AvalableTimeTextBox";
            this.AvalableTimeTextBox.Padding = new System.Windows.Forms.Padding(1);
            this.AvalableTimeTextBox.PasswordChar = '\0';
            this.AvalableTimeTextBox.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(176)))), ((int)(((byte)(185)))));
            this.AvalableTimeTextBox.PlaceholderText = "";
            this.AvalableTimeTextBox.SelectedText = "";
            this.AvalableTimeTextBox.ShadowDecoration.BorderRadius = 5;
            this.AvalableTimeTextBox.Size = new System.Drawing.Size(271, 31);
            this.AvalableTimeTextBox.TabIndex = 254;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Poppins", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.label12.Location = new System.Drawing.Point(323, 298);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(104, 23);
            this.label12.TabIndex = 255;
            this.label12.Text = "Available Time";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Poppins", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.label2.Location = new System.Drawing.Point(18, 220);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 23);
            this.label2.TabIndex = 241;
            this.label2.Text = "Age";
            // 
            // AvailableDaysTextBox
            // 
            this.AvailableDaysTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AvailableDaysTextBox.Animated = true;
            this.AvailableDaysTextBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.AvailableDaysTextBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(221)))), ((int)(((byte)(226)))));
            this.AvailableDaysTextBox.BorderRadius = 3;
            this.AvailableDaysTextBox.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.AvailableDaysTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.AvailableDaysTextBox.DefaultText = "";
            this.AvailableDaysTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.AvailableDaysTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.AvailableDaysTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.AvailableDaysTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.AvailableDaysTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.AvailableDaysTextBox.Font = new System.Drawing.Font("Poppins", 7.8F);
            this.AvailableDaysTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(104)))), ((int)(((byte)(112)))));
            this.AvailableDaysTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.AvailableDaysTextBox.Location = new System.Drawing.Point(327, 242);
            this.AvailableDaysTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.AvailableDaysTextBox.Name = "AvailableDaysTextBox";
            this.AvailableDaysTextBox.Padding = new System.Windows.Forms.Padding(1);
            this.AvailableDaysTextBox.PasswordChar = '\0';
            this.AvailableDaysTextBox.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(176)))), ((int)(((byte)(185)))));
            this.AvailableDaysTextBox.PlaceholderText = "";
            this.AvailableDaysTextBox.SelectedText = "";
            this.AvailableDaysTextBox.ShadowDecoration.BorderRadius = 5;
            this.AvailableDaysTextBox.Size = new System.Drawing.Size(271, 31);
            this.AvailableDaysTextBox.TabIndex = 252;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Poppins", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.label11.Location = new System.Drawing.Point(323, 218);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(105, 23);
            this.label11.TabIndex = 253;
            this.label11.Text = "Available Days";
            // 
            // EmailTextBox
            // 
            this.EmailTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.EmailTextBox.Animated = true;
            this.EmailTextBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.EmailTextBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(221)))), ((int)(((byte)(226)))));
            this.EmailTextBox.BorderRadius = 3;
            this.EmailTextBox.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.EmailTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.EmailTextBox.DefaultText = "";
            this.EmailTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.EmailTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.EmailTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.EmailTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.EmailTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.EmailTextBox.Font = new System.Drawing.Font("Poppins", 7.8F);
            this.EmailTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(104)))), ((int)(((byte)(112)))));
            this.EmailTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.EmailTextBox.Location = new System.Drawing.Point(22, 498);
            this.EmailTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.EmailTextBox.Name = "EmailTextBox";
            this.EmailTextBox.Padding = new System.Windows.Forms.Padding(1);
            this.EmailTextBox.PasswordChar = '\0';
            this.EmailTextBox.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(176)))), ((int)(((byte)(185)))));
            this.EmailTextBox.PlaceholderText = "";
            this.EmailTextBox.SelectedText = "";
            this.EmailTextBox.ShadowDecoration.BorderRadius = 5;
            this.EmailTextBox.Size = new System.Drawing.Size(271, 31);
            this.EmailTextBox.TabIndex = 250;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Poppins", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.label10.Location = new System.Drawing.Point(18, 474);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(45, 23);
            this.label10.TabIndex = 251;
            this.label10.Text = "Email";
            // 
            // genderTextBox
            // 
            this.genderTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.genderTextBox.Animated = true;
            this.genderTextBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.genderTextBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(221)))), ((int)(((byte)(226)))));
            this.genderTextBox.BorderRadius = 3;
            this.genderTextBox.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.genderTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.genderTextBox.DefaultText = "";
            this.genderTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.genderTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.genderTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.genderTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.genderTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.genderTextBox.Font = new System.Drawing.Font("Poppins", 7.8F);
            this.genderTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(104)))), ((int)(((byte)(112)))));
            this.genderTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.genderTextBox.Location = new System.Drawing.Point(22, 330);
            this.genderTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.genderTextBox.Name = "genderTextBox";
            this.genderTextBox.Padding = new System.Windows.Forms.Padding(1);
            this.genderTextBox.PasswordChar = '\0';
            this.genderTextBox.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(176)))), ((int)(((byte)(185)))));
            this.genderTextBox.PlaceholderText = "";
            this.genderTextBox.SelectedText = "";
            this.genderTextBox.ShadowDecoration.BorderRadius = 5;
            this.genderTextBox.Size = new System.Drawing.Size(271, 31);
            this.genderTextBox.TabIndex = 248;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Poppins", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.label6.Location = new System.Drawing.Point(18, 306);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 23);
            this.label6.TabIndex = 249;
            this.label6.Text = "Gender";
            // 
            // PreferredMethodTextBox
            // 
            this.PreferredMethodTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PreferredMethodTextBox.Animated = true;
            this.PreferredMethodTextBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.PreferredMethodTextBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(221)))), ((int)(((byte)(226)))));
            this.PreferredMethodTextBox.BorderRadius = 3;
            this.PreferredMethodTextBox.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.PreferredMethodTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PreferredMethodTextBox.DefaultText = "";
            this.PreferredMethodTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.PreferredMethodTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.PreferredMethodTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.PreferredMethodTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.PreferredMethodTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PreferredMethodTextBox.Font = new System.Drawing.Font("Poppins", 7.8F);
            this.PreferredMethodTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(104)))), ((int)(((byte)(112)))));
            this.PreferredMethodTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PreferredMethodTextBox.Location = new System.Drawing.Point(327, 74);
            this.PreferredMethodTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PreferredMethodTextBox.Name = "PreferredMethodTextBox";
            this.PreferredMethodTextBox.Padding = new System.Windows.Forms.Padding(1);
            this.PreferredMethodTextBox.PasswordChar = '\0';
            this.PreferredMethodTextBox.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(176)))), ((int)(((byte)(185)))));
            this.PreferredMethodTextBox.PlaceholderText = "";
            this.PreferredMethodTextBox.SelectedText = "";
            this.PreferredMethodTextBox.ShadowDecoration.BorderRadius = 5;
            this.PreferredMethodTextBox.Size = new System.Drawing.Size(271, 31);
            this.PreferredMethodTextBox.TabIndex = 246;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Poppins", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.label7.Location = new System.Drawing.Point(323, 50);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(166, 23);
            this.label7.TabIndex = 247;
            this.label7.Text = "Communication Method";
            // 
            // MedicalLicenceTextBox
            // 
            this.MedicalLicenceTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.MedicalLicenceTextBox.Animated = true;
            this.MedicalLicenceTextBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.MedicalLicenceTextBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(221)))), ((int)(((byte)(226)))));
            this.MedicalLicenceTextBox.BorderRadius = 3;
            this.MedicalLicenceTextBox.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.MedicalLicenceTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.MedicalLicenceTextBox.DefaultText = "";
            this.MedicalLicenceTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.MedicalLicenceTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.MedicalLicenceTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.MedicalLicenceTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.MedicalLicenceTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.MedicalLicenceTextBox.Font = new System.Drawing.Font("Poppins", 7.8F);
            this.MedicalLicenceTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(104)))), ((int)(((byte)(112)))));
            this.MedicalLicenceTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.MedicalLicenceTextBox.Location = new System.Drawing.Point(22, 74);
            this.MedicalLicenceTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MedicalLicenceTextBox.Name = "MedicalLicenceTextBox";
            this.MedicalLicenceTextBox.Padding = new System.Windows.Forms.Padding(1);
            this.MedicalLicenceTextBox.PasswordChar = '\0';
            this.MedicalLicenceTextBox.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(176)))), ((int)(((byte)(185)))));
            this.MedicalLicenceTextBox.PlaceholderText = "";
            this.MedicalLicenceTextBox.SelectedText = "";
            this.MedicalLicenceTextBox.ShadowDecoration.BorderRadius = 5;
            this.MedicalLicenceTextBox.Size = new System.Drawing.Size(271, 31);
            this.MedicalLicenceTextBox.TabIndex = 242;
            // 
            // WorkPlaceTextBox
            // 
            this.WorkPlaceTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.WorkPlaceTextBox.Animated = true;
            this.WorkPlaceTextBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.WorkPlaceTextBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(221)))), ((int)(((byte)(226)))));
            this.WorkPlaceTextBox.BorderRadius = 3;
            this.WorkPlaceTextBox.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.WorkPlaceTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.WorkPlaceTextBox.DefaultText = "";
            this.WorkPlaceTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.WorkPlaceTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.WorkPlaceTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.WorkPlaceTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.WorkPlaceTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.WorkPlaceTextBox.Font = new System.Drawing.Font("Poppins", 7.8F);
            this.WorkPlaceTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(104)))), ((int)(((byte)(112)))));
            this.WorkPlaceTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.WorkPlaceTextBox.Location = new System.Drawing.Point(22, 162);
            this.WorkPlaceTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.WorkPlaceTextBox.Name = "WorkPlaceTextBox";
            this.WorkPlaceTextBox.Padding = new System.Windows.Forms.Padding(1);
            this.WorkPlaceTextBox.PasswordChar = '\0';
            this.WorkPlaceTextBox.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(176)))), ((int)(((byte)(185)))));
            this.WorkPlaceTextBox.PlaceholderText = "";
            this.WorkPlaceTextBox.SelectedText = "";
            this.WorkPlaceTextBox.ShadowDecoration.BorderRadius = 5;
            this.WorkPlaceTextBox.Size = new System.Drawing.Size(271, 31);
            this.WorkPlaceTextBox.TabIndex = 244;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Poppins", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.label9.Location = new System.Drawing.Point(18, 50);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(112, 23);
            this.label9.TabIndex = 243;
            this.label9.Text = "Medical License";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Poppins", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.label8.Location = new System.Drawing.Point(18, 137);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(102, 23);
            this.label8.TabIndex = 245;
            this.label8.Text = "Working Place";
            // 
            // DoctorProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1010, 690);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.closeBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DoctorProfile";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.DoctorProfile_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DoctorProfilePictureBox)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ImageButton closeBtn;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2CirclePictureBox DoctorProfilePictureBox;
        private Guna.UI2.WinForms.Guna2TextBox FullNameTextBox;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TextBox ContactNoTextbox;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2TextBox SpecificationTextBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2TextBox RegisterDateTextBox;
        private System.Windows.Forms.Label label15;
        private Guna.UI2.WinForms.Guna2TextBox AddressTextBox;
        private System.Windows.Forms.Label label14;
        private Guna.UI2.WinForms.Guna2TextBox QualificationTextBox1;
        private System.Windows.Forms.Label label13;
        private Guna.UI2.WinForms.Guna2TextBox AgeTextBox;
        private Guna.UI2.WinForms.Guna2TextBox AvalableTimeTextBox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox AvailableDaysTextBox;
        private System.Windows.Forms.Label label11;
        private Guna.UI2.WinForms.Guna2TextBox EmailTextBox;
        private System.Windows.Forms.Label label10;
        private Guna.UI2.WinForms.Guna2TextBox genderTextBox;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2TextBox PreferredMethodTextBox;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2TextBox MedicalLicenceTextBox;
        private Guna.UI2.WinForms.Guna2TextBox WorkPlaceTextBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
    }
}