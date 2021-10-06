using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;

namespace APIPractical.Controllers
{   
    [Route("movies")]
    public class MovieController : ControllerBase
    {
        public static List<Movie> _movies ;// new Database().getData();
        public void CacheData()
        { 
            if (_movies == null)
                _movies = new Database().getData();

        }
        [Route("")]
        [HttpGet]
        public List<Movie> GetAll()
        {
            CacheData();
            return _movies;
        }


        [Route("{movieName}")]
        [HttpGet]
        public Movie GetMovie(string movieName)
        {
            return _movies.Find(movie => movie.Name == movieName);
        }

        [Route("revalidate")]
        [HttpGet]
        public List<Movie> RevalidateCache()
        {
            _movies = new Database().getData();

            return _movies;
        }

        [Route("{movieName}")]
        [HttpPost]
        public List<Movie> PutMovie(string movieName)
        {
            var movie = new Movie()
            {
                Name = movieName,
                Genre = "dr",
                Year = 1999
            };
            _movies.Add(movie);
            return _movies;
        }

        [Route("add")]
        [HttpPost]
        public List<Movie> AddMovie([FromBody]Movie movie)
        {
            _movies.Add(movie);
            return _movies;

        }


        [Route("{movieName}")]
        [HttpDelete]
        public List<Movie> RemoveMovie(string movieName)
        {
            var movieToDelete = _movies.Find(movie => movie.Name == movieName);
            _movies.Remove(movieToDelete);
            return _movies;

        }

        [Route("year/{movieName}/{updateYear}")]
        [HttpPut]
        public Movie UpdateMovieYear(string movieName, int updateYear)
        {
            var index = _movies.IndexOf(_movies.Find(movie => movie.Name == movieName));
            _movies[index].Year = updateYear;
            return _movies[index];
        }


    }
}
