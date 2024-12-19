using TaskManager.Molels.Entities;

namespace TaskManager.Repositories;

public interface IUserRepository
{
    User Create(User user);
    User Get(long id);
}