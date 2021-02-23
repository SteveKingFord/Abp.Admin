using WeChatMiniProgram.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace WeChatMiniProgram.Permissions
{
    public class WeChatMiniProgramPermissionDefinitionProvider : PermissionDefinitionProvider
    {
        public override void Define(IPermissionDefinitionContext context)
        {
            var myGroup = context.AddGroup(WeChatMiniProgramPermissions.GroupName, L("Permission:WeChatMiniProgram"));
        }

        private static LocalizableString L(string name)
        {
            return LocalizableString.Create<WeChatMiniProgramResource>(name);
        }
    }
}