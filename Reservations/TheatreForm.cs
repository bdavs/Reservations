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
    public partial class TheatreForm : Form
    {
        public TheatreForm()
        {
            InitializeComponent();
           /* TheatreList = Venue.LoadVenues();
           UserForm.showList.
            TheatreList.Items.Clear();
            foreach (Shows s in UserForm.showList)
                TheatreList.Items.Add(s);
            TheatreList.DisplayMember = "Name";
            TheatreList.Sorted = true;
            editEventButton.Enabled = false;*/
            //UserForm.selectCustomer.
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            this.Text = textBox1.Text;
        }

        private void TheatreForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string number = textBox2.Text;
            int num = Convert.ToInt32(number);
            TheatreLayout TL = new TheatreLayout(currentVenue); //EDIT THIS HERE TO THE VENUE YOU ARE PASSING
            TL.ShowDialog();
        }

        private void save_Click(object sender, EventArgs e)
        {

        }
    }
}
