using System;
using Volo.Abp.Application.Dtos;

namespace WeChatMiniProgram.Users.Dtos
{
    public class UserDto : FullAuditedEntityDto<Guid>
    {
        public Guid UId { get; set; }
        public string NickName { get; set; }
        public GenderType Gender { get; set; }         
    }
}
