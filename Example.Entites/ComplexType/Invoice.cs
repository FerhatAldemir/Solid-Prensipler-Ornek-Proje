using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Example.Entites.ComplexType
{
    public class Invoice:BaseComplexType
    {
        public int LogicalRef { get; set; }
        [MaxLength(length: 16)]
        public string Number { get; set; }

        public DateTime date { get; set; }

        public int DocNum { get; set; }
        public List<Entites.ComplexType.StLine> InvoiceLines { get; set; }

        public static implicit operator concrete.Invoice(Invoice Invoice)
        {


            return new concrete.Invoice { };
        }
    }
}
