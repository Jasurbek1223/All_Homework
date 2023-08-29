using N32___T1.Model;
using System.Text.Json;

namespace N32___T1;

public class Program
{
    static void Main(string[] args)
    {
        string jsonFilePathStudent = @"D:\.NET_new\fayll\Student.json";
        string jsonFilePathLocation = @"D:\.NET_new\fayll\Location.json";
        string jsonFilePathSpeciality = @"D:\.NET_new\fayll\Speciality.json";

        var jsonStudents = File.ReadAllText(jsonFilePathStudent);
        var jsonLocation = File.ReadAllText(jsonFilePathLocation);
        var jsonSpeciality = File.ReadAllText(jsonFilePathSpeciality);

        var students = JsonSerializer.Deserialize<List<Student>>(jsonStudents);
        var location = JsonSerializer.Deserialize<List<Location>>(jsonLocation);
        var speciality = JsonSerializer.Deserialize<List<Speciality>>(jsonSpeciality);


        //1- Speciality bo'yicha talabalar sonini sanash
        //var groupedStudents = speciality.GroupJoin(
        //    students,
        //    speciality => speciality.id,
        //    student => student.speciality_id,
        //    (speciality, students) => new
        //    {
        //        Speciality = speciality,
        //        Students = students
        //    });

        //foreach (var item in groupedStudents)
        //{
        //    Console.WriteLine($"{item.Speciality.speciality_name} - {item.Students.Count()}");
        //}

        //2- Student location boyicha guruhlash va har bir location boyicha ortacha yosh chiqarish
        var groupedStudents = students.Join(
            location,
            student => student.location_id, location => location.id, (student, location) => new
            {
                student.birth_day,
                location.lacation_name
            })
            .ToList();

        var studentsByLocation = groupedStudents
            .GroupBy(e => e.lacation_name)
            .ToDictionary
            (
            group => group.Key,
            group => group
            .Select(entry => CalculateAge(entry.birth_day))
            .ToList()
            );

        foreach ( var student in studentsByLocation )
        {
            double averageAge = student.Value.Any() ? student.Value.Average() : 0;
            Console.WriteLine($"Location: {student.Key}, Average: {Math.Round(averageAge, 2)}");
        }


        static double CalculateAge(string birthDay)
        {
            DateTime today = DateTime.Today;
            DateTime birthDate = DateTime.ParseExact(birthDay, "d/M/yyyy", null);
            int age = today.Year - birthDate.Year;
            if (today < birthDate.AddYears(age)) age--;
            return age;
        }







    }
}