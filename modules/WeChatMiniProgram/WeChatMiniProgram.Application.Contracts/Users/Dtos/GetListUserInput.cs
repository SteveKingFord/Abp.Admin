using Volo.Abp.Application.Dtos;
using System.ComponentModel.DataAnnotations;

namespace WeChatMiniProgram.Users.Dtos
{
    public class GetListUserInput : PagedAndSortedResultRequestDto
    {
        [MaxLength(128)]
        public string Filter { get; set; }
    }
}
