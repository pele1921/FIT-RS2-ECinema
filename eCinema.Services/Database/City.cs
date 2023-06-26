using System;
using System.Collections.Generic;

namespace eCinema.Services.Database;

public partial class City
{
    public string Id { get; set; } = null!;

    public string Name { get; set; } = null!;

    public virtual ICollection<Location> Locations { get; set; } = new List<Location>();
}
