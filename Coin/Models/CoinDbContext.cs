using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Coin.Models
{
    public class CoinDbContext : IdentityDbContext
    {
        public CoinDbContext() : base("MyConnectionString")
        {
            
        }
        public DbSet<User> Users { get; set; }
        public DbSet<News> News { get; set; }
        public DbSet<Subscribe> Subscribes { get; set; }
        public DbSet<Currency> Currencies { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<News>()
                .HasRequired(n => n.User)
                .WithMany(user => user.News)
                .HasForeignKey(n => n.UserId);

            modelBuilder.Entity<Subscribe>()
                .HasRequired(s => s.User)
                .WithMany(user => user.Subscribes)
                .HasForeignKey(s => s.UserId);
        }

    }
}