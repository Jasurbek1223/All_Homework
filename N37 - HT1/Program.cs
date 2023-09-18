using N37___HT1.Enum;
using N37___HT1.Models;
using N37___HT1.Services;

namespace N37___HT1;

internal class Program
{
    static async Task Main(string[] args)
    {
        var userService = new UserService();
        var emailService = new EmailService();
        var emailTemplateService = new EmailTemplateService();
        var emailSenderService = new EmailSenderService();

        var notification = new NotificationManagementService(userService, emailService, emailTemplateService, emailSenderService);

        userService.users.Add(new User("Jasur", "Abdulhayev", "jasurabdulxaev@gmail.com", StatusEnum.Deleted));
        userService.users.Add(new User("John", "Doe", "JohnDoe1808@gmail.com", StatusEnum.Registered));

        await notification.NotifyUsers();
    }
}
