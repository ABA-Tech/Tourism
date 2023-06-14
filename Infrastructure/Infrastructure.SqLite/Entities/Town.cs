
namespace Infrastructure.SqLite.Entities;

public class Town
{
    public int Id { get; set; }

    public string Name { get; set; } = default!;

    public string? Description { get; set; }

    public int CountryId { get; set; }

    public virtual Country? Country { get; set; }

    public virtual IEnumerable<Museum> Museums { get; set;} = Enumerable.Empty<Museum>();
}
