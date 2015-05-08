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
    public partial class TheatreLayout : Form
    {
        public Button[] buttonArray = new Button[1000];
        public List<Point>seats = new List<Point>();
        
        public string name1;
        public int number1;
        int oldIndex;
        public TheatreLayout(Venue currentVenue)
        {
            InitializeComponent();
            name1 = currentVenue.Name;
            number1 = currentVenue.Size;
            oldIndex = TheatreForm.venueList.FindIndex(i => i == currentVenue);
            this.WindowState = FormWindowState.Maximized;

        }

        private void TheatreLayout_Load(object sender, EventArgs e)
        {
            /*int ButtonWidth = 40;
            int ButtonHeight = 40;
            int Distance = 20;
            int start_x = 0;
            int start_y = 0;

            for (int x = 0; x < 5; x++)
            {
                for (int y = 0; y < 5; y++)
                {
                    Button tmpButton = new Button();
                    tmpButton.Top = start_x + (x * ButtonHeight + Distance);
                    tmpButton.Left = start_y + (y * ButtonWidth + Distance);
                    tmpButton.Width = ButtonWidth;
                    tmpButton.Height = ButtonHeight;
                    tmpButton.Text = "X: " + x.ToString() + " Y: " + y.ToString();
                    this.Controls.Add(tmpButton);
                }

            }*/
            CreateButtons();
            
            
        }
        private void CreateButtons()
        {
            string[] rowLetterString = new string[]{"A","B","C","D","E","F","G","H","I","J","K","L","M","N","O","P","Q","R","S","T","U","V","W","X","Y","Z","A'","B'","C'","D'","E'","F'","G'","H'","I'","J'","K'","L'","M'","N'","O'","P'","Q'","R'","S'","T'","U'","V'","W'","X'","Y'"};
            string rowDesignation;
            int seatDesignation;
            int horizontal = 30;
            int vertical = 30;

            for (int i = 0; i < buttonArray.Length; i++)
            {

                rowDesignation = rowLetterString[i / 40];
                seatDesignation = (i % 40) + 1;
                buttonArray[i] = new Button();
                buttonArray[i].Font = new Font("Georgia",8);
                buttonArray[i].Size = new Size(30, 30);
                buttonArray[i].Location = new Point(horizontal, vertical);
                
                buttonArray[i].Text = rowDesignation + seatDesignation.ToString();
                buttonArray[i].MouseUp += buttonArray_click;
                buttonArray[i].BackColor = Color.Green;
                buttonArray[i].Tag = i;
                if ((i + 1) % 40 == 0)
                {
                    vertical += 30;
                    horizontal = 30;
                }
                else
                {
                    horizontal += 30;
                }
                this.Controls.Add(buttonArray[i]);
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
                    buttonArray[index].BackColor = Color.Red;
                else if (buttonArray[index].BackColor == Color.Red)
                    buttonArray[index].BackColor = Color.Green;
            }
        }

        private void toList()
        {
            foreach (Button q in buttonArray)
            {
                if (q.BackColor == Color.Red)
                    seats.Add(q.Location);
            }
        }

        private void TheatreLayout_FormClosing(object sender, FormClosingEventArgs e)
        {
            toList();
            Venue temp = new Venue(name1,number1,number1,seats);
            List<Venue> newVenue = new List<Venue>();
            newVenue = Venue.LoadVenues();
            newVenue[oldIndex] = temp;
            Venue.SaveVenues(newVenue);
        }
    }
}
