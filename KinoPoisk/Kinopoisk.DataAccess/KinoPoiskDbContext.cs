using KinoPoisk.Kinopoisk.DataAccess.Entities;
using Microsoft.EntityFrameworkCore;

namespace KinoPoisk.Kinopoisk.DataAccess;

public class KinoPoiskDbContext : DbContext
{
    public DbSet<Role> Roles { get; set; }
    public DbSet<User> Users { get; set; }
    public DbSet<Movie> Movies { get; set; }
    
    public KinoPoiskDbContext(DbContextOptions options) : base(options) { }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<User>()
            .HasMany(u => u.Movies)
            .WithMany(m => m.Users)
            .UsingEntity<Dictionary<string, object>>(
                "users_movies",
                j => j.HasOne<Movie>().WithMany().HasForeignKey("MovieId"), 
                j => j.HasOne<User>().WithMany().HasForeignKey("UserId")    
            );
        
        modelBuilder.Entity<User>()
            .HasOne(u => u.Role) 
            .WithMany(r => r.Users) 
            .HasForeignKey(u => u.RoleId);

        modelBuilder.Entity<Movie>()
            .HasOne(m => m.Genre)
            .WithMany(g => g.Movies)
            .HasForeignKey(m => m.GenreId);
    }
}