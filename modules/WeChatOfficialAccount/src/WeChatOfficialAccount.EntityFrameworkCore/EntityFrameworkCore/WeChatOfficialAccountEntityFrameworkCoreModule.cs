using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.EntityFrameworkCore;
using Volo.Abp.Modularity;
using WeChatOfficialAccount.OAuthAccessTokens;

namespace WeChatOfficialAccount.EntityFrameworkCore
{
    [DependsOn(
        typeof(WeChatOfficialAccountDomainModule),
        typeof(AbpEntityFrameworkCoreModule)
    )]
    public class WeChatOfficialAccountEntityFrameworkCoreModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddAbpDbContext<WeChatOfficialAccountDbContext>(options =>
            {
                /* Add custom repositories here. Example:
                 * options.AddRepository<Question, EfCoreQuestionRepository>();
                 */

                options.AddRepository<OAuthAccessToken, OAuthAccessTokenRepository>();
            });
        }
    }
}
