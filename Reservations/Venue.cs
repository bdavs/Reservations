using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;
using System.Windows.Forms;
using System.Drawing;



namespace Reservations
{
    public class Venue
    {
        private string name;
        private int size;
        private int seats_available;
        private List<Point> seat_location;
        private List<Point> seats_taken;

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
        public List<Point> Seat_Location
        {
            //banananana
            get { return seat_location; }
            set { seat_location = value; }
        }
        public List<Point> Seats_Taken
        {
            get { return seats_taken; }
            set { seats_taken = value; }
        }






        public Venue()
        { }
        public Venue(string n, int s, int sa)
        {
            name = n;
            size = s;
            seats_available = sa;

        }
        public Venue(string n, int s, int sa, List<Point> sl)
        {
            name = n;
            size = s;
            seats_available = sa;
            seat_location = sl;

        }
        public Venue(string n, int s, int sa, List<Point> sl, List<Point> st)
        {
            name = n;
            size = s;
            seats_available = sa;
            seat_location = sl;
            seats_taken = st;
        }
        public static void XMLInit()
        {
            List<Venue> V = new List<Venue>();
            Venue Globe = new Venue("Globe Theater", 300, 300);
            Venue Ford = new Venue("Ford Theater", 200, 200);
            Venue Huntington = new Venue("Huntington Theater", 400, 400);
            Venue[] Venuez = { Globe, Ford, Huntington };
            V.AddRange(Venuez);
            using (var stream = new FileStream("../../venues.xml", FileMode.Create))
            {
                XmlSerializer XML = new XmlSerializer(typeof(List<Venue>));
                XML.Serialize(stream, V);
            }
        }
        public static void SaveVenues(List<Venue> L)
        {
            using (var stream = new FileStream("../../venues.xml", FileMode.Create))
            {
                XmlSerializer XML = new XmlSerializer(typeof(List<Venue>));
                XML.Serialize(stream, L);
            }
        }
        public static List<Venue> LoadVenues()
        {
            List<Venue> L = new List<Venue>();
            using (var stream = new FileStream("../../venues.xml", FileMode.Open))
            {
                XmlSerializer XML = new XmlSerializer(typeof(List<Venue>));
                return (List<Venue>)XML.Deserialize(stream);

            }
        }
    }
}
