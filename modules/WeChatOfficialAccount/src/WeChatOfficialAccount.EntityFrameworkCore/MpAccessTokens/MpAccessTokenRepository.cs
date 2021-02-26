using System;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;
using WeChatOfficialAccount.EntityFrameworkCore;

namespace WeChatOfficialAccount.MpAccessTokens
{
    /// <summary>
    ///  授权Token仓库实现
    /// </summary>
    public class MpAccessTokenRepository : EfCoreRepository<IWeChatOfficialAccountDbContext, MpAccessToken, Guid>, IMpAccessTokenRepository
    {
        public MpAccessTokenRepository(IDbContextProvider<IWeChatOfficialAccountDbContext> dbContextProvider) : base(dbContextProvider)
        {

        }
    }
}
