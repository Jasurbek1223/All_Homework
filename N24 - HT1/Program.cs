using N24___HT1.Model;
using N24___HT1.Service;

namespace N24___HT1;

internal class Program
{
    static void Main(string[] args)
    {
        var users = new List<User>();
        var credentials = new List<UserCredentials>();

        var userService = new UserService(users, new UserCredentialsService(credentials));
        var registrationService = new RegistrationService(userService, new UserCredentialsService(credentials));


        registrationService.Register("Thomas", "Shelby", "Tomas@gmail.com", "strongPas123");
        registrationService.Register("Luca", "Modric", "Modric2@gmail.com", "Madrid23");
        registrationService.Register("Leonel", "Messi", "Meessi@gmail.com", "BarcaLM10");

        Console.WriteLine("Registered Users: ");

        foreach(var user in users)
        {
            Console.WriteLine($"{user.FirstName} {user.LastName} - Email: {user.EmailAddress}");
        }

        Console.Write("Enter a search keyword: ");
        string searchKeyword = Console.ReadLine();

        List<User> searchUsers = userService.Search(searchKeyword, 10, 1);

        Console.WriteLine("Searched users: ");

        foreach(var user in searchUsers)
        {
            Console.WriteLine($"{user.FirstName} {user.LastName} - Email: {user.EmailAddress}");
        }

    }
}