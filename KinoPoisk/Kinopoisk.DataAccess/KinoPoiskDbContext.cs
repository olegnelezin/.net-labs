using KinoPoisk.Kinopoisk.DataAccess.Entities;
using Microsoft.EntityFrameworkCore;

namespace KinoPoisk.Kinopoisk.DataAccess;

public class KinoPoiskDbContext : DbContext
{
    public DbSet<User> Users { get; set; }
    public DbSet<Movie> Movies { get; set; }
    
    public KinoPoiskDbContext(DbContextOptions options) : base(options) { }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<User>()
            .HasMany(s => s.Movies)
            .WithMany(c => c.Users);
    }
}