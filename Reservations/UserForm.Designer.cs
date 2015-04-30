namespace Reservations
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
            System.Windows.Forms.ListViewGroup listViewGroup1 = new System.Windows.Forms.ListViewGroup("Show", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup2 = new System.Windows.Forms.ListViewGroup("Venue", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup3 = new System.Windows.Forms.ListViewGroup("Time", System.Windows.Forms.HorizontalAlignment.Left);
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SeatSelectButton = new System.Windows.Forms.Button();
            this.AdminModeButton = new System.Windows.Forms.Button();
            this.CreateNewUserButton = new System.Windows.Forms.Button();
            this.monthCalendar = new System.Windows.Forms.MonthCalendar();
            this.CheckoutButton = new System.Windows.Forms.Button();
            this.showListBox = new System.Windows.Forms.ListView();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(12, 12);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(109, 20);
            this.NameTextBox.TabIndex = 1;
            this.NameTextBox.Text = "Enter Name";
            this.NameTextBox.TextChanged += new System.EventHandler(this.NameTextBox_TextChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9"});
            this.comboBox1.Location = new System.Drawing.Point(860, 12);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(130, 21);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.Text = "Number of Tickets";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // SeatSelectButton
            // 
            this.SeatSelectButton.Location = new System.Drawing.Point(860, 39);
            this.SeatSelectButton.Name = "SeatSelectButton";
            this.SeatSelectButton.Size = new System.Drawing.Size(130, 35);
            this.SeatSelectButton.TabIndex = 3;
            this.SeatSelectButton.Text = "Select Seats";
            this.SeatSelectButton.UseVisualStyleBackColor = true;
            this.SeatSelectButton.Click += new System.EventHandler(this.SeatSelectButton_Click);
            // 
            // AdminModeButton
            // 
            this.AdminModeButton.Location = new System.Drawing.Point(945, 172);
            this.AdminModeButton.Name = "AdminModeButton";
            this.AdminModeButton.Size = new System.Drawing.Size(45, 34);
            this.AdminModeButton.TabIndex = 4;
            this.AdminModeButton.Text = "Admin mode";
            this.AdminModeButton.UseVisualStyleBackColor = true;
            this.AdminModeButton.Click += new System.EventHandler(this.AdminModeButton_Click);
            // 
            // CreateNewUserButton
            // 
            this.CreateNewUserButton.Location = new System.Drawing.Point(127, 10);
            this.CreateNewUserButton.Name = "CreateNewUserButton";
            this.CreateNewUserButton.Size = new System.Drawing.Size(112, 23);
            this.CreateNewUserButton.TabIndex = 6;
            this.CreateNewUserButton.Text = "Or Create New User";
            this.CreateNewUserButton.UseVisualStyleBackColor = true;
            this.CreateNewUserButton.Click += new System.EventHandler(this.CreateNewUserButton_Click);
            // 
            // monthCalendar
            // 
            this.monthCalendar.Location = new System.Drawing.Point(12, 44);
            this.monthCalendar.Name = "monthCalendar";
            this.monthCalendar.TabIndex = 7;
            this.monthCalendar.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar_DateSelected);
            // 
            // CheckoutButton
            // 
            this.CheckoutButton.Location = new System.Drawing.Point(860, 81);
            this.CheckoutButton.Name = "CheckoutButton";
            this.CheckoutButton.Size = new System.Drawing.Size(130, 33);
            this.CheckoutButton.TabIndex = 9;
            this.CheckoutButton.Text = "Checkout";
            this.CheckoutButton.UseVisualStyleBackColor = true;
            this.CheckoutButton.Click += new System.EventHandler(this.CheckoutButton_Click);
            // 
            // showListBox
            // 
            listViewGroup1.Header = "Show";
            listViewGroup1.Name = "showGroup";
            listViewGroup2.Header = "Venue";
            listViewGroup2.Name = "venueGroup";
            listViewGroup3.Header = "Time";
            listViewGroup3.Name = "timeGroup";
            this.showListBox.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup1,
            listViewGroup2,
            listViewGroup3});
            this.showListBox.Location = new System.Drawing.Point(251, 12);
            this.showListBox.Name = "showListBox";
            this.showListBox.Size = new System.Drawing.Size(603, 194);
            this.showListBox.TabIndex = 11;
            this.showListBox.UseCompatibleStateImageBehavior = false;
            this.showListBox.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.showListBox_ColumnClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(860, 120);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(50, 86);
            this.button1.TabIndex = 12;
            this.button1.Text = "Display all shows";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(999, 219);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.showListBox);
            this.Controls.Add(this.CheckoutButton);
            this.Controls.Add(this.monthCalendar);
            this.Controls.Add(this.CreateNewUserButton);
            this.Controls.Add(this.AdminModeButton);
            this.Controls.Add(this.SeatSelectButton);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.NameTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "UserForm";
            this.Text = "Reservations";
            this.Load += new System.EventHandler(this.UserForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button SeatSelectButton;
        private System.Windows.Forms.Button AdminModeButton;
        private System.Windows.Forms.Button CreateNewUserButton;
        private System.Windows.Forms.MonthCalendar monthCalendar;
        private System.Windows.Forms.Button CheckoutButton;
        private System.Windows.Forms.ListView showListBox;
        private System.Windows.Forms.Button button1;
    }
}