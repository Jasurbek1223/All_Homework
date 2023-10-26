using N52___HT1.Models;

namespace N52___HT1.Services.Interfaces;

public interface IEmailSenderservice
{
    ValueTask<bool> SendAsync(User user);
}