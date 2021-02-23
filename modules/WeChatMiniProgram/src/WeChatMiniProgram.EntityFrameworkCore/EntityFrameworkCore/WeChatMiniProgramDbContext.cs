using Microsoft.EntityFrameworkCore;
using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;
using WeChatMiniProgram.Users;

namespace WeChatMiniProgram.EntityFrameworkCore
{
    [ConnectionStringName(WeChatMiniProgramDbProperties.ConnectionStringName)]
    public class WeChatMiniProgramDbContext : AbpDbContext<WeChatMiniProgramDbContext>, IWeChatMiniProgramDbContext
    {
        /* Add DbSet for each Aggregate Root here. Example:
         * public DbSet<Question> Questions { get; set; }
         */

        public DbSet<User> Users { get; set; }


        public WeChatMiniProgramDbContext(DbContextOptions<WeChatMiniProgramDbContext> options)
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.ConfigureWeChatMiniProgram();
        }
    }
}