namespace CompanyManagament.Model;

public class Employee
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string FullName { get; set; }
    public Position Position { get; set; }
    public decimal Salary { get; set; }
    public int DepartmentId { get; set; }
    //public static int _count = 1000;
    public string No { get; set; }

    public Employee()
    {


    }

    

}
