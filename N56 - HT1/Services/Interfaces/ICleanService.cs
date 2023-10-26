using N56___HT1.Models;

namespace N56___HT1.Services.Interfaces;

public interface ICleanService
{
    ValueTask<List<string>> CleanUpfile(User user);
}
