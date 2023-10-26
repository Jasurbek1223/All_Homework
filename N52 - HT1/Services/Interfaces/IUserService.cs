using N52___HT1.Models;
using System.Linq.Expressions;

namespace N52___HT1.Services.Interfaces;

public interface IUserService
{
    ValueTask<User> Create(User user);
}