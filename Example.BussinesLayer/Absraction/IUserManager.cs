using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;

namespace Example.BussinesLayer.Absraction
{
    public interface IUserManager<T,R>
    {
        HttpContext Context { get;}
        R SignIn(string Username, string Password);
        void SignOut();
        R RefreshToken();

    /*    R Authentication(string user,string Password);*/
    }
}
