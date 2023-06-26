using System;
using System.Collections.Generic;

namespace eCinema.Services.Database;

public partial class Movie
{
    public string Id { get; set; } = null!;

    public string Name { get; set; } = null!;

    public string GenreId { get; set; } = null!;

    public string CountryOfOrigin { get; set; } = null!;

    public virtual Genre Genre { get; set; } = null!;

    public virtual ICollection<MoviePersonnel> MoviePersonnel { get; set; } = new List<MoviePersonnel>();
}
