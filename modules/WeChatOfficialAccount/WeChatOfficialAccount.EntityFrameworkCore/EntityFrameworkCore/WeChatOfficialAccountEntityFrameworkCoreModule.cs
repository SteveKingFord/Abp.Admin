using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.EntityFrameworkCore;
using Volo.Abp.Modularity;

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
            });
        }
    }
}