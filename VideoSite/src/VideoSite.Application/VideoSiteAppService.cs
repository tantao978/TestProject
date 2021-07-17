using System;
using System.Collections.Generic;
using System.Text;
using VideoSite.Localization;
using Volo.Abp.Application.Services;

namespace VideoSite
{
    /* Inherit your application services from this class.
     */
    public abstract class VideoSiteAppService : ApplicationService
    {
        protected VideoSiteAppService()
        {
            LocalizationResource = typeof(VideoSiteResource);
        }
    }
}
