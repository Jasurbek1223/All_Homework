using N51___T1.Models;

namespace N51___T1.Services.Interfaces;

public interface IAccountService
{
    ValueTask<bool> RegisterAsync(RegisterDetails registerDetails);
}