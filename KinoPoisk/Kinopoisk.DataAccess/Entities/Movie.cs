namespace KinoPoisk.Kinopoisk.DataAccess.Entities;

public class Movie : BaseEntity
{
    public string Name { get; set; }
    
    public string Description { get; set; }
    
    public string AvatarUrl { get; set; }
    
    public double Rating { get; set; }
    
    public int Genre { get; set; }
    
    public ICollection<User> Users { get; set; }
}