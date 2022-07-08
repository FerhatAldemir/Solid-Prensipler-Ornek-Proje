using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Example.Core.Bussines
{
    public interface BaseAbsraction<T,F> 
        where T:class
       
    {
        T  Post(T Item);
        T Put(T ITem);
        void Delete(T ITem);
        T Get(Expression<Func<F,bool>> Filter);      
    }
}
