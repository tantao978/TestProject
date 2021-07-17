using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using VideoSite.Data;
using Volo.Abp.DependencyInjection;

namespace VideoSite.EntityFrameworkCore
{
    public class EntityFrameworkCoreVideoSiteDbSchemaMigrator
        : IVideoSiteDbSchemaMigrator, ITransientDependency
    {
        private readonly IServiceProvider _serviceProvider;

        public EntityFrameworkCoreVideoSiteDbSchemaMigrator(
            IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public async Task MigrateAsync()
        {
            /* We intentionally resolving the VideoSiteMigrationsDbContext
             * from IServiceProvider (instead of directly injecting it)
             * to properly get the connection string of the current tenant in the
             * current scope.
             */

            await _serviceProvider
                .GetRequiredService<VideoSiteMigrationsDbContext>()
                .Database
                .MigrateAsync();
        }
    }
}