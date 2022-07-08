using Example.Entites.ComplexType;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Linq.Expressions;

namespace Example.DataAccessLayer.Concrete
{
    public class InvoiceDal : Core.Concrete.Repostory<Entites.concrete.Invoice>, DataAccessLayer.absraction.IinvoiceDal
    {
        public InvoiceDal(DbContext context) : base(context)
        {
          
        }

        public List<Invoice> GetAllInvoice(Expression<Func<Entites.concrete.Invoice,bool>> Filter)
        {

            var Item = from Inv in _Context.Set<Entites.concrete.Invoice>().Where(Filter)
                       
                       select new Invoice {
                           DocNum = Inv.DocNum,                         
                           date = Inv.date,
                           LogicalRef = Inv.LogicalRef,
                           Number = Inv.Number,
                           InvoiceLines = _Context.Set<Entites.concrete.InvoiceLine>().Where(x=>x.InvoiceRef == Inv.LogicalRef).ToList()
                       };
            return Item.ToList();
        }
    }
}
