using Example.Core.DataAccess;
using Example.DataAccessLayer.absraction;
using System;
using System.Collections.Generic;
using System.Text;

namespace Example.DataAccessLayer.RepoStoryConcrete
{
    public class UserRepoStory : Core.Concrete.UnitWorkBase, RepoStoryAbsraction.IUserRepoStory
    {
        private IUserDal _User { get; set; }

        public UserRepoStory(DataBaseContext context, IUserDal user) : base(context)
        {
            _User = user;
        }

        public IUserDal User => _User;
    }
}
