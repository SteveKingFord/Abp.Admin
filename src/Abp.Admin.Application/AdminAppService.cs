using Abp.Admin.Localization;
using Volo.Abp.Application.Services;

namespace Abp.Admin
{
    public abstract class AdminAppService : ApplicationService
    {
        protected AdminAppService()
        {
            LocalizationResource = typeof(AdminResource);
            ObjectMapperContext = typeof(AdminApplicationModule);
        }
    }
}
