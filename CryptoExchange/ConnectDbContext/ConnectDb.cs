using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoExchange.ConnectDbContext
{
    public class ConnectDb : DbContext
    {
        public ConnectDb() : base("DbConnectionString")
        {

        }
        public DbSet<User> Users { get; set; }
    }
}
