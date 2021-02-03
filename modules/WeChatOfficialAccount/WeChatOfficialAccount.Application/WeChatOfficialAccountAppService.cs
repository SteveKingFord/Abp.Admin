using WeChatOfficialAccount.Localization;
using Volo.Abp.Application.Services;

namespace WeChatOfficialAccount
{
    public abstract class WeChatOfficialAccountAppService : ApplicationService
    {
        protected WeChatOfficialAccountAppService()
        {
            LocalizationResource = typeof(WeChatOfficialAccountResource);
            ObjectMapperContext = typeof(WeChatOfficialAccountApplicationModule);
        }
    }
}
