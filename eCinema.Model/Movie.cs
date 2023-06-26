using System;
using System.Collections.Generic;
using System.Text;

namespace eCinema.Model
{
    public partial class Movie
    {
        public string Id { get; set; }

        public string Name { get; set; }

        public string GenreId { get; set; }

        public string CountryOfOrigin { get; set; }

        public virtual Genre Genre { get; set; }

        //public virtual ICollection<MoviePersonnel> MoviePersonnel { get; set; } = new List<MoviePersonnel>();
    }
}
