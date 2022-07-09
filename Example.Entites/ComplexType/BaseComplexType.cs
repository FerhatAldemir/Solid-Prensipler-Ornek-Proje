using System;
using System.Collections.Generic;
using System.Text;

namespace Example.Entites.ComplexType
{
    public abstract class BaseComplexType
    {
        public Statu Statu { get; set; }

    }

   public enum Statu
    {
        Inserted=1,
        Updated=2,
        Deleted=3,

    }
}
