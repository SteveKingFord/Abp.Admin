using Abp.Admin.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace Abp.Admin
{
    /* Domain tests are configured to use the EF Core provider.
     * You can switch to MongoDB, however your domain tests should be
     * database independent anyway.
     */
    [DependsOn(
        typeof(AdminEntityFrameworkCoreTestModule)
        )]
    public class AdminDomainTestModule : AbpModule
    {
        
    }
}
