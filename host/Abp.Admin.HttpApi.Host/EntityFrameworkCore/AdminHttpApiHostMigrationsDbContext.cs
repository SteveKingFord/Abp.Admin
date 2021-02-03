using Microsoft.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;
using WeChatMiniProgram.EntityFrameworkCore;


namespace Abp.Admin.EntityFrameworkCore
{
    public class AdminHttpApiHostMigrationsDbContext : AbpDbContext<AdminHttpApiHostMigrationsDbContext>
    {
        public AdminHttpApiHostMigrationsDbContext(DbContextOptions<AdminHttpApiHostMigrationsDbContext> options)
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ConfigureAdmin();
            modelBuilder.ConfigureWeChatMiniProgram();
         
        }
    }
}
