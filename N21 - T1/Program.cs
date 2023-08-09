namespace N21___T1;

public class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("                     Kirish!");
        Console.Write("Login: ");
        var login = Console.ReadLine();
        Console.Write("Password: ");
        var parol = Console.ReadLine();
        Console.Clear();
        if(login == "admin" && parol == "admin")
        {
            Developer developer = new Developer();
            developer.Id = new Guid();
            developer.UserName = "admin";
            developer.Password = "admin";
            developer.RoleId = 1;
            developer.Email = "admin@gmail.com";

            while (true)
            {
                Console.WriteLine("\n1-Project yaratish\n2-Task yaratish\n3-User yaratish\n4-Notification yaratish\n");

                string temp = Console.ReadLine().ToString();

                if (temp == "1")
                {



                }
                else if (temp == "2")
                {
                    var n = 0;
                    foreach (var project in developer.AssignedProjects)
                    {
                        Console.WriteLine(($"{++n}-{project}"));
                    }

                }
                else if (temp == "3")
                {

                }
                else if (temp == "4")
                {

                }
                else
                {
                    Console.Clear() ;
                    Console.WriteLine("Bunday buyruq yo'q!");
                }

            }


        }
        else
        {
            Console.WriteLine("Tizimga kirilmadi!\nLogin yoki parol xato.");
        }











    }
}