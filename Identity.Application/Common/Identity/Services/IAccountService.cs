using Identity.Domain.Entities;

namespace Identity.Application.Common.Identity.Services;

public interface IAccountService
{
    List<User> Users { get; }

    ValueTask<bool> VerificateAsync (string token);

    ValueTask<User> CreateUserAsync (User user);
}
