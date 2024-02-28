using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CryptoExchange.ValidateUser
{
    public class Validate
    {
        public bool ValidateUser(string lastname, string firstname, string middlename, string login, string password,string passwordRepeat)
        {
            var MinPassword = new Regex(".{6,12}");
            if (string.IsNullOrWhiteSpace(lastname)
                || string.IsNullOrWhiteSpace(firstname)
                || string.IsNullOrWhiteSpace(login)
                || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Не все поля заполнены");
                return false;
            }
            if(password != passwordRepeat)
            {
                MessageBox.Show("Пароли не совпадают");
                return false;
            }
            if(!MinPassword.IsMatch(password)) 
            {
                MessageBox.Show("Длина пароля должна составлять от 6 до 12 символов");
                return false;
            }
            return true;
        }
    }
}
