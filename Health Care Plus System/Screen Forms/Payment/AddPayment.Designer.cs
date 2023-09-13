namespace Health_Care_Plus_System.Screen_Forms.Payment
{
    partial class AddPayment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddPayment));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.GenderComboBox = new Guna.UI2.WinForms.Guna2ComboBox();
            this.EmailTextbox = new Guna.UI2.WinForms.Guna2TextBox();
            this.DOBDateTimePicker = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.FullnameTextbox = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(30, 42);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(28, 28);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 66;
            this.pictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.label4.Location = new System.Drawing.Point(508, 197);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 26);
            this.label4.TabIndex = 64;
            this.label4.Text = "Date of Birth";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.label5.Location = new System.Drawing.Point(507, 93);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 26);
            this.label5.TabIndex = 63;
            this.label5.Text = "Gender";
            // 
            // GenderComboBox
            // 
            this.GenderComboBox.BackColor = System.Drawing.Color.Transparent;
            this.GenderComboBox.BorderRadius = 3;
            this.GenderComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.GenderComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.GenderComboBox.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.GenderComboBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.GenderComboBox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.GenderComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.GenderComboBox.ItemHeight = 30;
            this.GenderComboBox.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.GenderComboBox.Location = new System.Drawing.Point(508, 124);
            this.GenderComboBox.Name = "GenderComboBox";
            this.GenderComboBox.Size = new System.Drawing.Size(316, 36);
            this.GenderComboBox.TabIndex = 61;
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
            this.EmailTextbox.Location = new System.Drawing.Point(116, 227);
            this.EmailTextbox.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.EmailTextbox.Name = "EmailTextbox";
            this.EmailTextbox.Padding = new System.Windows.Forms.Padding(1);
            this.EmailTextbox.PasswordChar = '\0';
            this.EmailTextbox.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(176)))), ((int)(((byte)(185)))));
            this.EmailTextbox.PlaceholderText = "Email Address";
            this.EmailTextbox.SelectedText = "";
            this.EmailTextbox.ShadowDecoration.BorderRadius = 5;
            this.EmailTextbox.Size = new System.Drawing.Size(316, 36);
            this.EmailTextbox.TabIndex = 60;
            // 
            // DOBDateTimePicker
            // 
            this.DOBDateTimePicker.BackColor = System.Drawing.Color.White;
            this.DOBDateTimePicker.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.DOBDateTimePicker.BorderRadius = 3;
            this.DOBDateTimePicker.Checked = true;
            this.DOBDateTimePicker.FillColor = System.Drawing.Color.White;
            this.DOBDateTimePicker.FocusedColor = System.Drawing.Color.White;
            this.DOBDateTimePicker.Font = new System.Drawing.Font("Poppins", 9F);
            this.DOBDateTimePicker.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(104)))), ((int)(((byte)(112)))));
            this.DOBDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DOBDateTimePicker.Location = new System.Drawing.Point(512, 227);
            this.DOBDateTimePicker.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.DOBDateTimePicker.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.DOBDateTimePicker.Name = "DOBDateTimePicker";
            this.DOBDateTimePicker.Size = new System.Drawing.Size(316, 36);
            this.DOBDateTimePicker.TabIndex = 59;
            this.DOBDateTimePicker.Value = new System.DateTime(2023, 8, 22, 22, 8, 20, 402);
            // 
            // FullnameTextbox
            // 
            this.FullnameTextbox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.FullnameTextbox.Animated = true;
            this.FullnameTextbox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(221)))), ((int)(((byte)(226)))));
            this.FullnameTextbox.BorderRadius = 3;
            this.FullnameTextbox.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.FullnameTextbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.FullnameTextbox.DefaultText = "";
            this.FullnameTextbox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.FullnameTextbox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.FullnameTextbox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.FullnameTextbox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.FullnameTextbox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.FullnameTextbox.Font = new System.Drawing.Font("Poppins", 9F);
            this.FullnameTextbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(104)))), ((int)(((byte)(112)))));
            this.FullnameTextbox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.FullnameTextbox.Location = new System.Drawing.Point(116, 124);
            this.FullnameTextbox.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.FullnameTextbox.Name = "FullnameTextbox";
            this.FullnameTextbox.Padding = new System.Windows.Forms.Padding(1);
            this.FullnameTextbox.PasswordChar = '\0';
            this.FullnameTextbox.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(176)))), ((int)(((byte)(185)))));
            this.FullnameTextbox.PlaceholderText = "Enter Patient Name";
            this.FullnameTextbox.SelectedText = "";
            this.FullnameTextbox.ShadowDecoration.BorderRadius = 5;
            this.FullnameTextbox.Size = new System.Drawing.Size(316, 36);
            this.FullnameTextbox.TabIndex = 58;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(299, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(342, 29);
            this.label1.TabIndex = 57;
            this.label1.Text = "PAYMENT INVOICE RECORD";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.label3.Location = new System.Drawing.Point(111, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 26);
            this.label3.TabIndex = 62;
            this.label3.Text = "Full Name";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.label7.Location = new System.Drawing.Point(113, 199);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 26);
            this.label7.TabIndex = 65;
            this.label7.Text = "Email";
            // 
            // AddPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(976, 669);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.GenderComboBox);
            this.Controls.Add(this.EmailTextbox);
            this.Controls.Add(this.DOBDateTimePicker);
            this.Controls.Add(this.FullnameTextbox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label7);
            this.Name = "AddPayment";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected internal System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2ComboBox GenderComboBox;
        private Guna.UI2.WinForms.Guna2TextBox EmailTextbox;
        private Guna.UI2.WinForms.Guna2DateTimePicker DOBDateTimePicker;
        private Guna.UI2.WinForms.Guna2TextBox FullnameTextbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
    }
}