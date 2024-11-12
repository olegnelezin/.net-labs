using KinoPoisk.KinoPoisk.BL.Users.Model;

namespace KinoPoisk.KinoPoisk.BL.Users.Manager;

public interface IUsersManager
{
    UserModel createUser(CreateUserModel createUserModel);
}