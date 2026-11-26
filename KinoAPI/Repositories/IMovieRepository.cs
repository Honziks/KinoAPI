using KinoAPI.Entities;

namespace KinoAPI.Repositories
{
    public interface IMovieRepository
    {
        Task<List<Movie>> GetAllMoviesAsync();
        Task<Movie?> GetMovieByIdAsync(int id);

    }
}
