using Microsoft.EntityFrameworkCore;
using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;
using WeChatMiniProgram.Users;

namespace WeChatMiniProgram.EntityFrameworkCore
{
    [ConnectionStringName(WeChatMiniProgramDbProperties.ConnectionStringName)]
    public interface IWeChatMiniProgramDbContext : IEfCoreDbContext
    {
        /* Add DbSet for each Aggregate Root here. Example:
         * DbSet<Question> Questions { get; }
         */

        DbSet<User> Users { get; }
    }
}