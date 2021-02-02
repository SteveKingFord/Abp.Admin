using Microsoft.EntityFrameworkCore;
using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace Abp.Admin.EntityFrameworkCore
{
    [ConnectionStringName(AdminDbProperties.ConnectionStringName)]
    public class AdminDbContext : AbpDbContext<AdminDbContext>, IAdminDbContext
    {
        /* Add DbSet for each Aggregate Root here. Example:
         * public DbSet<Question> Questions { get; set; }
         */

        public AdminDbContext(DbContextOptions<AdminDbContext> options) 
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.ConfigureAdmin();
        }
    }
}