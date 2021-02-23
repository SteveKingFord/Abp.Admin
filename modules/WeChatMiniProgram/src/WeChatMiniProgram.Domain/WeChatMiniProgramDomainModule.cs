using Volo.Abp.Domain;
using Volo.Abp.Modularity;

namespace WeChatMiniProgram
{
    [DependsOn(
        typeof(AbpDddDomainModule),
        typeof(WeChatMiniProgramDomainSharedModule)
    )]
    public class WeChatMiniProgramDomainModule : AbpModule
    {

    }
}
