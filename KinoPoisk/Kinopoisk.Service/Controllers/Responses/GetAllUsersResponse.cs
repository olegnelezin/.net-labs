using KinoPoisk.KinoPoisk.BL.Users.Model;

namespace KinoPoisk.Kinopoisk.Service.Controllers.Responses;

public class GetAllUsersResponse
{
    public List<UserModel> Users { get; set; }
}