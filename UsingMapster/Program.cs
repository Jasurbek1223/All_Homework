using UsingMapster;
using Sharprompt;
using UsingMapster.DTOs;
using UsingMapster.Services;

var service = new UserService();

while (true)
{
    var choose = Prompt.Select("Tanlang: ", new[] { "User yaratish", "Get users" });

    if (choose == "User yaratish")
    {
        var user1 = new UserForCreation();

        var firstName = Prompt.Input<string>("Enter firstName: ");
        var lastName = Prompt.Input<string>("LastName: ");
        var email = Prompt.Input<string>("Email: ");
        var password = Prompt.Input<string>("Password: ");
        var userName = Prompt.Input<string>("UserName: ");

        //var user = new UserForCreation()
        //{
        //    FirstName = firstName,
        //    LastName = lastName,
        //    Email = email,
        //    Password = password,
        //    UserName = userName
        //};

        service.CreateUser(user1);
    }
    else if(choose == "Get users")
    {
        var user = service.GetUsers();

        foreach(var existuser in user)
        {
            Console.WriteLine($"{existuser.LastName} {existuser.FirstName}  {existuser.UserName}  {existuser.CreatedAt}");
            Prompt.Input<string>(" ");
        }
    }

    Console.Clear();
}