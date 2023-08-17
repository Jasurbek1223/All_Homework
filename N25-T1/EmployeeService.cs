namespace N25_T1;

class EmployeeService
{
    private List<Employee> employees;

    public EmployeeService(List<Employee> employees)
    {
        this.employees = employees;
    }

    public List<Employee> GetBySalary(int pageSize, int pageToken)
    {
        var sortedEmployees = employees.OrderBy(e => e.Salary).ToList();
        int startIndex = (pageToken - 1) * pageSize;
        int endIndex = Math.Min(startIndex + pageSize, sortedEmployees.Count);
        return sortedEmployees.GetRange(startIndex, endIndex - startIndex);
    }

}