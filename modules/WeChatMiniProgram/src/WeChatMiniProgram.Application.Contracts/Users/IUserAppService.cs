using System;
using Volo.Abp.Application.Services;
using WeChatMiniProgram.Users.Dtos;

namespace WeChatMiniProgram.Users
{
   
    public interface IUserAppService : ICrudAppService<UserDto, Guid, GetListUserInput, CreateUserDto, UpdateUserDto>
    {

    }
}
