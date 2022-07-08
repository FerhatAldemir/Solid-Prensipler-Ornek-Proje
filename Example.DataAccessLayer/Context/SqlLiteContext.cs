using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace Example.DataAccessLayer.Context
{
    public class SqlLiteContext:DbContext
    {
        public DbSet<Entites.concrete.Invoice> ınvoices { get; set; }
        public DbSet<Entites.concrete.InvoiceLine> ınvoiceLines { get; set; }

        public SqlLiteContext()
        {
            this.Database.AutoTransactionsEnabled = false;

            this.ChangeTracker.LazyLoadingEnabled = false;


        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            optionsBuilder.UseSqlite("Data Source=Db.sqlite");



        }
    }
}
