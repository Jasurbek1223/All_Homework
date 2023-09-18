using N37___HT1.Interfaces;
using N37___HT1.Models;

namespace N37___HT1.Services;

public class UserService : IUserservice
{
    public List<User> users;

    public UserService()
    {
        users = new List<User>();
    }

    public IEnumerable<User> GetUsers()
    {
        foreach (var user in users)
        {
            yield return user;
        }
    }
}
