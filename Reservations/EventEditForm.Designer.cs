namespace Reservations
{
    partial class EventEditForm
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
            this.label6 = new System.Windows.Forms.Label();
            this.priceBox = new System.Windows.Forms.TextBox();
            this.CreateEventButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.Schedule = new System.Windows.Forms.DateTimePicker();
            this.venueComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 89);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 24;
            this.label6.Text = "Price";
            // 
            // priceBox
            // 
            this.priceBox.Location = new System.Drawing.Point(12, 105);
            this.priceBox.Name = "priceBox";
            this.priceBox.Size = new System.Drawing.Size(189, 20);
            this.priceBox.TabIndex = 16;
            this.priceBox.TextChanged += new System.EventHandler(this.priceBox_TextChanged);
            // 
            // CreateEventButton
            // 
            this.CreateEventButton.Location = new System.Drawing.Point(66, 186);
            this.CreateEventButton.Name = "CreateEventButton";
            this.CreateEventButton.Size = new System.Drawing.Size(87, 23);
            this.CreateEventButton.TabIndex = 23;
            this.CreateEventButton.Text = "Create Event";
            this.CreateEventButton.UseVisualStyleBackColor = true;
            this.CreateEventButton.Click += new System.EventHandler(this.CreateEventButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "Time";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Name";
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(11, 25);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(189, 20);
            this.nameBox.TabIndex = 13;
            this.nameBox.TextChanged += new System.EventHandler(this.nameBox_TextChanged);
            // 
            // Schedule
            // 
            this.Schedule.CustomFormat = "MM/dd/yyyy     hh:mm:sstt";
            this.Schedule.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.Schedule.Location = new System.Drawing.Point(12, 66);
            this.Schedule.Name = "Schedule";
            this.Schedule.Size = new System.Drawing.Size(187, 20);
            this.Schedule.TabIndex = 27;
            this.Schedule.ValueChanged += new System.EventHandler(this.Schedule_ValueChanged);
            // 
            // venueComboBox
            // 
            this.venueComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.venueComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.venueComboBox.FormattingEnabled = true;
            this.venueComboBox.Location = new System.Drawing.Point(12, 147);
            this.venueComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.venueComboBox.Name = "venueComboBox";
            this.venueComboBox.Size = new System.Drawing.Size(189, 21);
            this.venueComboBox.Sorted = true;
            this.venueComboBox.TabIndex = 28;
            this.venueComboBox.Text = "Enter Venue";
            this.venueComboBox.SelectedIndexChanged += new System.EventHandler(this.venueComboBox_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 29;
            this.label2.Text = "Venue";
            // 
            // EventEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(234, 236);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.venueComboBox);
            this.Controls.Add(this.Schedule);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.priceBox);
            this.Controls.Add(this.CreateEventButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nameBox);
            this.Name = "EventEditForm";
            this.Text = "EventEditForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox priceBox;
        private System.Windows.Forms.Button CreateEventButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.DateTimePicker Schedule;
        private System.Windows.Forms.ComboBox venueComboBox;
        private System.Windows.Forms.Label label2;

    }
}