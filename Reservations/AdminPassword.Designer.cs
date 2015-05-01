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
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // AdminPasswordBox
            // 
            this.AdminPasswordBox.Location = new System.Drawing.Point(12, 22);
            this.AdminPasswordBox.Name = "AdminPasswordBox";
            this.AdminPasswordBox.PasswordChar = '♥';
            this.AdminPasswordBox.Size = new System.Drawing.Size(138, 20);
            this.AdminPasswordBox.TabIndex = 0;
            this.AdminPasswordBox.TextChanged += new System.EventHandler(this.AdminPasswordBox_TextChanged);
            this.AdminPasswordBox.Enter += new System.EventHandler(this.AdminPasswordBox_Enter);
            this.AdminPasswordBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AdminPasswordBox_KeyPress);
            // 
            // AdminPasswordEnter
            // 
            this.AdminPasswordEnter.Location = new System.Drawing.Point(39, 48);
            this.AdminPasswordEnter.Name = "AdminPasswordEnter";
            this.AdminPasswordEnter.Size = new System.Drawing.Size(75, 23);
            this.AdminPasswordEnter.TabIndex = 1;
            this.AdminPasswordEnter.Text = "Login";
            this.AdminPasswordEnter.UseVisualStyleBackColor = true;
            this.AdminPasswordEnter.Click += new System.EventHandler(this.AdminPasswordEnter_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Enter Admin Password";
            // 
            // AdminPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(175, 83);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AdminPasswordEnter);
            this.Controls.Add(this.AdminPasswordBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "AdminPassword";
            this.Text = "Admin";
            this.Load += new System.EventHandler(this.AdminPassword_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AdminPassword_KeyPress);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox AdminPasswordBox;
        private System.Windows.Forms.Button AdminPasswordEnter;
        private System.Windows.Forms.Label label1;
    }
}