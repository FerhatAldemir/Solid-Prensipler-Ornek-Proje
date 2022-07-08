using Example.Entites.concrete;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Example.BussinesLayer.Concrete
{
    public class InvoiceManager : BussinesLayer.Absraction.IInvoiceService
    {
        private DataAccessLayer.absraction.IinvoiceDal InvoiceDal { get; set; }
        public InvoiceManager()
        {
            InvoiceDal = Global.GetInstance().Service.GetService<DataAccessLayer.absraction.IinvoiceDal>();
        }

        public void Delete(Invoice ITem)
        {
            InvoiceDal.Remove(ITem);
        }

        

        public Invoice Post(Invoice Item)
        {
            return InvoiceDal.Add(Item);
        }

        public Invoice Put(Invoice ITem)
        {
            return InvoiceDal.Update(ITem);
        }

        public Invoice Get(Expression<Func<Invoice, bool>> Filter)
        {
           return InvoiceDal.Get(Filter);
        }
    }
}
