namespace N23___T1;

internal class University<TStudent, TId, TGrade> where TStudent : Student<TId, TGrade>
{

    public List<TStudent> students = new List<TStudent>();
    public List<Course> courses = new List<Course>();

    public void EnroolStudent(TStudent student, Course course)
    {
        students.Add(student);
        courses.Add(course);

    }

}
