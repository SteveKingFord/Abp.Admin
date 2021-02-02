using JetBrains.Annotations;
using Volo.Abp.MongoDB;

namespace Abp.Admin.MongoDB
{
    public class AdminMongoModelBuilderConfigurationOptions : AbpMongoModelBuilderConfigurationOptions
    {
        public AdminMongoModelBuilderConfigurationOptions(
            [NotNull] string collectionPrefix = "")
            : base(collectionPrefix)
        {
        }
    }
}