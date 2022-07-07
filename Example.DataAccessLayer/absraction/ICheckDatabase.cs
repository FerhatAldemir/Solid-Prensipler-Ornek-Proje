using System;
using System.Collections.Generic;
using System.Text;

namespace Example.DataAccessLayer.absraction
{
    public interface ICheckDatabase : IDisposable
    {
       
        void MigrationDatase();

    }
}
