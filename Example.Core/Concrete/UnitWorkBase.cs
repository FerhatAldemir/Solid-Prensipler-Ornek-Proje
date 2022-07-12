using Example.Core.RepoStory;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Example.Core.Concrete
{
    public class UnitWorkBase: Core.UnitOfWork.IUnitOfWorkBase
    {
        private DbContext Context { get; set; }

        public UnitWorkBase(DbContext context)
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
