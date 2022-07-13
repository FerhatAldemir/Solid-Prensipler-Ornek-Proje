using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Example.Core.DataAccess;

namespace Example.DataAccessLayer.Context
{
    public class MssqlContext : DbContext,Core.DataAccess.DataBaseContext
    {
        public MssqlContext()
        {


            this.Database.AutoTransactionsEnabled = true;

            this.ChangeTracker.LazyLoadingEnabled = false;
            this.ChangeTracker.AutoDetectChangesEnabled = true;
           

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {



            var ConString = @"Server=DESKTOP-VK5TOV2\SQL19;Database=Examples;User Id=sa;Password=123456";



            optionsBuilder.UseSqlServer(ConString);


        }

        IQueryable<T> DataBaseContext.Set<T>()
        {
            return this.Set<T>();
        }

        public void BeginTransaction()
        {
            this.Database.BeginTransaction();
        }

        public void Commit()
        {
            this.Database.CurrentTransaction.Commit();
        }

        public void RollBack()
        {
            this.Database.CurrentTransaction.Rollback();
        }

        T DataBaseContext.Add<T>(T Item)
        {
            
            return this.Set<T>().Add(Item) as T;
        }

        void DataBaseContext.Remove<T>(T Item)
        {
            this.Set<T>().Remove(Item);
        }

        void DataBaseContext.RemoveRange<T>(IQueryable<T> Items)
        {
            this.Set<T>().RemoveRange(Items);
        }

        T DataBaseContext.Update<T>(T Item)
        {
            var Entry = this.Attach(Item);
         
            return Item;
        }

        public void Migrate()
        {
            this.Database.Migrate();
        }

        public DbSet<Entites.concrete.Invoice> ınvoices { get;set;}
        public DbSet<Entites.concrete.InvoiceLine> ınvoiceLines { get;set;} 
        }
}
