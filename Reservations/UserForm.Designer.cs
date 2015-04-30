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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SeatSelectButton = new System.Windows.Forms.Button();
            this.AdminModeButton = new System.Windows.Forms.Button();
            this.CreateNewUserButton = new System.Windows.Forms.Button();
            this.monthCalendar = new System.Windows.Forms.MonthCalendar();
            this.ShowsBox = new System.Windows.Forms.ListBox();
            this.CheckoutButton = new System.Windows.Forms.Button();
            this.ShowBoxTree = new System.Windows.Forms.TreeView();
            this.listView1 = new System.Windows.Forms.ListView();
            this.nameComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(620, 57);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(172, 24);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.Text = "Number of Tickets";
            // 
            // SeatSelectButton
            // 
            this.SeatSelectButton.Location = new System.Drawing.Point(620, 90);
            this.SeatSelectButton.Margin = new System.Windows.Forms.Padding(4);
            this.SeatSelectButton.Name = "SeatSelectButton";
            this.SeatSelectButton.Size = new System.Drawing.Size(173, 43);
            this.SeatSelectButton.TabIndex = 3;
            this.SeatSelectButton.Text = "Select Seats";
            this.SeatSelectButton.UseVisualStyleBackColor = true;
            this.SeatSelectButton.Click += new System.EventHandler(this.SeatSelectButton_Click);
            // 
            // AdminModeButton
            // 
            this.AdminModeButton.Location = new System.Drawing.Point(733, 262);
            this.AdminModeButton.Margin = new System.Windows.Forms.Padding(4);
            this.AdminModeButton.Name = "AdminModeButton";
            this.AdminModeButton.Size = new System.Drawing.Size(60, 42);
            this.AdminModeButton.TabIndex = 4;
            this.AdminModeButton.Text = "Admin mode";
            this.AdminModeButton.UseVisualStyleBackColor = true;
            this.AdminModeButton.Click += new System.EventHandler(this.AdminModeButton_Click);
            // 
            // CreateNewUserButton
            // 
            this.CreateNewUserButton.Location = new System.Drawing.Point(184, 11);
            this.CreateNewUserButton.Margin = new System.Windows.Forms.Padding(4);
            this.CreateNewUserButton.Name = "CreateNewUserButton";
            this.CreateNewUserButton.Size = new System.Drawing.Size(159, 28);
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
            // ShowsBox
            // 
            this.ShowsBox.FormattingEnabled = true;
            this.ShowsBox.ItemHeight = 16;
            this.ShowsBox.Location = new System.Drawing.Point(335, 57);
            this.ShowsBox.Margin = new System.Windows.Forms.Padding(4);
            this.ShowsBox.Name = "ShowsBox";
            this.ShowsBox.Size = new System.Drawing.Size(241, 116);
            this.ShowsBox.TabIndex = 8;
            // 
            // CheckoutButton
            // 
            this.CheckoutButton.Location = new System.Drawing.Point(620, 142);
            this.CheckoutButton.Margin = new System.Windows.Forms.Padding(4);
            this.CheckoutButton.Name = "CheckoutButton";
            this.CheckoutButton.Size = new System.Drawing.Size(173, 41);
            this.CheckoutButton.TabIndex = 9;
            this.CheckoutButton.Text = "Checkout";
            this.CheckoutButton.UseVisualStyleBackColor = true;
            this.CheckoutButton.Click += new System.EventHandler(this.CheckoutButton_Click);
            // 
            // ShowBoxTree
            // 
            this.ShowBoxTree.Location = new System.Drawing.Point(335, 181);
            this.ShowBoxTree.Margin = new System.Windows.Forms.Padding(4);
            this.ShowBoxTree.Name = "ShowBoxTree";
            this.ShowBoxTree.Size = new System.Drawing.Size(241, 122);
            this.ShowBoxTree.TabIndex = 10;
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(585, 190);
            this.listView1.Margin = new System.Windows.Forms.Padding(4);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(160, 118);
            this.listView1.TabIndex = 11;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // nameComboBox
            // 
            this.nameComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.nameComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.nameComboBox.FormattingEnabled = true;
            this.nameComboBox.Location = new System.Drawing.Point(16, 14);
            this.nameComboBox.Name = "nameComboBox";
            this.nameComboBox.Size = new System.Drawing.Size(161, 24);
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
            this.ClientSize = new System.Drawing.Size(809, 319);
            this.Controls.Add(this.nameComboBox);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.ShowBoxTree);
            this.Controls.Add(this.CheckoutButton);
            this.Controls.Add(this.ShowsBox);
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
        private System.Windows.Forms.ListBox ShowsBox;
        private System.Windows.Forms.Button CheckoutButton;
        private System.Windows.Forms.TreeView ShowBoxTree;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ComboBox nameComboBox;
    }
}