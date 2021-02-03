using Volo.Abp.Reflection;

namespace WeChatMiniProgram.Permissions
{
    public class WeChatMiniProgramPermissions
    {
        public const string GroupName = "WeChatMiniProgram";

        public static string[] GetAll()
        {
            return ReflectionHelper.GetPublicConstantsRecursively(typeof(WeChatMiniProgramPermissions));
        }
    }
}