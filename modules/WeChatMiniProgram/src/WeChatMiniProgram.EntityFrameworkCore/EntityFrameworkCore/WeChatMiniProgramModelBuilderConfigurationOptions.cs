using JetBrains.Annotations;
using Volo.Abp.EntityFrameworkCore.Modeling;

namespace WeChatMiniProgram.EntityFrameworkCore
{
    public class WeChatMiniProgramModelBuilderConfigurationOptions : AbpModelBuilderConfigurationOptions
    {
        public WeChatMiniProgramModelBuilderConfigurationOptions(
            [NotNull] string tablePrefix = "",
            [CanBeNull] string schema = null)
            : base(
                tablePrefix,
                schema)
        {

        }
    }
}