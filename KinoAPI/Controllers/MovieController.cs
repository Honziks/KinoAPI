using KinoAPI.Entities;
using Microsoft.AspNetCore.Mvc;

namespace KinoAPI.Controllers
{
  
    
        [ApiController]
        [Route("api/[controller]")]

        public class MovieController : ControllerBase
        {
            private readonly List<Movie> _movies;
            public MovieController()
            {
                _movies = new List<Movie>
                {
                    new Movie { Id = 1, Title = "Inception", genre = "Sci-Fi", duration = "2h 28m", ageLimit = 13, releaseYear = 2010 },
                    new Movie { Id = 2, Title = "The Dark Knight", genre = "Action", duration = "2h 32m", ageLimit = 13, releaseYear = 2008 },
                    new Movie { Id = 3, Title = "Interstellar", genre = "Sci-Fi", duration = "2h 49m", ageLimit = 13, releaseYear = 2014 }
                };
            }
            [HttpGet]
            public ActionResult<IEnumerable<Movie>> GetMovies()
            {
                return Ok(_movies);
            }
            [HttpGet("{id}")]
            public ActionResult<Movie> GetMovie(int id)
            {
                var movie = _movies.FirstOrDefault(m => m.Id == id);
                if (movie == null)
                {
                    return NotFound();
                }
                return Ok(movie);
            }
        }
    
}
