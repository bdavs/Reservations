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
    public partial class ticketForm : Form
    {
        Customer customer;
        public ticketForm(Customer selectedCustomer)
        {
            customer = selectedCustomer;
            InitializeComponent();
            List<Shows> showList = Shows.LoadShows();
            foreach (Shows s in showList)
            {
                comboBox1.Items.Add(s);
            }
            comboBox1.DisplayMember = "Name";
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void ticketForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Shows temp = (Shows)comboBox1.SelectedItem;
            UserForm.customerList.RemoveAt(AdminForm.tempIndex);
            customer.Tickets.Add(new Ticket((Shows)comboBox1.SelectedItem, Int32.Parse(maskedTextBox1.Text)));
            UserForm.customerList.Add(customer);
            Customer.SaveCustomers(UserForm.customerList);
            this.Close();
        }
    }
}
