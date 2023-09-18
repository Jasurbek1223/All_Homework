using N10Tester.Domain.Entities;
using N10Tester.Service.Interface;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N10Tester.Service.Services;

public class StudentService : IStudentService
{
    string path = "file.path";

    public StudentService()
    {
        string result = File.ReadAllText(path);
        if (string.IsNullOrEmpty(result))
        {
            File.WriteAllText(path, "[]");
        }
    }

    public object Newtonsoft { get; private set; }

    public Student Create(Student student)
    {
        string source = File.ReadAllText(path);
        List<Student> students = JsonConvert.DeserializeObject<List<Student>>(source);

        Student existStudent = students.FirstOrDefault(m => m.Id.Equals(student.Id));

        if (existStudent != null)
        {
            throw new Exception("Student already exists");
        };

        int lastId = students.LastOrDefault().Id;

        student.Id = lastId + 1;

        students.Add(student);

        string json = JsonConvert.SerializeObject(students, Newtonsoft.Json.Formatting.Indented);

        File.WriteAllText(path, json);
    }

    public bool Delete(long id)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<Student> GetAll()
    {
        throw new NotImplementedException();
    }

    public Student GetById(long id)
    {
        throw new NotImplementedException();
    }

    public Student Update(Student student)
    {
        throw new NotImplementedException();
    }
}
