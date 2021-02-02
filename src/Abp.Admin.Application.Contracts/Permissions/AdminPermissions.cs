using Volo.Abp.Reflection;

namespace Abp.Admin.Permissions
{
    public class AdminPermissions
    {
        public const string GroupName = "Admin";

        public static string[] GetAll()
        {
            return ReflectionHelper.GetPublicConstantsRecursively(typeof(AdminPermissions));
        }
    }
}