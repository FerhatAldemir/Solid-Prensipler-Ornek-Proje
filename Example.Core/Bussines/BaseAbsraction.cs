using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Example.Core.Bussines
{
    public interface BaseAbsraction<ComplexType,Table,R> 
        where ComplexType : class, new()
        where Table: class,new()
       
    {
        R  Post(ComplexType Item);
        R Put(ComplexType ITem);
        R Delete(Table ITem);
        R Delete(int LogicalRef);
        R Delete(Expression<Func<Table,bool>> Filter);
        R Get(Expression<Func<Table, bool>> Filter);
        R GetAll(Expression<Func<Table,bool>> Filter);
        R GetAll();
    }
}
