using AutoMapper;
using WeChatMiniProgram.Users;
using WeChatMiniProgram.Users.Dtos;

namespace WeChatMiniProgram
{
    public class WeChatMiniProgramApplicationAutoMapperProfile : Profile
    {
        public WeChatMiniProgramApplicationAutoMapperProfile()
        {
            /* You can configure your AutoMapper mapping configuration here.
             * Alternatively, you can split your mapping configurations
             * into multiple profile classes for a better organization. */
            CreateMap<User, UserDto>();
            CreateMap<UserDto, User>(MemberList.Source);
            CreateMap<CreateUserDto, User>(MemberList.Source);
            CreateMap<UpdateUserDto, User>(MemberList.Source);
        }
    }
}