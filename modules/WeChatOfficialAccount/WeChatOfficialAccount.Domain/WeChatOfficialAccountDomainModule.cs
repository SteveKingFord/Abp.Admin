using Volo.Abp.Domain;
using Volo.Abp.Modularity;

namespace WeChatOfficialAccount
{
    [DependsOn(
        typeof(AbpDddDomainModule),
        typeof(WeChatOfficialAccountDomainSharedModule)
    )]
    public class WeChatOfficialAccountDomainModule : AbpModule
    {

    }
}
