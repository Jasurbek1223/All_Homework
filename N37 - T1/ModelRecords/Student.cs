namespace N37___T1.ModelRecords;

public record Student(string FirstName, string LastName, int score)
    : Person(FirstName, LastName);
