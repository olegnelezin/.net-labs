using AutoMapper;
using KinoPoisk.KinoPoisk.BL.Users.Model;
using KinoPoisk.Kinopoisk.DataAccess.Repository;

namespace KinoPoisk.KinoPoisk.BL.Users.Manager;

public class UsersManager : IUsersManager
{
    private readonly IRepository<User> _usersRepository;
    private readonly IMapper _mapper;

    public UsersManager(IRepository<User> usersRepository, IMapper mapper)
    {
        _usersRepository = usersRepository;
        _mapper = mapper;
    }
    
    public UserModel CreateUser(CreateUserModel createUserModel)
    {
        var user = _mapper.Map<User>(createUserModel);
        user = _usersRepository.Save(user);
        return _mapper.Map<UserModel>(user);
    }

    public UserModel UpdateUser(UpdateUserModel updateUserModel)
    {
        var user = _mapper.Map<User>(updateUserModel);
        user = _usersRepository.Save(user);
        return _mapper.Map<UserModel>(user);
    }
}