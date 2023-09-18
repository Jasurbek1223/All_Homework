using N39___HT2.Model;
using System.Text.RegularExpressions;

namespace N39___HT2.Service;

public class AccountService
{
    public List<User> users;
    private readonly IEmailSenderService _emailSenderService;

    public AccountService()
    {
        users = new List<User>();
        _emailSenderService = new EmailSenderService();
    }

    public User Register(string emailAddress, string password)
    {
        var emailRegex = new Regex(@"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$"
);
        var passwordRegex = new Regex(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d).{8,}$");

        if (emailRegex.IsMatch(emailAddress) && passwordRegex.IsMatch(password))
        {
            if (users.FirstOrDefault(x => x.EmailAddress.Equals(emailAddress)) != null)
                throw new Exception("This email already exist");

            if (!_emailSenderService.SendEmail(emailAddress))
                throw new InvalidOperationException("Email sender error");

            var user = new User(emailAddress, password);
            users.Add(user);
            return user;
        }
        throw new ArgumentException("Invalid email or password");
    }
}
