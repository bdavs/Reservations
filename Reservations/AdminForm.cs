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
        Customer selectedCustomer = new Customer();
        Shows selectedShow = new Shows();
        public static int tempIndex;
        public AdminForm()
        {
            InitializeComponent();
            UserForm.showList = Shows.LoadShows();
            UserForm.customerList = Customer.LoadCustomers();
            UserList.Items.Clear();
            foreach (Shows s in UserForm.showList)
                UserList.Items.Add(s);
            UserList.DisplayMember = "Name";
            UserList.Sorted = true;
            editEventButton.Enabled = false;
            foreach (Shows s in UserForm.showList)
            {
                DateSelect.AddBoldedDate(s.Date);
            }
            TicketBox.Visible = false;
        }

        private void DateSelect_DateSelected(object sender, DateRangeEventArgs e)
        {
            MonthCalendar mc = sender as MonthCalendar;
            editEventButton.Enabled = false;
            UserList.Items.Clear();
            foreach (Shows s in UserForm.showList)
            {
                if (s.Date.Date == mc.SelectionStart)
                {
                    UserList.Items.Add(s);
                }
                
                
            }
            UserLabel.Text = "Events";
            editEventButton.Text = "Edit Event";
            addEventButtons.Text = "Add Event(s)";
            ViewUserButton.Text = "View All Users";
            UserList.DisplayMember = "Name";
            UserList.Sorted = true;
        }

        private void UserList_SelectedIndexChanged(object sender, EventArgs e)
        {
             if (editEventButton.Text == "Edit User")
            {
                try
                {
                    selectedCustomer = UserForm.customerList.Find(item => item == UserList.SelectedItems[0]);
                    tempIndex = UserForm.customerList.IndexOf(selectedCustomer);
                    TicketBox.Items.Clear();
                    foreach (Ticket t in selectedCustomer.Tickets)
                        TicketBox.Items.Add(t);
                    TicketBox.DisplayMember = "ShowName";
                    addTicketButton.Enabled = true;
                    removeTicketButton.Enabled = false;
                }
                catch (Exception ex)
                {
                    if (ex is NullReferenceException || ex is ArgumentOutOfRangeException)
                          selectedCustomer = new Customer();
                }
             }
             else
             {
                try
                {
                    selectedShow = UserForm.showList.Find(item => item == UserList.SelectedItems[0]);
                }
                catch (Exception ex)
                {
                    if (ex is NullReferenceException || ex is ArgumentOutOfRangeException)
                          selectedShow = new Shows();
                }
             }


            
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
            editEventButton.Enabled = false;
            if (ViewUserButton.Text == "View All Users")
            {
                DateLabel.Text = "Tickets";
                DateSelect.Visible = false;
                addTicketButton.Visible = true;
                removeTicketButton.Visible = true;
                addTicketButton.Enabled = false;
                removeTicketButton.Enabled = false;
                TicketBox.Visible = true;
                UserLabel.Text = "Users";
                editEventButton.Text = "Edit User";
                addEventButtons.Text = "Add User(s)";
                ViewUserButton.Text = "View All Events";
                UserList.Items.Clear();
                foreach (Customer dude in UserForm.customerList)
                {
                    UserList.Items.Add(dude);
                }
                
                UserList.DisplayMember = "Name";
                UserList.Sorted = true;
            }
            else 
            {
                DateLabel.Text = "Date";
                DateSelect.Visible = true;
                addTicketButton.Visible = false;
                removeTicketButton.Visible = false;
                TicketBox.Visible = false;
                UserLabel.Text = "Events";
                editEventButton.Text = "Edit Event";
                addEventButtons.Text = "Add Event(s)";
                ViewUserButton.Text = "View All Users";
                UserList.Items.Clear();
                foreach (Shows dude in UserForm.showList)
                {
                    UserList.Items.Add(dude);
                }
                UserList.DisplayMember = "Name";
                UserList.Sorted = true;
            }

        }

        private void editEventButton_Click(object sender, EventArgs e)
        {
            
            if (editEventButton.Text == "Edit User")
            {
                UserForm.customerList = Customer.LoadCustomers();
                UserAccountForm UAF = new UserAccountForm(selectedCustomer,true);//dis now work 
                UAF.Closed += new EventHandler(RefreshData);
                
                UAF.Show();   
            }
            else
            {
                UserForm.showList = Shows.LoadShows();
                EventEditForm EEF = new EventEditForm(selectedShow);
                EEF.Closed += new EventHandler(RefreshData);

                EEF.Show();   
            }
        }
        private void RefreshData(object sender, EventArgs e)
        {
            if (editEventButton.Text == "Edit User")
            {
                UserForm.customerList = Customer.LoadCustomers();
                UserList.Items.Clear();
                foreach (Customer c in UserForm.customerList)
                    UserList.Items.Add(c);
                TicketBox.Items.Clear();
                this.Refresh();
            }
            else
            {
                UserForm.showList = Shows.LoadShows();
                UserList.Items.Clear();
                foreach (Shows s in UserForm.showList)
                    UserList.Items.Add(s);
                editEventButton.Enabled = false;
                DateSelect.RemoveAllBoldedDates();
                foreach (Shows s in UserForm.showList)
                {
                    DateSelect.AddBoldedDate(s.Date);
                }

            }
        }
        private void UserList_Click(object sender, EventArgs e)
        {
            editEventButton.Enabled = true;
        }

        private void VenueButton_Click(object sender, EventArgs e)
        {
            TheatreForm TF = new TheatreForm();
            TF.ShowDialog();
        }

        private void addEventButtons_Click(object sender, EventArgs e)
        {

            if (editEventButton.Text == "Edit User")
            {
                //UserForm.customerList = Customer.LoadCustomers();

                UserAccountForm UAF = new UserAccountForm();

                UAF.Closed += new EventHandler(RefreshData);

                UAF.Show();
            }
            else 
            {
                EventEditForm EEF = new EventEditForm();
                EEF.Closed += new EventHandler(RefreshData);
                EEF.Show();
            }

        }

        private void TicketBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            removeTicketButton.Enabled = true;
        }

        private void addTicketButton_Click(object sender, EventArgs e)
        {
            ticketForm TF = new ticketForm(selectedCustomer);
            TF.Closed += new EventHandler(RefreshData);
            TF.Show();   
            
        }

        private void removeTicketButton_Click(object sender, EventArgs e)
        {
            UserForm.customerList.RemoveAt(tempIndex);
            selectedCustomer.Tickets.Remove((Ticket)TicketBox.SelectedItem);
            UserForm.customerList.Add(selectedCustomer);
            Customer.SaveCustomers(UserForm.customerList);
            TicketBox.Items.Clear();
            foreach (Ticket t in selectedCustomer.Tickets)
                TicketBox.Items.Add(t);
            removeTicketButton.Enabled = false;
        }

        
    }
}
