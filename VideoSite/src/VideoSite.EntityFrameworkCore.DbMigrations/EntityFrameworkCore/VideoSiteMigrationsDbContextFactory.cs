using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace VideoSite.EntityFrameworkCore
{
    /* This class is needed for EF Core console commands
     * (like Add-Migration and Update-Database commands) */
    public class VideoSiteMigrationsDbContextFactory : IDesignTimeDbContextFactory<VideoSiteMigrationsDbContext>
    {
        public VideoSiteMigrationsDbContext CreateDbContext(string[] args)
        {
            VideoSiteEfCoreEntityExtensionMappings.Configure();

            var configuration = BuildConfiguration();

            var builder = new DbContextOptionsBuilder<VideoSiteMigrationsDbContext>()
                .UseSqlServer(configuration.GetConnectionString("Default"));

            return new VideoSiteMigrationsDbContext(builder.Options);
        }

        private static IConfigurationRoot BuildConfiguration()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../VideoSite.DbMigrator/"))
                .AddJsonFile("appsettings.json", optional: false);

            return builder.Build();
        }
    }
}
