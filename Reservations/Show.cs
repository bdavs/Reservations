using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;

namespace Reservations
{
   public class Show
    {
        private string name;
        private DateTime date;
        private Venue venue;
        private double price;
        private bool available;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public DateTime Date
        {
            get { return date; }
            set { date = value; }
        }
        public Venue Venue
        {
            get{ return venue; }
            set{ venue=value; }
        }
        public double Price
        {
            get { return price; }
            set { price = value; }
        }
        public bool Available
        {
            get { return available; }
            set { available = value; }
        }

        public Show()
        { }
        public Show(string n, DateTime d, Venue v, double p, bool a)
        {
            name = n;
            date = d;
            venue = v;
            price = p;
            available = a;
        }

        public static void XMLInit()
        {   //                        Title                   Date Time YYYY/MM/DD/HH/MM/SS       Venue     Price  Available
            string fileName = "../../shows.xml";
            List<Show> L = new List<Show>();
            List<Venue> V = Venue.LoadVenues();

            Show Show0 = new Show("A Midsummer Night's Scream", new DateTime(2015, 5, 5, 19, 0, 0), V[0], 14.99, true);
            Show Show1 = new Show("Dog on a Cold Copper Floor", new DateTime(2015, 5, 20, 15, 0, 0), V[1], 19.99, true);
            Show Show2 = new Show("A Grape in the Moonlight", new DateTime(2015, 6, 3, 21, 0, 0), V[2], 19.99, true);
            Show Show3 = new Show("A Lawn Bike Named Apathy", new DateTime(2015, 6, 15, 12, 30, 0), V[1], 14.99, true);
            Show Show4 = new Show("For White Girls Who Have Considered Patricide When the Tortise Is Enuf", new DateTime(2015, 6, 25, 18, 30, 0), V[0], 19.99, true);
            Show Show5 = new Show("An Action Figure's Mansion", new DateTime(2015, 7, 1, 10, 0, 0), V[0], 14.99, true);
            Show Show6 = new Show("Bromeo and Griliet", new DateTime(2015, 7, 12, 17, 30, 0), V[0], 19.99, true);
            Show Show7 = new Show("The Insignifigance of Abstaining Indifference", new DateTime(2015, 7, 25, 15, 30, 0), V[0], 19.99, true);
            Show Show8 = new Show("Birth of a Customer", new DateTime(2015, 8, 3, 3, 45, 0), V[0], 4.99, true);
            Show Show9 = new Show("An Imperfect Wife", new DateTime(2015, 8, 14, 16, 30, 0), V[0], 14.99, true);
            Show[] Showz={Show0,Show1,Show2,Show3,Show4,Show5,Show6,Show7,Show8,Show8,Show9};
            L.AddRange(Showz);
            using (var stream = new FileStream(fileName,FileMode.Create))
            {
                XmlSerializer XML = new XmlSerializer(typeof(List<Show>));
                XML.Serialize(stream, L);
            }

        }
        public static void SaveShows(List<Show> L)
        {
            using (var stream = new FileStream("../../shows.xml", FileMode.Create))
            {
                XmlSerializer XML = new XmlSerializer(typeof(List<Show>));
                XML.Serialize(stream, L);
            }
        }
        public static List<Show> LoadShows()
        {
            List<Show> L = new List<Show>();
            using (var stream = new FileStream("../../shows.xml", FileMode.Open))
            {
                XmlSerializer XML = new XmlSerializer(typeof(List<Show>));
                return (List<Show>)XML.Deserialize(stream);
            }
        }


    }
}
