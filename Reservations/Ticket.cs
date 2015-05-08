using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;

namespace Reservations
{
    public class Ticket
    {
        private Shows show;
        private int seatnumber;


        public Shows Show
        {
            get { return show; }
            set { show = value; }
        }
        public int SeatNumber
        {
            get { return seatnumber; }
            set { seatnumber = value; }
        }

        public Ticket()
        { }
        public Ticket(Shows s,int n)
        {
            show = s;
            seatnumber = n;
        }
    }
}
