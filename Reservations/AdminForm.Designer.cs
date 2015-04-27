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
            this.UserList.Location = new System.Drawing.Point(257, 51);
            this.UserList.Name = "UserList";
            this.UserList.Size = new System.Drawing.Size(208, 160);
            this.UserList.TabIndex = 9;
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
            this.UserLabel.Size = new System.Drawing.Size(59, 24);
            this.UserLabel.TabIndex = 11;
            this.UserLabel.Text = "Users";
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 243);
            this.Controls.Add(this.UserLabel);
            this.Controls.Add(this.DateLabel);
            this.Controls.Add(this.UserList);
            this.Controls.Add(this.DateSelect);
            this.Name = "AdminForm";
            this.Text = "AdminForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MonthCalendar DateSelect;
        private System.Windows.Forms.ListBox UserList;
        private System.Windows.Forms.Label DateLabel;
        private System.Windows.Forms.Label UserLabel;
    }
}