using System;
using Volo.Abp.Domain.Repositories;
using WeChatOfficialAccount.OAuthAccessTokens;

namespace WeChatOfficialAccount.MpAccessTokens
{
    /// <summary>
    ///  授权仓库接口
    /// </summary>
    public interface IOAuthAccessTokenRepository : IRepository<OAuthAccessToken, Guid>
    {
    }
}
