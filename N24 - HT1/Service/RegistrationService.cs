using N24___HT1.Interface;

namespace N24___HT1.Service;

class RegistrationService
{
    private IUserService userService;
    private IUserCredentialsService userCredentialsService;

    public RegistrationService(IUserService userService, IUserCredentialsService userCredentialsService)
    {
        this.userService = userService;
        this.userCredentialsService = userCredentialsService;
    }

    public bool Register(string firstName, string lastName, string emailAddress, string password)
    {
        try
        {
            var newUser = userService.Add(firstName, lastName, emailAddress);
            userCredentialsService.Add(newUser.Id, password);
            return true;
        }
        catch(Exception ex)
        {
            Console.WriteLine($"Regestration Failed: {ex.Message}");
            return false;   
        }
    }

}
