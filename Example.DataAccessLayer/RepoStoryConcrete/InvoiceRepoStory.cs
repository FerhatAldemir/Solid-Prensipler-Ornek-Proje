using Example.DataAccessLayer.absraction;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Example.DataAccessLayer.RepoStoryConcrete
{
    public class InvoiceRepoStory : Core.Concrete.UnitWorkBase, RepoStoryAbsraction.IInvoiceRepoStory
    {
        private  IinvoiceDal InvoiceDal { get; set; }
        public InvoiceRepoStory(DbContext context,IinvoiceDal _InvoiceDal) : base(context)
        {
            InvoiceDal = _InvoiceDal;
        }

        public IinvoiceDal Invoice => InvoiceDal;
    }
}
