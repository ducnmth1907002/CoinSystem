using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Coin.Models
{
    public class CoinDbContext : IdentityDbContext<User>
    {
        public CoinDbContext() : base("MyConnectionString")
        {

        }
        //public DbSet<User> Users { get; set; }
        public DbSet<News> News { get; set; }
        public DbSet<Subscribe> Subscribes { get; set; }
        public DbSet<Currency> Currencies { get; set; }
    }
}