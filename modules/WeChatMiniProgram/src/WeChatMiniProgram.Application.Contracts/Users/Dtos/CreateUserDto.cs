using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace WeChatMiniProgram.Users.Dtos
{
    [Serializable]
    public class CreateUserDto: CreateUpdateBaseDto
    {
        /// <summary>
        /// OpenId
        /// </summary>
        [Required]
        public string OpenId { get; set; }
        public Guid? UserId { get; set; }
     
    }
}
