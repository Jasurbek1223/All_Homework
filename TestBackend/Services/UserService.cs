using TestBackend.Files;
using TestBackend.Models;

namespace TestBackend.Services;

public class UserService : IUserService
{
    private IFileContext FileContext;

    public UserService(IFileContext fileContext)
    {
        this.FileContext = fileContext;
    }

    public User AddUser(User user)
    {
        return FileContext.AddUser(user);
    }

}
