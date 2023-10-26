using N52___HT1.Models;
using N52___HT1.Services.Interfaces;
using System.Linq.Expressions;
using System.Text.RegularExpressions;

namespace N52___HT1.Services;

public class UserService : IUserService
{
    private readonly AccountEventStore _eventStore;
    public UserService(AccountEventStore accountEventStore)
    {
        _eventStore = accountEventStore;
    }

    public async ValueTask<User> Create(User user)
    {
        await _eventStore.CreateUserAddedAsync(user);

        return user;
    }
}