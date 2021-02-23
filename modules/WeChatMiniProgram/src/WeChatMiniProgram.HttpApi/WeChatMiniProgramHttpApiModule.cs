using Localization.Resources.AbpUi;
using WeChatMiniProgram.Localization;
using Volo.Abp.AspNetCore.Mvc;
using Volo.Abp.Localization;
using Volo.Abp.Modularity;
using Microsoft.Extensions.DependencyInjection;

namespace WeChatMiniProgram
{
    [DependsOn(
        typeof(WeChatMiniProgramApplicationContractsModule),
        typeof(AbpAspNetCoreMvcModule))]
    public class WeChatMiniProgramHttpApiModule : AbpModule
    {
        public override void PreConfigureServices(ServiceConfigurationContext context)
        {
            PreConfigure<IMvcBuilder>(mvcBuilder =>
            {
                mvcBuilder.AddApplicationPartIfNotExists(typeof(WeChatMiniProgramHttpApiModule).Assembly);
            });
        }

        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpLocalizationOptions>(options =>
            {
                options.Resources
                    .Get<WeChatMiniProgramResource>()
                    .AddBaseTypes(typeof(AbpUiResource));
            });
        }
    }
}
