using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace VideoSite.Data
{
    /* This is used if database provider does't define
     * IVideoSiteDbSchemaMigrator implementation.
     */
    public class NullVideoSiteDbSchemaMigrator : IVideoSiteDbSchemaMigrator, ITransientDependency
    {
        public Task MigrateAsync()
        {
            return Task.CompletedTask;
        }
    }
}