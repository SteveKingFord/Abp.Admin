using System;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using WeChatOfficialAccount.OAuthAccessTokens;
using WeChatOfficialAccount.OAuthAccessTokens.dto;

namespace WeChatOfficialAccount.MpAccessTokens
{
    public class OAuthAccessTokenAppService : WeChatOfficialAccountAppService, IOAuthAccessTokenAppService
    {
        private readonly IOAuthAccessTokenRepository _repository;

        private static HttpClient HttpClient;

        public OAuthAccessTokenAppService(IOAuthAccessTokenRepository repository)
        {
            _repository = repository;
            HttpClient = new HttpClient();
        }

        /// <summary>
        /// 获取token
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public async Task<AccessTokenDto> GetAccessToken(GetAccessTokenInput input)
        {
            // 授权地址
            string authUrl = $"{OAuthAccessTokenConsts.AccessTokenUrl}?grant_type={OAuthAccessTokenConsts.GrantType}&appid={input.AppId}&secret={input.Secret}";

            // 发起授权请求
            var response = await HttpClient.GetAsync("https://www.baidu.com/");




            if (response.IsSuccessStatusCode)
            {
                var result = _repository.FirstOrDefault(x => x.AppId == input.AppId);

                if (result.AppId.IsNullOrEmpty())
                {

                    result.AccessToken = "";
                    result.ExpiresIn = 0;

                    await _repository.UpdateAsync(result);

                    return ObjectMapper.Map<OAuthAccessToken, AccessTokenDto>(result);

                }

                // 不存在添加
                var entity = new OAuthAccessToken(GuidGenerator.Create(), "token", input.AppId, input.Secret);
                var result2 = await _repository.InsertAsync(entity);
                return ObjectMapper.Map<OAuthAccessToken, AccessTokenDto>(result2);

            }

            throw new System.NotImplementedException();
        }





    }
}
