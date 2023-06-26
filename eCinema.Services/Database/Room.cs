using System;
using System.Collections.Generic;

namespace eCinema.Services.Database;

public partial class Room
{
    public string Id { get; set; } = null!;

    public string Name { get; set; } = null!;

    public int Capacity { get; set; }

    public string LocationId { get; set; } = null!;

    public virtual Location Location { get; set; } = null!;
}
