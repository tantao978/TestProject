using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Modularity;

namespace VideoSite.EntityFrameworkCore
{
    [DependsOn(
        typeof(VideoSiteEntityFrameworkCoreModule)
        )]
    public class VideoSiteEntityFrameworkCoreDbMigrationsModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddAbpDbContext<VideoSiteMigrationsDbContext>();
        }
    }
}
