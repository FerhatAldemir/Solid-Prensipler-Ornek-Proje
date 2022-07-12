using Example.Core.Concrete;
using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace Example.BussinesLayer.Concrete
{
    public class ResultBuilder<T> : BussinesLayer.Absraction.IResutBuilder<T> where T : class
    {
        private Result<T> _result;

        public ResultBuilder()
        {
            _result = new Result<T>();
        }

        public void AddHttpStatus(HttpStatusCode code)
        {
            _result.StatusCode = code;
        }

        public void AddITem(object _object)
        {
            _result.Item = _object;
        }

        public void AddMessage(string Message)
        {
            _result.HttpMessage = Message;
        }

        

        public Result<T> GetResult()
        {
            return _result as Result<T>;

        }
    }
}
