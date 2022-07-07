using System;
using System.Collections.Generic;
using System.Text;

namespace Example.Core.UnitOfWork
{
    public interface IUnitOfWork:IDisposable 
    {
       
        void beginTransection();
        void RollBack();
        void Commit();
        void SaveChanges();


    }
}
