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
            this.EditEventsButton = new System.Windows.Forms.Button();
            this.DelEventButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // DateSelect
            // 
            this.DateSelect.Location = new System.Drawing.Point(18, 51);
            this.DateSelect.Name = "DateSelect";
            this.DateSelect.TabIndex = 8;
            this.DateSelect.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.DateSelect_DateSelected);
            // 
            // UserList
            // 
            this.UserList.FormattingEnabled = true;
            this.UserList.Location = new System.Drawing.Point(257, 53);
            this.UserList.Name = "UserList";
            this.UserList.Size = new System.Drawing.Size(208, 160);
            this.UserList.TabIndex = 9;
            this.UserList.SelectedIndexChanged += new System.EventHandler(this.UserList_SelectedIndexChanged);
            // 
            // DateLabel
            // 
            this.DateLabel.AutoSize = true;
            this.DateLabel.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateLabel.Location = new System.Drawing.Point(102, 18);
            this.DateLabel.Name = "DateLabel";
            this.DateLabel.Size = new System.Drawing.Size(53, 24);
            this.DateLabel.TabIndex = 10;
            this.DateLabel.Text = "Date";
            // 
            // UserLabel
            // 
            this.UserLabel.AutoSize = true;
            this.UserLabel.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserLabel.Location = new System.Drawing.Point(334, 18);
            this.UserLabel.Name = "UserLabel";
            this.UserLabel.Size = new System.Drawing.Size(71, 24);
            this.UserLabel.TabIndex = 11;
            this.UserLabel.Text = "Events";
            // 
            // EditUserButton
            // 
            this.EditUserButton.Location = new System.Drawing.Point(482, 53);
            this.EditUserButton.Name = "EditUserButton";
            this.EditUserButton.Size = new System.Drawing.Size(88, 27);
            this.EditUserButton.TabIndex = 12;
            this.EditUserButton.Text = "View Seats";
            this.EditUserButton.UseVisualStyleBackColor = true;
            this.EditUserButton.Click += new System.EventHandler(this.EditUserButton_Click);
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(482, 152);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(88, 27);
            this.BackButton.TabIndex = 13;
            this.BackButton.Text = "Go Back";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // EditEventsButton
            // 
            this.EditEventsButton.Location = new System.Drawing.Point(482, 119);
            this.EditEventsButton.Name = "EditEventsButton";
            this.EditEventsButton.Size = new System.Drawing.Size(88, 27);
            this.EditEventsButton.TabIndex = 14;
            this.EditEventsButton.Text = "Add Event(s)";
            this.EditEventsButton.UseVisualStyleBackColor = true;
            // 
            // DelEventButton
            // 
            this.DelEventButton.Location = new System.Drawing.Point(482, 86);
            this.DelEventButton.Name = "DelEventButton";
            this.DelEventButton.Size = new System.Drawing.Size(88, 27);
            this.DelEventButton.TabIndex = 15;
            this.DelEventButton.Text = "Remove Event";
            this.DelEventButton.UseVisualStyleBackColor = true;
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 243);
            this.Controls.Add(this.DelEventButton);
            this.Controls.Add(this.EditEventsButton);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.EditUserButton);
            this.Controls.Add(this.UserLabel);
            this.Controls.Add(this.DateLabel);
            this.Controls.Add(this.UserList);
            this.Controls.Add(this.DateSelect);
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
        private System.Windows.Forms.Button EditEventsButton;
        private System.Windows.Forms.Button DelEventButton;
    }
}