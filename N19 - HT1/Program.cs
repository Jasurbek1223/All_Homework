namespace N19___HT1;

internal class Program
{
    static void Main(string[] args)
    {

        Validator.IsValidName(" jasurbek", out var formattedName);
        Console.WriteLine("Ism: " + formattedName);

        Validator.IsValidEmailAddress(" jasurabdulxaev@gmail.com  ", out var formattedEmailAddress);
        Console.WriteLine("Email: " + formattedEmailAddress);

        Console.WriteLine("Age: " + Validator.IsValidAge(15));

        Validator.IsValidPhoneNumber(" 998909179998   ", out var phonenumber);
        Console.WriteLine("PhoneNumber: " + phonenumber);

    }
}