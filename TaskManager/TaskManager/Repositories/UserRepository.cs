using TaskManager.Molels.Entities;

namespace TaskManager.Repositories;

public class UserRepository(ILogger<UserRepository> logger) : IUserRepository
{
    public User Create(User user)
    {
        throw new NotImplementedException();
    }

    public User Get(long id)
    {
        throw new NotImplementedException();
    }
}