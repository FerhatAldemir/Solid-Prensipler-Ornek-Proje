using System;
using System.Collections.Generic;
using System.Text;

namespace Example.DataAccessLayer.RepoStoryAbsraction
{
    public interface IInvoiceRepoStory:Core.UnitOfWork.IUnitOfWorkBase,Core.RepoStory.IRepo
    {
        absraction.IinvoiceDal Invoice { get; }
        absraction.IStLineDal StLine { get; }
    }
}
