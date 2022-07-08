using Example.Entites.ComplexType;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Linq;

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
            /*RepoStory.Invoice.Remove(ITem);*/
        }
        public Invoice Post(Invoice Item)
        {


            return null; //RepoStory.Invoice.Add(Item);
        }

        public Invoice Put(Invoice ITem)
        {
            return null;//RepoStory.Invoice.Update(ITem);
        }

        public Invoice Get(Expression<Func<Invoice, bool>> Filter)
        {
            Invoice Invoice = RepoStory.Invoice.GetAllInvoice(0).FirstOrDefault();
            
           return Invoice ;
        }
    }
}
