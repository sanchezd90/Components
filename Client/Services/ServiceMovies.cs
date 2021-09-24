using System;
using System.Collections.Generic;
using Components.Shared.Entity;

namespace Components.Client.Services
{
    public class ServiceMovies : IServiceMovies
    {        
        public List<Movie>GetMovies(){
            return new List<Movie>(){
                new Movie(){Title = "Maligno", Description = "Madison está paralizada por causa de visiones impactantes de asesinatos espeluznantes. Su tormento empeora cuando descubre que estos sueños de vigilia son, de hecho, realidades aterradoras.",Genres = "Crimen, Horror, Misterio",MovieImage = "/images/maligno.png", ReleaseDate = new DateTime(2021, 09, 03)},
                new Movie(){Title = "Ondina. Un amor para siempre", Description = "Ondina es una historiadora que enseña sobre el desarrollo urbanístico de Berlín. Cuando el hombre al que quiere la deja, un antiguo mito se apodera de ella. Ondina debe matar al traidor y regresar al agua.",Genres = "Drama, Fantasía, Misterio",MovieImage= "/images/ondina.png", ReleaseDate = new DateTime(2020, 09, 20)},
                new Movie(){Title = "El padre", Description = "Un hombre rechaza toda la ayuda de su hija a medida que envejece. Mientras trata de encontrarle sentido a sus circunstancias cambiantes, comienza a dudar de sus seres queridos, de su propia mente e incluso del tejido de su realidad.",Genres = "Drama",MovieImage= "/images/father.png", ReleaseDate = new DateTime(2020, 12, 23)},
                new Movie(){Title = "El oficial y el espía", Description = "En 1894, en capitán francés Alfred Dreyfus es injustamente sentenciado por traición y condenado de por vida en la Isla del Diablo.",Genres = "Drama, Thriller, Historia",MovieImage= "/images/jaccuse.png", ReleaseDate = new DateTime(2020, 01, 01)},
                new Movie(){Title = "The Night House", Description = "Una viuda comienza a descubrir los inquietantes secretos de su marido recientemente fallecido.",Genres = "Horror, Misterio, Thriller",MovieImage= "/images/night.png", ReleaseDate = new DateTime(2021, 09, 21)}      
            };
        }
    }
}