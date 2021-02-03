using System.ComponentModel.DataAnnotations;
using Volo.Abp.Validation;


namespace WeChatMiniProgram.Users.Dtos
{
    public class CreateUpdateProprietorBaseDto
    {
        [Required]
        [DynamicStringLength(typeof(UserConsts), nameof(UserConsts.MaxNameLength))]
        public string NickName { get; set; }
    }
}
