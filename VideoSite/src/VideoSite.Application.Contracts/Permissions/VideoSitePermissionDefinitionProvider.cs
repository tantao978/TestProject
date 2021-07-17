using VideoSite.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace VideoSite.Permissions
{
    public class VideoSitePermissionDefinitionProvider : PermissionDefinitionProvider
    {
        public override void Define(IPermissionDefinitionContext context)
        {
            var myGroup = context.AddGroup(VideoSitePermissions.GroupName);

            //Define your own permissions here. Example:
            //myGroup.AddPermission(VideoSitePermissions.MyPermission1, L("Permission:MyPermission1"));
        }

        private static LocalizableString L(string name)
        {
            return LocalizableString.Create<VideoSiteResource>(name);
        }
    }
}
