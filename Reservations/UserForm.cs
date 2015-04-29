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
            SeatForm SF = new SeatForm();
            SF.ShowDialog();
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
            //ShowBoxTree.Nodes.AddRange(l);
            ShowsBox.Items.AddRange(l);
            //ShowsBox.DisplayMember = "Name";
            ShowsBox.DisplayMember = "VenueName";
            //ShowsBox.DisplayMember ="EventName";
        }

        private void UserForm_Load(object sender, EventArgs e)
        {

        }

        private void CreateNewUserButton_Click(object sender, EventArgs e)
        {
            UserAccountForm UAF = new UserAccountForm();
            UAF.Show();
        }

        private void CheckoutButton_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Your tickets will arrive soon.\nThank you", "Form Submit", MessageBoxButtons.OK);

            if (result == System.Windows.Forms.DialogResult.Yes)
            {

                // Closes the parent form. 

                this.Close();
            }

        }
    }
}
