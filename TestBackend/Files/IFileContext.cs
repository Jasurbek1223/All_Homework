using TestBackend.Models;

namespace TestBackend.Files;

public interface IFileContext
{
    public User AddUser(User user);
}
