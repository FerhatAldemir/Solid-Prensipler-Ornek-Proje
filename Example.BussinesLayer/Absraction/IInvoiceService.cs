using System;
using System.Collections.Generic;
using System.Text;

namespace Example.BussinesLayer.Absraction
{
    public interface IInvoiceService:Core.Bussines.BaseAbsraction<Entites.ComplexType.Invoice,Entites.concrete.Invoice,Core.Concrete.Result<Entites.ComplexType.Invoice>>
    {
       
    }
}
