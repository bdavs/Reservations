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


        private void CreateUserButton_Click(object sender, EventArgs e)
        {

            Customer cumstomertemp = new Customer(this.nameBox.Text, this.addressBox.Text, this.phoneNumberBox.Text, this.creditCardBox.Text, this.emailBox.Text, int.Parse(this.familySizeBox.Text));
            List<Customer> templist = Customer.LoadCustomers();
            templist.Add(cumstomertemp);
            Customer.SaveCustomers(templist);

        }
    }
}
