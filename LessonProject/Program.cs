using System.Text.Json;
//using Newtonsoft.Json;

namespace LessonProject;

internal class Program
{
    static void Main(string[] args)
    {
        var result = new List<Person>
        {
            new Person {Id = 1, Name = "Begzod", Age = 18},
            new Person {Id = 2, Name = "Bunyod", Age=19},
            new Person {Id = 3, Name = "Vali", Age=20}

        };

        string path = @"D:\.NET_new\HomeTasks\Fayl\Dars.txt";

        //// Jsonga ogiradi
        //string jsonPerson = JsonSerializer.Serialize(result);


        //// Faylga yozadi(1-usul)
        //using (StreamWriter wr = new StreamWriter(path, true))
        //{
        //    wr.WriteLine(jsonPerson);
        //    wr.Close();
        //}


        ////Faylga yozadi (2-usul)
        //StreamWriter writer = new StreamWriter(path, false);
        //writer.WriteLine(jsonPerson);

        //Ekranga chiqarish
        //foreach (Person person in result)
        //{
        //    Console.WriteLine($"Id: {person.Id}, Name: {person.Name}, Age: {person.Age}");
        //}



        // O'qish uchun
        using (StreamReader reader = new StreamReader(path))
        {
            var people = JsonSerializer.Deserialize<List<Person>>(reader.ReadToEnd());
            foreach (var item in people)
            {
                Console.WriteLine(item.Name + " " + item.Age);
            }
        }





    }
}