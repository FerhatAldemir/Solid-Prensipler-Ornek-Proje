using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Example.Entites.ComplexType
{
    public class User
    {
        [Key]
        public int LogicalRef { get; set; }

        public string UserName { get; set; }
        public string Password { get; set; }


        public static implicit operator Entites.concrete.User(User Item)
        {



            return new concrete.User
            {
                LogicalRef = Item.LogicalRef,
                Password = Item.Password,
                UserName = Item.UserName
            };
        }
    }
}
