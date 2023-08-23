using N29_HT2.Model;
using System.Net;
using System.Net.Mail;

namespace N29_HT2.Service;

public class EmployeeService
{
    public async Task HireAsync(string firstName, string lastName, string email)
    {
        Employee newEmployee = new Employee
        {
            FirstName = firstName,
            LastName = lastName,
            Email = email
        };

        await SendConfirmationEmailAsync(newEmployee);

        await CreateEmploymentContractFileAsync(newEmployee);

        await SendWelcomeEmailAsync(newEmployee);

        await CreateOfficePoliciesFileAsync(newEmployee);
    }                                                                                                                                   

    private async Task SendConfirmationEmailAsync(Employee employee)
    {
        string smtpServer = "smtp.gmail.com"; // SMTP server (masalan, Gmail uchun)
        int smtpPort = 587; // SMTP port (masalan, Gmail uchun)
        string smtpUsername = "jasurabdulxaev@gmail.com"; // Sizning email manzilingiz
        string smtpPassword = "xaubbroofvsxoxnh"; // Sizning email parolingiz

        using (SmtpClient client = new SmtpClient(smtpServer, smtpPort))
        {
            client.UseDefaultCredentials = false;
            client.Credentials = new NetworkCredential(smtpUsername, smtpPassword);
            client.EnableSsl = true;

            MailMessage message = new MailMessage("noreply@example.com", employee.Email)
            {
                Subject = "Confirm Your Email Address",
                Body = $"Dear {employee.FirstName} {employee.LastName},\n\n" +
                       $"Thank you for joining the team. To start your journey we need to first confirm your email address, please click on the following link to confirm your email address:\n\n" +
                       $"[Link to Confirm Email]\n\n" +
                       $"If you received this email mistakenly, please ignore this email.\n\n" +
                       $"Thank you"
            };
            await client.SendMailAsync(message);
        }
    }

    private async Task CreateEmploymentContractFileAsync(Employee employee)
    {
        string fileName = $"{employee.FirstName}_{employee.LastName}_employment_contract.docx";
        string contractText = $"This is the employment contract for {employee.FirstName} {employee.LastName}.";
        await File.WriteAllTextAsync(fileName, contractText);
    }

    private async Task SendWelcomeEmailAsync(Employee employee)
    {
        string smtpServer = "smtp.gmail.com"; // SMTP server (masalan, Gmail uchun)
        int smtpPort = 587; // SMTP port (masalan, Gmail uchun)
        string smtpUsername = "jasurabdulxaev@gmail.com"; // Sizning email manzilingiz
        string smtpPassword = "xaubbroofvsxoxnh"; // Sizning email parolingiz

        using (SmtpClient client = new SmtpClient(smtpServer, smtpPort))
        {
            client.UseDefaultCredentials = false;
            client.Credentials = new NetworkCredential(smtpUsername, smtpPassword);
            client.EnableSsl = true;

            MailMessage message = new MailMessage("noreply@example.com", employee.Email)
            {
                Subject = "Welcome to [Your Company]",
                Body = $"Dear {employee.FirstName} {employee.LastName},\n\n" +
                       $"We are thrilled to welcome you! We are excited to have you on board and look forward to working with you.\n\n" +
                       $"As a new member of our team, we want to make sure you have everything you need to get started. Please let us know if you have any questions or need any assistance.\n\n" +
                       $"We wish you all the best in your new role and look forward to your contributions to our team.\n\n" +
                       $"Best regards"
            };
            await client.SendMailAsync(message);
        }
    }

    private async Task CreateOfficePoliciesFileAsync(Employee employee)
    {
        string fileName = $"{employee.FirstName}_{employee.LastName}_office_policies.docx";
        string policiesText = $"These are the office policies for {employee.FirstName} {employee.LastName}.";
        await File.WriteAllTextAsync(fileName, policiesText);
    }

}
