using System.Collections;

namespace N38___HT1.Models;

public class UserContainer : IEnumerable<User>
{
    private IEnumerable<User> _users;

    public UserContainer()
    {
        _users = new List<User>();
    }

    public UserContainer(IEnumerable<User> users)
    {
        _users = users;
    }

    public User this[Guid id] => _users.First(user => user.Id == id);

    public User this[string keyword] => _users.First(x => x.FirstName.Contains(keyword)
    || x.LastName.Contains(keyword) || x.EmailAddress.Contains(keyword));

    public User this[int index] => _users.ToArray()[index];

    public IEnumerator<User> GetEnumerator()
    {
        return _users.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}