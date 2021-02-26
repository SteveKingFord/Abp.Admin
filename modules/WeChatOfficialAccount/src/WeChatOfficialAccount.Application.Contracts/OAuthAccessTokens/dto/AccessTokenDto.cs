using System;
using Volo.Abp.Application.Dtos;

namespace WeChatOfficialAccount.OAuthAccessTokens.dto
{
    public class AccessTokenDto : FullAuditedEntityDto<Guid>
    {
        public string AccessToken { get; set; }
        public string ExpiresIn { get; set; }
        public string AppId { get; set; }
        public string Secret { get; set; }
    }
}
