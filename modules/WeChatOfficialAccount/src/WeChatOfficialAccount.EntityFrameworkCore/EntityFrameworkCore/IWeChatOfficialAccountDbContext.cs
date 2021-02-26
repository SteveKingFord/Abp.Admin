using Microsoft.EntityFrameworkCore;
using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;
using WeChatOfficialAccount.MpAccessTokens;


namespace WeChatOfficialAccount.EntityFrameworkCore
{
    [ConnectionStringName(WeChatOfficialAccountDbProperties.ConnectionStringName)]
    public interface IWeChatOfficialAccountDbContext : IEfCoreDbContext
    {
        /* Add DbSet for each Aggregate Root here. Example:
         * DbSet<Question> Questions { get; }
         */

        DbSet<MpAccessToken> MpAccessTokens { get; }
    }
}
