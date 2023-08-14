namespace N24___T2;

internal class Program
{
    static void Main(string[] args)
    {
        RegistrationService registrationService = new RegistrationService();

        registrationService.Register("jasurabdulxaev@gmail.com", "jasur1223");
        registrationService.Register("aliyevVali@gmail.com", "gishmat007");
        registrationService.Register("qwerty2@gmail.com", "12345a");
        registrationService.Login("sdfsfff@gmail.com", "12345", true, true);

        //Console.Write("Emailni kiriting: ");
        //var email1 = Console.ReadLine();
        //Console.Write("Password kiriting: ");
        //var password1 = Console.ReadLine();
        //Console.WriteLine();

        //registrationService.Register(email1, password1);

        registrationService.Display();
    }
}