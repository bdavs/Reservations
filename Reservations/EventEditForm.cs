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
    public partial class EventEditForm : Form
    {
        Shows tempEvent = new Shows();
        List<Venue> venuesList = new List<Venue>();
        int oldIndex=-1;
        public EventEditForm()
        {
            InitializeComponent();
            
            venuesList = Venue.LoadVenues();
            foreach (Venue v in venuesList)
                venueComboBox.Items.Add(v.Name);
            
        }
        public EventEditForm(Shows s)
        {
            InitializeComponent();
            tempEvent = s;
            venuesList = Venue.LoadVenues();
            foreach (Venue v in venuesList)
                venueComboBox.Items.Add(v.Name);
            nameBox.Text = s.Name;
            priceBox.Text = s.Price.ToString();
            venueComboBox.SelectedItem = s.VenueName;
            Schedule.Value = s.Date;
            oldIndex = UserForm.showList.FindIndex(i => i.Name == s.Name);
            CreateEventButton.Text = "Save Info";
        }

        private void nameBox_TextChanged(object sender, EventArgs e)
        {
            tempEvent.Name = nameBox.Text;
        }

        private void Schedule_ValueChanged(object sender, EventArgs e)
        {
            tempEvent.Date = Schedule.Value;
        }

        private void priceBox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void venueComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CreateEventButton_Click(object sender, EventArgs e)
        {
            tempEvent.Name = nameBox.Text;
            tempEvent.Date = Schedule.Value;
            tempEvent.Price = Double.Parse(priceBox.Text.ToString());
            tempEvent.VenueName = venueComboBox.SelectedItem.ToString();
            tempEvent.Available = true;
            if (oldIndex == -1) UserForm.showList.Add(tempEvent);
            else UserForm.showList[oldIndex] = tempEvent;
            Shows.SaveShows(UserForm.showList);
            this.Close();
        }
    }
}
