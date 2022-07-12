using System;
using System.Collections.Generic;
using System.Net;
using System.Text;
using Example.Core.Concrete;

namespace Example.BussinesLayer.Absraction
{
    public interface IResutBuilder<T> where T : class
    {
        void AddHttpStatus(HttpStatusCode code);
        void AddITem(object _object);
        void AddMessage(string Message);
        Result<T> GetResult() ;
        
    }
}
