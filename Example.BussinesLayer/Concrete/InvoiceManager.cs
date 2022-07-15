using Example.Entites.ComplexType;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Linq;
using Example.Core.Bussines;
using Example.Core.Concrete;
using Microsoft.AspNetCore.Identity;

namespace Example.BussinesLayer.Concrete
{
    public class InvoiceManager : BussinesLayer.Absraction.IInvoiceService
    {
        private DataAccessLayer.RepoStoryAbsraction.IInvoiceRepoStory RepoStory { get; set; }
        private Absraction.IResutBuilder<Entites.ComplexType.Invoice> ResultBuilder { get; set; }
        private Core.Identity.IUserInfoService<Entites.ComplexType.User> user;


        public InvoiceManager(DataAccessLayer.RepoStoryAbsraction.IInvoiceRepoStory repo,
            Core.Identity.IUserInfoService<Entites.ComplexType.User> user, Absraction.IResutBuilder<Entites.ComplexType.Invoice> resutBuilder)
        {
            RepoStory = repo;
            this.user = user;
            ResultBuilder = resutBuilder;
        }

        public Result<Entites.ComplexType.Invoice> Post(Entites.ComplexType.Invoice Item)
        {
            try { 
            RepoStory.beginTransection();

            Entites.concrete.Invoice Invoice = (Entites.concrete.Invoice)Item;
            RepoStory.Invoice.Add(Invoice);
            RepoStory.SaveChanges();
            foreach (var Inv in Item.InvoiceLines)
            {
                var InvLine = (Entites.concrete.InvoiceLine)Inv;
                InvLine.InvoiceRef = Invoice.LogicalRef;
                RepoStory.StLine.Add(InvLine); 



            }
            RepoStory.SaveChanges();
            RepoStory.Commit();
            ResultBuilder.AddHttpStatus(System.Net.HttpStatusCode.Accepted);
            ResultBuilder.AddMessage("Fatura Başarılı Bir Şekilde Eklendi");
            ResultBuilder.AddITem(RepoStory.Invoice.GetInvoice(x=>x.LogicalRef == Invoice.LogicalRef));
            }
            catch (Exception ex)
            {

                RepoStory.RollBack();

                ResultBuilder.AddMessage("Fatura Ekleme İşlemi Gerçekleşirken Bir Hata Verdi. Hata :" + ex.Message);
                ResultBuilder.AddHttpStatus(System.Net.HttpStatusCode.InternalServerError);

            }
            return ResultBuilder.GetResult();


        }

        public Result<Entites.ComplexType.Invoice> Put(Entites.ComplexType.Invoice ITem)
        {
            Entites.concrete.Invoice Invoice = (Entites.concrete.Invoice)ITem;
            try {
                RepoStory.beginTransection();
            RepoStory.Invoice.Update(Invoice);
            RepoStory.SaveChanges();

                foreach (var Inv in ITem.InvoiceLines)
            {
                var InvLine = (Entites.concrete.InvoiceLine)Inv;
                switch (Inv.Statu)
                {
                    case Statu.Updated:
                    RepoStory.StLine.Update(InvLine);
                   
                    break;
                    case Statu.Deleted:
                    RepoStory.StLine.Remove(InvLine);
                    RepoStory.SaveChanges();
                    break;
                    case Statu.Inserted:
                    InvLine.InvoiceRef = Invoice.LogicalRef;
                    var AddedItem = RepoStory.StLine.Add(InvLine);
                    RepoStory.SaveChanges();
                    Inv.Statu = Statu.Updated;
                    Inv.LogicalRef = AddedItem.LogicalRef;
                    break;

                }

            }

                RepoStory.Commit();
                ResultBuilder.AddITem(RepoStory.Invoice.GetInvoice(x=>x.LogicalRef == Invoice.LogicalRef));
             
                ResultBuilder.AddMessage("Fatura Güncelleme İşlemi Başarıyla Tamamlandı.");
                ResultBuilder.AddHttpStatus(System.Net.HttpStatusCode.Accepted);

            }
            catch (Exception ex)
            {
                RepoStory.RollBack();
                ResultBuilder.AddMessage("Fatura Güncelleme İşlemi Başarısız Oldu. Hata:"+ex.Message);
                ResultBuilder.AddHttpStatus(System.Net.HttpStatusCode.InternalServerError);
            }
            RepoStory.Dispose();
            return ResultBuilder.GetResult();
        }

        public Result<Entites.ComplexType.Invoice> Delete(Entites.concrete.Invoice ITem)
        {
            throw new NotImplementedException();
        }

        public Result<Entites.ComplexType.Invoice> Delete(int LogicalRef)
        {
            throw new NotImplementedException();
        }

        public Result<Entites.ComplexType.Invoice> Delete(Expression<Func<Entites.concrete.Invoice, bool>> Filter)
        {
          
            var Item = RepoStory.Invoice.GetInvoice(Filter);
           
            if (Item == null)
            {
                    ResultBuilder.AddMessage("Silinmek İstenen Fatura Bulanamadı");
                    ResultBuilder.AddHttpStatus(System.Net.HttpStatusCode.NotFound);
               

            }
            else
            {
                try
                {
                RepoStory.beginTransection();
                RepoStory.Invoice.Remove(Filter);
                RepoStory.StLine.Remove(x=>x.InvoiceRef == Item.LogicalRef);
                RepoStory.SaveChanges();
                RepoStory.Commit();
                ResultBuilder.AddMessage("Fatura Başarı İle Silindi");
                ResultBuilder.AddHttpStatus(System.Net.HttpStatusCode.Found);
                ResultBuilder.AddITem(Item);

                }
                catch (Exception ex)
                {
                    RepoStory.RollBack();

                    ResultBuilder.AddMessage("Silme İşlemi Gerçekleşirken Bir Hata Verdi. Hata :" + ex.Message);
                    ResultBuilder.AddHttpStatus(System.Net.HttpStatusCode.InternalServerError);
                }

            }
            
          
            return ResultBuilder.GetResult();
        }

        public Result<Entites.ComplexType.Invoice> Get(Expression<Func<Entites.concrete.Invoice, bool>> Filter)
        {
            var Item = RepoStory.Invoice.GetInvoice(Filter);

            var a = user.User;
            if (Item == null)
            {
                ResultBuilder.AddHttpStatus(System.Net.HttpStatusCode.NotFound);
                ResultBuilder.AddMessage("Veri Bulanamadı");


            }
            else
            {
                ResultBuilder.AddHttpStatus(System.Net.HttpStatusCode.Found);
                ResultBuilder.AddMessage("Veriler Başarılı Bir Şekilde Listelendi");


                ResultBuilder.AddITem(Item);

            }
            
           
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
