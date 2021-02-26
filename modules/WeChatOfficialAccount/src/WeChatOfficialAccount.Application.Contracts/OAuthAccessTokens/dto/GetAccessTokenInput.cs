using System.ComponentModel.DataAnnotations;

namespace WeChatOfficialAccount.OAuthAccessTokens.dto
{
    public class GetAccessTokenInput
    {
        /// <summary>
        ///  公众号 AppId
        /// </summary>
        [Required]
        public string AppId { get; set; }

        /// <summary>
        /// 公众号 Secret
        /// </summary>
        [Required]
        public string Secret { get; set; }
    }
}
