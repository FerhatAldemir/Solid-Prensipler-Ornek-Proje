using Example.Entites.ComplexType;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;

namespace Example.BussinesLayer.Concrete
{
    public class UserInfoManager : Core.Identity.IUserInfoService<Entites.ComplexType.User>
    {
        private IHttpContextAccessor httpContextAccessor;
        private DataAccessLayer.RepoStoryAbsraction.IUserRepoStory userRepoStory;
        private Entites.ComplexType.User user;
        public UserInfoManager(DataAccessLayer.RepoStoryAbsraction.IUserRepoStory userRepoStory, IHttpContextAccessor httpContextAccessor)
        {
            this.httpContextAccessor = httpContextAccessor;
            this.userRepoStory= userRepoStory;
            this.user = new User();
        }
        public HttpContext Context => httpContextAccessor.HttpContext;

        public User User => user;

        public bool IsAuthenticated => httpContextAccessor.HttpContext.User.Identity.IsAuthenticated;
    }
}
