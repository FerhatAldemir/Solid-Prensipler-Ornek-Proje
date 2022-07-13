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
        private IStLineDal StLineDal { get; set; }
        public InvoiceRepoStory(Core.DataAccess.DataBaseContext context,IinvoiceDal _InvoiceDal,IStLineDal stLineDal) : base(context)
        {
            InvoiceDal = _InvoiceDal;
            StLineDal = stLineDal;
        }

        public IinvoiceDal Invoice => InvoiceDal;

        public IStLineDal StLine => StLineDal;
    }
}
