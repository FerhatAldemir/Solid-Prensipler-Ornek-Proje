using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Example.BussinesLayer.Absraction
{
    public interface IUserManager<T,R>
    {
        R CreateUser(T Item);
        Task<R>  CreateUserAsync(T Item);

        R SignIn(string Username, string Password);
        Task<R> SignInAsync(string Username, string Password);
        void SignOut();

        Task SignOutAsync();

        R RefreshToken();

        R TwoFactorAuthentication(string code);
    /*    R Authentication(string user,string Password);*/
    }
}
