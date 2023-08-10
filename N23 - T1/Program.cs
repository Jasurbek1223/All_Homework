namespace N23___T1;

internal class Program
{
    static void Main(string[] args)
    {
        Student<Guid, string> student1 = new Student<Guid, string>(Guid.NewGuid(), "Foundation","G'ishmat");


        Course course1 = new Course("Dotnet Bootcamp");

        University<Student<Guid,string>, Guid, string> university = new University<Student<Guid,string>, Guid, string>();

        university.EnroolStudent(student1, course1);

        university.students.ForEach(x => Console.WriteLine(x.Id + " " + x.Name + " " + x.Grade));
        //university.students.ForEach(Console.WriteLine);

    }
}