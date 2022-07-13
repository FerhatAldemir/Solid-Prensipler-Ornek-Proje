using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Example.DataAccessLayer.Concrete
{
    public class StLineDal : Core.Concrete.Repostory<Entites.concrete.InvoiceLine>,DataAccessLayer.absraction.IStLineDal
    {
        public StLineDal(Core.DataAccess.DataBaseContext context) : base(context)
        {
        }
    }
}
