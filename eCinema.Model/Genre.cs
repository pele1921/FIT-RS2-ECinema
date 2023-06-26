using System;
using System.Collections.Generic;
using System.Text;

namespace eCinema.Model
{
    public partial class Genre
    {
        public string Id { get; set; }

        public string Name { get; set; }

        public virtual ICollection<Movie> Movies { get; set; } = new List<Movie>();
    }
}

