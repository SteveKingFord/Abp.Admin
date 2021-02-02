using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace Abp.Admin.EntityFrameworkCore
{
    [ConnectionStringName(AdminDbProperties.ConnectionStringName)]
    public interface IAdminDbContext : IEfCoreDbContext
    {
        /* Add DbSet for each Aggregate Root here. Example:
         * DbSet<Question> Questions { get; }
         */
    }
}