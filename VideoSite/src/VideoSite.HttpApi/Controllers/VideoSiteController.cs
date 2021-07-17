using VideoSite.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace VideoSite.Controllers
{
    /* Inherit your controllers from this class.
     */
    public abstract class VideoSiteController : AbpController
    {
        protected VideoSiteController()
        {
            LocalizationResource = typeof(VideoSiteResource);
        }
    }
}