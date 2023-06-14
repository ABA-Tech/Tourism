namespace Infrastructure.SqLite.Data;

using Infrastructure.SqLite.Entities;
using Microsoft.EntityFrameworkCore;

public class WebApiContext :DbContext
{
    public WebApiContext(DbContextOptions<WebApiContext> options)
        : base(options)
    {
    }

    public DbSet<Town> Town { get; set; } = default!;
}
