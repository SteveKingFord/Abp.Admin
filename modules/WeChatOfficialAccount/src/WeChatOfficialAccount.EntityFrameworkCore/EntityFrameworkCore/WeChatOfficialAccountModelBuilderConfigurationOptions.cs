using JetBrains.Annotations;
using Volo.Abp.EntityFrameworkCore.Modeling;

namespace WeChatOfficialAccount.EntityFrameworkCore
{
    public class WeChatOfficialAccountModelBuilderConfigurationOptions : AbpModelBuilderConfigurationOptions
    {
        public WeChatOfficialAccountModelBuilderConfigurationOptions(
            [NotNull] string tablePrefix = "",
            [CanBeNull] string schema = null)
            : base(
                tablePrefix,
                schema)
        {

        }
    }
}