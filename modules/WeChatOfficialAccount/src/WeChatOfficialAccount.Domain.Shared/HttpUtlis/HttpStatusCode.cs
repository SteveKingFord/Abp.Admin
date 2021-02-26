using System.Collections.Generic;

namespace WeChatOfficialAccount.HttpUtlis
{
    public class HttpStatusCode
    {
        public string GetStatusMsg(int code)
        {
            //https://developers.weixin.qq.com/doc/offiaccount/Getting_Started/Global_Return_Code.html


            var statusMap = new Dictionary<int, string>()  {
                {-1,"系统繁忙，此时请开发者稍候再试" },
                {0,"请求成功"},
                {40001,"获取 access_token 时 AppSecret 错误，或者 access_token 无效。请开发者认真比对 AppSecret 的正确性，或查看是否正在为恰当的公众号调用接口" },
                {40002,"不合法的凭证类型" },
                {40003,"不合法的 OpenID ，请开发者确认 OpenID （该用户）是否已关注公众号，或是否是其他公众号的 OpenID" },
                {40004,"不合法的媒体文件类型" },
                {40005,"不合法的文件类型" },
            };

            return statusMap[code];
        }
    }
}
