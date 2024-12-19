using TaskManager.Molels.Entities;

namespace TaskManager.Services;

public interface IUserService
{
    public User Create(User user);
    public User Get(long id);
    public User Update(User update);
    public User Delete(long id);
}