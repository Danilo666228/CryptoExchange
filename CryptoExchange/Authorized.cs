using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CryptoExchange
{
    public partial class Authorized : Form
    {
        RegistrationForm registrationForm = new RegistrationForm();
        public Authorized()
        {
            InitializeComponent();
        }
        


        private void swPassword_CheckedChanged(object sender, EventArgs e)
        {
            
            if (swPassword.Checked)
            {
                txbPassword.UseSystemPasswordChar = true;
            }
            else
            {
                txbPassword.UseSystemPasswordChar = false;
            }
        }

        

        private void LinklblRegistration_Click(object sender, EventArgs e)
        {
            this.Hide();            
            registrationForm.Show();
        }
    }
}
