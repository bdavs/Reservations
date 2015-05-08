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
    public partial class SeatForm : Form
    {
        public Button[] buttonArray = new Button[1000];
        public Customer currentCustomer = new Customer();
        public Shows currentShow = new Shows();
        public List<Venue> venueList = Venue.LoadVenues(); public List<Customer> customerList = Customer.LoadCustomers();
        public Venue currentVenue = new Venue();
        public int venueIndex; public int customerIndex; 
        public SeatForm()
        {
            InitializeComponent();
            
        }

        private void SeatForm_Load(object sender, EventArgs e)
        {
            currentCustomer = UserForm.selectedCustomer;
            customerIndex = customerList.IndexOf(currentCustomer);
            currentShow = UserForm.selectedShow;
            foreach (Venue q in venueList)
            {
                if (q.Name == currentShow.VenueName)
                    currentVenue = q;
            }
            venueIndex = venueList.IndexOf(currentVenue);
            CreateButtons();
            panel1.SendToBack();
        }

        private void CreateButtons()
        {
            string[] rowLetterString = new string[] { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z"};
            /*string rowDesignation;
            int seatDesignation;
            int horizontal = 10;
            int vertical = 10;*/

            int i = 0;
            bool taken = new bool();
            foreach (Point q in currentVenue.Seat_Location)
            {
                taken = currentVenue.Seats_Taken.Exists(g=>g==q);
                buttonArray[i] = new Button();
                buttonArray[i].Size = new Size(15, 15);
                buttonArray[i].Location = new Point(q.X/2,q.Y/2);
                buttonArray[i].Text = i.ToString();//rowDesignation + seatDesignation.ToString();
                buttonArray[i].MouseUp += buttonArray_click;
                buttonArray[i].BackColor = Color.Green;
                if (taken == true)
                    buttonArray[i].BackColor = Color.Purple;
                buttonArray[i].Tag = i;
                this.Controls.Add(buttonArray[i]);
                i++;
            }
        }

        private void buttonArray_click(object sender, MouseEventArgs mea)
        {
            if (sender.GetType() == typeof(System.Windows.Forms.Button))
            {
                int tag = (int)((System.Windows.Forms.Button)sender).Tag;       // tag is a programmer usable field
                int r = tag / 40;                                                // the index was put in this field by CreateButtons() below
                int c = tag % 40;
                int index = r * 40 + c;
                if (buttonArray[index].BackColor == Color.Green)
                {
                    buttonArray[index].BackColor = Color.Red;
                    currentVenue.Seats_Taken.Add(currentVenue.Seat_Location.ElementAt(index));
                }
                else if (buttonArray[index].BackColor == Color.Red)
                {
                    buttonArray[index].BackColor = Color.Green;
                    currentVenue.Seats_Taken.Remove(currentVenue.Seat_Location.ElementAt(index));
                }
                SeatNumber.Text = buttonArray[index].Text;
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PurchaseButton_Click(object sender, EventArgs e)
        {
            venueList.RemoveAt(venueIndex);
            venueList.Add(currentVenue);
            customerList.RemoveAt(customerIndex);
            customerList.Add(currentCustomer);
            Customer.SaveCustomers(customerList);
            Venue.SaveVenues(venueList);
            this.Close();

        }

    }
}
