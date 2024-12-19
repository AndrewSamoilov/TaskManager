using Microsoft.AspNetCore.Mvc;
using TaskManager.Molels.Dtos;
using TaskManager.Molels.Mappers;
using TaskManager.Services;

namespace TaskManager.Controllers;

[ApiController]
[Route("[controller]")]
public class UsersController(IUserService userService, UserMapper userMapper) : ControllerBase
{
    [HttpPost(Name = "Create")]
    public UserDto Create(UserDto userDto)
    {
        var user = userMapper.MapToUser(userDto);
        return userMapper.MapToUserDto(userService.Create(user));
    }
}