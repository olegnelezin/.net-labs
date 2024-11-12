namespace KinoPoisk.KinoPoisk.BL.Users.Model;

public class CreateUserModel
{
    public string? UserName { get; set; }
    
    public string? PasswordHash { get; set; }
}