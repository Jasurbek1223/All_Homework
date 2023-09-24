using N43___HT1.Services.Interfaces;

namespace N43___HT1.Services;

public class EmployeeService : IEmployeeService
{
    private readonly IUserService _userService;
    private Mutex _mutex = new(false, "mutex");

    public EmployeeService(IUserService userService)
    {
        _userService = userService;
    }

    public Task CreatePerfomanceRecordAsync(Guid id)
    {
        return Task.Run(() =>
        {
            _mutex.WaitOne();
            var existUser = _userService.Get(id);
            if (existUser != null)
            {
                var fullName = $"{existUser.FirstName}{existUser.LastName}.txt";
                File.Create(fullName).Close();
            }
            _mutex.ReleaseMutex();
        });
    }
}
