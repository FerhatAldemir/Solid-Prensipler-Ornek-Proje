using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Example.Entites.concrete
{
    [Table("StLine")]
    public class InvoiceLine: Absraction.BaseEntite, Core.Entities.Ientites
    {
        
        public int StockRef { get; set; }
        public int InvoiceRef { get; set; }
        public int StFicheRef { get; set; }
        public double Amount { get; set; }
        public double price { get; set; }


        public static implicit operator ComplexType.StLine(InvoiceLine imp)
        {
            return new ComplexType.StLine {
                Amount = imp.Amount,
                InvoiceRef = imp.InvoiceRef,
                StockRef = imp.StockRef,
                LogicalRef = imp.LogicalRef,
                price   = imp.price,
                StFicheRef=imp.StFicheRef,
                Statu = imp.LogicalRef != 0 ? ComplexType.Statu.Updated: ComplexType.Statu.Deleted

            };
        }
    }
}
