namespace N27_HT1;

class User
{
    public Guid Id { get; set; }
    public string EmailAddress { get; set; }
    public string Password { get; set; }
    public bool IsAdmin { get; set; }
}