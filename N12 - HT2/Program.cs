using System.ComponentModel.DataAnnotations;

namespace N12___HT2;

internal class Program
{
    static void Main(string[] args)
    {
        Email email = new Email();

        email.To = "jasurabdulxaev@gmail.com"; // Valid Email
       // email.To = "kas @@@ .gmail.com";       // Invalid Email

        email.From = "johnDoe333@gmail.com"; // Valid Email
       // email.From = "s @@ .gmail.com";       // Invalid Email

        email.Subject = "John Doe G'ishmat Toshmat, Bob"; // Valid Text
        //email.Subject = "Toshmat"; // Invalid Text - 3 ta sozdan kopligi hisobga olingan

        email.Subject = "Hello World, lets C# Coding"; // Valid Text
        email.Subject = "   "; // Invalid Text - 3 ta sozdan kopligi hisobga olingan







    }
}