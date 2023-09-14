using N37___T1.ModelRecords;

namespace N37___T1;

public class Program
{
    static void Main(string[] args)
    {
        Person person = new Student("Aziz", "Aliyev", 4);
        Person person1 = person with { FirstName = "Jaurbek" };

        Console.WriteLine(person);
        Console.WriteLine(person1);



        person.Deconstruct(out string firstName, out string lastName);
        (string firstName1, string lastName1) = person;
        (string firstName2, string lastName2) person2 = ("Abdullox", "Muhammedov");
    }
}
