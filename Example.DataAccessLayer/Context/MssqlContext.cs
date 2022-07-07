using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Example.DataAccessLayer.Context
{
    public class MssqlContext : DbContext,Core.DataAccess.DataBaseContext
    {
        public MssqlContext()
        {


            CheckDataBase();
            Migration();

        }

        public bool CheckDataBase()
        {
            throw new NotImplementedException();
        }

        public bool Migration()
        {
            throw new NotImplementedException();
        }
    }
}
