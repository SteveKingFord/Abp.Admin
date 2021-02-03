using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Http.Client;
using Volo.Abp.Modularity;

namespace WeChatMiniProgram
{
    [DependsOn(
        typeof(WeChatMiniProgramApplicationContractsModule),
        typeof(AbpHttpClientModule))]
    public class WeChatMiniProgramHttpApiClientModule : AbpModule
    {
        public const string RemoteServiceName = "WeChatMiniProgram";

        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddHttpClientProxies(
                typeof(WeChatMiniProgramApplicationContractsModule).Assembly,
                RemoteServiceName
            );
        }
    }
}
