using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace Example.Core.Concrete
{
    public class Result<T> :Core.Bussines.IResult<T> where T : class
    {
        public object Item { get; set; }
        public HttpStatusCode StatusCode { get; set; }
        public string HttpMessage { get; set; }
    }
}
