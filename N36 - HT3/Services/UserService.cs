using N36___HT3.Models;

namespace N36___HT3.Services;

public class UserService
{
    private List<User> users;

    public UserService()
    {
        users = new List<User>();
    }

    public void Create(User user)
    {
        users.Add(user);
    }

    public List<User> GetUsers()
    {
        return users;
    }

    public User GetUser(Guid id)
    {
        return users.FirstOrDefault(u => u.Id == id);
    }

    public void Update(User user)
    {
        var existUser = users.FirstOrDefault(u=>u.Id == user.Id);

        if (existUser != null)
        {
            existUser.FirstName = user.FirstName;
            existUser.LastName = user.LastName;
        }
    }

    public void Delete(Guid id)
    {
        var existUser = users.FirstOrDefault(u => u.Id == id);

        if (existUser != null)
        {
            users.Remove(existUser);
        }
    }
}

