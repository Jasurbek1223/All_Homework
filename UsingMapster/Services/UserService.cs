using Mapster;
using UsingMapster.DTOs;
using UsingMapster.Entities;
using UsingMapster.Services.Interfaces;

namespace UsingMapster.Services;

public class UserService : IUserService
{
    private IList<User> _users = new List<User>();

    public User CreateUser(UserForCreation user)
    {
        var existUser = _users.FirstOrDefault(u => u.Email.Equals(user.Email));
        if(existUser != null)
        {
            Console.WriteLine("User already exist!");
            return existUser;
        }

        var newUser = user.Adapt<User>();

        newUser.CreatedAt = DateTime.UtcNow;
        newUser.UpdatedAt = DateTime.UtcNow;

        _users.Add(newUser);

        return newUser;
    }

    public List<UserViewModel> GetUsers()
    {
        return _users.Adapt<List<UserViewModel>>();
    }

    //public UserForCreation GetUserByEmail(string email)
    //{
    //    return users.FirstOrDefault(u => u.Email == email);
    //}

    //public void UpdateUser(string email, UserForCreation updatedUser)
    //{
    //    var existingUser = GetUserByEmail(email);
    //    if (existingUser != null)
    //    {
    //        // Ma'lumotlarni yangilash
    //        existingUser.FirstName = updatedUser.FirstName;
    //        existingUser.LastName = updatedUser.LastName;
    //        existingUser.Password = updatedUser.Password;
    //        existingUser.UserName = updatedUser.UserName;
    //        // Boshqa kerakli yangilashlar, masalan, ma'lumotni saqlash.
    //    }
    //}

    //public void DeleteUser(string email)
    //{
    //    var userToDelete = GetUserByEmail(email);
    //    if (userToDelete != null)
    //    {
    //        _users.Remove(userToDelete);
    //        // Boshqa kerakli o'chirish amallar, masalan, ma'lumotni saqlash.
    //    }
    //}
}
