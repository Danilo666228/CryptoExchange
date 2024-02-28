using CryptoExchange.ConnectDbContext;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CryptoExchange
{
    public partial class RegistrationForm : Form
    {
        User user = new User();
        public RegistrationForm()
        {
            InitializeComponent();
        }

        private void btnRegistration_Click(object sender, EventArgs e)
        {
            user.AddUser(txbLastName.Text,txbFirstName.Text,txbMiddleName.Text,txbLogin.Text,user.GetHashPassword(txbPassword.Text));
        }
    }
}
