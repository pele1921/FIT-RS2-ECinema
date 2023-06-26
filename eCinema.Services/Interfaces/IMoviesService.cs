using eCinema.Model;

namespace eCinema.Services
{
    public interface IMoviesService
    {
        IEnumerable<Movie> Get();
        Movie GetById(string id);
    }
}
