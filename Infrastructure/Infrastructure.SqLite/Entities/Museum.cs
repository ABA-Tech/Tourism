namespace Infrastructure.SqLite.Entities;

public class Museum
{
    public int Id { get; set; }

    public string Name { get; set; } = default!;

    public string? Description { get; set; }

    public int TownId { get; set; }

    public virtual Town? Town { get; set; }
}
