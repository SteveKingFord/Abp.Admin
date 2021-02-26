using System.Threading.Tasks;
using WeChatOfficialAccount.OAuthAccessTokens.dto;

namespace WeChatOfficialAccount.OAuthAccessTokens
{
    public interface IOAuthAccessTokenAppService
    {
        Task<AccessTokenDto> GetAccessToken(GetAccessTokenInput input);
    }
}
