using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reservations
{
    public class ShowTime
    {
        private DateTime info;
        private string eventName;
        private string venueName;

        public DateTime Info
        { 
            get {return info;}
            set {info = value;}
        }
        public string EventName
        {
            get {return eventName;}
            set {eventName = value;}
        }
        public string VenueName
        {
            get {return venueName;}
            set {venueName = value;}
        }


        public ShowTime() { }
    }
}
