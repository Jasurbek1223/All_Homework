using AutoMapper;
using DemoWebUser.Models;
using DemoWebUser.Models.DTOs.Incoming;

namespace DemoWebUser.Profiles;

public class UserProfile : Profile
{
    public UserProfile() {
        CreateMap<UserForCreationDto, User>()
            .ForMember(dest => dest.Id,
            opt => opt.MapFrom(src => Guid.NewGuid()))
            .ForMember(dest => dest.FirstName,
            opt => opt.MapFrom(src => src.FirstName))
            .ForMember(dest => dest.LastName,
            opt => opt.MapFrom(src => src.LastName))
            .ForMember(dest => dest.Email,
            opt => opt.MapFrom(src => src.Email))
            .ForMember(dest => dest.Password,
            opt => opt.MapFrom(src => src.Password))
            .ForMember(dest => dest.UserName,
            opt => opt.MapFrom(src => src.UserName))
            .ForMember(dest => dest.DateOfBirth,
            opt => opt.MapFrom(src => new DateTime(23, 12, 2002)));

        }
}
