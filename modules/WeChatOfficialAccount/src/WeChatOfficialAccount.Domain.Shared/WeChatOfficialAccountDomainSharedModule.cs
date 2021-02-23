using Volo.Abp.Modularity;
using Volo.Abp.Localization;
using WeChatOfficialAccount.Localization;
using Volo.Abp.Localization.ExceptionHandling;
using Volo.Abp.Validation;
using Volo.Abp.Validation.Localization;
using Volo.Abp.VirtualFileSystem;

namespace WeChatOfficialAccount
{
    [DependsOn(
        typeof(AbpValidationModule)
    )]
    public class WeChatOfficialAccountDomainSharedModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpVirtualFileSystemOptions>(options =>
            {
                options.FileSets.AddEmbedded<WeChatOfficialAccountDomainSharedModule>();
            });

            Configure<AbpLocalizationOptions>(options =>
            {
                options.Resources
                    .Add<WeChatOfficialAccountResource>("en")
                    .AddBaseTypes(typeof(AbpValidationResource))
                    .AddVirtualJson("/Localization/WeChatOfficialAccount");
            });

            Configure<AbpExceptionLocalizationOptions>(options =>
            {
                options.MapCodeNamespace("WeChatOfficialAccount", typeof(WeChatOfficialAccountResource));
            });
        }
    }
}
