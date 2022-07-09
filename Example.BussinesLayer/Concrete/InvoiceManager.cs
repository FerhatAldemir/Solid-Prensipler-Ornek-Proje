using Example.Entites.ComplexType;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Linq;
using Example.Core.Bussines;

namespace Example.BussinesLayer.Concrete
{
    public class InvoiceManager : BussinesLayer.Absraction.IInvoiceService
    {
        private DataAccessLayer.RepoStoryAbsraction.IInvoiceRepoStory RepoStory { get; set; }
        public InvoiceManager()
        {
            RepoStory = Global.GetInstance().Service.GetService<DataAccessLayer.RepoStoryAbsraction.IInvoiceRepoStory>();
        }

        public Entites.ComplexType.Invoice Post(Entites.ComplexType.Invoice Item)
        {
            throw new NotImplementedException();
        }

        public Entites.ComplexType.Invoice Put(Entites.ComplexType.Invoice ITem)
        {
            throw new NotImplementedException();
        }

        public void Delete(Entites.concrete.Invoice ITem)
        {
            throw new NotImplementedException();
        }

        public void Delete(int LogicalRef)
        {
            throw new NotImplementedException();
        }

        public void Delete(Expression<Func<Entites.concrete.Invoice, bool>> Filter)
        {
            throw new NotImplementedException();
        }

        public Entites.ComplexType.Invoice Get(Expression<Func<Entites.concrete.Invoice, bool>> Filter)
        {
            var Item = RepoStory.Invoice.GetInvoice(Filter);
            RepoStory.Dispose();
            return Item;
        }

        public List<Entites.ComplexType.Invoice> GetAll(Expression<Func<Entites.concrete.Invoice, bool>> Filter)
        {
            var Items = RepoStory.Invoice.GetAllInvoice(Filter);
            RepoStory.Dispose();
            return Items;
        }

        public List<Entites.ComplexType.Invoice> GetAll()
        {
            var Items = RepoStory.Invoice.GetAllInvoice();
            RepoStory.Dispose();
            return Items;
        }
    }
}
