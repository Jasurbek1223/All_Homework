namespace N27_HT1;

class UserService
{
    private List<User> Users {  get; set; }

    public UserService()
    {
        Users = new List<User>();

        EnsureAdminExists();

        Users.Add(new User { Id = Guid.NewGuid(), EmailAddress = "user1@gmail.com", Password = "password1", IsAdmin = false });
        Users.Add(new User { Id = Guid.NewGuid(), EmailAddress = "user2@gmail.com", Password = "password2", IsAdmin = false });
        Users.Add(new User { Id = Guid.NewGuid(), EmailAddress = "user3@gmail.com", Password = "password3", IsAdmin = true });
    }

    private void EnsureAdminExists()
    {
        if(!Users.Any(u => u.IsAdmin))
        {
            Users.Add(new User { Id = Guid.NewGuid(), EmailAddress = "admin1@gmai;.com", Password = "pasAdmin1", IsAdmin = true });
        }
    }

    public void Add(string emailAddress, string password)
    {
        int newUserId = Users.Count() + 1;
        Users.Add(new User { Id = Guid.NewGuid(), EmailAddress = emailAddress, Password = password, IsAdmin = false });
    }

    public List<User> GetUsers()
    {
        return Users;
    }



}
