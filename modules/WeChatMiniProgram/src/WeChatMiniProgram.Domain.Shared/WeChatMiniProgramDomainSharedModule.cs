using Volo.Abp.Modularity;
using Volo.Abp.Localization;
using WeChatMiniProgram.Localization;
using Volo.Abp.Localization.ExceptionHandling;
using Volo.Abp.Validation;
using Volo.Abp.Validation.Localization;
using Volo.Abp.VirtualFileSystem;

namespace WeChatMiniProgram
{
    [DependsOn(
        typeof(AbpValidationModule)
    )]
    public class WeChatMiniProgramDomainSharedModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpVirtualFileSystemOptions>(options =>
            {
                options.FileSets.AddEmbedded<WeChatMiniProgramDomainSharedModule>();
            });

            Configure<AbpLocalizationOptions>(options =>
            {
                options.Resources
                    .Add<WeChatMiniProgramResource>("en")
                    .AddBaseTypes(typeof(AbpValidationResource))
                    .AddVirtualJson("/Localization/WeChatMiniProgram");
            });

            Configure<AbpExceptionLocalizationOptions>(options =>
            {
                options.MapCodeNamespace("WeChatMiniProgram", typeof(WeChatMiniProgramResource));
            });
        }
    }
}
