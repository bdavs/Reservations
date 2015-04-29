using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;


namespace Reservations
{
    public class Venue
    {
        private string name;
        private int size;
        private int seats_available;

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
        public Venue()
        { }
        public Venue(string n, int s, int sa, int st)
        {
            name = n;
            size = s;
            seats_available = sa;
        }
        public static void XMLInit()
        {
            List<Venue> V = new List<Venue>();
            Venue Globe = new Venue("Globe Theater", 300, 300, 0);
            Venue Ford = new Venue("Ford Theater", 200, 200, 0);
            Venue Huntington = new Venue("Huntington Theater", 400, 400, 0);
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
