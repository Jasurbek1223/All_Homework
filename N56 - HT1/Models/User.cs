namespace N56___HT1.Models;

public class User
{
    // User modelini yaratamiz + constructor bilan
    public Guid Id { get; set; }
    public string Name { get; set; }

    public User(Guid id, string name)
    {
        Id = id;
        Name = name;
    }
}