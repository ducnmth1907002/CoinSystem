using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Coin.Models
{
    public class CoinDbContext : DbContext
    {
        public CoinDbContext()
        {

        }
        public DbSet<User> Users { get; set; }
        public DbSet<News> News { get; set; }
        public DbSet<Subscribe> Subscribes { get; set; }
        public DbSet<Currency> Currencies { get; set; }

    }
}