using N43___HT1.Services.Interfaces;

namespace N43___HT1.Services;

public class AccountService : IAccountService
{
    private readonly IEmployeeService _employeeService;
    private readonly IPerfomanceService _perfomanceService;

    public AccountService(IEmployeeService employeeService, IPerfomanceService perfomanceService)
    {
        _employeeService = employeeService;
        _perfomanceService = perfomanceService;
    }

    public Task CreateReportAsync(Guid id)
    {
        var res = _employeeService.CreatePerfomanceRecordAsync(id).ContinueWith(x => _perfomanceService.ReportPerfomanceAsync(id));
        return res;
    }
}
