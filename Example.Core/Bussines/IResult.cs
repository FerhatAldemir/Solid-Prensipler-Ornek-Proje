using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace Example.Core.Bussines
{
    public interface IResult<T> where T : class
    {
        object Item { get; set; }

        HttpStatusCode StatusCode { get; set; }

        string HttpMessage { get; set; }
    }
}
