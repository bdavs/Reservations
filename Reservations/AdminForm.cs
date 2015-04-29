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
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
        }

        private void DateSelect_DateSelected(object sender, DateRangeEventArgs e)
        {

        }

        private void newTheatre_Click(object sender, EventArgs e)
        {
            TheatreForm TF = new TheatreForm();
            TF.ShowDialog();
        }
    }
}
