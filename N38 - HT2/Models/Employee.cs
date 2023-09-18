using System.Xml.Linq;

namespace N38___HT2.Models;

public class Employee
{
    public int EmployeeId { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }

    public override string ToString()
    {
        return $"Id: {EmployeeId}, FirstName: {FirstName}, LastName : {LastName}, Email: {Email}";
    }
}