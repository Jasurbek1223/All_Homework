using N43___HT1.Models;
using N43___HT1.Services.Interfaces;

namespace N43___HT1.Services;

public class UserService : IUserService
{
    private List<User> _users;

    public UserService()
    {
        _users = new List<User>();
    }

    public User Create(User user)
    {
        if (user != null)
        {
            _users.Add(user);
            return user;
        }

        throw new ArgumentException("User is null");
    }

    public bool Delete(Guid id)
    {
        var existUser = _users.FirstOrDefault(user => user.Id == id);
        if (existUser != null)
        {
            _users.Remove(existUser);
            return true;
        }
        return false;
    }

    public User? Get(Guid id)
    {
        return _users.FirstOrDefault(user => user.Id == id);
    }

    public List<User> GetAll()
    {
        return _users.ToList();
    }

    public User Update(User user)
    {
        var existUser = _users.FirstOrDefault(u => u.Id == user.Id);
        if (existUser != null)
        {
            existUser.FirstName = user.FirstName;
            existUser.LastName = user.LastName;
            existUser.IsActive=  user.IsActive;
            return existUser;
        }
        throw new ArgumentNullException(nameof(user), "User not found");
    }
}
