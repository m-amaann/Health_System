namespace Health_Care_Plus_System.Screen_Forms.EMR
{
    partial class EMRForm
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
            this.EMRDataGridTable = new System.Windows.Forms.DataGridView();
            this.DeleteButton = new Guna.UI2.WinForms.Guna2Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SearchTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.Addbutton = new Guna.UI2.WinForms.Guna2Button();
            this.Updatebutton = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.EMRDataGridTable)).BeginInit();
            this.SuspendLayout();
            // 
            // EMRDataGridTable
            // 
            this.EMRDataGridTable.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.EMRDataGridTable.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.EMRDataGridTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.EMRDataGridTable.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.EMRDataGridTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EMRDataGridTable.Location = new System.Drawing.Point(12, 162);
            this.EMRDataGridTable.Name = "EMRDataGridTable";
            this.EMRDataGridTable.RowHeadersWidth = 51;
            this.EMRDataGridTable.RowTemplate.Height = 24;
            this.EMRDataGridTable.Size = new System.Drawing.Size(970, 523);
            this.EMRDataGridTable.TabIndex = 55;
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
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label2.Location = new System.Drawing.Point(326, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(409, 27);
            this.label2.TabIndex = 53;
            this.label2.Text = "Manage Eelectronic Medical (EMR)";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
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
            // 
            // EMRForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(995, 704);
            this.Controls.Add(this.EMRDataGridTable);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.SearchTextBox);
            this.Controls.Add(this.Addbutton);
            this.Controls.Add(this.Updatebutton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EMRForm";
            this.Text = "EMRForm";
            ((System.ComponentModel.ISupportInitialize)(this.EMRDataGridTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView EMRDataGridTable;
        private Guna.UI2.WinForms.Guna2Button DeleteButton;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox SearchTextBox;
        private Guna.UI2.WinForms.Guna2Button Addbutton;
        private Guna.UI2.WinForms.Guna2Button Updatebutton;
    }
}