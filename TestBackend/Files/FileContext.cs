using System.Text.Json;
using TestBackend.Models;

namespace TestBackend.Files;

public class FileContext : IFileContext
{
    private string _filePath = @"D:\.NET_new\HomeTasks\TestBackend\Files\User.txt";
    private List<User> users = new List<User>();

    public User AddUser(User user)
    {
        users.Add(user);

        var jsonData = JsonSerializer.Serialize(users);
        File.WriteAllText(jsonData, _filePath);
        return user;
    }
}
