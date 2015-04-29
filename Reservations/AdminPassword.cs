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
    public partial class AdminPassword : Form
    {
        public AdminPassword()
        {
            InitializeComponent();
            AdminPasswordEnter.Focus();
        }

        private void AdminPasswordBox_Enter(object sender, EventArgs e)
        {   
   
        }

        private void AdminPasswordEnter_Click(object sender, EventArgs e)
        {
            AdminForm AF = new AdminForm();
            if (this.AdminPasswordBox.Text == "password")
            {
                AF.Show();
                this.Close();       
            }

        }

        private void AdminPassword_Load(object sender, EventArgs e)
        {
            AdminPasswordEnter.Focus();
        }

        private void AdminPasswordBox_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
