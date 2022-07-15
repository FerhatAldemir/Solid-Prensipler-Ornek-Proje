using System;
using System.Collections.Generic;
using System.Text;

namespace Example.DataAccessLayer.absraction
{
    public interface IUserDal:Core.RepoStory.IEntityRepoStory<Entites.concrete.User>,Core.RepoStory.IRepo
    {
    }
}
