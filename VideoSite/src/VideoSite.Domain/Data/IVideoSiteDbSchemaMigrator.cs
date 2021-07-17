using System.Threading.Tasks;

namespace VideoSite.Data
{
    public interface IVideoSiteDbSchemaMigrator
    {
        Task MigrateAsync();
    }
}
