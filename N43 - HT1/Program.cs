using N43___HT1.Models;
using N43___HT1.Services;

namespace N43___HT1
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var user = new User("Cristiano", "Ronaldo", true);

            var userService = new UserService();
            userService.Create(user);
            var employeeService = new EmployeeService(userService);
            var performanceService = new PerfomanceService(userService);
            var accountService = new AccountService(employeeService, performanceService);
            await accountService.CreateReportAsync(user.Id);
        }
    }
}
