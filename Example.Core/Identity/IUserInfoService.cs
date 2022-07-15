using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;


namespace Example.Core.Identity
{
    public interface IUserInfoService<T>
    {
        HttpContext Context { get; }
        T User { get; }

        bool IsAuthenticated { get; }
    }
}
