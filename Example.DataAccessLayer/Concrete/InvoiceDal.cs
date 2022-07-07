using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Example.DataAccessLayer.Concrete
{
    public class InvoiceDal : Core.Concrete.Repostory<Entites.concrete.Invoice>, DataAccessLayer.absraction.IinvoiceDal
    {
        public InvoiceDal(DbContext context) : base(context)
        {
          
        }
    }
}
