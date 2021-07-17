using VideoSite.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace VideoSite.Web.Pages
{
    /* Inherit your PageModel classes from this class.
     */
    public abstract class VideoSitePageModel : AbpPageModel
    {
        protected VideoSitePageModel()
        {
            LocalizationResourceType = typeof(VideoSiteResource);
        }
    }
}