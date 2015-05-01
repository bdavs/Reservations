﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reservations
{
    public partial class AdminForm : Form
    {
        List<Customer> customerList = Customer.LoadCustomers();
        public AdminForm()
        {
            InitializeComponent();
        }

        private void DateSelect_DateSelected(object sender, DateRangeEventArgs e)
        {

        }

        private void UserList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void EditUserButton_Click(object sender, EventArgs e)
        {
            this.Close();
            AdminEditUserForm Form = new AdminEditUserForm();
            Form.Show();
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {

        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ViewUserButton_Click(object sender, EventArgs e)
        {

            if (UserList.Items.Count == 0)
            {
                foreach (Customer dude in customerList)
                {
                    UserList.Items.Add(dude);
                }
                UserList.DisplayMember = "Name";
                UserList.Sorted = true;
            }
        }
    }
}
