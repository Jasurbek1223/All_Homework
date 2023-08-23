
using N29_HT2.Service;

class Program
{
    static async Task Main(string[] args)
    {
        EmployeeService employeeService = new EmployeeService();
        await employeeService.HireAsync("Jasur", "Abdulhayev", "jasurabdulxaev@example.com");

        Console.WriteLine("Hiring process completed.");
    }
}
