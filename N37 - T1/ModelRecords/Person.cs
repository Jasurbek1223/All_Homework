namespace N37___T1.ModelRecords;

public abstract record Person(string FirstName, string LastName);

public abstract record Human
{
    public Human(string firstName, string lastName)
    {
        FirstName = firstName;
        LastName = lastName;
    }

    public string FirstName { get; set; }
    public string LastName { get; set; }

}