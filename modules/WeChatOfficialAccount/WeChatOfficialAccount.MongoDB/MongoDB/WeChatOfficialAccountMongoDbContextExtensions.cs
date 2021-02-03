using System;
using Volo.Abp;
using Volo.Abp.MongoDB;

namespace WeChatOfficialAccount.MongoDB
{
    public static class WeChatOfficialAccountMongoDbContextExtensions
    {
        public static void ConfigureWeChatOfficialAccount(
            this IMongoModelBuilder builder,
            Action<AbpMongoModelBuilderConfigurationOptions> optionsAction = null)
        {
            Check.NotNull(builder, nameof(builder));

            var options = new WeChatOfficialAccountMongoModelBuilderConfigurationOptions(
                WeChatOfficialAccountDbProperties.DbTablePrefix
            );

            optionsAction?.Invoke(options);
        }
    }
}