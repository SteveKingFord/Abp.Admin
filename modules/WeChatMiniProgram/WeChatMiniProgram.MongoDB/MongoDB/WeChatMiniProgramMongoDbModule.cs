using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Modularity;
using Volo.Abp.MongoDB;

namespace WeChatMiniProgram.MongoDB
{
    [DependsOn(
        typeof(WeChatMiniProgramDomainModule),
        typeof(AbpMongoDbModule)
        )]
    public class WeChatMiniProgramMongoDbModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddMongoDbContext<WeChatMiniProgramMongoDbContext>(options =>
            {
                /* Add custom repositories here. Example:
                 * options.AddRepository<Question, MongoQuestionRepository>();
                 */
            });
        }
    }
}
