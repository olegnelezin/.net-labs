using System.ComponentModel.DataAnnotations;

namespace KinoPoisk.Kinopoisk.Service.Controllers.Requests;

public class RegisterUserRequest
{
    [Required(ErrorMessage = "Username must be not empty!")]
    public string UserName { get; set; }
    
    [Required(ErrorMessage = "Password must be not empty!")]
    public string PasswordHash { get; set; }
}