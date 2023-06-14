namespace Infrastructure.SqLite.Entities;

public class Country
{
    public int Id { get; set; }

    public string Name { get; set; } = default!;

    public string? Description { get; set; }

    public virtual IEnumerable<Town>? Towns { get; set; } = Enumerable.Empty<Town>();
}
