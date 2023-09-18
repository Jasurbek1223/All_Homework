using N37___HT1.Interfaces;
using N37___HT1.Models;

namespace N37___HT1.Services;

public class EmailService : IEmailService
{
    public IEnumerable<EmailMessage> GetMessages(IEnumerable<EmailTemplate> templates, IEnumerable<User> users)
    {
        foreach (var item in users.Zip(templates))
        {
            yield return new EmailMessage(item.Second.Subject, item.Second.Body,
                MessageConstants.SenderEmailAddress, item.First.EmailAddress);
        }
    }
}
