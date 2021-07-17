using VideoSite.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace VideoSite.DbMigrator
{
    [DependsOn(
        typeof(AbpAutofacModule),
        typeof(VideoSiteEntityFrameworkCoreDbMigrationsModule),
        typeof(VideoSiteApplicationContractsModule)
        )]
    public class VideoSiteDbMigratorModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
        }
    }
}
