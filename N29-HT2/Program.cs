using N29_HT2.Model;
using N29_HT2.Service;


Employee employee1 = new Employee("Jasurbek", "Abulkhaev", "jasurabdulxaev@gmail.com");
Employee employee2 = new Employee("Azam", "Amonov", "azamamonov555@gmail.com");
var service = new EmployeeService();
await service.HireAsync(employee1);
await service.HireAsync(employee2);