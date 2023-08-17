using N24___HT1.Interface;
using N24___HT1.Model;

namespace N24___HT1.Service;

class UserService : IUserService
{
    private List<User> users;
    private IUserCredentialsService userCredentialsService;

    public UserService(List<User> users, IUserCredentialsService userCredentialsService)
    {
        this.users = users;
        this.userCredentialsService = userCredentialsService;
    }

    public List<User> Get(int pageSize, int pageToken)
    {
        int startIndex = (pageToken - 1) * pageSize;
        return users.Skip(startIndex).Take(pageSize).ToList();
    }

    public List<User> Search(string searchKeyword, int pageSize,  int pageToken)
    {
        var query = users
            .Where(user => user.FirstName.Contains(searchKeyword, StringComparison.OrdinalIgnoreCase) || user.LastName.Contains(searchKeyword, StringComparison.OrdinalIgnoreCase))
            .ToList();

        int startIndex = (pageToken-1) * pageSize;
        return query.Skip(startIndex).Take(pageSize).ToList();
          
    }

    public List<User> Filter(UserFilterModel userFilterModel)
    {
        var query = users
            .Where(user =>
            (string.IsNullOrEmpty(userFilterModel.FirstName) ||
            user.FirstName.Contains(userFilterModel.FirstName, StringComparison.OrdinalIgnoreCase)) &&
            (string.IsNullOrEmpty(userFilterModel.LastName) ||
            user.LastName.Contains(userFilterModel.LastName, StringComparison.OrdinalIgnoreCase)))
            .ToList();

        int startIndex = (userFilterModel.PageToken-1)*userFilterModel.PageSize;
        return query.Skip(startIndex).Take(userFilterModel.PageSize).ToList();

    }


    public User Add(string firstName, string lastName, string emailAddress)
    {
        if(users.Any(user => user.EmailAddress.Equals(emailAddress, StringComparison.OrdinalIgnoreCase)))
        {
            throw new ArgumentException("User with the same email address already exist. ");
        }

        var newUser = new User
        {
            Id = users.Count + 1,
            FirstName = firstName,
            LastName = lastName,
            EmailAddress = emailAddress,
            IsDeleted = false
        };

        users.Add(newUser);
        return newUser;
    }

    public User Update(User user)
    {
        var exastingUser = users.FirstOrDefault(u => u.Id == user.Id);

        if(exastingUser != null)
        {
            exastingUser.FirstName = user.FirstName;
            exastingUser.LastName = user.LastName;
            exastingUser.EmailAddress = user.EmailAddress;
        }

        return exastingUser;
    }


    public bool Delete(int id)
    {
        var user = users.FirstOrDefault(user => user.Id == id);
        if(user != null)
        {
            user.IsDeleted = true;
            return true;
        }

        return false;
    }

    User IUserService.Delete(int id)
    {
        throw new NotImplementedException();
    }
}
