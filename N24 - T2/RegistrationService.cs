using System.Runtime.InteropServices;

namespace N24___T2;

internal class RegistrationService
{
    List<User> users = new List<User>();


    public bool Register(string emailAddress, string password)
    {
        if(users.Any(x=>x.EmailAddress == emailAddress))
        {
            Console.WriteLine("Bu email bor");
            return false;
        }

        users.Add(new User(emailAddress, password));
        return true;

    }

    public void Login(string emailAddress, string password, bool isEmailVerified, bool isPhoneVerified)
    {
        var user1 = users.FirstOrDefault(x => x.EmailAddress == emailAddress && x.Password == password);
        if(user1 != null && user1.IsEmailVerified)
        {
            Console.WriteLine("User verified");
        }
        else
        {
            Console.WriteLine("Not verified");
        }
      
    }




    public void Display()
    {
        foreach(var user in users)
        {
            Console.WriteLine($"Email: {user.EmailAddress}, Password: {user.Password}," +
                $" EmailVerified: {user.IsEmailVerified}, PhoneVerified: {user.IsPhoneVerified}");
        }
    }



}
