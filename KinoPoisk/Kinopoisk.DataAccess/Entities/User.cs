using KinoPoisk.Kinopoisk.DataAccess.Entities;

public class User : BaseEntity
{
    public string UserName { get; set; }
    
    public string PasswordHash { get; set; }
    
    public bool IsActive { get; set; }
    
    public int Role { get; set; }
    
    public ICollection<Movie> Movies { get; set; }
}