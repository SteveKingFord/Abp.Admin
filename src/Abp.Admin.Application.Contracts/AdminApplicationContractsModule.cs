using Volo.Abp.Application;
using Volo.Abp.Modularity;
using Volo.Abp.Authorization;

namespace Abp.Admin
{
    [DependsOn(
        typeof(AdminDomainSharedModule),
        typeof(AbpDddApplicationContractsModule),
        typeof(AbpAuthorizationModule)
        )]
    public class AdminApplicationContractsModule : AbpModule
    {

    }
}
