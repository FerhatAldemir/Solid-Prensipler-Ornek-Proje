using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Example.Entites.concrete
{
    [Table("User")]
    public class User:Absraction.BaseEntite,Core.Entities.Ientites
    {
    }
}
