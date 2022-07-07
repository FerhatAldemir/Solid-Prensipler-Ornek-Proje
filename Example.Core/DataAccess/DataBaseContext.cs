using System;
using System.Collections.Generic;
using System.Text;

namespace Example.Core.DataAccess
{
    public interface DataBaseContext
    {
        bool CheckDataBase();
        bool Migration();



    }
}
