using N37___HT1.Models;
using N37___HT1.Interfaces;

namespace N37___HT1.Services;

public class NotificationManagementService : INotificationManagementService
{
    private IUserservice _userService;
    private IEmailService _emailService;
    private IEmailTemplateService _emailTemplateService;
    private IEmailSenderService _emailSenderService;

    public NotificationManagementService(UserService userService, EmailService emailService,
        EmailTemplateService emailTemplateService, EmailSenderService emailSenderService)
    {
        _userService = userService;
        _emailService = emailService;
        _emailTemplateService = emailTemplateService;
        _emailSenderService = emailSenderService;
    }

    public async Task NotifyUsers()
    {
        var users = _userService.GetUsers();
        var templates = _emailTemplateService.GetTemplates(users);
        var messages = _emailService.GetMessages(templates, users);
        await _emailSenderService.SendEmailsAsync(messages);
    }
}