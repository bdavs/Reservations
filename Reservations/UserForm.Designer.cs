﻿namespace Reservations
{
    partial class UserForm
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
            System.Windows.Forms.ListViewGroup listViewGroup4 = new System.Windows.Forms.ListViewGroup("Show", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup5 = new System.Windows.Forms.ListViewGroup("Venue", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup6 = new System.Windows.Forms.ListViewGroup("Time", System.Windows.Forms.HorizontalAlignment.Left);
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SeatSelectButton = new System.Windows.Forms.Button();
            this.AdminModeButton = new System.Windows.Forms.Button();
            this.CreateNewUserButton = new System.Windows.Forms.Button();
            this.monthCalendar = new System.Windows.Forms.MonthCalendar();
            this.CheckoutButton = new System.Windows.Forms.Button();
            this.showListBox = new System.Windows.Forms.ListView();
            this.nameComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(860, 46);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(172, 24);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.Text = "Number of Tickets";
            // 
            // SeatSelectButton
            // 
            this.SeatSelectButton.Location = new System.Drawing.Point(860, 73);
            this.SeatSelectButton.Name = "SeatSelectButton";
            this.SeatSelectButton.Size = new System.Drawing.Size(173, 43);
            this.SeatSelectButton.TabIndex = 3;
            this.SeatSelectButton.Text = "Select Seats";
            this.SeatSelectButton.UseVisualStyleBackColor = true;
            this.SeatSelectButton.Click += new System.EventHandler(this.SeatSelectButton_Click);
            // 
            // AdminModeButton
            // 
            this.AdminModeButton.Location = new System.Drawing.Point(945, 213);
            this.AdminModeButton.Name = "AdminModeButton";
            this.AdminModeButton.Size = new System.Drawing.Size(60, 42);
            this.AdminModeButton.TabIndex = 4;
            this.AdminModeButton.Text = "Admin mode";
            this.AdminModeButton.UseVisualStyleBackColor = true;
            this.AdminModeButton.Click += new System.EventHandler(this.AdminModeButton_Click);
            // 
            // CreateNewUserButton
            // 
            this.CreateNewUserButton.Location = new System.Drawing.Point(173, 10);
            this.CreateNewUserButton.Name = "CreateNewUserButton";
            this.CreateNewUserButton.Size = new System.Drawing.Size(112, 23);
            this.CreateNewUserButton.TabIndex = 6;
            this.CreateNewUserButton.Text = "Or Create New User";
            this.CreateNewUserButton.UseVisualStyleBackColor = true;
            this.CreateNewUserButton.Click += new System.EventHandler(this.CreateNewUserButton_Click);
            // 
            // monthCalendar
            // 
            this.monthCalendar.Location = new System.Drawing.Point(16, 54);
            this.monthCalendar.Margin = new System.Windows.Forms.Padding(12, 11, 12, 11);
            this.monthCalendar.Name = "monthCalendar";
            this.monthCalendar.TabIndex = 7;
            this.monthCalendar.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar_DateSelected);
            // 
            // CheckoutButton
            // 
            this.CheckoutButton.Location = new System.Drawing.Point(860, 115);
            this.CheckoutButton.Name = "CheckoutButton";
            this.CheckoutButton.Size = new System.Drawing.Size(173, 41);
            this.CheckoutButton.TabIndex = 9;
            this.CheckoutButton.Text = "Checkout";
            this.CheckoutButton.UseVisualStyleBackColor = true;
            this.CheckoutButton.Click += new System.EventHandler(this.CheckoutButton_Click);
            // 
            // showListBox
            // 
            listViewGroup4.Header = "Show";
            listViewGroup4.Name = "showGroup";
            listViewGroup5.Header = "Venue";
            listViewGroup5.Name = "venueGroup";
            listViewGroup6.Header = "Time";
            listViewGroup6.Name = "timeGroup";
            this.showListBox.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup4,
            listViewGroup5,
            listViewGroup6});
            this.showListBox.Location = new System.Drawing.Point(300, 10);
            this.showListBox.Name = "showListBox";
            this.showListBox.Size = new System.Drawing.Size(554, 276);
            this.showListBox.TabIndex = 11;
            this.showListBox.UseCompatibleStateImageBehavior = false;
            this.showListBox.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.showListBox_ColumnClick);
            // 
            // nameComboBox
            // 
            this.nameComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.nameComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.nameComboBox.FormattingEnabled = true;
            this.nameComboBox.Location = new System.Drawing.Point(16, 10);
            this.nameComboBox.Name = "nameComboBox";
            this.nameComboBox.Size = new System.Drawing.Size(151, 24);
            this.nameComboBox.Sorted = true;
            this.nameComboBox.TabIndex = 12;
            this.nameComboBox.Text = "Enter Name";
            this.nameComboBox.TextChanged += new System.EventHandler(this.nameComboBox_TextChanged);
            this.nameComboBox.Enter += new System.EventHandler(this.nameComboBox_Enter);
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1039, 295);
            this.Controls.Add(this.nameComboBox);
            this.Controls.Add(this.showListBox);
            this.Controls.Add(this.CheckoutButton);
            this.Controls.Add(this.monthCalendar);
            this.Controls.Add(this.CreateNewUserButton);
            this.Controls.Add(this.AdminModeButton);
            this.Controls.Add(this.SeatSelectButton);
            this.Controls.Add(this.comboBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UserForm";
            this.Text = "Reservations";
            this.Load += new System.EventHandler(this.UserForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button SeatSelectButton;
        private System.Windows.Forms.Button AdminModeButton;
        private System.Windows.Forms.Button CreateNewUserButton;
        private System.Windows.Forms.MonthCalendar monthCalendar;
        private System.Windows.Forms.Button CheckoutButton;
        private System.Windows.Forms.ListView showListBox;
        private System.Windows.Forms.ComboBox nameComboBox;
    }
}