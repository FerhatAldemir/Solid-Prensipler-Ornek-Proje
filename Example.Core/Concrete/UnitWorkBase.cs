using Example.Core.RepoStory;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Example.Core.Concrete
{
    public class UnitWorkBase: Core.UnitOfWork.IUnitOfWorkBase
    {
        private Core.DataAccess.DataBaseContext Context { get; set; }

        public UnitWorkBase(Core.DataAccess.DataBaseContext context)
        {
            Context = context;

        }

        public void beginTransection()
        {
            Context.BeginTransaction();
        }

        public void Commit()
        {
            Context.Commit();
        }

        public void Dispose()
        {
             
            Context.Dispose();
        }

        public void RollBack()
        {
            Context.RollBack();
        }

        public void SaveChanges()
        {
            Context.SaveChanges();
        }
    }
}
