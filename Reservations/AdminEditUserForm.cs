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
    public partial class AdminEditUserForm : Form
    {
        public AdminEditUserForm()
        {
            InitializeComponent();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Close();
            AdminForm Form = new AdminForm();
            Form.Show();
        }

        private void EditUserButton_Click(object sender, EventArgs e)
        {

        }
    }
}
