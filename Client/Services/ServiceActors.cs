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
                new Actors(){Name = "Jhon Doe", Region = Movie.Europe, BirthDate = new DateTime(1980, 01, 18), Biography="John nació en ..."},                
                new Actors(){Name = "Juan Perez", Region = Movie.NorthAmerica, BirthDate = new DateTime(1990, 02, 28), Biography="Juan nació en ..."},                
                new Actors(){Name = "Jonas Kleinmann", Region = Movie.LatinAmerica, BirthDate = new DateTime(1970, 03, 26), Biography="Jonas nació en ..."},                
                new Actors(){Name = "Abdul Farez", Region = Movie.MiddleEast, BirthDate = new DateTime(1960, 04, 16), Biography="Abdul nació en ..."},                
            };
        }
    }
}