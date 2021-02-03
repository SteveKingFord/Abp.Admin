using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace WeChatMiniProgram.Users.Dtos
{
    [Serializable]
    public class CreateUserDto
    {
        /// <summary>
        /// OpenId
        /// </summary>
        [Required]
        public string OpenId { get; set; }
        public Guid? UId { get; set; }
        public string NickName { get; set; }
        public GenderType Gender { get; set; }
    }
}
