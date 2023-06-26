using System;
using System.Collections.Generic;

namespace eCinema.Services.Database;

public partial class Personnel
{
    public string Id { get; set; } = null!;

    public string Name { get; set; } = null!;

    public virtual ICollection<MoviePersonnel> MoviePersonnel { get; set; } = new List<MoviePersonnel>();
}
