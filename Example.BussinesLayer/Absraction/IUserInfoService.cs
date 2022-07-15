using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;

namespace Example.BussinesLayer.Absraction
{
    public interface IUserInfoService
    {
        HttpContext Context { get; }
        Entites.ComplexType.User User { get; }

        bool IsAuthenticated { get; }
    }
}
