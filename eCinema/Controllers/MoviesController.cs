using eCinema.Model;
using eCinema.Services;
using Microsoft.AspNetCore.Mvc;

namespace eCinema.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MoviesController
    {
        private readonly IMoviesService _moviesService;

        public MoviesController(IMoviesService moviesService)
        {
            _moviesService = moviesService;
        }

        [HttpGet]
        public IEnumerable<Movie> Get()
        {

            return _moviesService.Get();
        }

        [HttpGet("{id}")]
        public Movie GetById(string id)
        {
            return _moviesService.GetById(id);
        }
    }
}
