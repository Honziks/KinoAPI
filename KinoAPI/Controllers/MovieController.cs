using KinoAPI.Entities;
using KinoAPI.Services;
using Microsoft.AspNetCore.Mvc;

namespace KinoAPI.Controllers
{    
        [ApiController]
        [Route("api/[controller]")]

        public class MovieController : ControllerBase
        {
            private readonly MovieServices _movies;
            
            public MovieController(MovieServices movieServices)
            {
            _movies = movieServices;
        }
           
            [HttpGet]
            public async Task<ActionResult<List<Movie>>> GetAllMovies()
        {
            var movies = await Task.FromResult(_movies);
            return Ok(movies);
        }
            [HttpGet("{id}")]
        public async Task<ActionResult<Movie>> GetMovieById(int id)
        {
            var movie = await _movies.GetMovieByIdAsync(id);
            if (movie == null)
            {
                return NotFound();
            }
            return Ok(movie);
        }
    }
    
}
