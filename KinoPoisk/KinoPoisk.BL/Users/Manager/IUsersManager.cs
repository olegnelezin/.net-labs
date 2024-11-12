using KinoPoisk.KinoPoisk.BL.Users.Model;

namespace KinoPoisk.KinoPoisk.BL.Users.Manager;

public interface IUsersManager
{
    UserModel CreateUser(CreateUserModel createUserModel);

    UserModel UpdateUser(UpdateUserModel updateUserModel);

    void DeleteUser(int id);
}