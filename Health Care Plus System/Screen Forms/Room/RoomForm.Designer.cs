﻿namespace Health_Care_Plus_System.Screen_Forms.Room
{
    partial class RoomForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RoomForm));
            this.RoomDataGridview = new System.Windows.Forms.DataGridView();
            this.DeleteButton = new Guna.UI2.WinForms.Guna2Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SearchBtn = new Guna.UI2.WinForms.Guna2Button();
            this.SearchTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.Addbutton = new Guna.UI2.WinForms.Guna2Button();
            this.Updatebutton = new Guna.UI2.WinForms.Guna2Button();
            this.RoomBookingBtn = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.RoomDataGridview)).BeginInit();
            this.SuspendLayout();
            // 
            // RoomDataGridview
            // 
            this.RoomDataGridview.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.RoomDataGridview.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.RoomDataGridview.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RoomDataGridview.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.RoomDataGridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RoomDataGridview.Location = new System.Drawing.Point(12, 157);
            this.RoomDataGridview.Name = "RoomDataGridview";
            this.RoomDataGridview.RowHeadersWidth = 51;
            this.RoomDataGridview.RowTemplate.Height = 24;
            this.RoomDataGridview.Size = new System.Drawing.Size(970, 470);
            this.RoomDataGridview.TabIndex = 55;
            this.RoomDataGridview.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ResourceDataGridview_CellContentClick);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Animated = true;
            this.DeleteButton.BorderRadius = 5;
            this.DeleteButton.CustomBorderThickness = new System.Windows.Forms.Padding(5);
            this.DeleteButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.DeleteButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.DeleteButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.DeleteButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.DeleteButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(67)))), ((int)(((byte)(54)))));
            this.DeleteButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.DeleteButton.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.DeleteButton.ImageSize = new System.Drawing.Size(15, 15);
            this.DeleteButton.Location = new System.Drawing.Point(873, 95);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(100, 39);
            this.DeleteButton.TabIndex = 54;
            this.DeleteButton.Text = "DELETE";
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label2.Location = new System.Drawing.Point(422, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(188, 27);
            this.label2.TabIndex = 53;
            this.label2.Text = "Manage Rooms";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // SearchBtn
            // 
            this.SearchBtn.Animated = true;
            this.SearchBtn.AutoRoundedCorners = true;
            this.SearchBtn.BackColor = System.Drawing.Color.Transparent;
            this.SearchBtn.BorderRadius = 20;
            this.SearchBtn.CustomBorderThickness = new System.Windows.Forms.Padding(5);
            this.SearchBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.SearchBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.SearchBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.SearchBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.SearchBtn.FillColor = System.Drawing.Color.Gainsboro;
            this.SearchBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchBtn.ForeColor = System.Drawing.SystemColors.Highlight;
            this.SearchBtn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.SearchBtn.ImageSize = new System.Drawing.Size(17, 17);
            this.SearchBtn.Location = new System.Drawing.Point(292, 91);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.Size = new System.Drawing.Size(96, 43);
            this.SearchBtn.TabIndex = 52;
            this.SearchBtn.Text = "Search";
            // 
            // SearchTextBox
            // 
            this.SearchTextBox.Animated = true;
            this.SearchTextBox.AutoRoundedCorners = true;
            this.SearchTextBox.BorderRadius = 20;
            this.SearchTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.SearchTextBox.DefaultText = "";
            this.SearchTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.SearchTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.SearchTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.SearchTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.SearchTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.SearchTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.SearchTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.SearchTextBox.Location = new System.Drawing.Point(29, 91);
            this.SearchTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.SearchTextBox.Name = "SearchTextBox";
            this.SearchTextBox.PasswordChar = '\0';
            this.SearchTextBox.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(179)))), ((int)(((byte)(184)))));
            this.SearchTextBox.PlaceholderText = "Enter Search....";
            this.SearchTextBox.SelectedText = "";
            this.SearchTextBox.Size = new System.Drawing.Size(258, 43);
            this.SearchTextBox.TabIndex = 51;
            this.SearchTextBox.TextChanged += new System.EventHandler(this.SearchTextBox_TextChanged);
            // 
            // Addbutton
            // 
            this.Addbutton.Animated = true;
            this.Addbutton.BackColor = System.Drawing.Color.Transparent;
            this.Addbutton.BorderRadius = 5;
            this.Addbutton.CustomBorderThickness = new System.Windows.Forms.Padding(5);
            this.Addbutton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Addbutton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Addbutton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Addbutton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Addbutton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(206)))), ((int)(((byte)(107)))));
            this.Addbutton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Addbutton.ForeColor = System.Drawing.Color.White;
            this.Addbutton.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Addbutton.ImageSize = new System.Drawing.Size(17, 17);
            this.Addbutton.Location = new System.Drawing.Point(649, 95);
            this.Addbutton.Name = "Addbutton";
            this.Addbutton.Size = new System.Drawing.Size(102, 39);
            this.Addbutton.TabIndex = 50;
            this.Addbutton.Text = "ADD";
            this.Addbutton.Click += new System.EventHandler(this.Addbutton_Click);
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
            this.Updatebutton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.Updatebutton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.Updatebutton.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Updatebutton.ImageSize = new System.Drawing.Size(15, 15);
            this.Updatebutton.Location = new System.Drawing.Point(762, 95);
            this.Updatebutton.Name = "Updatebutton";
            this.Updatebutton.Size = new System.Drawing.Size(100, 39);
            this.Updatebutton.TabIndex = 49;
            this.Updatebutton.Text = "UPDATE";
            this.Updatebutton.Click += new System.EventHandler(this.Updatebutton_Click);
            // 
            // RoomBookingBtn
            // 
            this.RoomBookingBtn.Animated = true;
            this.RoomBookingBtn.BorderRadius = 10;
            this.RoomBookingBtn.CustomBorderThickness = new System.Windows.Forms.Padding(5);
            this.RoomBookingBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.RoomBookingBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.RoomBookingBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.RoomBookingBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.RoomBookingBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(223)))), ((int)(((byte)(203)))));
            this.RoomBookingBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.RoomBookingBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(131)))), ((int)(((byte)(149)))));
            this.RoomBookingBtn.Image = ((System.Drawing.Image)(resources.GetObject("RoomBookingBtn.Image")));
            this.RoomBookingBtn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.RoomBookingBtn.ImageSize = new System.Drawing.Size(21, 21);
            this.RoomBookingBtn.Location = new System.Drawing.Point(12, 653);
            this.RoomBookingBtn.Name = "RoomBookingBtn";
            this.RoomBookingBtn.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.RoomBookingBtn.Size = new System.Drawing.Size(184, 39);
            this.RoomBookingBtn.TabIndex = 56;
            this.RoomBookingBtn.Text = "  Room Booking";
            this.RoomBookingBtn.Click += new System.EventHandler(this.RoomBookingBtn_Click);
            // 
            // RoomForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(995, 704);
            this.Controls.Add(this.RoomBookingBtn);
            this.Controls.Add(this.RoomDataGridview);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.SearchBtn);
            this.Controls.Add(this.SearchTextBox);
            this.Controls.Add(this.Addbutton);
            this.Controls.Add(this.Updatebutton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RoomForm";
            this.Text = "RoomForm";
            this.Load += new System.EventHandler(this.RoomForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.RoomDataGridview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView RoomDataGridview;
        private Guna.UI2.WinForms.Guna2Button DeleteButton;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2Button SearchBtn;
        private Guna.UI2.WinForms.Guna2TextBox SearchTextBox;
        private Guna.UI2.WinForms.Guna2Button Addbutton;
        private Guna.UI2.WinForms.Guna2Button Updatebutton;
        private Guna.UI2.WinForms.Guna2Button RoomBookingBtn;
    }
}