using System.Text;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System;
namespace Components.Shared.Entity
{
    public class Movie
    {
        public int Id{get; set;}
        [Required(ErrorMessage ="El campo {0} es requerido")]
        public string Title {get; set; }
        [Required(ErrorMessage ="El campo {0} es requerido")]
        public bool InTheaters {get; set; }
        public string Description { get; set; }
        public string Genres { get; set; }
        public string MovieImage { get; set; }
        [Required (ErrorMessage ="El campo {0} es requerido")]        
        public DateTime ReleaseDate { get; set; }
        public List <CategoryMovie> CategoriesMovie {get;set;} = new List <CategoryMovie> ();
        public string ShortName
        {
            get{
               if (string.IsNullOrWhiteSpace(Title))
               {
                   return null;
               }
               if (Title.Length > 60){
                   return Title.Substring(0,60) + "...";
               }else{
                   return Title;
               }
            }
        }
    }
}