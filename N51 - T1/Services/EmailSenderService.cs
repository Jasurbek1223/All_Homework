using N51___T1.Services.Interfaces;

namespace N51___T1.Services;

public class EmailSenderService : IEmailSenderService
{
    public ValueTask<bool> SendEmailAsync(string email, string subject, string message)
    {
        return new(true);
    }
}