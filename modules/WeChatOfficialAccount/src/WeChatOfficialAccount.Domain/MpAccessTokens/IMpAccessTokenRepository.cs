using System;
using Volo.Abp.Domain.Repositories;

namespace WeChatOfficialAccount.MpAccessTokens
{
    /// <summary>
    ///  授权仓库接口
    /// </summary>
    public interface IMpAccessTokenRepository : IRepository<MpAccessToken, Guid>
    {
    }
}
