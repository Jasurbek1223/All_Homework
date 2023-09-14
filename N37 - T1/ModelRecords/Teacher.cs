namespace N37___T1.ModelRecords;

public record Teacher(string FirstName, string LastName, int experience)
    : Person(FirstName, LastName);
