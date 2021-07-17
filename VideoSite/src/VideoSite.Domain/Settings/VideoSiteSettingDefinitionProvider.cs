using Volo.Abp.Settings;

namespace VideoSite.Settings
{
    public class VideoSiteSettingDefinitionProvider : SettingDefinitionProvider
    {
        public override void Define(ISettingDefinitionContext context)
        {
            //Define your own settings here. Example:
            //context.Add(new SettingDefinition(VideoSiteSettings.MySetting1));
        }
    }
}
