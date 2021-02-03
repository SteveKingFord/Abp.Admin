using Volo.Abp.Reflection;

namespace WeChatOfficialAccount.Permissions
{
    public class WeChatOfficialAccountPermissions
    {
        public const string GroupName = "WeChatOfficialAccount";

        public static string[] GetAll()
        {
            return ReflectionHelper.GetPublicConstantsRecursively(typeof(WeChatOfficialAccountPermissions));
        }
    }
}