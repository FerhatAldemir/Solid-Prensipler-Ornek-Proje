using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Example.Entites.ComplexType
{
     public class StLine
    {
        [Key]
        public int LogicalRef { get; set; }
        public int StockRef { get; set; }
        public int InvoiceRef { get; set; }
        public int StFicheRef { get; set; }
        public double Amount { get; set; }
        public double price { get; set; }

        public Statu Statu { get; set; }

        public static implicit operator concrete.InvoiceLine(StLine stLine)
        {


            return new concrete.InvoiceLine {
             Amount = stLine.Amount,
             StockRef = stLine.StockRef,
             InvoiceRef = stLine.InvoiceRef,
             LogicalRef = stLine.LogicalRef,
             price =  stLine.price,
             StFicheRef = stLine.StFicheRef,
             
            };
        }
       

    }

   
}
