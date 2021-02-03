using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using WeChatMiniProgram.Users;
using WeChatMiniProgram.Users.Dtos;

namespace WeChatMiniProgram.MiniPrograms
{
    /// <summary>
    /// 微信用户
    /// </summary>
    [Route("/api/wechat-miniprogram/user")]
    public class UserController : WeChatMiniProgramController, IUserAppService
    {
        private readonly IUserAppService _service;

        public UserController(IUserAppService Service)
        {
            _service = Service;
        }

        [HttpPost]
        public Task<UserDto> CreateAsync(CreateUserDto input)
        {
            return _service.CreateAsync(input);
        }

        [HttpDelete]
        [Route("{id}")]
        public Task DeleteAsync(Guid id)
        {
            return _service.DeleteAsync(id);
        }

        [HttpGet]
        [Route("{id}")]
        public Task<UserDto> GetAsync(Guid id)
        {
            return _service.GetAsync(id);
        }

        [HttpGet]
        public Task<PagedResultDto<UserDto>> GetListAsync(GetListUserInput input)
        {
            return _service.GetListAsync(input);
        }

        [HttpPut]
        [Route("{id}")]
        public Task<UserDto> UpdateAsync(Guid id, UpdateUserDto input)
        {
            return _service.UpdateAsync(id, input);
        }
    }
}
