namespace Health_Care_Plus_System.Screen_Forms.AdminAcceess
{
    partial class AddUsers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddUsers));
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.AddButton = new Guna.UI2.WinForms.Guna2Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.LastTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.RoleComboBox = new Guna.UI2.WinForms.Guna2ComboBox();
            this.EmailTextbox = new Guna.UI2.WinForms.Guna2TextBox();
            this.FirstTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.PasstxtBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.Usertxtbox = new Guna.UI2.WinForms.Guna2TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(27, 32);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(28, 28);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 161;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
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
            this.AddButton.Location = new System.Drawing.Point(414, 601);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(117, 37);
            this.AddButton.TabIndex = 160;
            this.AddButton.Text = "   SAVE";
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.label2.Location = new System.Drawing.Point(528, 453);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 26);
            this.label2.TabIndex = 159;
            this.label2.Text = "Password";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.label4.Location = new System.Drawing.Point(144, 451);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 26);
            this.label4.TabIndex = 157;
            this.label4.Text = "Username";
            // 
            // LastTextBox
            // 
            this.LastTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LastTextBox.Animated = true;
            this.LastTextBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(221)))), ((int)(((byte)(226)))));
            this.LastTextBox.BorderRadius = 3;
            this.LastTextBox.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.LastTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.LastTextBox.DefaultText = "";
            this.LastTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.LastTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.LastTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.LastTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.LastTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.LastTextBox.Font = new System.Drawing.Font("Poppins", 9F);
            this.LastTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(104)))), ((int)(((byte)(112)))));
            this.LastTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.LastTextBox.Location = new System.Drawing.Point(531, 272);
            this.LastTextBox.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.LastTextBox.Name = "LastTextBox";
            this.LastTextBox.Padding = new System.Windows.Forms.Padding(1);
            this.LastTextBox.PasswordChar = '\0';
            this.LastTextBox.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(176)))), ((int)(((byte)(185)))));
            this.LastTextBox.PlaceholderText = "Enter Last Name";
            this.LastTextBox.SelectedText = "";
            this.LastTextBox.ShadowDecoration.BorderRadius = 5;
            this.LastTextBox.Size = new System.Drawing.Size(303, 36);
            this.LastTextBox.TabIndex = 154;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.label12.Location = new System.Drawing.Point(526, 244);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(90, 26);
            this.label12.TabIndex = 155;
            this.label12.Text = "Last Name";
            // 
            // RoleComboBox
            // 
            this.RoleComboBox.BackColor = System.Drawing.Color.Transparent;
            this.RoleComboBox.BorderRadius = 3;
            this.RoleComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.RoleComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.RoleComboBox.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.RoleComboBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.RoleComboBox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.RoleComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.RoleComboBox.ItemHeight = 30;
            this.RoleComboBox.Items.AddRange(new object[] {
            "Admin",
            "Receptionist"});
            this.RoleComboBox.Location = new System.Drawing.Point(531, 376);
            this.RoleComboBox.Name = "RoleComboBox";
            this.RoleComboBox.Size = new System.Drawing.Size(303, 36);
            this.RoleComboBox.TabIndex = 150;
            // 
            // EmailTextbox
            // 
            this.EmailTextbox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.EmailTextbox.Animated = true;
            this.EmailTextbox.BackColor = System.Drawing.Color.Transparent;
            this.EmailTextbox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(221)))), ((int)(((byte)(226)))));
            this.EmailTextbox.BorderRadius = 3;
            this.EmailTextbox.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.EmailTextbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.EmailTextbox.DefaultText = "";
            this.EmailTextbox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.EmailTextbox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.EmailTextbox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.EmailTextbox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.EmailTextbox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.EmailTextbox.Font = new System.Drawing.Font("Poppins", 9F);
            this.EmailTextbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(104)))), ((int)(((byte)(112)))));
            this.EmailTextbox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.EmailTextbox.Location = new System.Drawing.Point(149, 376);
            this.EmailTextbox.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.EmailTextbox.Name = "EmailTextbox";
            this.EmailTextbox.Padding = new System.Windows.Forms.Padding(1);
            this.EmailTextbox.PasswordChar = '\0';
            this.EmailTextbox.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(176)))), ((int)(((byte)(185)))));
            this.EmailTextbox.PlaceholderText = "Email Address";
            this.EmailTextbox.SelectedText = "";
            this.EmailTextbox.ShadowDecoration.BorderRadius = 5;
            this.EmailTextbox.Size = new System.Drawing.Size(303, 36);
            this.EmailTextbox.TabIndex = 149;
            // 
            // FirstTextBox
            // 
            this.FirstTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.FirstTextBox.Animated = true;
            this.FirstTextBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(221)))), ((int)(((byte)(226)))));
            this.FirstTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.FirstTextBox.DefaultText = "";
            this.FirstTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.FirstTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.FirstTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.FirstTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.FirstTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.FirstTextBox.Font = new System.Drawing.Font("Poppins", 9F);
            this.FirstTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(104)))), ((int)(((byte)(112)))));
            this.FirstTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.FirstTextBox.Location = new System.Drawing.Point(149, 272);
            this.FirstTextBox.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.FirstTextBox.Name = "FirstTextBox";
            this.FirstTextBox.Padding = new System.Windows.Forms.Padding(1);
            this.FirstTextBox.PasswordChar = '\0';
            this.FirstTextBox.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(176)))), ((int)(((byte)(185)))));
            this.FirstTextBox.PlaceholderText = "Enter First Name";
            this.FirstTextBox.SelectedText = "";
            this.FirstTextBox.ShadowDecoration.BorderRadius = 5;
            this.FirstTextBox.Size = new System.Drawing.Size(303, 36);
            this.FirstTextBox.TabIndex = 148;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.label3.Location = new System.Drawing.Point(144, 244);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 26);
            this.label3.TabIndex = 151;
            this.label3.Text = "First Name";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.label7.Location = new System.Drawing.Point(146, 348);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 26);
            this.label7.TabIndex = 152;
            this.label7.Text = "Email";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.label6.Location = new System.Drawing.Point(529, 350);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 26);
            this.label6.TabIndex = 153;
            this.label6.Text = "Role";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(351, 140);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(266, 29);
            this.label1.TabIndex = 147;
            this.label1.Text = "ADD ACCESS DETAILS";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(444, 32);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(99, 93);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 146;
            this.pictureBox1.TabStop = false;
            // 
            // PasstxtBox
            // 
            this.PasstxtBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PasstxtBox.DefaultText = "";
            this.PasstxtBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.PasstxtBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.PasstxtBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.PasstxtBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.PasstxtBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PasstxtBox.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasstxtBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.PasstxtBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PasstxtBox.IconLeft = ((System.Drawing.Image)(resources.GetObject("PasstxtBox.IconLeft")));
            this.PasstxtBox.IconLeftSize = new System.Drawing.Size(15, 15);
            this.PasstxtBox.IconRightSize = new System.Drawing.Size(17, 17);
            this.PasstxtBox.Location = new System.Drawing.Point(531, 479);
            this.PasstxtBox.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.PasstxtBox.Name = "PasstxtBox";
            this.PasstxtBox.PasswordChar = '\0';
            this.PasstxtBox.PlaceholderText = "Password";
            this.PasstxtBox.SelectedText = "";
            this.PasstxtBox.ShadowDecoration.BorderRadius = 15;
            this.PasstxtBox.Size = new System.Drawing.Size(303, 36);
            this.PasstxtBox.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.PasstxtBox.TabIndex = 163;
            // 
            // Usertxtbox
            // 
            this.Usertxtbox.AutoRoundedCorners = true;
            this.Usertxtbox.BorderRadius = 17;
            this.Usertxtbox.BorderThickness = 0;
            this.Usertxtbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Usertxtbox.DefaultText = "";
            this.Usertxtbox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Usertxtbox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Usertxtbox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Usertxtbox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Usertxtbox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Usertxtbox.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Usertxtbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Usertxtbox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Usertxtbox.IconLeft = ((System.Drawing.Image)(resources.GetObject("Usertxtbox.IconLeft")));
            this.Usertxtbox.IconLeftSize = new System.Drawing.Size(15, 15);
            this.Usertxtbox.Location = new System.Drawing.Point(151, 479);
            this.Usertxtbox.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Usertxtbox.Name = "Usertxtbox";
            this.Usertxtbox.PasswordChar = '\0';
            this.Usertxtbox.PlaceholderText = "User Name";
            this.Usertxtbox.SelectedText = "";
            this.Usertxtbox.ShadowDecoration.BorderRadius = 15;
            this.Usertxtbox.Size = new System.Drawing.Size(301, 36);
            this.Usertxtbox.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.Usertxtbox.TabIndex = 162;
            // 
            // AddUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(990, 720);
            this.Controls.Add(this.PasstxtBox);
            this.Controls.Add(this.Usertxtbox);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.LastTextBox);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.RoleComboBox);
            this.Controls.Add(this.EmailTextbox);
            this.Controls.Add(this.FirstTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddUsers";
            this.Text = "AccessUsers";
            this.Load += new System.EventHandler(this.AddUsers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected internal System.Windows.Forms.PictureBox pictureBox2;
        private Guna.UI2.WinForms.Guna2Button AddButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2TextBox LastTextBox;
        private System.Windows.Forms.Label label12;
        private Guna.UI2.WinForms.Guna2ComboBox RoleComboBox;
        private Guna.UI2.WinForms.Guna2TextBox EmailTextbox;
        private Guna.UI2.WinForms.Guna2TextBox FirstTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2TextBox PasstxtBox;
        private Guna.UI2.WinForms.Guna2TextBox Usertxtbox;
    }
}