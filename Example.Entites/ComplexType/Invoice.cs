using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Example.Entites.ComplexType
{
    public class Invoice
    {
        public int LogicalRef { get; set; }
        [MaxLength(length: 16)]
        public string Number { get; set; }

        public DateTime date { get; set; }

        public int DocNum { get; set; }
        public List<Entites.concrete.InvoiceLine> InvoiceLines { get; set; }
    }
}
