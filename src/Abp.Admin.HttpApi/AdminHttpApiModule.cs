using Localization.Resources.AbpUi;
using Abp.Admin.Localization;
using Volo.Abp.AspNetCore.Mvc;
using Volo.Abp.Localization;
using Volo.Abp.Modularity;
using Microsoft.Extensions.DependencyInjection;

namespace Abp.Admin
{
    [DependsOn(
        typeof(AdminApplicationContractsModule),
        typeof(AbpAspNetCoreMvcModule))]
    public class AdminHttpApiModule : AbpModule
    {
        public override void PreConfigureServices(ServiceConfigurationContext context)
        {
            PreConfigure<IMvcBuilder>(mvcBuilder =>
            {
                mvcBuilder.AddApplicationPartIfNotExists(typeof(AdminHttpApiModule).Assembly);
            });
        }

        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpLocalizationOptions>(options =>
            {
                options.Resources
                    .Get<AdminResource>()
                    .AddBaseTypes(typeof(AbpUiResource));
            });
        }
    }
}
