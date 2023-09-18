using N39___HT1.Models;

namespace N39___HT1;

public class Program
{
    static void Main(string[] args)
    {
        List<WeatherReport> weatherReports = new List<WeatherReport>
        {
            new WeatherReport(state: "Tashkent", degree: 25.0),
            new WeatherReport(state: "Gulistan", degree: 27.0),
            new WeatherReport(state: "Syrdarya", degree: 30.5),
            new WeatherReport(state: "Sayxunabad", degree: 34.8)
        };

        List<User> users = new List<User>
        {
            new User(firstName : "Jasurbek", lastName : "Abdulhayev"),
            new User(firstName : "Asad", lastName : "Asadov"),
            new User(firstName : "John", lastName : "Doe"),
            new User(firstName : "John", lastName : "Malik"),
        };

        var highTemperatureReports = weatherReports.Where(report => report.Degree > 30);

        Console.WriteLine("30 C dan baland bo'lgan weather reportlar:");
        foreach (var report in highTemperatureReports)
            Console.WriteLine($"State: {report.State}, Degree: {report.Degree} C");


        var johnUsers = users.Where(user => user.FirstName.Equals("John"));

        Console.WriteLine("\nFirstName \"John\" ga match bo'lgan userlar:");
        foreach (var user in johnUsers)
            Console.WriteLine($"FirstName: {user.FirstName}, LastName: {user.LastName}");
        

    }
}