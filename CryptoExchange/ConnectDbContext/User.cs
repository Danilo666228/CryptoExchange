using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CryptoExchange.ConnectDbContext
{
    public class User
    {
        public int Id { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string Email { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        [DefaultValue(0)]
        public decimal Balance { get; set; }

        public bool AddUser(string lastname, string firstname, string middlename, string login, string password)
        {
            using (ConnectDb db = new ConnectDb())
            {
                var ExistUser = db.Users.FirstOrDefault(item => item.Login == login);
                if (ExistUser == null)
                {
                    db.Users.Add(new User()
                    {
                        LastName = lastname,
                        FirstName = firstname,
                        MiddleName = middlename,
                        Login = login,
                        Password = GetHashPassword(password)
                    });
                    db.SaveChanges();
                    MessageBox.Show("Вы успешно зарегистированы");
                    return true;
                }
                else
                {
                    MessageBox.Show("Этот логин уже занят");
                    return false;
                }
            }
        }
        public int ReturnId(string login,string password)
        {
            using(ConnectDb db = new ConnectDb())
            {
                var userId = db.Users.FirstOrDefault(item => item.Login == login && item.Password == password);
                if(userId == null)
                {
                    return -1;
                }
                else
                {
                    return userId.Id;
                }
            }
        }
        public string GetHashPassword(string input)
        {
            var md5 = MD5.Create();
            var hash = md5.ComputeHash(Encoding.UTF8.GetBytes(input));
            return Convert.ToBase64String(hash);
        }

    }
}
