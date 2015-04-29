namespace Reservations
{
    partial class AdminEditUserForm
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
            this.UserList = new System.Windows.Forms.ListBox();
            this.UserLabel = new System.Windows.Forms.Label();
            this.EditUserButton = new System.Windows.Forms.Button();
            this.BackButton = new System.Windows.Forms.Button();
            this.RemoveSeatButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // UserList
            // 
            this.UserList.FormattingEnabled = true;
            this.UserList.Location = new System.Drawing.Point(12, 54);
            this.UserList.Name = "UserList";
            this.UserList.Size = new System.Drawing.Size(208, 160);
            this.UserList.TabIndex = 10;
            // 
            // UserLabel
            // 
            this.UserLabel.AutoSize = true;
            this.UserLabel.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserLabel.Location = new System.Drawing.Point(77, 9);
            this.UserLabel.Name = "UserLabel";
            this.UserLabel.Size = new System.Drawing.Size(58, 24);
            this.UserLabel.TabIndex = 12;
            this.UserLabel.Text = "Seats";
            // 
            // EditUserButton
            // 
            this.EditUserButton.Location = new System.Drawing.Point(247, 54);
            this.EditUserButton.Name = "EditUserButton";
            this.EditUserButton.Size = new System.Drawing.Size(88, 27);
            this.EditUserButton.TabIndex = 13;
            this.EditUserButton.Text = "Edit User Info";
            this.EditUserButton.UseVisualStyleBackColor = true;
            this.EditUserButton.Click += new System.EventHandler(this.EditUserButton_Click);
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(247, 120);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(88, 27);
            this.BackButton.TabIndex = 14;
            this.BackButton.Text = "Go Back";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // RemoveSeatButton
            // 
            this.RemoveSeatButton.Location = new System.Drawing.Point(247, 87);
            this.RemoveSeatButton.Name = "RemoveSeatButton";
            this.RemoveSeatButton.Size = new System.Drawing.Size(88, 27);
            this.RemoveSeatButton.TabIndex = 15;
            this.RemoveSeatButton.Text = "Remove Seat";
            this.RemoveSeatButton.UseVisualStyleBackColor = true;
            // 
            // AdminEditUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 246);
            this.Controls.Add(this.RemoveSeatButton);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.EditUserButton);
            this.Controls.Add(this.UserLabel);
            this.Controls.Add(this.UserList);
            this.Name = "AdminEditUserForm";
            this.Text = "AdminEditUserForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox UserList;
        private System.Windows.Forms.Label UserLabel;
        private System.Windows.Forms.Button EditUserButton;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Button RemoveSeatButton;
    }
}