using Example.BussinesLayer.Absraction;
using Example.Core.Bussines;
using Example.Core.Concrete;
using Example.Entites.concrete;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Example.BussinesLayer.Concrete
{
    public class UserManager : Absraction.IUserManager<Entites.concrete.User,Core.Concrete.Result<object>>
    {
        private IHttpContextAccessor httpContextAccessor;
        private IResutBuilder<object> ResultBuilder;
        private DataAccessLayer.RepoStoryAbsraction.IUserRepoStory userRepoStory;
        public UserManager(IHttpContextAccessor contextAccessor, IResutBuilder<object> resutBuilder, DataAccessLayer.RepoStoryAbsraction.IUserRepoStory userRepoStory)
        {
            httpContextAccessor = contextAccessor;

            ResultBuilder = resutBuilder;
            this.userRepoStory = userRepoStory;
        }

        public Result<object> CreateUser(User Item)
        {
            throw new NotImplementedException();
        }

        public Task<Result<object>> CreateUserAsync(User Item)
        {
            throw new NotImplementedException();
        }

        public Result<object> RefreshToken()
        {
            throw new NotImplementedException();
        }

        public Result<object> SignIn(string Username, string Password)
        {
            throw new NotImplementedException();
        }

        public Task<Result<object>> SignInAsync(string Username, string Password)
        {
            throw new NotImplementedException();
        }

        public void SignOut()
        {
            throw new NotImplementedException();
        }

        public Task SignOutAsync()
        {
            throw new NotImplementedException();
        }

        public Result<object> TwoFactorAuthentication(string code)
        {
            throw new NotImplementedException();
        }
    }
}
