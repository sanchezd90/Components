using System.IO.MemoryMappedFiles;
using System;
using System.Collections.Generic;
using Components.Shared.Entity;

namespace Components.Client.Services
{
    public class ServiceActors : IServiceActors
    {        
        public List<Actor> GetActors(){
            return new List<Actor>(){
                new Actor(){Id=1, Name = "Kate Winslet", Region = Region.Europe, BirthDate = new DateTime(1980, 01, 18), Biography="John nació en ...", Nominations=1, KnownCredits=10, Photo="/images/winslet.png"},                
                new Actor(){Id=2, Name = "Jake Gyllenghaal", Region = Region.NorthAmerica, BirthDate = new DateTime(1990, 02, 28), Biography="Juan nació en ...", Nominations=2, KnownCredits=20, Photo="/images/gyllenghaal.png"},                
                new Actor(){Id=3, Name = "Colin Farrel", Region = Region.LatinAmerica, BirthDate = new DateTime(1970, 03, 26), Biography="Jonas nació en ...", Nominations=3, KnownCredits=30, Photo="/images/farrel.png"},                
                new Actor(){Id=4, Name = "Nicole Kidman", Region = Region.MiddleEast, BirthDate = new DateTime(1960, 04, 16), Biography="Abdul nació en ...", Nominations=4, KnownCredits=40, Photo="/images/kidman.png"},                
            };
        }
    }
}