namespace KinoPoisk.Kinopoisk.DataAccess.Entities;

public class Role
{
    public int Id { get; set; }
    
    public string RoleValue { get; set; }
    
    public List<User> Users { get; set; }
}