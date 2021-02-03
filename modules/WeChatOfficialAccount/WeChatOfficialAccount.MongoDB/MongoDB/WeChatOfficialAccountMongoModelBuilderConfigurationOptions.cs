using JetBrains.Annotations;
using Volo.Abp.MongoDB;

namespace WeChatOfficialAccount.MongoDB
{
    public class WeChatOfficialAccountMongoModelBuilderConfigurationOptions : AbpMongoModelBuilderConfigurationOptions
    {
        public WeChatOfficialAccountMongoModelBuilderConfigurationOptions(
            [NotNull] string collectionPrefix = "")
            : base(collectionPrefix)
        {
        }
    }
}