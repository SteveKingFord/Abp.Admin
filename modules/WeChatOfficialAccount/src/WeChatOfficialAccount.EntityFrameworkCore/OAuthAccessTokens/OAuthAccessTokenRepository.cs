using System;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;
using WeChatOfficialAccount.EntityFrameworkCore;
using WeChatOfficialAccount.MpAccessTokens;

namespace WeChatOfficialAccount.OAuthAccessTokens
{
    /// <summary>
    ///  授权Token仓库实现
    /// </summary>
    public class OAuthAccessTokenRepository : EfCoreRepository<IWeChatOfficialAccountDbContext, OAuthAccessToken, Guid>, IOAuthAccessTokenRepository
    {
        public OAuthAccessTokenRepository(IDbContextProvider<IWeChatOfficialAccountDbContext> dbContextProvider) : base(dbContextProvider)
        {

        }
    }
}
