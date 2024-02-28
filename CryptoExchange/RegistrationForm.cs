using CryptoExchange.ConnectDbContext;
using CryptoExchange.ValidateUser;
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


        public RegistrationForm()
        {
            InitializeComponent();
        }

        private void btnRegistration_Click(object sender, EventArgs e)
        {
            Validate validate = new Validate();
            User user = new User();
            if (validate.ValidateUser(txbLastName.Text, txbFirstName.Text, txbMiddleName.Text, txbLogin.Text, txbPassword.Text,txbRepeatPassword.Text) == false)
            {
                return;
            }
            else if (user.AddUser(txbLastName.Text, txbFirstName.Text, txbMiddleName.Text, txbLogin.Text,
                txbPassword.Text))
            {
                this.Hide();
                Authorized authorized = new Authorized();
                authorized.Show();

            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Authorized authorized = new Authorized();
            authorized.Show();
        }
    }
}
