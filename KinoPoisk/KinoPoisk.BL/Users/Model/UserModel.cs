namespace KinoPoisk.KinoPoisk.BL.Users.Model;

public class UserModel
{
    public int Id { get; set; }
    
    public DateTime CreationTime { get; set; }
    
    public DateTime ModificationTime { get; set; }
    
    public string? UserName { get; set; }
    
    public string? PasswordHash { get; set; }
    
    public bool IsActive { get; set; }
    
    public int RoleId { get; set; }
}