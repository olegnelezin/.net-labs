using AutoMapper;
using KinoPoisk.KinoPoisk.BL.Users.Exceptions;
using KinoPoisk.KinoPoisk.BL.Users.Model;
using KinoPoisk.Kinopoisk.DataAccess.Repository;
using Microsoft.IdentityModel.Tokens;

namespace KinoPoisk.KinoPoisk.BL.Users.Provider;

public class UsersProvider : IUsersProvider
{
    private readonly IRepository<User> _usersRepository;
    private readonly IMapper _mapper;
    
    public UsersProvider(IRepository<User> usersRepository, IMapper mapper)
    {
        _usersRepository = usersRepository;
        _mapper = mapper;
    }
    
    public IEnumerable<UserModel> GetUsers()
    {
        var users = _usersRepository.GetAll();
        if (users.IsNullOrEmpty())
        {
            throw new UserNotFoundException("User not found.");
        }

        return _mapper.Map<IEnumerable<UserModel>>(users);
    }

    public UserModel GetUserInfo(int id)
    {
        var user = _usersRepository.GetById(id);
        if (user == null)
        {
            throw new UserNotFoundException("User not found.");
        }

        return _mapper.Map<UserModel>(user);
    }
}