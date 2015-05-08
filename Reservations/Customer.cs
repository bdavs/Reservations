using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;

namespace Reservations
{
   public class Customer
    {
       private string name;
       private string address;
       private string phone;
       private string credit;
       private string email;
       private int size;
       private List<Ticket> tickets;

       public string Name
       {
           get { return name; }
           set { name = value; }
       }
       public string Address
       {
           get { return address; }
           set { address = value; }
       }
       public string Phone
       {
           get { return phone; }
           set { phone = value; }
       }
       public string Credit
       {
           get { return credit; }
           set { credit = value; }
       }
       public string Email
       {
           get { return email; }
           set { email = value; }
       }
       public int Size
       {
           get { return size; }
           set { size = value; }
       }
       public List<Ticket> Tickets
       {
           get { return tickets; }
           set { tickets = value; }
       }

       public Customer()
       { }
       public Customer(string n, string a, string p, string c, string e, int s)
       {
           name = n;
           address = a;
           phone = p;
           credit = c;
           email = e;
           size = s;
           tickets = new List<Ticket>();
       }

       public static void XMLInit()
       {
           List<Customer> C = new List<Customer>();
           Customer Customer0 = new Customer("William Shakespeare", "Church of the Holy Trinity, Stratford-upon-Avon, United Kingdom", "7815553460", "1234567890123456", "thespeare@gmail.com", 1);
           Customer Customer1 = new Customer("Oscar Wilde", "Père Lachaise Cemetery, France", "1345456782", "2345678901234567", "gonewilder@comcast.net", 3);
           Customer Customer2 = new Customer("Edward Albee", "Somewhere in Virginia", "3334445555", "1234567887654321", "12yogay@yahoo.com", 5);
           Customer Customer3 = new Customer("Pompus White Guy", "Practically Everywhere", "3456547753", "1222555567678221", "yourwrong@lifeisabitch.org", 1);
           Customer[] Customerz = { Customer0, Customer1, Customer2, Customer3 };
           C.AddRange(Customerz);
           using (var stream = new FileStream("../../customers.xml", FileMode.Create))
           {
               XmlSerializer XML = new XmlSerializer(typeof(List<Customer>));
               XML.Serialize(stream, C);
           }
       }
       public static void SaveCustomers(List<Customer> C)
       {
           using (var stream = new FileStream("../../customers.xml", FileMode.Create))
           {
               XmlSerializer XML = new XmlSerializer(typeof(List<Customer>));
               XML.Serialize(stream, C);
           }
       }
       public static List<Customer> LoadCustomers()
       {
           List<Customer> L = new List<Customer>();
           using (var stream = new FileStream("../../customers.xml", FileMode.Open))
           {
               XmlSerializer XML = new XmlSerializer(typeof(List<Customer>));
               return (List<Customer>)XML.Deserialize(stream);
           }
       }
    }
}
