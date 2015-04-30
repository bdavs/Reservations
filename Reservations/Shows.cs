using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;

namespace Reservations
{
   public class Shows
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

        public Shows()
        { }
        public Shows(string n, DateTime d, Venue v, double p, bool a)
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
            List<Shows> L = new List<Shows>();
            List<Venue> V = Venue.LoadVenues();

            Shows Show0 = new Shows("A Midsummer Night's Scream", new DateTime(2015, 5, 5, 19, 0, 0), V[0], 14.99, true);
            Shows Show1 = new Shows("Dog on a Cold Copper Floor", new DateTime(2015, 5, 20, 15, 0, 0), V[1], 19.99, true);
            Shows Show2 = new Shows("A Grape in the Moonlight", new DateTime(2015, 6, 3, 21, 0, 0), V[2], 19.99, true);
            Shows Show3 = new Shows("A Lawn Bike Named Apathy", new DateTime(2015, 6, 15, 12, 30, 0), V[1], 14.99, true);
            Shows Show4 = new Shows("For White Girls Who Have Considered Patricide When the Tortise Is Enuf", new DateTime(2015, 6, 25, 18, 30, 0), V[0], 19.99, true);
            Shows Show5 = new Shows("An Action Figure's Mansion", new DateTime(2015, 7, 1, 10, 0, 0), V[0], 14.99, true);
            Shows Show6 = new Shows("Bromeo and Griliet", new DateTime(2015, 7, 12, 17, 30, 0), V[0], 19.99, true);
            Shows Show7 = new Shows("The Insignifigance of Abstaining Indifference", new DateTime(2015, 7, 25, 15, 30, 0), V[0], 19.99, true);
            Shows Show8 = new Shows("Birth of a Customer", new DateTime(2015, 8, 3, 3, 45, 0), V[0], 4.99, true);
            Shows Show9 = new Shows("An Imperfect Wife", new DateTime(2015, 8, 14, 16, 30, 0), V[0], 14.99, true);
            Shows[] Showz={Show0,Show1,Show2,Show3,Show4,Show5,Show6,Show7,Show8,Show9};
            L.AddRange(Showz);
            using (var stream = new FileStream(fileName,FileMode.Create))
            {
                XmlSerializer XML = new XmlSerializer(typeof(List<Shows>));
                XML.Serialize(stream, L);
            }

        }
        public static void SaveShows(List<Shows> L)
        {
            using (var stream = new FileStream("../../shows.xml", FileMode.Create))
            {
                XmlSerializer XML = new XmlSerializer(typeof(List<Shows>));
                XML.Serialize(stream, L);
            }
        }
        public static List<Shows> LoadShows()
        {
            List<Shows> L = new List<Shows>();
            using (var stream = new FileStream("../../shows.xml", FileMode.Open))
            {
                XmlSerializer XML = new XmlSerializer(typeof(List<Shows>));
                return (List<Shows>)XML.Deserialize(stream);
            }
        }


    }
}
