using WeChatMiniProgram.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace WeChatMiniProgram
{
    public abstract class WeChatMiniProgramController : AbpController
    {
        protected WeChatMiniProgramController()
        {
            LocalizationResource = typeof(WeChatMiniProgramResource);
        }
    }
}
