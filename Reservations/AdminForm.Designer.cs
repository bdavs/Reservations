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
            this.newTheatre = new System.Windows.Forms.Button();
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
            this.UserList.Location = new System.Drawing.Point(343, 63);
            this.UserList.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.UserList.Name = "UserList";
            this.UserList.Size = new System.Drawing.Size(276, 196);
            this.UserList.TabIndex = 9;
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
            this.UserLabel.Location = new System.Drawing.Point(445, 22);
            this.UserLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.UserLabel.Name = "UserLabel";
            this.UserLabel.Size = new System.Drawing.Size(80, 31);
            this.UserLabel.TabIndex = 11;
            this.UserLabel.Text = "Users";
            // 
            // newTheatre
            // 
            this.newTheatre.Location = new System.Drawing.Point(749, 223);
            this.newTheatre.Name = "newTheatre";
            this.newTheatre.Size = new System.Drawing.Size(123, 47);
            this.newTheatre.TabIndex = 12;
            this.newTheatre.Text = "Add New Theatre";
            this.newTheatre.UseVisualStyleBackColor = true;
            this.newTheatre.Click += new System.EventHandler(this.newTheatre_Click);
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 299);
            this.Controls.Add(this.newTheatre);
            this.Controls.Add(this.UserLabel);
            this.Controls.Add(this.DateLabel);
            this.Controls.Add(this.UserList);
            this.Controls.Add(this.DateSelect);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
        private System.Windows.Forms.Button newTheatre;
    }
}