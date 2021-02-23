using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Http.Client;
using Volo.Abp.Modularity;

namespace WeChatOfficialAccount
{
    [DependsOn(
        typeof(WeChatOfficialAccountApplicationContractsModule),
        typeof(AbpHttpClientModule))]
    public class WeChatOfficialAccountHttpApiClientModule : AbpModule
    {
        public const string RemoteServiceName = "WeChatOfficialAccount";

        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddHttpClientProxies(
                typeof(WeChatOfficialAccountApplicationContractsModule).Assembly,
                RemoteServiceName
            );
        }
    }
}
