using N37___HT1.Enum;
using N37___HT1.Interfaces;
using N37___HT1.Models;

namespace N37___HT1.Services;

public class EmailTemplateService : IEmailTemplateService
{
    public IEnumerable<EmailTemplate> GetTemplates(IEnumerable<User> users)
    {
        foreach (var user in users)
        {
            string fullName = $"{user.FirstName} {user.LastName}";

            if (user.Status == StatusEnum.Registered)
            {
                yield return new EmailTemplate(
                    MessageConstants.RegisteredBody.Replace("{{FullName}}", fullName),
                    MessageConstants.RegisteredSubject);
            }
            else if (user.Status == StatusEnum.Deleted)
            {
                yield return new EmailTemplate(
                    MessageConstants.DeletedBody.Replace("{{FullName}}", fullName),
                    MessageConstants.DeletedSubject);
            }
        }
    }
}
