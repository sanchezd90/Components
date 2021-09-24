using System;
using System.Collections.Generic;
using Components.Shared.Entity;

namespace Components.Client.Services
{
    public interface IServiceMovies
    {
         List<Movie> GetMovies();         
    }
}