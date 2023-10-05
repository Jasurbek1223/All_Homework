using N51___T1.Models;
using N51___T1.Services.Interfaces;

namespace N51___T1.Services;

public class UserService : IUserService
{
    public ValueTask<User> CreateAsync(User user)
    {
        return new(user);
    }
}