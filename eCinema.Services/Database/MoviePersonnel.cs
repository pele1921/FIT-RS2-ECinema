namespace eCinema.Services.Database;

public partial class MoviePersonnel
{
    public string Id { get; set; } = null!;

    public string PersonnelId { get; set; } = null!;

    public string MovieId { get; set; } = null!;

    public string Role { get; set; } = null!;

    public virtual Movie Movie { get; set; } = null!;

    public virtual Personnel Personnel { get; set; } = null!;
}
