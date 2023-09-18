namespace N39___HT2.Model;

public class User
{
    public string EmailAddress { get; set; }
    public string Password { get; set; }

    public User(string emailAddress, string password)
    {
        EmailAddress = emailAddress;
        Password = password;
    }
}
