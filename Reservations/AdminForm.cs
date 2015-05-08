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
        Customer selectedCustomer = new Customer();
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
        }

        private void DateSelect_DateSelected(object sender, DateRangeEventArgs e)
        {

        }

        private void UserList_SelectedIndexChanged(object sender, EventArgs e)
        {

            try
            {
                selectedCustomer = UserForm.customerList.Find(item => item == UserList.SelectedItems[0]);
            }
            catch (Exception ex)
            {
                if (ex is NullReferenceException || ex is ArgumentOutOfRangeException)
                      selectedCustomer = new Customer();
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
                //Customer temp = new Customer();
                /*foreach(Customer c in UserForm.customerList)
                {
                    if (c == UserList.SelectedItem) temp = c;   //WTF why dis no work???
                }*/
                UserAccountForm UAF = new UserAccountForm(selectedCustomer);//dis now work
                //UAF.tempIndex = UserForm.customerList.IndexOf(selectedCustomer);
                UAF.Closed += new EventHandler(RefreshData);
                
                UAF.Show();
                
            }
        }
        private void RefreshData(object sender, EventArgs e)
        {
            UserForm.customerList = Customer.LoadCustomers();
            UserList.Items.Clear();
            foreach (Customer c in UserForm.customerList)
                UserList.Items.Add(c);
            this.Refresh();
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
    }
}
