namespace N51___T1.Services.Interfaces;

public interface IEmailSenderService
{
    ValueTask<bool> SendEmailAsync(string email, string subject, string message);
}
