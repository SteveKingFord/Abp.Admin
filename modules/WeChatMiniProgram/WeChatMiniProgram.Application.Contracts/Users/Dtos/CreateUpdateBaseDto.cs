using System.ComponentModel.DataAnnotations;
using Volo.Abp.Validation;


namespace WeChatMiniProgram.Users.Dtos
{
    public class CreateUpdateBaseDto
    {
        public string NickName { get; set; }
        public GenderType Gender { get; set; }
    }
}
