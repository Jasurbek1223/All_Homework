using Bogus;
using N39___T1.Models;

namespace N39___T1;

public class Program
{
    static void Main(string[] args)
    {
        int idSeed = 1;

        var faker = new Faker<Address>()
            .StrictMode(true)
            .RuleFor(a => a.Id, f => idSeed++)
            .RuleFor(a => a.Country, f => f.Address.Country())
            .RuleFor(a => a.City, f => f.Address.City())
            .RuleFor(a => a.Region, f => f.Address.State())
            .RuleFor(a => a.Street, f => f.Address.StreetName())
            .RuleFor(a => a.HomeNumber, f => f.Address.BuildingNumber());

        int numberOfAddresses = 10; 
        var fakeAddresses = faker.Generate(numberOfAddresses);

        
        foreach (var address in fakeAddresses)
        {
            Console.WriteLine($"ID: {address.Id}");
            Console.WriteLine($"Country: {address.Country}");
            Console.WriteLine($"City: {address.City}");
            Console.WriteLine($"Region: {address.Region}");
            Console.WriteLine($"Street: {address.Street}");
            Console.WriteLine($"Home Number: {address.HomeNumber}");
            Console.WriteLine();
        }
    }
}
