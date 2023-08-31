using N33_HT1.Classes;

namespace N33_HT1.Objects;

public class UsersManagement
{
    private List<UserModel> UserList = new()
    {
        new UserModel("John", "Doe", false),
        new UserModel("Jonibek", "Doniyorov", false),
        new UserModel("Jane", "Doe", true),
        new UserModel("Tommy", "Hilfiger", false),
        new UserModel("Mark", "Polo", true),
    };

    public ICollection<UserModel> GetByCreatedDate(bool includeAdmin) =>
         UserList.Where(user => includeAdmin || user.IsAdmin == false)
            .OrderByDescending(user => user.CreatedTime).ToList();
    
}
