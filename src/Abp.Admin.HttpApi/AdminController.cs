using Abp.Admin.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace Abp.Admin
{
    public abstract class AdminController : AbpController
    {
        protected AdminController()
        {
            LocalizationResource = typeof(AdminResource);
        }
    }
}
