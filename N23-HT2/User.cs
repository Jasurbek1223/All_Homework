namespace N23_HT2;

internal class User
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string EmailAddress { get; set; }

    public User(string firstName, string lastName, string email)
    {
        FirstName = firstName;
        LastName = lastName;
        EmailAddress = email;
    }
}
