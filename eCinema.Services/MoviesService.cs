using AutoMapper;
using eCinema.Services.Database;

namespace eCinema.Services
{
    public class MoviesService : IMoviesService
    {
        public ECinemaContext ECinemaContext { get; }
        private readonly IMapper _mapper;

        public MoviesService(ECinemaContext eCinemaContext, IMapper mapper)
        {
            ECinemaContext = eCinemaContext;
            _mapper = mapper;
        }
        public IEnumerable<Model.Movie> Get()
        {
            return _mapper.Map<List<Model.Movie>>(ECinemaContext.Movies.ToList());
        }
        

        public Model.Movie GetById(string id)
        {
            return _mapper.Map<Model.Movie>(ECinemaContext.Movies.FirstOrDefault(m => m.Id == id));
        }

    }
}
