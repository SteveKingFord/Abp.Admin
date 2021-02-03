using WeChatOfficialAccount.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace WeChatOfficialAccount
{
    public abstract class WeChatOfficialAccountController : AbpController
    {
        protected WeChatOfficialAccountController()
        {
            LocalizationResource = typeof(WeChatOfficialAccountResource);
        }
    }
}
