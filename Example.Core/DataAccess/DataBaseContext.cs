using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Example.Core.DataAccess
{
    public interface DataBaseContext:IDisposable
    {
        T Add<T>(T Item) where T : class,Core.Entities.Ientites;
        void Remove<T>(T Item) where T : class, Core.Entities.Ientites;
        void RemoveRange<T>(IQueryable<T> Items) where T : class, Core.Entities.Ientites;
        IQueryable<T> Set<T>() where T : class, Core.Entities.Ientites;
        T Update<T>(T Item) where T : class, Core.Entities.Ientites;
        int SaveChanges();
        void BeginTransaction();
        void Commit();
        void RollBack();
        void Migrate();
       




    }
}
