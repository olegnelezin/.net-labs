using KinoPoisk.Kinopoisk.DataAccess;
using Microsoft.EntityFrameworkCore;

namespace KinoPoisk.Service.IoC;

public static class DbContextConfigurator
{
    public static void ConfigureService(WebApplicationBuilder builder)
    {
        var configuration = new ConfigurationBuilder()
            .AddJsonFile("Kinopoisk.Service/appsettings.json", optional: false)
            .Build();
        string connectionString = configuration.GetValue<string>("KinoPoiskDbContext");

        builder.Services.AddDbContextFactory<KinoPoiskDbContext>(
            options => { options.UseSqlServer(connectionString); },
            ServiceLifetime.Scoped
        );
    }

    public static void ConfigureApplication(IApplicationBuilder app)
    {
        using var scope = app.ApplicationServices.CreateScope();
        var contextFactory = scope.ServiceProvider.GetRequiredService<IDbContextFactory<KinoPoiskDbContext>>();
        using var context = contextFactory.CreateDbContext();
        context.Database.Migrate();
    }
}