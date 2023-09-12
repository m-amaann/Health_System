namespace Health_Care_Plus_System.Screen_Forms.Room
{
    partial class UpdateRoom
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateRoom));
            this.StatusComboBox = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ScheduleProcedureComboBox = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.RoomTypeComboBox = new Guna.UI2.WinForms.Guna2ComboBox();
            this.RoomTheaterNoTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Updatebutton = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // StatusComboBox
            // 
            this.StatusComboBox.BackColor = System.Drawing.Color.Transparent;
            this.StatusComboBox.BorderRadius = 3;
            this.StatusComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.StatusComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.StatusComboBox.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.StatusComboBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.StatusComboBox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.StatusComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.StatusComboBox.ItemHeight = 30;
            this.StatusComboBox.Items.AddRange(new object[] {
            "Available",
            "Occupancy",
            ""});
            this.StatusComboBox.Location = new System.Drawing.Point(534, 277);
            this.StatusComboBox.Name = "StatusComboBox";
            this.StatusComboBox.Size = new System.Drawing.Size(303, 36);
            this.StatusComboBox.TabIndex = 167;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.label4.Location = new System.Drawing.Point(532, 249);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 26);
            this.label4.TabIndex = 168;
            this.label4.Text = "Status";
            // 
            // ScheduleProcedureComboBox
            // 
            this.ScheduleProcedureComboBox.BackColor = System.Drawing.Color.Transparent;
            this.ScheduleProcedureComboBox.BorderRadius = 3;
            this.ScheduleProcedureComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ScheduleProcedureComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ScheduleProcedureComboBox.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ScheduleProcedureComboBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ScheduleProcedureComboBox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.ScheduleProcedureComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.ScheduleProcedureComboBox.ItemHeight = 30;
            this.ScheduleProcedureComboBox.Items.AddRange(new object[] {
            "Special Room",
            "Standard Room ",
            "General Room",
            "Single Room",
            "Isolation Room",
            "Emergency Room",
            "Radiology Room",
            "Operating Theater"});
            this.ScheduleProcedureComboBox.Location = new System.Drawing.Point(137, 277);
            this.ScheduleProcedureComboBox.Name = "ScheduleProcedureComboBox";
            this.ScheduleProcedureComboBox.Size = new System.Drawing.Size(303, 36);
            this.ScheduleProcedureComboBox.TabIndex = 165;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.label2.Location = new System.Drawing.Point(135, 248);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(174, 26);
            this.label2.TabIndex = 166;
            this.label2.Text = "Scheduled Procedure";
            // 
            // RoomTypeComboBox
            // 
            this.RoomTypeComboBox.BackColor = System.Drawing.Color.Transparent;
            this.RoomTypeComboBox.BorderRadius = 3;
            this.RoomTypeComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.RoomTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.RoomTypeComboBox.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.RoomTypeComboBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.RoomTypeComboBox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.RoomTypeComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.RoomTypeComboBox.ItemHeight = 30;
            this.RoomTypeComboBox.Items.AddRange(new object[] {
            "THEATER ",
            "ROOM"});
            this.RoomTypeComboBox.Location = new System.Drawing.Point(534, 174);
            this.RoomTypeComboBox.Name = "RoomTypeComboBox";
            this.RoomTypeComboBox.Size = new System.Drawing.Size(303, 36);
            this.RoomTypeComboBox.TabIndex = 162;
            // 
            // RoomTheaterNoTextBox
            // 
            this.RoomTheaterNoTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.RoomTheaterNoTextBox.Animated = true;
            this.RoomTheaterNoTextBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(221)))), ((int)(((byte)(226)))));
            this.RoomTheaterNoTextBox.BorderRadius = 3;
            this.RoomTheaterNoTextBox.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.RoomTheaterNoTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.RoomTheaterNoTextBox.DefaultText = "";
            this.RoomTheaterNoTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.RoomTheaterNoTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.RoomTheaterNoTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.RoomTheaterNoTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.RoomTheaterNoTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.RoomTheaterNoTextBox.Font = new System.Drawing.Font("Poppins", 9F);
            this.RoomTheaterNoTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(104)))), ((int)(((byte)(112)))));
            this.RoomTheaterNoTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.RoomTheaterNoTextBox.Location = new System.Drawing.Point(137, 170);
            this.RoomTheaterNoTextBox.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.RoomTheaterNoTextBox.Name = "RoomTheaterNoTextBox";
            this.RoomTheaterNoTextBox.Padding = new System.Windows.Forms.Padding(1);
            this.RoomTheaterNoTextBox.PasswordChar = '\0';
            this.RoomTheaterNoTextBox.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(176)))), ((int)(((byte)(185)))));
            this.RoomTheaterNoTextBox.PlaceholderText = "Enter Room Theater Number";
            this.RoomTheaterNoTextBox.SelectedText = "";
            this.RoomTheaterNoTextBox.ShadowDecoration.BorderRadius = 5;
            this.RoomTheaterNoTextBox.Size = new System.Drawing.Size(303, 36);
            this.RoomTheaterNoTextBox.TabIndex = 160;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.label3.Location = new System.Drawing.Point(135, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 26);
            this.label3.TabIndex = 163;
            this.label3.Text = "Room Theater No";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(27, 62);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(28, 28);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 159;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(363, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(255, 29);
            this.label1.TabIndex = 158;
            this.label1.Text = "EDIT ROOM RECORD";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.label6.Location = new System.Drawing.Point(532, 146);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 26);
            this.label6.TabIndex = 164;
            this.label6.Text = "Room Type";
            // 
            // Updatebutton
            // 
            this.Updatebutton.Animated = true;
            this.Updatebutton.BorderRadius = 5;
            this.Updatebutton.CustomBorderThickness = new System.Windows.Forms.Padding(5);
            this.Updatebutton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Updatebutton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Updatebutton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Updatebutton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Updatebutton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(130)))), ((int)(((byte)(234)))));
            this.Updatebutton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Updatebutton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.Updatebutton.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Updatebutton.ImageSize = new System.Drawing.Size(15, 15);
            this.Updatebutton.Location = new System.Drawing.Point(413, 419);
            this.Updatebutton.Name = "Updatebutton";
            this.Updatebutton.Size = new System.Drawing.Size(116, 41);
            this.Updatebutton.TabIndex = 300;
            this.Updatebutton.Text = "UPDATE";
            // 
            // UpdateRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(986, 632);
            this.Controls.Add(this.Updatebutton);
            this.Controls.Add(this.StatusComboBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ScheduleProcedureComboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.RoomTypeComboBox);
            this.Controls.Add(this.RoomTheaterNoTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label6);
            this.Name = "UpdateRoom";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ComboBox StatusComboBox;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2ComboBox ScheduleProcedureComboBox;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2ComboBox RoomTypeComboBox;
        private Guna.UI2.WinForms.Guna2TextBox RoomTheaterNoTextBox;
        private System.Windows.Forms.Label label3;
        protected internal System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2Button Updatebutton;
    }
}