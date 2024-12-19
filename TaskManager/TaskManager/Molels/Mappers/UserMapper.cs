using Riok.Mapperly.Abstractions;
using TaskManager.Molels.Dtos;
using TaskManager.Molels.Entities;

namespace TaskManager.Molels.Mappers;

[Mapper]
public partial class UserMapper
{
    public partial User MapToUser(UserDto userDto);
    public partial UserDto MapToUserDto(User user);
}