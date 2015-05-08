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
        public Venue currentVenue = new Venue(); 
        public SeatForm()
        {
            InitializeComponent();
        }

        private void SeatForm_Load(object sender, EventArgs e)
        {
            currentCustomer = UserForm.selectedCustomer;
            currentShow = UserForm.selectedShow;
            currentVenue = currentShow.VenueName;
        }

        private void CreateButtons()
        {
            string[] rowLetterString = new string[] { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z"};
            string rowDesignation;
            int seatDesignation;
            int horizontal = 10;
            int vertical = 10;
            
            foreach (Point q in currentVenue.Seat_Location)
            {
                int i = 0;
                buttonArray[i] = new Button();
                buttonArray[i].Size = new Size(15, 15);
                buttonArray[i].Location = new Point(horizontal, vertical);
                buttonArray[i].Text = i.ToString();//rowDesignation + seatDesignation.ToString();
                //buttonArray[i].MouseUp += buttonArray_click;
                buttonArray[i].BackColor = Color.Green;
                buttonArray[i].Tag = i;
                this.Controls.Add(buttonArray[i]);
            }

            for (int i = 0; i < buttonArray.Length; i++)
            {

                rowDesignation = rowLetterString[i / 40];
                seatDesignation = (i % 40) + 1;
                
            }
        }

    }
}
