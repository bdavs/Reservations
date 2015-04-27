using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Xml.Serialization;

namespace Reservations
{
    public partial class UserForm : Form
    {
        public List<ShowTime> showTimeList;
        public UserForm()
        {
            InitializeComponent();
            showTimeList = ReadXML<ShowTime>("..\\..\\showtimes.xml");
        }
        // Read XML file into a list of objects
        public static List<T> ReadXML<T>(string path)
        {
            List<T> list = new List<T>();

            try
            {
                using (StreamReader sr = new StreamReader(path))
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(List<T>));
                    list = serializer.Deserialize(sr) as List<T>;
                }
            }
            catch (Exception error)
            {
                MessageBox.Show("Error Reading File.");
            }

            return list;
        }

        private void NameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void AdminModeButton_Click(object sender, EventArgs e)
        {
            AdminPassword AP = new AdminPassword();
            AP.Show();
            //this.Close();

        }

        private void SeatSelectButton_Click(object sender, EventArgs e)
        {

        }

        private void monthCalendar_DateSelected(object sender, DateRangeEventArgs e)
        {
            MonthCalendar mc = sender as MonthCalendar;

            /*           Schedule[] l = (from s in schedule
                                       where s.Info.Date == mc.SelectionStart
                                       orderby s.Info.TimeOfDay
                                       select s).ToArray();  */
            List<ShowTime> sss = new List<ShowTime>();
            foreach (ShowTime s in showTimeList)
                if (s.Info.Date == mc.SelectionStart)
                    sss.Add(s);

            ShowTime[] l = sss.ToArray();

            ShowsBox.Items.Clear();
            ShowsBox.Items.AddRange(l);
            //ShowsBox.DisplayMember = "Name";
            ShowsBox.DisplayMember = "VenueName";
        }
    }
}
