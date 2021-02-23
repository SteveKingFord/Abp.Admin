using Volo.Abp.Application;
using Volo.Abp.Modularity;
using Volo.Abp.Authorization;

namespace WeChatMiniProgram
{
    [DependsOn(
        typeof(WeChatMiniProgramDomainSharedModule),
        typeof(AbpDddApplicationContractsModule),
        typeof(AbpAuthorizationModule)
        )]
    public class WeChatMiniProgramApplicationContractsModule : AbpModule
    {

    }
}
