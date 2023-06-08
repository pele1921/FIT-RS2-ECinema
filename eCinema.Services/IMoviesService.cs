using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCinema.Services
{
    public interface IMoviesService
    {
        IEnumerable<Movie> Get();
        Movie GetById(int id);
    }
}
