using KinoPoisk.KinoPoisk.BL.Users.Model;

namespace KinoPoisk.KinoPoisk.BL.Users.Provider;

public interface IUsersProvider
{
    IEnumerable<UserModel> GetUsers();
    UserModel GetUserInfo(int id);
}