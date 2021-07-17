using VideoSite.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace VideoSite
{
    [DependsOn(
        typeof(VideoSiteEntityFrameworkCoreTestModule)
        )]
    public class VideoSiteDomainTestModule : AbpModule
    {

    }
}