using Bogus;
namespace N38___HT2;

public class Program
{
    static void Main(string[] args)
    {
        var faker = new Faker();

        var employee = faker.Person;
        Console.WriteLine("Employee:");
        Console.WriteLine($"ID: {faker.Random.Number(1, 100)}");
        Console.WriteLine($"First Name: {employee.FirstName}");
        Console.WriteLine($"Last Name: {employee.LastName}");
        Console.WriteLine($"Email: {employee.Email}");

        var order = faker.Commerce;
        Console.WriteLine("\nOrder:");
        Console.WriteLine($"Order ID: {faker.Random.Number(1000, 9999)}");
        Console.WriteLine($"Product Name: {order.ProductName()}");
        Console.WriteLine($"Price: {order.Price()}");
        Console.WriteLine($"Order Date: {faker.Date.Recent()}");

        var userAddress = faker.Address;
        Console.WriteLine("\nUser Address:");
        Console.WriteLine($"Address ID: {faker.Random.Number(100, 999)}");
        Console.WriteLine($"Country: {userAddress.Country()}");
        Console.WriteLine($"City: {userAddress.City()}");
        Console.WriteLine($"State: {userAddress.State()}");
        Console.WriteLine($"Street: {userAddress.StreetAddress()}");
        Console.WriteLine($"Number: {faker.Phone.PhoneNumber()}");

        var blogPost = faker.Random.Words();
        Console.WriteLine("\nBlog Post:");
        Console.WriteLine($"Post ID: {faker.Random.Number(10000, 99999)}");
        Console.WriteLine($"Title: {blogPost}");
        Console.WriteLine($"Content: {faker.Lorem.Paragraph()}");

        Console.WriteLine("\nWeather Report:");
        Console.WriteLine($"Report ID: {faker.Random.Number(100, 999)}");
        Console.WriteLine($"Location: {faker.Address.City()}");
        Console.WriteLine($"Report Date: {faker.Date.Recent()}");
        Console.WriteLine($"Temperature (Celsius): {faker.Random.Double(-10, 40)}");

        Console.ReadLine();
    }
}