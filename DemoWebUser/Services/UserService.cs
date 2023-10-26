using DemoWebUser.Data;
using DemoWebUser.Models;
using DemoWebUser.Services.Interfaces;

namespace DemoWebUser.Services;

public class UserService //: IUserService
{
    private readonly IDataContext _dataContext;
  
    public UserService(IDataContext dataContext)
    {
        _dataContext = dataContext;
    }

    public async ValueTask<User> CreateAsync(User user, bool SaveChanges = true, CancellationToken cancellationToken = default)
    {
        var existUser = _dataContext.Users.FirstOrDefault(u => u.Email.Equals(user.Email));
        if (existUser is null)
            throw new Exception("This user is exist");

        var entity = await _dataContext.Users.AddAsync(user);

        await _dataContext.SaveChangesAsync();

        return entity.Entity;
    }

    public async ValueTask<User> DeleteAsync(Guid id, bool SaveChanges = true, CancellationToken cancellationToken = default)
    {
        var user = await _dataContext.Users.FindAsync(id, cancellationToken);

        if (user == null) throw new Exception();

        await _dataContext.Users.RemoveAsync(user);
        await _dataContext.SaveChangesAsync();

        return user;
    }


    public ValueTask<ICollection<User>> Get(CancellationToken cancellationToken = default)
    {
        return new ValueTask<ICollection<User>>(_dataContext.Users.ToList());
    }

    public ValueTask<User> GetByIdAsync(Guid id, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public ValueTask<User> UpdateAsync(Guid id, User user, bool SaveChanges = true, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }
}
