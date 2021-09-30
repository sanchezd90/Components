using System;
using System.ComponentModel.DataAnnotations;

namespace Components.Shared.Entity
{
    public class Category
    {
        public int Id{get; set;}
        [Required(ErrorMessage="Este campo {0} es obligatorio")]
        public string Name{get; set;}
    }
}