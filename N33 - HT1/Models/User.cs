namespace N33_HT1.Classes;

public class UserModel
{
    public Guid Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }

    public bool IsAdmin { get; set; }

    public DateTime CreatedTime { get; set; }

    public UserModel(string firstName, string lastName, bool isAdmin)
    {
        Id = Guid.NewGuid();
        FirstName = firstName;
        LastName = lastName;
        IsAdmin = isAdmin;
        CreatedTime = DateTime.Now;
    }

    public override string ToString()
    {
        return $"Id: {Id}, Firstname: {FirstName}, Lastname: {LastName}, Admin: {IsAdmin}, Created: {CreatedTime}";
    }
}
