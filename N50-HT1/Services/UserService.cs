using N50_HT1.Models.Entities;
using N50_HT1.Services.Interfaces;

namespace N50_HT1.Services;

public class UserService : IUserService
{
    private List<User> _users;

    public UserService(List<User> users)
    {
        _users = users;
    }

    public User Create(User user)
    {
        if(user is null)
            throw new ArgumentNullException("User is null");

        _users.Add(user);
        return user;
    }

    public void Delete(Guid id)
    {
        var existUser = Get(id);
        if (existUser is null)
            throw new InvalidOperationException("User not found");
    }

    public void Delete(User user)
    {
        _users.Remove(user);
    }

    public User Get(Guid id)
    {
        return _users.FirstOrDefault(u => u.Id == id);
    }

    public List<User> GetAll()
    {
        return _users.ToList();
    }

    public User Update(User user)
    {
        var existUser = _users.FirstOrDefault(x => x.Id == user.Id);
        if (existUser is null)
            throw new InvalidOperationException("User not found");

        existUser.FirstName = user.FirstName;
        existUser.LastName = user.LastName;
        existUser.Email = user.Email;

        return existUser;
    }
}