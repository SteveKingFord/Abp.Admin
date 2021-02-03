using System;
using System.Collections.Generic;
using System.Text;

namespace WeChatMiniProgram.Users.Dtos
{
    [Serializable]
    public class UpdateUserDto
    {
        public string NickName { get; set; }
        public GenderType Gender { get; set; }
    }
}
