using Example.Entites.concrete;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
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

        public Invoice Delete(Invoice ITem)
        {
            throw new NotImplementedException();
        }

        public Invoice Get(int Id)
        {
          return InvoiceDal.Get(x=>x.LogicalRef == Id);
        }

        public Invoice Post(Invoice Item)
        {
            throw new NotImplementedException();
        }

        public Invoice Put(Invoice ITem)
        {
            throw new NotImplementedException();
        }
    }
}
