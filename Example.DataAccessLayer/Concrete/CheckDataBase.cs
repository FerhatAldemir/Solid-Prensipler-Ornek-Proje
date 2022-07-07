using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Example.DataAccessLayer.Concrete
{
    public class CheckDataBase : absraction.ICheckDatabase
    {
        readonly DbContext Context;

        public CheckDataBase(DbContext context)
        {
            Context = context;
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

       

        public void MigrationDatase()
        {
            Context.Database.Migrate();
        }
    }
}
