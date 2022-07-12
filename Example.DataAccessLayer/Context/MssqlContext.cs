using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Example.DataAccessLayer.Context
{
    public class MssqlContext : DbContext
    {
        public MssqlContext()
        {


            this.Database.AutoTransactionsEnabled = false;

            this.ChangeTracker.LazyLoadingEnabled = false;
            this.ChangeTracker.AutoDetectChangesEnabled = false;
           

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {



            var ConString = @"Server=DESKTOP-VK5TOV2\SQL19;Database=Examples;User Id=sa;Password=123456";



            optionsBuilder.UseSqlServer(ConString);


        }

        public DbSet<Entites.concrete.Invoice> ınvoices { get;set;}
        public DbSet<Entites.concrete.InvoiceLine> ınvoiceLines { get;set;} 
        }
}
