using Example.Core.RepoStory;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Example.Core.Concrete
{
    public class UnitWork: Core.UnitOfWork.IUnitOfWork
    {
        private DbContext Context { get; set; }

        public UnitWork(DbContext context)
        {
            Context = context;

        }

        public void beginTransection()
        {
            Context.Database.BeginTransaction();
            
        }

        public void Commit()
        {
            Context.Database.CurrentTransaction.Commit();
        }

        public void Dispose()
        {
            Context.Database.CurrentTransaction.Dispose();
            Context.Dispose();
        }

        public void RollBack()
        {
            Context.Database.CurrentTransaction.Rollback();
        }

        public void SaveChanges()
        {
            Context.SaveChanges();
        }
    }
}
