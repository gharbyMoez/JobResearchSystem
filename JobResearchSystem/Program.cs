using JobResearchSystem.Application;
using JobResearchSystem.Infrastructure;
using JobResearchSystem.Infrastructure.Database;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

#region Connection String Configuration
builder.Services.AddDbContext<ApplicationContext>(opt =>
                opt.UseSqlServer(builder.Configuration.GetConnectionString("Default")));
#endregion


builder.Services
    .AddInfrastructureDependencies()
    .AddApplicationDependeicies();


var app = builder.Build();

using var scope = app.Services.CreateScope();

var dbContext = scope.ServiceProvider.GetRequiredService<ApplicationContext>();

var loggerFactory = scope.ServiceProvider.GetRequiredService<ILoggerFactory>();

try
{
    await dbContext.Database.MigrateAsync();

    await AppContextSeed.SeedAsync(dbContext);
}
catch (Exception ex)
{
    var logger = loggerFactory.CreateLogger<Program>();
    logger.LogError(ex, "Database updating failed !");
}

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
