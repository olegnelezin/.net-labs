using System.ComponentModel.DataAnnotations.Schema;
using KinoPoisk.Kinopoisk.DataAccess.Entities;

[Table("users")]
public class User : BaseEntity
{
    public string UserName { get; set; }
    
    public string PasswordHash { get; set; }
    
    public bool IsActive { get; set; }
    
    public int RoleId { get; set; }
    
    [ForeignKey("RoleId")]
    public Role Role { get; set; }
    
    public ICollection<Movie> Movies { get; set; }
}