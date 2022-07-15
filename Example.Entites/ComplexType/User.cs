using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Example.Entites.ComplexType
{
    public class User
    {
        [Key]
        public long LogicalRef { get; set; }
    }
}
