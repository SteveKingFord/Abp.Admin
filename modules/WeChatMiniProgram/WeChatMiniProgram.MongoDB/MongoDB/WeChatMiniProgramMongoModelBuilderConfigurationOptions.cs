using JetBrains.Annotations;
using Volo.Abp.MongoDB;

namespace WeChatMiniProgram.MongoDB
{
    public class WeChatMiniProgramMongoModelBuilderConfigurationOptions : AbpMongoModelBuilderConfigurationOptions
    {
        public WeChatMiniProgramMongoModelBuilderConfigurationOptions(
            [NotNull] string collectionPrefix = "")
            : base(collectionPrefix)
        {
        }
    }
}