using Localization.Resources.AbpUi;
using WeChatOfficialAccount.Localization;
using Volo.Abp.AspNetCore.Mvc;
using Volo.Abp.Localization;
using Volo.Abp.Modularity;
using Microsoft.Extensions.DependencyInjection;

namespace WeChatOfficialAccount
{
    [DependsOn(
        typeof(WeChatOfficialAccountApplicationContractsModule),
        typeof(AbpAspNetCoreMvcModule))]
    public class WeChatOfficialAccountHttpApiModule : AbpModule
    {
        public override void PreConfigureServices(ServiceConfigurationContext context)
        {
            PreConfigure<IMvcBuilder>(mvcBuilder =>
            {
                mvcBuilder.AddApplicationPartIfNotExists(typeof(WeChatOfficialAccountHttpApiModule).Assembly);
            });
        }

        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpLocalizationOptions>(options =>
            {
                options.Resources
                    .Get<WeChatOfficialAccountResource>()
                    .AddBaseTypes(typeof(AbpUiResource));
            });
        }
    }
}
