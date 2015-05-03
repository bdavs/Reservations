namespace Reservations
{
    partial class AdminForm
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
            this.DateSelect = new System.Windows.Forms.MonthCalendar();
            this.UserList = new System.Windows.Forms.ListBox();
            this.DateLabel = new System.Windows.Forms.Label();
            this.UserLabel = new System.Windows.Forms.Label();
            this.EditUserButton = new System.Windows.Forms.Button();
            this.BackButton = new System.Windows.Forms.Button();
            this.addEventButtons = new System.Windows.Forms.Button();
            this.editEventButton = new System.Windows.Forms.Button();
            this.ViewUserButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // DateSelect
            // 
            this.DateSelect.Location = new System.Drawing.Point(24, 63);
            this.DateSelect.Margin = new System.Windows.Forms.Padding(12, 11, 12, 11);
            this.DateSelect.Name = "DateSelect";
            this.DateSelect.TabIndex = 8;
            this.DateSelect.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.DateSelect_DateSelected);
            // 
            // UserList
            // 
            this.UserList.FormattingEnabled = true;
            this.UserList.ItemHeight = 16;
            this.UserList.Location = new System.Drawing.Point(309, 65);
            this.UserList.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.UserList.Name = "UserList";
            this.UserList.Size = new System.Drawing.Size(310, 196);
            this.UserList.TabIndex = 9;
            this.UserList.SelectedIndexChanged += new System.EventHandler(this.UserList_SelectedIndexChanged);
            // 
            // DateLabel
            // 
            this.DateLabel.AutoSize = true;
            this.DateLabel.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateLabel.Location = new System.Drawing.Point(136, 22);
            this.DateLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.DateLabel.Name = "DateLabel";
            this.DateLabel.Size = new System.Drawing.Size(69, 31);
            this.DateLabel.TabIndex = 10;
            this.DateLabel.Text = "Date";
            // 
            // UserLabel
            // 
            this.UserLabel.AutoSize = true;
            this.UserLabel.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserLabel.Location = new System.Drawing.Point(417, 22);
            this.UserLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.UserLabel.Name = "UserLabel";
            this.UserLabel.Size = new System.Drawing.Size(93, 31);
            this.UserLabel.TabIndex = 11;
            this.UserLabel.Text = "Events";
            // 
            // EditUserButton
            // 
            this.EditUserButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EditUserButton.Location = new System.Drawing.Point(643, 65);
            this.EditUserButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.EditUserButton.Name = "EditUserButton";
            this.EditUserButton.Size = new System.Drawing.Size(117, 33);
            this.EditUserButton.TabIndex = 12;
            this.EditUserButton.Text = "View Seats";
            this.EditUserButton.UseVisualStyleBackColor = true;
            this.EditUserButton.Click += new System.EventHandler(this.EditUserButton_Click);
            // 
            // BackButton
            // 
            this.BackButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BackButton.Location = new System.Drawing.Point(643, 229);
            this.BackButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(117, 33);
            this.BackButton.TabIndex = 13;
            this.BackButton.Text = "Go Back";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // addEventButtons
            // 
            this.addEventButtons.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addEventButtons.Location = new System.Drawing.Point(643, 188);
            this.addEventButtons.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.addEventButtons.Name = "addEventButtons";
            this.addEventButtons.Size = new System.Drawing.Size(117, 33);
            this.addEventButtons.TabIndex = 14;
            this.addEventButtons.Text = "Add Event(s)";
            this.addEventButtons.UseVisualStyleBackColor = true;
            // 
            // editEventButton
            // 
            this.editEventButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.editEventButton.Location = new System.Drawing.Point(643, 148);
            this.editEventButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.editEventButton.Name = "editEventButton";
            this.editEventButton.Size = new System.Drawing.Size(117, 33);
            this.editEventButton.TabIndex = 15;
            this.editEventButton.Text = "Edit Event";
            this.editEventButton.UseVisualStyleBackColor = true;
            // 
            // ViewUserButton
            // 
            this.ViewUserButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ViewUserButton.Location = new System.Drawing.Point(643, 106);
            this.ViewUserButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ViewUserButton.Name = "ViewUserButton";
            this.ViewUserButton.Size = new System.Drawing.Size(117, 33);
            this.ViewUserButton.TabIndex = 16;
            this.ViewUserButton.Text = "View All Users";
            this.ViewUserButton.UseVisualStyleBackColor = true;
            this.ViewUserButton.Click += new System.EventHandler(this.ViewUserButton_Click);
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(776, 299);
            this.Controls.Add(this.ViewUserButton);
            this.Controls.Add(this.editEventButton);
            this.Controls.Add(this.addEventButtons);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.EditUserButton);
            this.Controls.Add(this.UserLabel);
            this.Controls.Add(this.DateLabel);
            this.Controls.Add(this.UserList);
            this.Controls.Add(this.DateSelect);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AdminForm";
            this.Text = "AdminForm";
            this.Load += new System.EventHandler(this.AdminForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MonthCalendar DateSelect;
        private System.Windows.Forms.ListBox UserList;
        private System.Windows.Forms.Label DateLabel;
        private System.Windows.Forms.Label UserLabel;
        private System.Windows.Forms.Button EditUserButton;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Button addEventButtons;
        private System.Windows.Forms.Button editEventButton;
        private System.Windows.Forms.Button ViewUserButton;
    }
}