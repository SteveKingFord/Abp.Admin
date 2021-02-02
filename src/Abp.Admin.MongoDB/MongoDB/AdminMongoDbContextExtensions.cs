using System;
using Volo.Abp;
using Volo.Abp.MongoDB;

namespace Abp.Admin.MongoDB
{
    public static class AdminMongoDbContextExtensions
    {
        public static void ConfigureAdmin(
            this IMongoModelBuilder builder,
            Action<AbpMongoModelBuilderConfigurationOptions> optionsAction = null)
        {
            Check.NotNull(builder, nameof(builder));

            var options = new AdminMongoModelBuilderConfigurationOptions(
                AdminDbProperties.DbTablePrefix
            );

            optionsAction?.Invoke(options);
        }
    }
}