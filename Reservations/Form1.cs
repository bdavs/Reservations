using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reservations
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
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
    }
}
