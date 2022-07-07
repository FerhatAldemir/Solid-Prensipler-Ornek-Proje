using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace Example.Entites.Absraction
{
    public abstract class BaseEntite
    {
        [Key]
        public  int LogicalRef { get; set; }
    }
}
