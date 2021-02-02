using Volo.Abp.Http.Client.IdentityModel;
using Volo.Abp.Modularity;

namespace Abp.Admin
{
    [DependsOn(
        typeof(AdminHttpApiClientModule),
        typeof(AbpHttpClientIdentityModelModule)
        )]
    public class AdminConsoleApiClientModule : AbpModule
    {
        
    }
}
