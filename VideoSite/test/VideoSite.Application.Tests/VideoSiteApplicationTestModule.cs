using Volo.Abp.Modularity;

namespace VideoSite
{
    [DependsOn(
        typeof(VideoSiteApplicationModule),
        typeof(VideoSiteDomainTestModule)
        )]
    public class VideoSiteApplicationTestModule : AbpModule
    {

    }
}