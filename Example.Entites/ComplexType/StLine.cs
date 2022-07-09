using System;
using System.Collections.Generic;
using System.Text;

namespace Example.Entites.ComplexType
{
     public class StLine
    {
        public int LogicalRef { get; set; }
        public int StockRef { get; set; }
        public int InvoiceRef { get; set; }
        public int StFicheRef { get; set; }
        public double Amount { get; set; }
        public double price { get; set; }

        public Statu Statu { get; set; }

        public static implicit operator concrete.InvoiceLine(StLine stLine)
        {


            return new concrete.InvoiceLine { };
        }
       

    }

   
}
