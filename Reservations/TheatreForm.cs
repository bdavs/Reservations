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
        Venue selectedTheatre = new Venue();
        public static List<Venue> venueList = new List<Venue>();
        public TheatreForm()
        {
            InitializeComponent();
            
            venueList= Venue.LoadVenues();
            TheatreList.Items.Clear();
            foreach (Venue v in venueList)
                TheatreList.Items.Add(v);
            TheatreList.DisplayMember = "Name";
            TheatreList.Sorted = true;
            //editEventButton.Enabled = false;
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
            //string number = textBox2.Text;
            //int num = Convert.ToInt32(number);
            int num = selectedTheatre.Seat_Location.Count;
            TheatreLayout TL = new TheatreLayout(selectedTheatre);
            TL.ShowDialog();
        }

        private void save_Click(object sender, EventArgs e)
        {
            Venue.SaveVenues(venueList);
        }

        private void TheatreList_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedTheatre = venueList.Find(item => item == TheatreList.SelectedItems[0]);
            textBox1.Text = selectedTheatre.Name;
            textBox2.Text = selectedTheatre.Seat_Location.Count.ToString();
        }

        private void newTheatreButton_Click(object sender, EventArgs e)
        {
           
            //tempVenue.Name = textBox1.Text;
            //tempVenue.Size = Convert.ToInt32(textBox2.Text);
            TheatreLayout TL = new TheatreLayout(textBox1.Text, Convert.ToInt32(textBox2.Text));
            TL.ShowDialog();
        }
    }
}
