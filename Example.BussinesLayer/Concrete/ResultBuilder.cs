using Example.Core.Concrete;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace Example.BussinesLayer.Concrete
{
    public class ResultBuilder<T> : BussinesLayer.Absraction.IResutBuilder<T> where T : class
    {
        private Result<T> _result;
        private IHttpContextAccessor Context;

        public ResultBuilder(IHttpContextAccessor httpContextAccessor=null)
        {
            _result = new Result<T>();
            this.Context = httpContextAccessor;
        }

        public void AddHttpStatus(HttpStatusCode code)
        {
            _result.StatusCode = code;
            if (Context != null) Context.HttpContext.Response.StatusCode = (int)code;
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
