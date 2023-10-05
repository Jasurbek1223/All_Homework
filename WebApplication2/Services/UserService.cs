namespace WebApplication2.Services;

using System.Collections.Generic;
using System.Linq.Expressions;
using WebApplication2.DataAccess;
using WebApplication2.Models;
using WebApplication2.Services.Interface;

public class UserService : IUserService
{
    private readonly IDataContext _dataContext;
    public async ValueTask<User> CreateAsync(User user, bool saveChanges = true, CancellationToken cancellationToken = default)
    {
        await _dataContext.Users.AddAsync(user, cancellationToken);

        if (saveChanges)
            await _dataContext.SaveChangesAsync();

        return user;
    }

    public async ValueTask<User> DeleteAsync(Guid id, bool saveChanges = true, CancellationToken cancellationToken = default)
    {
        var foundUser = await GetByIdAsync(id, cancellationToken);
        if (foundUser is null)
            throw new InvalidOperationException("User not found");

        await _dataContext.Users.RemoveAsync(foundUser, cancellationToken);
        await _dataContext.SaveChangesAsync();
        return foundUser;
    }

    private Task<User> GetByIdAsync(Guid id, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }

    public IQueryable<User> Get(Expression<Func<User, bool>> predicate)
    {
        return _dataContext.Users.Where(predicate.Compile()).AsQueryable();
    }

    public ValueTask<ICollection<User>> GetAsync(IEnumerable<Guid> ids, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    ValueTask<User?> IUserService.GetByIdAsync(Guid id, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }

    public ValueTask<User> UpdateAsync(User user, bool saveChanges = true, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }
}