using WeChatMiniProgram.Localization;
using Volo.Abp.Application.Services;

namespace WeChatMiniProgram
{
    public abstract class WeChatMiniProgramAppService : ApplicationService
    {
        protected WeChatMiniProgramAppService()
        {
            LocalizationResource = typeof(WeChatMiniProgramResource);
            ObjectMapperContext = typeof(WeChatMiniProgramApplicationModule);
        }
    }
}
