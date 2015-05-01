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
    public partial class UserAccountForm : Form
    {
        public int tempIndex;
 
        public UserAccountForm()
        {
            InitializeComponent();
        }
        public UserAccountForm(Customer c)
        {
            InitializeComponent();
            nameBox.Text = c.Name;
            addressBox.Text = c.Address;
            emailBox.Text = c.Email;
            phoneNumberBox.Text = c.Phone;
            familySizeBox.Text = c.Size.ToString();
            creditCardBox.Text = c.Credit;
            CreateUserButton.Text = "Save Info";
        }

        private void CreateUserButton_Click(object sender, EventArgs e)
        {
            try
            {
                Customer cumstomertemp = new Customer(this.nameBox.Text, this.addressBox.Text, this.phoneNumberBox.Text, this.creditCardBox.Text, this.emailBox.Text, int.Parse(this.familySizeBox.Text));
                List<Customer> templist = Customer.LoadCustomers();
                templist.RemoveAt(tempIndex);
                templist.Add(cumstomertemp);
                Customer.SaveCustomers(templist);
                this.Close();
            }
            catch (FormatException) { MessageBox.Show("Please Complete All Fields", "Field Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            
        }
    }
}
