using Microsoft.EntityFrameworkCore;
using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;
using WeChatOfficialAccount.MpAccessTokens;


namespace WeChatOfficialAccount.EntityFrameworkCore
{
    [ConnectionStringName(WeChatOfficialAccountDbProperties.ConnectionStringName)]
    public class WeChatOfficialAccountDbContext : AbpDbContext<WeChatOfficialAccountDbContext>, IWeChatOfficialAccountDbContext
    {
        /* Add DbSet for each Aggregate Root here. Example:
         * public DbSet<Question> Questions { get; set; }
         */

        public DbSet<MpAccessToken> MpAccessTokens { get; set; }

        public WeChatOfficialAccountDbContext(DbContextOptions<WeChatOfficialAccountDbContext> options)
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.ConfigureWeChatOfficialAccount();
        }
    }
}
