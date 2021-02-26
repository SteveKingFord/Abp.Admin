using AutoMapper;
using WeChatOfficialAccount.OAuthAccessTokens;
using WeChatOfficialAccount.OAuthAccessTokens.dto;

namespace WeChatOfficialAccount
{
    public class WeChatOfficialAccountApplicationAutoMapperProfile : Profile
    {
        public WeChatOfficialAccountApplicationAutoMapperProfile()
        {
            /* You can configure your AutoMapper mapping configuration here.
             * Alternatively, you can split your mapping configurations
             * into multiple profile classes for a better organization. */

            #region 公众号授权
            CreateMap<OAuthAccessToken, AccessTokenDto>();
            CreateMap<CreateAccessTokenDto, OAuthAccessToken>(MemberList.Source);
            CreateMap<UpdateAccessTokenDto, OAuthAccessToken>(MemberList.Source);
            #endregion

        }
    }
}
