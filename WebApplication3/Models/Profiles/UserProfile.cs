namespace WebApplication3.Models.Profiles;
public class UserProfile : Profile
{
    public UserProfile()
    {
        CreateMap<UserDto, User>();
    }
}