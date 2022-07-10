using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Example.DataAccessLayer.absraction
{
    public interface IinvoiceDal:Core.RepoStory.IEntityRepoStory<Entites.concrete.Invoice>,Core.RepoStory.IRepo
    {
        List<Entites.ComplexType.Invoice> GetAllInvoice(Expression<Func<Entites.concrete.Invoice, bool>> Filter = null);
        Entites.ComplexType.Invoice GetInvoice(Expression<Func<Entites.concrete.Invoice,bool>> Filter);

    }
}
