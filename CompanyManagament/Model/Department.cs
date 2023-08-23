namespace CompanyManagament.Model;

public class Department
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int WorkerLimit { get; set; }
    public decimal SalaryLimit { get; set; }
    public List<Department> Departments { get; set; }


    public decimal SalaryCalcAvr()
    {

    }



}
