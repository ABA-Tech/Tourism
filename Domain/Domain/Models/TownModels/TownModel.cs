namespace Domain.Models;

public class TownModel
{
    public int Id { get; set; }

    public string Name { get; set; } = default!;

    public string? Description { get; set; }

    public int CountryId { get; set; }

    public virtual CountryModel? Country { get; set; }
}
