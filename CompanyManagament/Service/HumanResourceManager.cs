using CompanyManagament.Model;

namespace CompanyManagament.Service;

public class HumanResourceManager : IHumanResourceManager
{
    private readonly Department _department;

    public void AddDepartment(Department department)
    {
        
    }

    public void AddEmployee(Employee employee)
    {
        throw new NotImplementedException();
    }

    public void EditDepartments(Department department)
    {
        throw new NotImplementedException();
    }

    public void EditEmployee(Employee employee)
    {
        throw new NotImplementedException();
    }

    public Department FindDepartment(string name)
    {
        throw new NotImplementedException();
    }

    public List<Department> GetDepartments()
    {
        throw new NotImplementedException();
    }

    public void RemoveEmployee(int id)
    {
        throw new NotImplementedException();
    }
}
