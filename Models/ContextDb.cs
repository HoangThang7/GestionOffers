using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GestionOffers.Models
{
    public class Context : DbContext
    {
       

        public Context(DbContextOptions<Context> options) : base(options)
        {
        }

        public static Context Create()
        {
             var connection = new DbContextOptionsBuilder<Context>();
             connection.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=GestionOffers;Trusted_Connection=True;ConnectRetryCount=0");
             return new Context(connection.Options);
        }

        public DbSet<Address> Address { get; set; }
        public DbSet<User> User { get; set; }
        public DbSet<Offer> Offer { get; set; }

    }
}