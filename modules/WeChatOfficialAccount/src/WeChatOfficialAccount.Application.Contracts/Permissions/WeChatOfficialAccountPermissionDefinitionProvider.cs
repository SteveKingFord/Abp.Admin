using WeChatOfficialAccount.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace WeChatOfficialAccount.Permissions
{
    public class WeChatOfficialAccountPermissionDefinitionProvider : PermissionDefinitionProvider
    {
        public override void Define(IPermissionDefinitionContext context)
        {
            var myGroup = context.AddGroup(WeChatOfficialAccountPermissions.GroupName, L("Permission:WeChatOfficialAccount"));
        }

        private static LocalizableString L(string name)
        {
            return LocalizableString.Create<WeChatOfficialAccountResource>(name);
        }
    }
}