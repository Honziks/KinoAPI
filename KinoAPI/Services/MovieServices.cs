using KinoAPI.Entities;
using KinoAPI.Repositories;

namespace KinoAPI.Services
{
    public class MovieServices
    {
        private readonly IMovieRepository _movieRepository;

        public MovieServices(IMovieRepository movieRepository)
        {
            _movieRepository = movieRepository;
            Console.WriteLine("MovieServices initialized with IMovieRepository.");
        }

        public async Task<List<Movie>> GetAllMoviesAsync()
        {
            return await _movieRepository.GetAllMoviesAsync();
        }

        public async Task<Movie?> GetMovieByIdAsync(int id)
        {
            if (id <= 0)
                return null;

            return await _movieRepository.GetMovieByIdAsync(id);
        }
    }
}
