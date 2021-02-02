using Volo.Abp.Domain;
using Volo.Abp.Modularity;

namespace Abp.Admin
{
    [DependsOn(
        typeof(AbpDddDomainModule),
        typeof(AdminDomainSharedModule)
    )]
    public class AdminDomainModule : AbpModule
    {

    }
}
