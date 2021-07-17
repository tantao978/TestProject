using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace VideoSite.Web
{
    [Dependency(ReplaceServices = true)]
    public class VideoSiteBrandingProvider : DefaultBrandingProvider
    {
        public override string AppName => "VideoSite";
    }
}
