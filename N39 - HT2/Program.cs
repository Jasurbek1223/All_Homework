using N39___HT2.Service;
namespace N39___HT2;

public class Program
{
    static void Main(string[] args)
    {
        var accountService = new AccountService();
        try
        {
            Console.Write("Enter Email Address: ");
            var emailAddress = Console.ReadLine();
            Console.Write("Enter Password: ");
            var password = Console.ReadLine();
            accountService.Register(emailAddress, password);
        }
        catch (ArgumentException a)
        {
            Console.WriteLine(a.Message);
        }
        catch (InvalidOperationException i)
        {
            Console.WriteLine(i.Message);
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }
}