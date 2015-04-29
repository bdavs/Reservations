namespace Reservations
{
    partial class UserAccountForm
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
            this.nameBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.familySizeBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.addressBox = new System.Windows.Forms.TextBox();
            this.CreateUserButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.emailBox = new System.Windows.Forms.TextBox();
            this.phoneNumberBox = new System.Windows.Forms.MaskedTextBox();
            this.creditCardBox = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(12, 29);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(189, 20);
            this.nameBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Family Size";
            // 
            // familySizeBox
            // 
            this.familySizeBox.Location = new System.Drawing.Point(13, 189);
            this.familySizeBox.Name = "familySizeBox";
            this.familySizeBox.Size = new System.Drawing.Size(188, 20);
            this.familySizeBox.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 216);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Credit Card Number";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Address";
            // 
            // addressBox
            // 
            this.addressBox.Location = new System.Drawing.Point(13, 70);
            this.addressBox.Name = "addressBox";
            this.addressBox.Size = new System.Drawing.Size(188, 20);
            this.addressBox.TabIndex = 6;
            // 
            // CreateUserButton
            // 
            this.CreateUserButton.Location = new System.Drawing.Point(68, 270);
            this.CreateUserButton.Name = "CreateUserButton";
            this.CreateUserButton.Size = new System.Drawing.Size(75, 23);
            this.CreateUserButton.TabIndex = 8;
            this.CreateUserButton.Text = "Create User";
            this.CreateUserButton.UseVisualStyleBackColor = true;
            this.CreateUserButton.Click += new System.EventHandler(this.CreateUserButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 134);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Phone Number";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 93);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Email";
            // 
            // emailBox
            // 
            this.emailBox.Location = new System.Drawing.Point(13, 109);
            this.emailBox.Name = "emailBox";
            this.emailBox.Size = new System.Drawing.Size(189, 20);
            this.emailBox.TabIndex = 9;
            // 
            // phoneNumberBox
            // 
            this.phoneNumberBox.Location = new System.Drawing.Point(13, 150);
            this.phoneNumberBox.Mask = "(999) 000-0000";
            this.phoneNumberBox.Name = "phoneNumberBox";
            this.phoneNumberBox.Size = new System.Drawing.Size(189, 20);
            this.phoneNumberBox.TabIndex = 13;
            // 
            // creditCardBox
            // 
            this.creditCardBox.Location = new System.Drawing.Point(12, 232);
            this.creditCardBox.Mask = "0000-0000-0000-00000";
            this.creditCardBox.Name = "creditCardBox";
            this.creditCardBox.Size = new System.Drawing.Size(189, 20);
            this.creditCardBox.TabIndex = 14;
            
            // 
            // UserAccountForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(224, 315);
            this.Controls.Add(this.creditCardBox);
            this.Controls.Add(this.phoneNumberBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.emailBox);
            this.Controls.Add(this.CreateUserButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.addressBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.familySizeBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nameBox);
            this.Name = "UserAccountForm";
            this.Text = "UserAccountForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox familySizeBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox addressBox;
        private System.Windows.Forms.Button CreateUserButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox emailBox;
        private System.Windows.Forms.MaskedTextBox phoneNumberBox;
        private System.Windows.Forms.MaskedTextBox creditCardBox;
    }
}