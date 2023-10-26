using DemoWebUser.Models;
using DemoWebUser.Models.DTOs.Outgoing;

namespace DemoWebUser.Services.Interfaces;

public interface IUserService
{
    ValueTask<ICollection<UserDto>> Get(CancellationToken cancellationToken = default);
    ValueTask<UserDto> GetByIdAsync(Guid id, CancellationToken cancellationToken = default);
    ValueTask<UserDto> CreateAsync(User user, bool SaveChanges = true, CancellationToken cancellationToken = default);
    ValueTask<User> UpdateAsync(Guid id, User user, bool SaveChanges = true, CancellationToken cancellationToken = default);
    void DeleteAsync(Guid id, bool SaveChanges = true, CancellationToken cancellationToken = default);
}
