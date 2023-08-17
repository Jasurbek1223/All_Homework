using LessonProject;
using System.Text.Json;

namespace N26_T1;

internal class Program
{
    static void Main(string[] args)
    {

        var savePath = @"D:\Text\Countries\AllCountries.txt";

        var jsonFile = File.ReadAllText(savePath);

        var people = JsonSerializer.Deserialize<List<Person>>(jsonFile);
        
        string a = Console.ReadLine();
        byte b = Convert.ToByte(Console.ReadLine());

        var person = new Person()
        {
            Id = people.Last().Id + 1,
            Name = a,
            Age = b

        };

        people.Add(person);

        var resultJson = JsonSerializer.Serialize(people);
        File.WriteAllText(savePath, resultJson);

        foreach(var item in people)
        {
            Console.WriteLine($"Id: {item.Id}\tName: {item.Name}\tAge: {item.Age}");
        }

       





    }
}