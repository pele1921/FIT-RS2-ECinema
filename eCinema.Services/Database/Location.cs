using System;
using System.Collections.Generic;

namespace eCinema.Services.Database;

public partial class Location
{
    public string Id { get; set; } = null!;

    public string CityId { get; set; } = null!;

    public string Address { get; set; } = null!;

    public virtual City City { get; set; } = null!;

    public virtual ICollection<Room> Rooms { get; set; } = new List<Room>();
}
