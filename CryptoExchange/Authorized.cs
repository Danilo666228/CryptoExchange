using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CryptoExchange.ConnectDbContext;

namespace CryptoExchange
{
    public partial class Authorized : Form
    {
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
            RegistrationForm registrationForm = new RegistrationForm();
            registrationForm.Show();
        }

        private void btnAuthorized_Click(object sender, EventArgs e)
        {
            User user = new User();
            var userId = user.ReturnId(txbLogin.Text,user.GetHashPassword(txbPassword.Text));
            if(userId != -1) 
            {
                MessageBox.Show("Вы успешно вошли в аккаунт");
                this.Hide();
                MainForm main = new MainForm(userId);
                main.Show();
            }
            else
            {
                MessageBox.Show("Неверные данные");
            }
        }
    }
}
