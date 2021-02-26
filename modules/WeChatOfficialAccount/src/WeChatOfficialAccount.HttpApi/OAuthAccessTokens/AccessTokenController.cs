using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Volo.Abp;
using WeChatOfficialAccount.OAuthAccessTokens.dto;

namespace WeChatOfficialAccount.OAuthAccessTokens
{
    /// <summary>
    /// 公众号授权
    /// </summary>
    [RemoteService]
    [Route("/api/wechat-official-account/access-token")]
    public class AccessTokenController : WeChatOfficialAccountController, IOAuthAccessTokenAppService
    {
        private readonly IOAuthAccessTokenAppService _service;

        public AccessTokenController(IOAuthAccessTokenAppService appService)
        {
            _service = appService;
        }


        [HttpGet]
        public Task<AccessTokenDto> GetAccessToken(GetAccessTokenInput input)
        {
            return _service.GetAccessToken(input);
        }
    }
}
