using System;
using System.Collections.Generic;
using System.Text;

namespace Example.DataAccessLayer.absraction
{
    public interface IinvoiceDal:Core.RepoStory.IEntityRepoStory<Entites.concrete.Invoice>
    {
        List<Entites.ComplexType.Invoice> GetAllInvoice(int LogicalRef);

    }
}
