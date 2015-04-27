namespace Reservations
{
    partial class AdminPassword
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
            this.AdminPasswordBox = new System.Windows.Forms.TextBox();
            this.AdminPasswordEnter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AdminPasswordBox
            // 
            this.AdminPasswordBox.Location = new System.Drawing.Point(12, 12);
            this.AdminPasswordBox.Name = "AdminPasswordBox";
            this.AdminPasswordBox.Size = new System.Drawing.Size(138, 20);
            this.AdminPasswordBox.TabIndex = 0;
            this.AdminPasswordBox.Text = "Enter Admin Password";
            this.AdminPasswordBox.Enter += new System.EventHandler(this.AdminPasswordBox_Enter);
            // 
            // AdminPasswordEnter
            // 
            this.AdminPasswordEnter.Location = new System.Drawing.Point(12, 41);
            this.AdminPasswordEnter.Name = "AdminPasswordEnter";
            this.AdminPasswordEnter.Size = new System.Drawing.Size(75, 23);
            this.AdminPasswordEnter.TabIndex = 1;
            this.AdminPasswordEnter.Text = "Login";
            this.AdminPasswordEnter.UseVisualStyleBackColor = true;
            this.AdminPasswordEnter.Click += new System.EventHandler(this.AdminPasswordEnter_Click);
            // 
            // AdminPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(175, 83);
            this.Controls.Add(this.AdminPasswordEnter);
            this.Controls.Add(this.AdminPasswordBox);
            this.Name = "AdminPassword";
            this.Text = "AdminPassword";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox AdminPasswordBox;
        private System.Windows.Forms.Button AdminPasswordEnter;
    }
}