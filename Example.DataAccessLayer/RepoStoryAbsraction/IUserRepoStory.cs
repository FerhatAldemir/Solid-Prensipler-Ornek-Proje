using Example.DataAccessLayer.absraction;
using System;
using System.Collections.Generic;
using System.Text;

namespace Example.DataAccessLayer.RepoStoryAbsraction
{
    public interface IUserRepoStory:Core.UnitOfWork.IUnitOfWorkBase,Core.RepoStory.IRepo
    {
        IUserDal User { get; }
    }
}
