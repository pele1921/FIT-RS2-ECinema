using System;
using System.Collections.Generic;

namespace eCinema.Services.Database;

public partial class Projection
{
    public string Id { get; set; } = null!;

    public string MovieId { get; set; } = null!;

    public string RoomId { get; set; } = null!;

    public DateTime DateTime { get; set; }

    public virtual Movie Movie { get; set; } = null!;

    public virtual Room Room { get; set; } = null!;
}
