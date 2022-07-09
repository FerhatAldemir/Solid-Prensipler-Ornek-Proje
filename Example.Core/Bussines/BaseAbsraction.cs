using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Example.Core.Bussines
{
    public interface BaseAbsraction<ComplexType,Table> 
        where ComplexType : class, new()
        where Table: class,new()
       
    {
        ComplexType  Post(ComplexType Item);
        ComplexType Put(ComplexType ITem);
        void Delete(Table ITem);
        void Delete(int LogicalRef);
        void Delete(Expression<Func<Table,bool>> Filter);
        ComplexType Get(Expression<Func<Table, bool>> Filter);
        List<ComplexType> GetAll(Expression<Func<Table,bool>> Filter);
        List<ComplexType> GetAll();
    }
}
