﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Example.DataAccessLayer.RepoStoryAbsraction
{
    public interface IInvoiceRepoStory:Core.UnitOfWork.IUnitOfWorkBase
    {
        absraction.IinvoiceDal Invoice { get; }
    }
}
