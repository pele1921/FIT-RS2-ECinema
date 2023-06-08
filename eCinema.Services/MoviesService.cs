using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCinema.Services
{
    public class MoviesService : IMoviesService
    {
        //create a list of two movies
        public List<Movie> Movies = new List<Movie>()
        {
            new Movie()
            {
                MovieId = 1,
                Name = "film",
                Genre = "drama"
            },
            new Movie()
            {
                MovieId = 2,
                Name = "film2",
                Genre = "drama2"
            }
        };
        public IEnumerable<Movie> Get()
        {
            return new List<Movie>()
            {
                new Movie()
                {
                    MovieId = 1,
                    Name = "film",
                    Genre = "drama"
                }
            };
        }
        

        public Movie GetById(int id)
        {
            return Movies.FirstOrDefault(x => x.MovieId == id);
        }

    }
}
