using Volo.Abp.Application;
using Volo.Abp.Modularity;
using Volo.Abp.Authorization;

namespace WeChatOfficialAccount
{
    [DependsOn(
        typeof(WeChatOfficialAccountDomainSharedModule),
        typeof(AbpDddApplicationContractsModule),
        typeof(AbpAuthorizationModule)
        )]
    public class WeChatOfficialAccountApplicationContractsModule : AbpModule
    {

    }
}
