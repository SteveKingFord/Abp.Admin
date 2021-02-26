using JetBrains.Annotations;
using System;
using Volo.Abp.Domain.Entities.Auditing;


namespace WeChatOfficialAccount.OAuthAccessTokens
{
    /// <summary>
    ///  公众号授权
    /// </summary>
    public class OAuthAccessToken : FullAuditedAggregateRoot<Guid>
    {
        /// <summary>
        /// 公众号AppId
        /// </summary>
        [NotNull]
        public string AppId { get; protected set; }

        /// <summary>
        /// 公众号Secret
        /// </summary>
        [NotNull]
        public string Secret { get; protected set; }

        /// <summary>
        /// 公众号Token
        /// </summary>
        [NotNull]
        public string AccessToken { get; set; }

        /// <summary>
        ///  Token生效时间，秒
        /// </summary>
        public int ExpiresIn { get; set; }


        protected OAuthAccessToken()
        {

        }

        public OAuthAccessToken(Guid id, string accessToken, string appId, string secret) : base(id)
        {
            AccessToken = accessToken;
            AppId = appId;
            Secret = secret;
        }
    }
}
