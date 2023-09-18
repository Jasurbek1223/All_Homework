using N38___HT1.Models;

namespace N38___HT1;

internal class Program
{
    static void Main(string[] args)
    {
        var users = new List<User>
{
    new User("John", "Doe", "john1808@gmail.com"),
    new User("Asad", "Asadov", "ASSSad@gmail.ru"),
    new User("Jasur", "Abdulhayev", "jasurabdulxaev@mail.com"),
    new User("Leonel", "Messi", "Meeessi10@gmail.com"),
};

        var userContainer = new UserContainer(users);
        var query = userContainer.Where(user => user.EmailAddress.Contains("gmail"));

        Console.WriteLine("Emaili gmail.com bo'lganlar :");
        foreach (var user in query)
        {
            Console.WriteLine(user);
        }

        Console.WriteLine();

        Console.WriteLine(userContainer[userContainer.LastOrDefault().Id]);
        Console.WriteLine(userContainer["Jasur"]);
        Console.WriteLine(userContainer[2]);
    }
}