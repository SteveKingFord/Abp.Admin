namespace WeChatOfficialAccount.OAuthAccessTokens
{
    public class OAuthAccessTokenConsts
    {
        public static string AccessTokenUrl = "https://api.weixin.qq.com/cgi-bin/token";
        public static string GrantType = "client_credential";




        public static int MinAccessTokenLength { get; set; } = 512;
        public static int MaxAppIdLength { get; set; } = 200;
        public static int MaxSecretLength { get; set; } = 200;
    }
}
