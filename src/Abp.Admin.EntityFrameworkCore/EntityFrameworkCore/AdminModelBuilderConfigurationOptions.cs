using JetBrains.Annotations;
using Volo.Abp.EntityFrameworkCore.Modeling;

namespace Abp.Admin.EntityFrameworkCore
{
    public class AdminModelBuilderConfigurationOptions : AbpModelBuilderConfigurationOptions
    {
        public AdminModelBuilderConfigurationOptions(
            [NotNull] string tablePrefix = "",
            [CanBeNull] string schema = null)
            : base(
                tablePrefix,
                schema)
        {

        }
    }
}