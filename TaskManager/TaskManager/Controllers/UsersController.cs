using Microsoft.AspNetCore.Mvc;
using TaskManager.Molels.Dtos;
using TaskManager.Molels.Entities;
using TaskManager.Molels.Mappers;
using TaskManager.Services;

namespace TaskManager.Controllers;

[ApiController]
[Route("[controller]")]
public class UsersController : ControllerBase
{

    private IUserService _userService;
    private UserMapper _userMapper;


    public UsersController(IUserService userService, UserMapper userMapper)
    {
        _userService = userService;
        _userMapper = userMapper;
    }
    
    [HttpPost(Name = "Create")]
    public UserDto Create(UserDto userDto)
    {
        var user = _userMapper.MapToUser(userDto);
        return _userMapper.MapToUserDto(_userService.Create(user));
    }
    
}