using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reservations
{
    public class Venue
    {
        private string name;
        private int size;
        private int seats_available;
        private int seats_taken;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public int Size
        {
            get { return size; }
            set { size = value; }
        }
        public int Seats_Available
        {
            get { return seats_available; }
            set { seats_available = value; }
        }
        public int Seats_Taken
        {
            get { return seats_taken; }
            set { seats_taken = value; }
        }
        public Venue()
        { }
        public Venue(string n, int s, int sa, int st)
        {
            name = n;
            size = s;
            seats_available = sa;
            seats_taken = st;
        }
    }
}
