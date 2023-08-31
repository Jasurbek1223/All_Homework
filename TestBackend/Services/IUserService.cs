using TestBackend.Models;

namespace TestBackend.Services;

public interface IUserService
{
    User AddUser(User user);
}
