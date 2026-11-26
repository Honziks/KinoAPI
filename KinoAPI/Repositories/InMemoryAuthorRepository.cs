using KinoAPI.Entities;

namespace KinoAPI.Repositories
{
    public class InMemoryAuthorRepository : IMovieRepository
    {
        private static readonly List<Movie> _movies = new List<Movie>
        {
          new Movie { Id = 1, Title = "Inception", genre = "Sci-Fi", duration = "2h 28m", ageLimit = 13, releaseYear = 2010 },
            new Movie { Id = 2, Title = "The Dark Knight", genre = "Action", duration = "2h 32m", ageLimit = 13, releaseYear = 2008 },
            new Movie { Id = 3, Title = "Interstellar", genre = "Sci-Fi", duration = "2h 49m", ageLimit = 13, releaseYear = 2014 },
        };

        public InMemoryAuthorRepository()
        {
            Console.WriteLine("InMemoryAuthorRepository initialized.");
        }

        public Task<List<Movie>> GetAllMoviesAsync()
        {
            return Task.FromResult(_movies.ToList());
        }
        public Task<Movie?> GetMovieByIdAsync(int id)
        {
            var movie = _movies.FirstOrDefault(m => m.Id == id);
            return Task.FromResult(movie);
        }
    }
}
