using CompanyManagament.Model;

namespace CompanyManagament.Service;

public interface IHumanResourceManager
{
    void AddDepartment(Department department);
    List<Department> GetDepartments();
    void EditDepartments(Department department);
    void AddEmployee(Employee employee);
    void RemoveEmployee(int id);
    void EditEmployee(Employee employee);
    Department FindDepartment(string name);

}
