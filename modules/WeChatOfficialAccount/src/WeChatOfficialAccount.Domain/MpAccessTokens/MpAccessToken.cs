using JetBrains.Annotations;
using System;
using Volo.Abp.Domain.Entities.Auditing;


namespace WeChatOfficialAccount.MpAccessTokens
{
    /// <summary>
    ///  授权实体
    /// </summary>
    public class MpAccessToken : FullAuditedAggregateRoot<Guid>
    {
        /// <summary>
        /// 公众号授权Token
        /// </summary>
        [NotNull]
        public string AccessToken { get; protected set; }

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

        protected MpAccessToken()
        {

        }

        public MpAccessToken(Guid id, string accessToken, string appId, string secret) : base(id)
        {
            AccessToken = accessToken;
            AppId = appId;
            Secret = secret;
        }
    }
}
