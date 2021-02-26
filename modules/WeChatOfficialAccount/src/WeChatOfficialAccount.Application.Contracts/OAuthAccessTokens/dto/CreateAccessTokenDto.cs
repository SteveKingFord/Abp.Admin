namespace WeChatOfficialAccount.OAuthAccessTokens.dto
{
    public class CreateAccessTokenDto : CreateUpdateAccessTokenBaseDto
    {
        public string AppId { get; set; }
        public string Secret { get; set; }
    }
}
