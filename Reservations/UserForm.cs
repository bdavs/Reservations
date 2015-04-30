using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Xml.Serialization;


namespace Reservations
{
    public partial class UserForm : Form
    {

        private Hashtable[] groupTables;
        // Declare a variable to store the current grouping column. 
        int groupColumn = 0;

        public List<Shows> showList;
        public List<ShowTime> showTimeList;
        public List<Customer> customerList;
        public UserForm()
        {

            
            InitializeComponent();
            showList = Shows.LoadShows();
            listViewSetup();


            
            foreach (Shows s in showList)
            {
                monthCalendar.AddBoldedDate(s.Date);
            }
             
           // ICollection<Shows> test = CollectionViewSource.GetDefaultView(showList);
            
        }
        private void listViewSetup() 
        {
            //showListBox.Dock = DockStyle.Fill;
            showListBox.View = View.Details;
            showListBox.Sorting = SortOrder.Ascending;

            // Create and initialize column headers for myListView.
            ColumnHeader columnHeader0 = new ColumnHeader();
            columnHeader0.Text = "Show";
            columnHeader0.Width = showListBox.Width / 2;
            ColumnHeader columnHeader1 = new ColumnHeader();
            columnHeader1.Text = "Venue";
            columnHeader1.Width = showListBox.Width/4;
            ColumnHeader columnHeader2 = new ColumnHeader();
            columnHeader2.Text = "Time";
            columnHeader2.Width = showListBox.Width/4-2;

            // Add the column headers to myListView.
            showListBox.Columns.AddRange(new ColumnHeader[] { columnHeader0, columnHeader1, columnHeader2 });
            foreach (Shows s in showList) 
            {
                if (s.Date.Date == monthCalendar.TodayDate)
                {
                    ListViewItem t = new ListViewItem(new string[] { s.Name, s.Venue.Name, s.Date.ToString() });
                    showListBox.Items.Add(t);
                }
            }

            groupTables = new Hashtable[showListBox.Columns.Count];
            for (int column = 0; column < showListBox.Columns.Count; column++)
            {
                // Create a hash table containing all the groups  
                // needed for a single column.
                groupTables[column] = CreateGroupsTable(column);
            }


            showTimeList = ReadXML<ShowTime>("..\\..\\showtimes.xml");
            customerList = Customer.LoadCustomers();
            foreach (Customer c in customerList)
                nameComboBox.Items.Add(c.Name);
        }
        // Read XML file into a list of objects
        public static List<T> ReadXML<T>(string path)
        {
            List<T> list = new List<T>();

            try
            {
                using (StreamReader sr = new StreamReader(path))
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(List<T>));
                    list = serializer.Deserialize(sr) as List<T>;
                }
            }
            catch (Exception error)
            {
                MessageBox.Show("Error Reading File.");
            }

