using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;

namespace APIPractical.Controllers
{   
    [Route("movies")]
    public class MovieController : ControllerBase
    {
        private static List<Movie> _movies = new List<Movie>()
        {
            new Movie()
            {
                Name = "ddlj",
                Genre = "drama",
                Year = 2015
            },
            new Movie()
            {
                Name = "matrix",
                Genre = "si-fi",
                Year = 1998
            }
        };


        [Route("")]
        [HttpGet]
        public List<Movie> GetAll()
        {
            return _movies;
        }

        [Route("{movieName}")]
        [HttpGet]
        public Movie GetMovie(string movieName)
        {
            return _movies.Find(movie => movie.Name == movieName);
        }
    }
}
