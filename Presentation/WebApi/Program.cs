using Infrastructure.SqLite.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
//builder.Services.AddDbContext<WebApiContext>(options =>
//    options.UseSqlite(@"Data Source=Db\\Tourism.db"));

builder.Services.AddDbContext<WebApiContext>(options =>
    options.UseSqlite(@"Data Source=.\\Db\\Tourism.db;")
        .UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking));

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

// Migrate latest database changes during startup
using(var scope = app.Services.CreateScope())
{
    var dbContext = scope.ServiceProvider
        .GetRequiredService<WebApiContext>();

    dbContext.Database.Migrate();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
