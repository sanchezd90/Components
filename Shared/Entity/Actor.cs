using System;

namespace Components.Shared.Entity
{
    public class Actor
    {
        public int Id{get; set;}
        public string Name {get; set;}
        public Region Region {get; set;}
        public DateTime BirthDate {get; set;}
        public string Biography {get; set;}
        public int Nominations {get; set;}
        public int KnownCredits {get; set;}
    }
    public enum Region
    {
        LatinAmerica=0,
        NorthAmerica=1,
        Europe=2,
        MiddleEast=3,        
        Asia=4,
        Oceania=5,
        Africa=6
    }

}