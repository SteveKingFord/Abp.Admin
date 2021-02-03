using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.AutoMapper;
using Volo.Abp.Modularity;
using Volo.Abp.Application;

namespace WeChatOfficialAccount
{
    [DependsOn(
        typeof(WeChatOfficialAccountDomainModule),
        typeof(WeChatOfficialAccountApplicationContractsModule),
        typeof(AbpDddApplicationModule),
        typeof(AbpAutoMapperModule)
        )]
    public class WeChatOfficialAccountApplicationModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddAutoMapperObjectMapper<WeChatOfficialAccountApplicationModule>();
            Configure<AbpAutoMapperOptions>(options =>
            {
                options.AddMaps<WeChatOfficialAccountApplicationModule>(validate: true);
            });
        }
    }
}
