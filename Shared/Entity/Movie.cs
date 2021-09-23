using System;
namespace Components.Shared.Entity
{
    public class Movie
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string Genres { get; set; }
        public string MovieImage { get; set; }        
        public DateTime ReleaseDate { get; set; }
    }
}