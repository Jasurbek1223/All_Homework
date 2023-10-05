using N51___T1.Models;

namespace N51___T1.Services.Interfaces;

public interface IUserService
{
    ValueTask<User> CreateAsync(User user);
}