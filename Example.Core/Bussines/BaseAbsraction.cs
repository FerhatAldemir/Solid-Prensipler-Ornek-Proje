using System;
using System.Collections.Generic;
using System.Text;

namespace Example.Core.Bussines
{
    public interface BaseAbsraction<T>
    {
        T  Post(T Item);
        T Put(T ITem);
        T Delete(T ITem);
        T Get(int Id);      
    }
}
