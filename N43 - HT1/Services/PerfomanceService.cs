using N43___HT1.Services.Interfaces;

namespace N43___HT1.Services;

public class PerfomanceService : IPerfomanceService
{
    private readonly IUserService _userService;
    private Mutex _mutex = new(false, "mutex");

    public PerfomanceService(IUserService userService)
    {
        _userService = userService;
    }

    public Task<bool> ReportPerfomanceAsync(Guid id)
    {
        return Task.Run(() =>
        {
            _mutex.WaitOne();
            var foundedUser = _userService.Get(id);

            if (foundedUser != null)
            {
                var fullName = $"{foundedUser.FirstName}{foundedUser.LastName}.txt";
                File.WriteAllText(fullName, "Something");
                return true;
            }

            return false;
            _mutex.ReleaseMutex();
        });
    }
}
