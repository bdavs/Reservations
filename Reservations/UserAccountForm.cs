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
        public UserAccountForm()
        {
            InitializeComponent();
        }
        public UserAccountForm(string n, string a, string e, string p, int f, string c,string s)
        {
            InitializeComponent();
            nameBox.Text = n;
            addressBox.Text = a;
            emailBox.Text = e;
            phoneNumberBox.Text = p;
            familySizeBox.Text = f.ToString();
            creditCardBox.Text = c;
            CreateUserButton.Text = s;

        }

        private void CreateUserButton_Click(object sender, EventArgs e)
        {
            //currently only field that cannot be blank is family size
            try
            {
                Customer cumstomertemp = new Customer(this.nameBox.Text, this.addressBox.Text, this.phoneNumberBox.Text, this.creditCardBox.Text, this.emailBox.Text, int.Parse(this.familySizeBox.Text));
                List<Customer> templist = Customer.LoadCustomers();
                templist.Add(cumstomertemp);
                Customer.SaveCustomers(templist);
                this.Close();
            }
            catch (FormatException) { MessageBox.Show("Please Complete All Fields", "Field Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }

        }
    }
}
