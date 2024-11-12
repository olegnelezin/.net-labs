using AutoMapper;
using KinoPoisk.KinoPoisk.BL.Users.Model;

namespace KinoPoisk.KinoPoisk.BL.Mapper;

public class UsersBLProfile : Profile
{
    public UsersBLProfile()
    {
        CreateMap<User, UserModel>()
            .ForMember(x => x.Id, opt => opt.MapFrom(src => src.Id))
            .ForMember(x => x.UserName, opt => opt.MapFrom(src => src.UserName))
            .ForMember(x => x.PasswordHash, opt => opt.MapFrom(src => src.PasswordHash))
            .ForMember(x => x.IsActive, opt => opt.MapFrom(src => src.IsActive))
            .ForMember(x => x.CreationTime, opt => opt.MapFrom(src => src.CreationTime))
            .ForMember(x => x.ModificationTime, opt => opt.MapFrom(src => src.ModificationTime));
        // add RoleId

        CreateMap<User, CreateUserModel>()
            .ForMember(x => x.UserName, opt => opt.MapFrom(src => src.UserName))
            .ForMember(x => x.PasswordHash, opt => opt.MapFrom(src => src.PasswordHash))
            .ForMember(x => true, opt => opt.MapFrom(src => src.IsActive));
        // add RoleId
    }
}