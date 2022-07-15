using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Example.Entites.concrete
{
    [Table("User")]
    public class User:Absraction.BaseEntite,Core.Entities.Ientites
    {
        public string UserName { get; set; }
        public string Password { get; set; }

        public static implicit operator Entites.ComplexType.User(User Item)
        {



            return new ComplexType.User {
             LogicalRef = Item.LogicalRef,
             Password = Item.Password,
             UserName = Item.UserName
            };
        }
    }
}
