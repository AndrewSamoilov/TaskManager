using TaskManager.Molels.Entities;

namespace TaskManager.Services;

public class UserService(ILogger<UserService> logger) : IUserService
{
    private readonly ILogger _logger = logger;

    public User Create(User user)
    {
        return user;
    }

    public User Get(long id)
    {
        throw new NotImplementedException();
    }

    public User Update(User update)
    {
        throw new NotImplementedException();
    }

    public User Delete(long id)
    {
        throw new NotImplementedException();
    }
}