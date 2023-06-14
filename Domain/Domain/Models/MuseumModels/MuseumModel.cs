namespace Domain.Models;

public class MuseumModel
{
    public int Id { get; set; }

    public string Name { get; set; } = default!;

    public string? Description { get; set; }

    public int TownId { get; set; }

    public virtual TownModel? Town { get; set; }
}
