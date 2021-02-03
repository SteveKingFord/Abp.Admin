using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace WeChatMiniProgram.EntityFrameworkCore
{
    [ConnectionStringName(WeChatMiniProgramDbProperties.ConnectionStringName)]
    public interface IWeChatMiniProgramDbContext : IEfCoreDbContext
    {
        /* Add DbSet for each Aggregate Root here. Example:
         * DbSet<Question> Questions { get; }
         */
    }
}