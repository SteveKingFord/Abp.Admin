using System;
using Volo.Abp;
using Volo.Abp.MongoDB;

namespace WeChatMiniProgram.MongoDB
{
    public static class WeChatMiniProgramMongoDbContextExtensions
    {
        public static void ConfigureWeChatMiniProgram(
            this IMongoModelBuilder builder,
            Action<AbpMongoModelBuilderConfigurationOptions> optionsAction = null)
        {
            Check.NotNull(builder, nameof(builder));

            var options = new WeChatMiniProgramMongoModelBuilderConfigurationOptions(
                WeChatMiniProgramDbProperties.DbTablePrefix
            );

            optionsAction?.Invoke(options);
        }
    }
}