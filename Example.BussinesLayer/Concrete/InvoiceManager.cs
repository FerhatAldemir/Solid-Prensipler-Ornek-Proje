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
        private DataAccessLayer.RepoStoryAbsraction.IInvoiceRepoStory RepoStory { get; set; }
        public InvoiceManager()
        {
            RepoStory = Global.GetInstance().Service.GetService<DataAccessLayer.RepoStoryAbsraction.IInvoiceRepoStory>();
        }

        public void Delete(Invoice ITem)
        {
            RepoStory.Invoice.Remove(ITem);
        }

        

        public Invoice Post(Invoice Item)
        {
            return RepoStory.Invoice.Add(Item);
        }

        public Invoice Put(Invoice ITem)
        {
            return RepoStory.Invoice.Update(ITem);
        }

        public Invoice Get(Expression<Func<Invoice, bool>> Filter)
        {
           return RepoStory.Invoice.Get(Filter);
        }
    }
}
