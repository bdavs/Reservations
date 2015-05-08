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
            this.SeatSelectButton = new System.Windows.Forms.Button();
            this.AdminModeButton = new System.Windows.Forms.Button();
            this.CreateNewUserButton = new System.Windows.Forms.Button();
            this.monthCalendar = new System.Windows.Forms.MonthCalendar();
            this.CheckoutButton = new System.Windows.Forms.Button();
            this.showListBox = new System.Windows.Forms.ListView();
            this.nameComboBox = new System.Windows.Forms.ComboBox();
            this.selectDateLabel = new System.Windows.Forms.Label();
            this.selectEventLabel = new System.Windows.Forms.Label();
            this.displayAllShowsButton = new System.Windows.Forms.Button();
            this.ticketsLabel = new System.Windows.Forms.Label();
            this.ticketsComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // SeatSelectButton
            // 
            this.SeatSelectButton.Location = new System.Drawing.Point(801, 44);
            this.SeatSelectButton.Margin = new System.Windows.Forms.Padding(2);
            this.SeatSelectButton.Name = "SeatSelectButton";
            this.SeatSelectButton.Size = new System.Drawing.Size(110, 35);
            this.SeatSelectButton.TabIndex = 3;
            this.SeatSelectButton.Text = "Select Seats";
            this.SeatSelectButton.UseVisualStyleBackColor = true;
            this.SeatSelectButton.Click += new System.EventHandler(this.SeatSelectButton_Click);
            // 
            // AdminModeButton
            // 
            this.AdminModeButton.Location = new System.Drawing.Point(801, 211);
            this.AdminModeButton.Margin = new System.Windows.Forms.Padding(2);
            this.AdminModeButton.Name = "AdminModeButton";
            this.AdminModeButton.Size = new System.Drawing.Size(110, 40);
            this.AdminModeButton.TabIndex = 4;
            this.AdminModeButton.Text = "Admin mode";
            this.AdminModeButton.UseVisualStyleBackColor = true;
            this.AdminModeButton.Click += new System.EventHandler(this.AdminModeButton_Click);
            // 
            // CreateNewUserButton
            // 
            this.CreateNewUserButton.Location = new System.Drawing.Point(130, 8);
            this.CreateNewUserButton.Margin = new System.Windows.Forms.Padding(2);
            this.CreateNewUserButton.Name = "CreateNewUserButton";
            this.CreateNewUserButton.Size = new System.Drawing.Size(84, 19);
            this.CreateNewUserButton.TabIndex = 6;
            this.CreateNewUserButton.Text = "Or Create New User";
            this.CreateNewUserButton.UseVisualStyleBackColor = true;
            this.CreateNewUserButton.Click += new System.EventHandler(this.CreateNewUserButton_Click);
            // 
            // monthCalendar
            // 
            this.monthCalendar.Location = new System.Drawing.Point(12, 58);
            this.monthCalendar.Name = "monthCalendar";
            this.monthCalendar.TabIndex = 7;
            this.monthCalendar.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar_DateSelected);
            // 
            // CheckoutButton
            // 
            this.CheckoutButton.Location = new System.Drawing.Point(801, 78);
            this.CheckoutButton.Margin = new System.Windows.Forms.Padding(2);
            this.CheckoutButton.Name = "CheckoutButton";
            this.CheckoutButton.Size = new System.Drawing.Size(110, 33);
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
            this.showListBox.Location = new System.Drawing.Point(250, 22);
            this.showListBox.Margin = new System.Windows.Forms.Padding(2);
            this.showListBox.Name = "showListBox";
            this.showListBox.Size = new System.Drawing.Size(546, 229);
            this.showListBox.TabIndex = 11;
            this.showListBox.UseCompatibleStateImageBehavior = false;
            this.showListBox.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.showListBox_ColumnClick);
            this.showListBox.SelectedIndexChanged += new System.EventHandler(this.showListBox_SelectedIndexChanged);
            // 
            // nameComboBox
            // 
            this.nameComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.nameComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.nameComboBox.FormattingEnabled = true;
            this.nameComboBox.Location = new System.Drawing.Point(12, 8);
            this.nameComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.nameComboBox.Name = "nameComboBox";
            this.nameComboBox.Size = new System.Drawing.Size(114, 21);
            this.nameComboBox.Sorted = true;
            this.nameComboBox.TabIndex = 12;
            this.nameComboBox.Text = "Enter Name";
            this.nameComboBox.SelectedIndexChanged += new System.EventHandler(this.nameComboBox_SelectedIndexChanged);
            this.nameComboBox.TextChanged += new System.EventHandler(this.nameComboBox_TextChanged);
            this.nameComboBox.Enter += new System.EventHandler(this.nameComboBox_Enter);
            // 
            // selectDateLabel
            // 
            this.selectDateLabel.AutoSize = true;
            this.selectDateLabel.Location = new System.Drawing.Point(13, 45);
            this.selectDateLabel.Name = "selectDateLabel";
            this.selectDateLabel.Size = new System.Drawing.Size(70, 13);
            this.selectDateLabel.TabIndex = 13;
            this.selectDateLabel.Text = "Select a date";
            // 
            // selectEventLabel
            // 
            this.selectEventLabel.AutoSize = true;
            this.selectEventLabel.Location = new System.Drawing.Point(250, 8);
            this.selectEventLabel.Name = "selectEventLabel";
            this.selectEventLabel.Size = new System.Drawing.Size(83, 13);
            this.selectEventLabel.TabIndex = 14;
            this.selectEventLabel.Text = "Select an Event";
            // 
            // displayAllShowsButton
            // 
            this.displayAllShowsButton.Location = new System.Drawing.Point(801, 120);
            this.displayAllShowsButton.Name = "displayAllShowsButton";
            this.displayAllShowsButton.Size = new System.Drawing.Size(50, 86);
            this.displayAllShowsButton.TabIndex = 12;
            this.displayAllShowsButton.Text = "Display all shows";
            this.displayAllShowsButton.UseVisualStyleBackColor = true;
            this.displayAllShowsButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // ticketsLabel
            // 
            this.ticketsLabel.AutoSize = true;
            this.ticketsLabel.Location = new System.Drawing.Point(798, 7);
            this.ticketsLabel.Name = "ticketsLabel";
            this.ticketsLabel.Size = new System.Drawing.Size(94, 13);
            this.ticketsLabel.TabIndex = 15;
            this.ticketsLabel.Text = "Number of Tickets";
            // 
            // ticketsComboBox
            // 
            this.ticketsComboBox.DropDownHeight = 50;
            this.ticketsComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ticketsComboBox.FormattingEnabled = true;
            this.ticketsComboBox.IntegralHeight = false;
            this.ticketsComboBox.Items.AddRange(new object[] {
            "1 \t",
            "2 \t",
            "3 \t",
            "4 \t",
            "5 \t",
            "6 \t",
            "7 \t",
            "8 \t",
            "9",
            "10 \t",
            "11 \t",
            "12 \t",
            "13 \t",
            "14 \t",
            "15 \t",
            "16 \t",
            "17 \t",
            "18 \t",
            "19",
            "20 \t",
            "21 \t",
            "22 \t",
            "23 \t",
            "24 \t",
            "25 \t",
            "26 \t",
            "27 \t",
            "28 \t",
            "29",
            "30 \t",
            "31 \t",
            "32 \t",
            "33 \t",
            "34 \t",
            "35 \t",
            "36 \t",
            "37 \t",
            "38 \t",
            "39",
            "40 \t",
            "41 \t",
            "42 \t",
            "43 \t",
            "44 \t",
            "45 \t",
            "46 \t",
            "47 \t",
            "48 \t",
            "49",
            "50 \t",
            "51 \t",
            "52 \t",
            "53 \t",
            "54 \t",
            "55 \t",
            "56 \t",
            "57 \t",
            "58 \t",
            "59",
            "60 \t",
            "61 \t",
            "62 \t",
            "63 \t",
            "64 \t",
            "65 \t",
            "66 \t",
            "67 \t",
            "68 \t",
            "69",
            "70 \t",
            "71 \t",
            "72 \t",
            "73 \t",
            "74 \t",
            "75 \t",
            "76 \t",
            "77 \t",
            "78 \t",
            "79",
            "80 \t",
            "81 \t",
            "82 \t",
            "83 \t",
            "84 \t",
            "85 \t",
            "86 \t",
            "87 \t",
            "88 \t",
            "89",
            "90 \t",
            "91 \t",
            "92 \t",
            "93 \t",
            "94 \t",
            "95 \t",
            "96 \t",
            "97 \t",
            "98 \t",
            "99",
            "100"});
            this.ticketsComboBox.Location = new System.Drawing.Point(801, 22);
            this.ticketsComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.ticketsComboBox.MaxDropDownItems = 5;
            this.ticketsComboBox.Name = "ticketsComboBox";
            this.ticketsComboBox.Size = new System.Drawing.Size(110, 21);
            this.ticketsComboBox.TabIndex = 2;
            this.ticketsComboBox.SelectedIndexChanged += new System.EventHandler(this.ticketsComboBox_SelectedIndexChanged);
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(922, 255);
            this.Controls.Add(this.ticketsLabel);
            this.Controls.Add(this.displayAllShowsButton);
            this.Controls.Add(this.selectEventLabel);
            this.Controls.Add(this.selectDateLabel);
            this.Controls.Add(this.nameComboBox);
            this.Controls.Add(this.showListBox);
            this.Controls.Add(this.CheckoutButton);
            this.Controls.Add(this.monthCalendar);
            this.Controls.Add(this.CreateNewUserButton);
            this.Controls.Add(this.AdminModeButton);
            this.Controls.Add(this.SeatSelectButton);
            this.Controls.Add(this.ticketsComboBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "UserForm";
            this.Text = "Reservations";
            this.Load += new System.EventHandler(this.UserForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SeatSelectButton;
        private System.Windows.Forms.Button AdminModeButton;
        private System.Windows.Forms.Button displayAllShowsButton;
        private System.Windows.Forms.Button CreateNewUserButton;
        private System.Windows.Forms.MonthCalendar monthCalendar;
        private System.Windows.Forms.Button CheckoutButton;
        private System.Windows.Forms.ListView showListBox;
        private System.Windows.Forms.ComboBox nameComboBox;
        private System.Windows.Forms.Label selectDateLabel;
        private System.Windows.Forms.Label selectEventLabel;
        private System.Windows.Forms.Label ticketsLabel;
        private System.Windows.Forms.ComboBox ticketsComboBox;
    }
}