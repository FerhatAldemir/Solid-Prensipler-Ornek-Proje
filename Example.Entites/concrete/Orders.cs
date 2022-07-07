using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Example.Entites.concrete
{
    public class Orders : Absraction.BaseEntite, Core.Entities.Ientites
    {
        [MaxLength(length: 16)]
        public string Number { get; set; }

        public DateTime date {get;set;}

        public int DocNum { get; set; }

    }
}
