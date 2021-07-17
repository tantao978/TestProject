using Microsoft.EntityFrameworkCore;
using VideoSite.Videos;
using Volo.Abp;
using Volo.Abp.EntityFrameworkCore.Modeling;

namespace VideoSite.EntityFrameworkCore
{
    public static class VideoSiteDbContextModelCreatingExtensions
    {
        public static void ConfigureVideoSite(this ModelBuilder builder)
        {
            Check.NotNull(builder, nameof(builder));

            /* Configure your own tables/entities inside here */

            //builder.Entity<YourEntity>(b =>
            //{
            //    b.ToTable(VideoSiteConsts.DbTablePrefix + "YourEntities", VideoSiteConsts.DbSchema);
            //    b.ConfigureByConvention(); //auto configure for the base class props
            //    //...
            //});

            builder.Entity<Video>(b =>
            {
                b.ToTable(VideoSiteConsts.DbTablePrefix + "Videos", VideoSiteConsts.DbSchema);
                b.ConfigureByConvention(); 
                b.Property(x => x.Name).IsRequired().HasMaxLength(128);
            });
        }
    }
}