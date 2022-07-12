using Example.Entites.ComplexType;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Linq;
using Example.Core.Bussines;
using Example.Core.Concrete;

namespace Example.BussinesLayer.Concrete
{
    public class InvoiceManager : BussinesLayer.Absraction.IInvoiceService
    {
        private DataAccessLayer.RepoStoryAbsraction.IInvoiceRepoStory RepoStory { get; set; }
        private Absraction.IResutBuilder<Entites.ComplexType.Invoice> ResultBuilder { get; set; }
        public InvoiceManager()
        {
            RepoStory = Global.GetInstance().Service.GetService<DataAccessLayer.RepoStoryAbsraction.IInvoiceRepoStory>();
            ResultBuilder = Global.GetInstance().Service.GetService<Absraction.IResutBuilder<Entites.ComplexType.Invoice>>();
        }

        public Result<Entites.ComplexType.Invoice> Post(Entites.ComplexType.Invoice Item)
        {
            throw new NotImplementedException();
        }

        public Result<Entites.ComplexType.Invoice> Put(Entites.ComplexType.Invoice ITem)
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

        public Result<Entites.ComplexType.Invoice> Get(Expression<Func<Entites.concrete.Invoice, bool>> Filter)
        {
            var Item = RepoStory.Invoice.GetInvoice(Filter);
            RepoStory.Dispose();
            ResultBuilder.AddHttpStatus(System.Net.HttpStatusCode.Accepted);
            ResultBuilder.AddMessage("Veriler Başarılı Bir Şekilde Getirildi");
            ResultBuilder.AddITem(Item);
            return ResultBuilder.GetResult();
        }

        public Result<Entites.ComplexType.Invoice> GetAll(Expression<Func<Entites.concrete.Invoice, bool>> Filter)
        {
            throw new NotImplementedException();
        }

        public Result<Entites.ComplexType.Invoice> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
