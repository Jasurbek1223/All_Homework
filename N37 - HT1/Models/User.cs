using N37___HT1.Enum;

namespace N37___HT1.Models;

public class User
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string EmailAddress { get; set; }
    public StatusEnum Status { get; set; }

    public User(string firstName, string lastName, string emailAddress, StatusEnum status)
    {
        FirstName = firstName;
        LastName = lastName;
        EmailAddress = emailAddress;
        Status = status;
    }
}
