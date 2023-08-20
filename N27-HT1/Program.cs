namespace N27_HT1;

internal class Program
{
    static void Main(string[] args)
    {
        UserService userService = new UserService();

        userService.Add("jasur@gmail.com", "password8");
        userService.Add("akbar@gmail.com", "password9");

        List<User> users = userService.GetUsers();
        Console.WriteLine("Users: ");
        foreach (User user in users)
        {
            Console.WriteLine($"Id: {user.Id}, Email: {user.EmailAddress}, IsAdmin: {user.IsAdmin} ");
        }
        
    }
}