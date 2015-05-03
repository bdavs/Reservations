using System;
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
        List<Customer> customerList;
        List<Shows> showList;
        public AdminForm()
        {
            InitializeComponent();
            showList = Shows.LoadShows();
            customerList = Customer.LoadCustomers();
            UserList.Items.Clear();
            foreach (Shows s in showList)
                UserList.Items.Add(s);
            UserList.DisplayMember = "Name";
            UserList.Sorted = true;
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
            if (ViewUserButton.Text == "View All Users")
            {
                UserLabel.Text = "Users";
                editEventButton.Text = "Edit User";
                addEventButtons.Text = "Add User(s)";
                ViewUserButton.Text = "View All Events";
                UserList.Items.Clear();
                foreach (Customer dude in customerList)
                {
                    UserList.Items.Add(dude);
                }
                UserList.DisplayMember = "Name";
                UserList.Sorted = true;
            }
            else 
            {
                UserLabel.Text = "Events";
                editEventButton.Text = "Edit Event";
                addEventButtons.Text = "Add Event(s)";
                ViewUserButton.Text = "View All Users";
                UserList.Items.Clear();
                foreach (Shows dude in showList)
                {
                    UserList.Items.Add(dude);
                }
                UserList.DisplayMember = "Name";
                UserList.Sorted = true;
            }

        }
    }
}
