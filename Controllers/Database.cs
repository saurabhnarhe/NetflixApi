using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
namespace APIPractical.Controllers
{
    public class Database
    {
             public static List<Movie> _movies = new List<Movie>()
        {
            new Movie()
            {
                Name = "ddlj",
                Genre = "drama",
                Year = 2015
            },
            new Movie()
            {
                Genre = "si-fi",
                Name = "matrix",
                Year = 1998
            },
            new Movie()
            {
                Name = "matrix2",
                Genre = "si-fi",
                Year = 1998
            },
            new Movie()
            {
                Name = "Spiderman",
                Genre = "si-fi",
                Year = 2000
            }

        };

        public List<Movie> getData()
        {
            Random random = new Random();
            Thread.Sleep(1000);
            _movies.Add(new Movie()
            {
                Name = "RandomMovie",
                Genre = "si-fi",    
                Year = random.Next(4000)
            });
            return _movies;
        }

    }
}

