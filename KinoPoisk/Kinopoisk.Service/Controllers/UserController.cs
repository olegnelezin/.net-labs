using AutoMapper;
using KinoPoisk.KinoPoisk.BL.Users.Manager;
using KinoPoisk.KinoPoisk.BL.Users.Model;
using KinoPoisk.KinoPoisk.BL.Users.Provider;
using KinoPoisk.Kinopoisk.Service.Controllers.Requests;
using KinoPoisk.Kinopoisk.Service.Controllers.Responses;
using Microsoft.AspNetCore.Mvc;

namespace KinoPoisk.Kinopoisk.Service.Controllers;

[ApiController]
[Route("[controller]")]
public class UserController : ControllerBase
{
    private readonly IUsersManager _usersManager;

    private readonly IUsersProvider _usersProvider;

    private readonly IMapper _mapper;

    public UserController(IUsersManager usersManager, IUsersProvider usersProvider, IMapper mapper)
    {
        _usersManager = usersManager;
        _usersProvider = usersProvider;
        _mapper = mapper;
    }
    [HttpPost]
    public IActionResult RegisterUser([FromBody] RegisterUserRequest request)
    {
        try
        {
            var createUserModel = _mapper.Map<CreateUserModel>(request);
            var userModel = _usersManager.CreateUser(createUserModel);
            return Ok(userModel);
        }
        catch (Exception e)
        {
            return StatusCode(500, "Internal server error.");
        }
    }
    
    [HttpGet]
    public IActionResult GetAllUsers()
    {
        try
        {
            var users = _usersProvider.GetUsers();
            return Ok(new GetAllUsersResponse()
            {
                Users = users.Select(u => _mapper.Map<UserModel>(u)).ToList()
            });
        }
        catch (Exception e)
        {
            return StatusCode(500, "Internal server error.");
        }
    }
    
    [HttpPut]
    public IActionResult UpdateUserInfo([FromBody] UpdateUserModel request)
    {
        try
        {
            var userModel = _usersManager.UpdateUser(request);
            return Ok(userModel);
        }
        catch (Exception e)
        {
            return StatusCode(500, "Internal server error.");
        }
    }

}