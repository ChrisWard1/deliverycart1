#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using deliverycart.Models;

namespace deliverycart.Data
{
    public class Context : DbContext
    {
        public Context (DbContextOptions<Context> options)
            : base(options)
        {
        }
        // protected override void OnModelCreating(ModelBuilder modelBuilder)
        // {
        //     modelBuilder.Entity<Order>().HasKey(s => new {s.UserID, s.ItemID});
        // }

        //public DbSet<deliverycart.Models.Order> User { get; set; }
        public DbSet<deliverycart.Models.Order> Order { get; set; }
        public DbSet<deliverycart.Models.Item> Item { get; set; }

        //public DbSet<deliverycart.Models.Customer> Customer { get; set; }
        public DbSet<deliverycart.Models.Vendor> Vendor { get; set; }
        
        //public DbSet<deliverycart.Models.Shopper> Shopper { get; set; }


    }
}