            return list;
        }

        private void NameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void AdminModeButton_Click(object sender, EventArgs e)
        {
            AdminPassword AP = new AdminPassword();
            AP.Show();
            //this.Close();

        }

        private void SeatSelectButton_Click(object sender, EventArgs e)
        {
            SeatForm SF = new SeatForm();
            SF.ShowDialog();
        }

        private void monthCalendar_DateSelected(object sender, DateRangeEventArgs e)
        {
            MonthCalendar mc = sender as MonthCalendar;

            showListBox.Items.Clear();
            foreach (Shows s in showList)
            {
                if (s.Date.Date == mc.SelectionStart)
                {
                    ListViewItem t = new ListViewItem(new string[] { s.Name, s.Venue.Name, s.Date.ToString() });
                    showListBox.Items.Add(t);
                }
            }
            
            
        }

        private void UserForm_Load(object sender, EventArgs e)
        {

        }

        private void CreateNewUserButton_Click(object sender, EventArgs e)
        {

            UserAccountForm UAF = new UserAccountForm();
            if (CreateNewUserButton.Text == "Edit Info")
            {
                customerList = Customer.LoadCustomers();
                Customer temp = new Customer();
                foreach (Customer c in customerList)
                    if (c.Name == nameComboBox.Text)
                    {
                        temp = c;
                    }
                customerList.Remove(temp);
                Customer.SaveCustomers(customerList);
                UAF = new UserAccountForm();//temp.Name, temp.Address, temp.Email, temp.Phone, temp.Size, temp.Credit,"Save Info");
            }
            UAF.Refresh();
            UAF.Show();
        }

        private void CheckoutButton_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Your tickets will arrive soon.\nThank you", "Form Submit", MessageBoxButtons.OK);

            if (result == System.Windows.Forms.DialogResult.Yes)
            {

                // Closes the parent form. 

                this.Close();
            }

        }

        private Hashtable CreateGroupsTable(int column)
        {
            // Create a Hashtable object.
            Hashtable groups = new Hashtable();

            // Iterate through the items in myListView. 
            foreach (ListViewItem item in showListBox.Items)
            {
                // Retrieve the text value for the column. 
                string subItemText = item.SubItems[column].Text;

                // Use the initial letter instead if it is the first column. 
                if (column == 0)
                {
                    subItemText = subItemText.Substring(0, 1);
                }

                // If the groups table does not already contain a group 
                // for the subItemText value, add a new group using the  
                // subItemText value for the group header and Hashtable key. 
                if (!groups.Contains(subItemText))
                {
                    groups.Add(subItemText, new ListViewGroup(subItemText,
                        HorizontalAlignment.Left));
                }
            }

            // Return the Hashtable object. 
            return groups;
        }

        private void SetGroups(int column)
        {
            // Remove the current groups.
            showListBox.Groups.Clear();

            // Retrieve the hash table corresponding to the column.
            Hashtable groups = (Hashtable)groupTables[column];

            // Copy the groups for the column to an array.
            ListViewGroup[] groupsArray = new ListViewGroup[groups.Count];
            groups.Values.CopyTo(groupsArray, 0);

            // Sort the groups and add them to myListView.
            Array.Sort(groupsArray, new ListViewGroupSorter(showListBox.Sorting));
            showListBox.Groups.AddRange(groupsArray);

            // Iterate through the items in myListView, assigning each  
            // one to the appropriate group. 
            foreach (ListViewItem item in showListBox.Items)
            {
                // Retrieve the subitem text corresponding to the column. 
                string subItemText = item.SubItems[column].Text;

                // For the Title column, use only the first letter. 
                if (column == 0)
                {
                    subItemText = subItemText.Substring(0, 1);
                }

                // Assign the item to the matching group.
                item.Group = (ListViewGroup)groups[subItemText];
            }
        }

        private void showListBox_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            if (showListBox.Sorting == SortOrder.Descending ||
                ((e.Column != groupColumn)))
            {
                showListBox.Sorting = SortOrder.Ascending;
            }
            else
            {
                showListBox.Sorting = SortOrder.Descending;
            }
            groupColumn = e.Column;

            // Set the groups to those created for the clicked column. 
            
            SetGroups(e.Column);
           
        }

        private class ListViewGroupSorter : IComparer
        {
            private SortOrder order;

            // Stores the sort order. 
            public ListViewGroupSorter(SortOrder theOrder)
            {
                order = theOrder;
            }

            // Compares the groups by header value, using the saved sort 
            // order to return the correct value. 
            public int Compare(object x, object y)
            {
                int result = String.Compare(
                    ((ListViewGroup)x).Header,
                    ((ListViewGroup)y).Header
                );
                if (order == SortOrder.Ascending)
                {
                    return result;
                }
                else
                {
                    return -result;
                }
            }
        }

        private void nameComboBox_Enter(object sender, EventArgs e)
        {
            nameComboBox.Items.Clear();
            customerList = Customer.LoadCustomers();
            foreach (Customer c in customerList)
                nameComboBox.Items.Add(c.Name);
        }

        private void nameComboBox_TextChanged(object sender, EventArgs e)
        {
            foreach (string s in nameComboBox.Items)
                if (s == nameComboBox.Text)
                {
                    CreateNewUserButton.Text = "Edit Info"; break;
                }
                else
                    CreateNewUserButton.Text = "Or Create New User";
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            showListBox.Items.Clear();
            foreach (Shows s in showList)
            {
                ListViewItem t = new ListViewItem(new string[] { s.Name, s.Venue.Name, s.Date.ToString() });
                showListBox.Items.Add(t);

            }
            groupTables = new Hashtable[showListBox.Columns.Count];
            for (int column = 0; column < showListBox.Columns.Count; column++)
            {
                // Create a hash table containing all the groups  
                // needed for a single column.
                groupTables[column] = CreateGroupsTable(column);
            }
            //showListBox_ColumnClick(sender, new ColumnClickEventArgs(0));
            showListBox.Sorting = SortOrder.Descending;
            SetGroups(1);
        }

    }
}
