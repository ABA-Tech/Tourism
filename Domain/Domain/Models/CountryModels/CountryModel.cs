namespace Domain.Models;

public class CountryModel
{
    public int Id { get; set; }

    public string Name { get; set; } = default!;

    public virtual IEnumerable<TownModel>? Towns { get; set; }
}
