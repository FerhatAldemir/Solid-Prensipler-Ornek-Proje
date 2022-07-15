using Example.Core.DataAccess;
using System;
using System.Collections.Generic;
using System.Text;

namespace Example.DataAccessLayer.Concrete
{
    public class UserDal : Core.Concrete.Repostory<Entites.concrete.User>, absraction.IUserDal
    {
        public UserDal(DataBaseContext context) : base(context)
        {
        }
    }
}
