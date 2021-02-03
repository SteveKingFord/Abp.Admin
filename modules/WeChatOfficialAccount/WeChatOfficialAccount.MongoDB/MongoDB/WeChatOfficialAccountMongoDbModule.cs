using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Modularity;
using Volo.Abp.MongoDB;

namespace WeChatOfficialAccount.MongoDB
{
    [DependsOn(
        typeof(WeChatOfficialAccountDomainModule),
        typeof(AbpMongoDbModule)
        )]
    public class WeChatOfficialAccountMongoDbModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddMongoDbContext<WeChatOfficialAccountMongoDbContext>(options =>
            {
                /* Add custom repositories here. Example:
                 * options.AddRepository<Question, MongoQuestionRepository>();
                 */
            });
        }
    }
}
