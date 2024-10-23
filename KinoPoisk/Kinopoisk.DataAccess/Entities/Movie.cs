using System.ComponentModel.DataAnnotations.Schema;

namespace KinoPoisk.Kinopoisk.DataAccess.Entities;

[Table("movies")]
public class Movie : BaseEntity
{
    public string Name { get; set; }
    
    public string Description { get; set; }
    
    public string AvatarUrl { get; set; }
    
    public double Rating { get; set; }
    
    [ForeignKey("GenreId")]
    public int GenreId { get; set; }
    
    public Genre Genre { get; set; }
    
    public ICollection<User> Users { get; set; }
}