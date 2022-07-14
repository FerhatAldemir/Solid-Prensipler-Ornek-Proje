using Example.BussinesLayer.Absraction;
using Example.Core.Bussines;
using Example.Core.Concrete;
using Example.Entites.concrete;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;

namespace Example.BussinesLayer.Concrete
{
    public class UserManager : Absraction.IUserManager<Entites.concrete.User,Core.Concrete.Result<object>>
    {
        private IHttpContextAccessor httpContextAccessor;
        private IResutBuilder<object> ResultBuilder;

        public UserManager(IHttpContextAccessor contextAccessor, IResutBuilder<object> resutBuilder)
        {
             httpContextAccessor = contextAccessor;
             
            ResultBuilder = resutBuilder;
        }

        public HttpContext Context => httpContextAccessor.HttpContext;

        public Result<object> RefreshToken()
        {
            throw new NotImplementedException();
        }

        public Result<object> SignIn(string Username, string Password)
        {
            throw new NotImplementedException();
        }

        public void SignOut()
        {
            throw new NotImplementedException();
        }

         


    }
}
