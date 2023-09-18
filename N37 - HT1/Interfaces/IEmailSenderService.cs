using N37___HT1.Models;

namespace N37___HT1.Interfaces;

public interface IEmailSenderService
{
    Task SendEmailsAsync(IEnumerable<EmailMessage> messages);
}
