using System;
using System.Collections.Generic;

namespace eCinema.Services.Database;

public partial class Genre
{
    public string Id { get; set; } = null!;

    public string Name { get; set; } = null!;

    public virtual ICollection<Movie> Movies { get; set; } = new List<Movie>();
}
