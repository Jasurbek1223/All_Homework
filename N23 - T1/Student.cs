namespace N23___T1;

public class Student<Tid, TGrade>
{
    public Tid Id { get; set; }
    public TGrade Grade { get; set;}
    public string Name { get; set; }

    public Student(Tid id, TGrade grade, string name)
    {
        Id = id;
        Grade = grade;
        Name = name;
    }





}
