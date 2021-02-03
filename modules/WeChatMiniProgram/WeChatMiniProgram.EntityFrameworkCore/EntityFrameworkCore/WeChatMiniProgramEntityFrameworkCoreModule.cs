using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.EntityFrameworkCore;
using Volo.Abp.Modularity;
using WeChatMiniProgram.Users;

namespace WeChatMiniProgram.EntityFrameworkCore
{
    [DependsOn(
        typeof(WeChatMiniProgramDomainModule),
        typeof(AbpEntityFrameworkCoreModule)
    )]
    public class WeChatMiniProgramEntityFrameworkCoreModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddAbpDbContext<WeChatMiniProgramDbContext>(options =>
            {
                /* Add custom repositories here. Example:
                 * options.AddRepository<Question, EfCoreQuestionRepository>();
                 */

                options.AddRepository<User, UserRepository>();
            });
        }
    }
}